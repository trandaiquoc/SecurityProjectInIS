using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using static System.Collections.Specialized.BitVector32;

namespace ATBMTHTTT
{
    public partial class ADMIN_PRIVILEGE_USER : Form
    {
        public static string data = string.Empty;
        public static string user = string.Empty;
        String priv = string.Empty;
        String table = string.Empty;
        OracleConnection con = new OracleConnection(data);
        public ADMIN_PRIVILEGE_USER()
        {
            InitializeComponent();
            con.Open();
        }
        void load(String text)
        {
            OracleCommand userdgv = new OracleCommand(text + user + "'", con);

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

        private void button_revoke_Click(object sender, EventArgs e)
        {
            OracleCommand oracle_script = new OracleCommand("ALTER SESSION SET \"_ORACLE_SCRIPT\"= TRUE",con);
            oracle_script.CommandType = CommandType.Text;
            oracle_script.ExecuteNonQuery();
            OracleCommand command = new OracleCommand();
                if (button_TAB.BackColor == System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(223)))), ((int)(((byte)(229))))) || 
                button_COL.BackColor == System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(223)))), ((int)(((byte)(229))))))
                {
                    command.CommandText = "REVOKE " + priv + " ON " + table + " FROM " + user;
                }
                else
                {
                    command.CommandText = "REVOKE " + priv + " FROM " + user;
                }    
                command.Connection = con;
                command.CommandType = CommandType.Text;
                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Thu hồi quyền thành công!");

                }
                catch (Exception EX)
                {
                    MessageBox.Show(EX.ToString());
                }
        }

        private void button_grant_Click(object sender, EventArgs e)
        {
            if (user != "")
            {
                ADMIN_GRANT.user = user;
                ADMIN_GRANT AG = new ADMIN_GRANT();
                AG.ShowDialog();
            }
            else MessageBox.Show("Chưa chọn user");
        }

        private void button_TAB_Click(object sender, EventArgs e)
        {
            String text = "SELECT * FROM USER_TAB_PRIVS WHERE GRANTEE = '";
            load(text);
            button_TAB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            button_COL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(151)))), ((int)(((byte)(108)))));
            button_ROLE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(151)))), ((int)(((byte)(108)))));
            button_SYS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(151)))), ((int)(((byte)(108)))));
        }

        private void button_COL_Click(object sender, EventArgs e)
        {
            String text = "SELECT * FROM USER_COL_PRIVS WHERE GRANTEE = '";
            load(text);
            button_TAB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(151)))), ((int)(((byte)(108)))));
            button_COL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            button_ROLE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(151)))), ((int)(((byte)(108)))));
            button_SYS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(151)))), ((int)(((byte)(108)))));
        }

        private void button_ROLE_Click(object sender, EventArgs e)
        {
            String text = "SELECT * FROM DBA_ROLE_PRIVS WHERE GRANTEE = '";
            load(text);
            button_TAB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(151)))), ((int)(((byte)(108)))));
            button_COL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(151)))), ((int)(((byte)(108)))));
            button_ROLE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            button_SYS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(151)))), ((int)(((byte)(108)))));
        }

        private void button_SYS_Click(object sender, EventArgs e)
        {
            String text = "SELECT * FROM USER_SYS_PRIVS WHERE USERNAME = '";
            load(text);
            button_TAB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(151)))), ((int)(((byte)(108)))));
            button_COL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(151)))), ((int)(((byte)(108)))));
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
            else if (button_COL.BackColor == System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(223)))), ((int)(((byte)(229))))))
            {
                priv = Convert.ToString(row.Cells["PRIVILEGE"].Value);
                table = Convert.ToString(row.Cells["TABLE_NAME"].Value);
            }
            else if (button_ROLE.BackColor == System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(223)))), ((int)(((byte)(229))))))
            {
                priv = Convert.ToString(row.Cells["GRANTED_ROLE"].Value);
            }
            else
            {
                priv = Convert.ToString(row.Cells["PRIVILEGE"].Value);
            }    
        }
    }
}
