using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace ATBMTHTTT
{
    public partial class ADMIN_PRIVILEGE_ROLE : Form
    {
        public static string data = string.Empty;
        public static string role = string.Empty;
        String priv = string.Empty;
        String table = string.Empty;
        OracleConnection con = new OracleConnection(data);
        public ADMIN_PRIVILEGE_ROLE()
        {
            InitializeComponent();
            con.Open();
        }
        void load(String text)
        {
            OracleCommand userdgv = new OracleCommand(text + role + "'", con);

            userdgv.CommandType = CommandType.Text;

            OracleDataReader _reader = userdgv.ExecuteReader();

            DataTable userlist = new DataTable();

            userlist.Load(_reader);

            dgv_privilege.DataSource = userlist;
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            con.Close();
            this.Close();
        }
        private void button_grant_Click(object sender, EventArgs e)
        {
            if (role != "")
            {
                ADMIN_ROLEGRANT.role = role;
                ADMIN_ROLEGRANT ARG = new ADMIN_ROLEGRANT();
                ARG.ShowDialog();
            }
            else MessageBox.Show("Chưa chọn role");
        }

        private void button_TAB_Click(object sender, EventArgs e)
        {
            String text = "SELECT * FROM ROLE_TAB_PRIVS WHERE ROLE = '";
            load(text);
            button_TAB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            button_ROLE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(151)))), ((int)(((byte)(108)))));
            button_SYS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(151)))), ((int)(((byte)(108)))));
        }

        private void button_ROLE_Click(object sender, EventArgs e)
        {
            String text = "SELECT * FROM DBA_ROLE_PRIVS WHERE GRANTED_ROLE = '";
            load(text);
            button_TAB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(151)))), ((int)(((byte)(108)))));
            button_ROLE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            button_SYS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(151)))), ((int)(((byte)(108)))));
        }

        private void button_SYS_Click(object sender, EventArgs e)
        {
            String text = "SELECT * FROM ROLE_SYS_PRIVS WHERE ROLE = '";
            load(text);
            button_TAB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(151)))), ((int)(((byte)(108)))));
            button_ROLE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(151)))), ((int)(((byte)(108)))));
            button_SYS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
        }

        private void dgv_privilege_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgv_privilege.Rows[e.RowIndex];
            if (button_TAB.BackColor == System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(223)))), ((int)(((byte)(229))))))
            {
                priv = Convert.ToString(row.Cells["PRIVILEGE"].Value);
                table = Convert.ToString(row.Cells["TABLE_NAME"].Value);
            }
            else if (button_ROLE.BackColor == System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(223)))), ((int)(((byte)(229))))))
            {
                priv = Convert.ToString(row.Cells["GRANTEE"].Value);
            }
            else
            {
                priv = Convert.ToString(row.Cells["PRIVILEGE"].Value);
            }
        }

        private void button_revoke_Click(object sender, EventArgs e)
        {
            OracleCommand oracle_script = new OracleCommand("ALTER SESSION SET \"_ORACLE_SCRIPT\"= TRUE", con);
            oracle_script.CommandType = CommandType.Text;
            oracle_script.ExecuteNonQuery();
            OracleCommand command = new OracleCommand();
            if (button_TAB.BackColor == System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(223)))), ((int)(((byte)(229))))))
            {
                command.CommandText = "REVOKE " + priv + " ON " + table + " FROM " + role;
            }
            else if (button_ROLE.BackColor == System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(223)))), ((int)(((byte)(229))))))
            {
                command.CommandText = "REVOKE " + role + " FROM " + priv;
            }
            else
            {
                command.CommandText = "REVOKE " + priv + " FROM " + role;
            }    
            command.Connection = con;
            command.CommandType = CommandType.Text;
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Thu hồi quyền thành công!");

            }
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
            }
        }
    }
}
