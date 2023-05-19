using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace ATBMTHTTT
{
    public partial class LOGIN : Form
    {
        public static string data = string.Empty;
        public static string username = string.Empty;
        public static string password = string.Empty;
        OracleConnection con = new OracleConnection(data);
        public LOGIN()
        {
            InitializeComponent();
            con.Open();

        }
        void load()
        {
            if (username != null && password != null)
            {
                textBox_username.Text = username;
                textBox_pass.Text = password;
            }
        }
        private void pictureBox_anmk_Click(object sender, EventArgs e)
        {
            if (textBox_pass.PasswordChar == '\0')
            {
                pictureBox_hienmk.BringToFront();
                textBox_pass.PasswordChar = '*';
            }
        }

        private void pictureBox_hienmk_Click(object sender, EventArgs e)
        {
            if (textBox_pass.PasswordChar == '*')
            {
                pictureBox_anmk.BringToFront();
                textBox_pass.PasswordChar = '\0';
            }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có chắc muốn thoát chứ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            OracleCommand command = new OracleCommand("MNG.USP_LOGIN", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new OracleParameter("PARA_USERNAME", OracleDbType.Varchar2, 32767)).Value = textBox_username.Text.Trim().ToUpper();
            command.Parameters.Add(new OracleParameter("PARA_PASSWORD", OracleDbType.Varchar2, 32767)).Value = textBox_pass.Text.Trim().ToUpper();

            command.Parameters.Add("MANV", OracleDbType.Varchar2, 32767).Direction = ParameterDirection.Output;
            command.Parameters.Add("VAITRO", OracleDbType.Varchar2, 32767).Direction = ParameterDirection.Output;

            try
            {
                command.ExecuteNonQuery();
                string MANV = command.Parameters["MANV"].Value.ToString();
                string ROLE = command.Parameters["VAITRO"].Value.ToString();

                if (ROLE == "MANAGER")
                {
                    ADMIN.vaitro = ROLE;
                    ADMIN AD = new ADMIN();
                    this.Hide();
                    AD.Show();
                    con.Close();
                }
                else if(ROLE == "NHANVIEN")
                {
                    NHANVIEN.vaitro = ROLE;
                    NHANVIEN.tk = textBox_username.Text;
                    NHANVIEN.mk = textBox_pass.Text;
                    NHANVIEN.manv = MANV;
                    NHANVIEN nv = new NHANVIEN();
                    this.Hide();
                    nv.Show();
                    con.Close();
                }
                else if (ROLE == "QUANLY")
                {
                    QUANLY.vaitro = ROLE;
                    QUANLY.tk = textBox_username.Text;
                    QUANLY.mk = textBox_pass.Text;
                    QUANLY.manv = MANV;
                    QUANLY QL = new QUANLY();
                    this.Hide();
                    QL.Show();
                    con.Close();
                }
                else if (ROLE == "TRUONGPHONG")
                {
                    TRUONGPHONG.vaitro = ROLE;
                    TRUONGPHONG.tk = textBox_username.Text;
                    TRUONGPHONG.mk = textBox_pass.Text;
                    TRUONGPHONG.manv = MANV;
                    TRUONGPHONG TP = new TRUONGPHONG();
                    this.Hide();
                    TP.Show();
                    con.Close();
                }
                else if (ROLE == "TAICHINH")
                {
                    TAICHINH.vaitro = ROLE;
                    TAICHINH.tk = textBox_username.Text;
                    TAICHINH.mk = textBox_pass.Text;
                    TAICHINH.manv = MANV;
                    TAICHINH TC = new TAICHINH();
                    this.Hide();
                    TC.Show();
                    con.Close();
                }
                else if (ROLE == "TRUONGDEAN")
                {
                    TRUONGDEAN.vaitro = ROLE;
                    TRUONGDEAN.tk = textBox_username.Text;
                    TRUONGDEAN.mk = textBox_pass.Text;
                    TRUONGDEAN.manv = MANV;
                    TRUONGDEAN TDA = new TRUONGDEAN();
                    this.Hide();
                    TDA.Show();
                    con.Close();
                }
                else
                {
                    NHANSU.vaitro = ROLE;
                    NHANSU.tk = textBox_username.Text;
                    NHANSU.mk = textBox_pass.Text;
                    NHANSU.manv = MANV;
                    NHANSU NS = new NHANSU();
                    this.Hide();
                    NS.Show();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                //MessageBox.Show("Invalid username or password!");
            }
        }

        private void button_signup_Click(object sender, EventArgs e)
        {
            REGISTER R = new REGISTER();
            R.ShowDialog();
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {
            load();
        }
    }
}
