using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace ATBMTHTTT
{
    
    public partial class ADMIN_ROLE : Form
    {
        public static string data = string.Empty;
        OracleConnection con = new OracleConnection(data);
        public ADMIN_ROLE()
        {
            InitializeComponent();
            con.Open();
        }

        void load()
        {
            OracleCommand roledgv = new OracleCommand("SELECT * FROM DBA_ROLES WHERE ORACLE_MAINTAINED = 'Y' AND ROLE_ID BETWEEN 150 and 500", con);

            roledgv.CommandType = CommandType.Text;

            OracleDataReader _reader = roledgv.ExecuteReader();

            DataTable rolelist = new DataTable();

            rolelist.Load(_reader);

            dgv_role.DataSource = rolelist;
        }
        private void button_xem_Click(object sender, EventArgs e)
        {
            if (comboBox_rolename.Text != null)
            {
                ADMIN_PRIVILEGE_ROLE APU = new ADMIN_PRIVILEGE_ROLE();
                ADMIN_PRIVILEGE_ROLE.role = comboBox_rolename.Text;
                APU.ShowDialog();
            }
            else
            {
                MessageBox.Show("Chưa chọn user!!");
            }
        }

        private void ADMIN_ROLE_Load(object sender, EventArgs e)
        {
            load();
        }
        private void button_rf_Click(object sender, EventArgs e)
        {
            load();
        }

        private void dgv_role_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgv_role.Rows[e.RowIndex];
            comboBox_rolename.Text = Convert.ToString(row.Cells["ROLE"].Value);
        }

        private void button_them_Click(object sender, EventArgs e)
        {
            if (comboBox_rolename.Text != "")
            {
                OracleCommand command = new OracleCommand("MNG.USP_CREATEROLE", con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new OracleParameter("PARA_ROLE", OracleDbType.Varchar2, 32767)).Value = comboBox_rolename.Text.Trim();
                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Thêm role mới thành công!");
                    load();
                }
                catch (Exception EX)
                {
                    MessageBox.Show(EX.ToString());
                }
            }
            else MessageBox.Show("Không thể thêm role khi để trống");
        }
            private void button_xoa_Click(object sender, EventArgs e)
        {
            if (comboBox_rolename.Text != "")
            {
                OracleCommand oracle_script = new OracleCommand("ALTER SESSION SET \"_ORACLE_SCRIPT\"= TRUE", con);
                oracle_script.CommandType = CommandType.Text;
                oracle_script.ExecuteNonQuery();
                OracleCommand command = new OracleCommand("DROP ROLE " + comboBox_rolename.Text.Trim(), con);
                command.CommandType = CommandType.Text;
                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Xoá role thành công!");
                    load();
                }
                catch (Exception EX)
                {
                    MessageBox.Show(EX.ToString());
                }
            }
            else MessageBox.Show("Không thể xoá role khi để trống");
        }
    }
}
