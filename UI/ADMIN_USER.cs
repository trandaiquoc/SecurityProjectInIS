using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace ATBMTHTTT
{
    public partial class ADMIN_USER : Form
    {
        public static string data = string.Empty;
        OracleConnection con = new OracleConnection(data);
        public ADMIN_USER()
        {
            InitializeComponent();
            con.Open();
        }
        void load()
        {
            label_mk.Hide();
            textBox_pass.Hide();
            textBox_pass.Text = null;
            OracleCommand userdgv = new OracleCommand("SELECT * FROM ALL_USERS WHERE CREATED > TO_DATE('2023/01/01', 'yyyy/mm/dd') AND ORACLE_MAINTAINED = 'Y'", con);

            userdgv.CommandType = CommandType.Text;

            OracleDataReader _reader = userdgv.ExecuteReader();

            DataTable userlist = new DataTable();

            userlist.Load(_reader);

            dgv_user.DataSource = userlist;
        }
        private void dgv_user_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgv_user.Rows[e.RowIndex];
            comboBox_username.Text = Convert.ToString(row.Cells["USERNAME"].Value);
        }

        private void button_xem_Click(object sender, EventArgs e)
        {
            if(comboBox_username.Text != null)
            {
                ADMIN_PRIVILEGE_USER APU = new ADMIN_PRIVILEGE_USER();
                ADMIN_PRIVILEGE_USER.user = comboBox_username.Text;
                APU.ShowDialog();
            }
            else
            {
                MessageBox.Show("Chưa chọn user!!");
            }
            
        }

        private void ADMIN_USER_Load(object sender, EventArgs e)
        {
            load();
        }

        private void button_rf_Click(object sender, EventArgs e)
        {
            load();
        }

        private void button_xoa_Click(object sender, EventArgs e)
        {
            if(comboBox_username.Text != "MNG" && comboBox_username.Text != "")
            {
                OracleCommand oracle_script = new OracleCommand("ALTER SESSION SET \"_ORACLE_SCRIPT\"= TRUE", con);
                oracle_script.CommandType = CommandType.Text;
                oracle_script.ExecuteNonQuery();
                OracleCommand command = new OracleCommand("MNG.USP_DROPUSER" , con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new OracleParameter("PARA_USERNAME", OracleDbType.Varchar2, 32767)).Value = comboBox_username.Text.Trim();
                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Xoá user thành công!");
                    load();

                }
                catch (Exception EX)
                {
                    MessageBox.Show(EX.ToString());
                }
            }
            else MessageBox.Show("Không thể xóa admin và dữ liệu trống");
        }

        private void button_sua_Click(object sender, EventArgs e)
        {
            if(label_mk.Visible == true)
            {
                label_mk.Hide();
                textBox_pass.Hide();
            }
            else
            {
                label_mk.Show();
                textBox_pass.Show();
            }
            if (textBox_pass.Text !=  "")
            {
                if (comboBox_username.Text != "MNG" && comboBox_username.Text != "")
                {
                    OracleCommand command = new OracleCommand("ALTER USER " + comboBox_username.Text + " IDENTIFIED BY " + textBox_pass.Text.Trim().ToUpper(), con);

                    command.CommandType = CommandType.Text;

                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Sửa thành công!");
                        load();

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Sửa không thành công do không tồn tại user đang sửa");
                    }
                }
                else MessageBox.Show("Không thể sửa admin và dữ liệu trống");
            }
            
        }

        private void button_them_Click(object sender, EventArgs e)
        {
            if (label_mk.Visible == true)
            {
                label_mk.Hide();
                textBox_pass.Hide();
            }
            else
            {
                label_mk.Show();
                textBox_pass.Show();
            }
            if (textBox_pass.Text != "")
            {
                if (comboBox_username.Text != "MNG" && comboBox_username.Text != "")
                {
                    OracleCommand command = new OracleCommand("MNG.USP_CREATEUSER", con);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new OracleParameter("PARA_USERNAME", OracleDbType.Varchar2, 32767)).Value = comboBox_username.Text.Trim();
                    command.Parameters.Add(new OracleParameter("PARA_PASSWORD", OracleDbType.Varchar2, 32767)).Value = textBox_pass.Text.Trim();

                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Thêm user mới thành công!");
                        load();

                    }
                    catch (Exception EX)
                    {
                        MessageBox.Show(EX.ToString());
                    }
                }
                else MessageBox.Show("Không thể thêm admin và dữ liệu trống");
            }
        }
    }
}
