using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace ATBMTHTTT
{
    public partial class REGISTER : Form
    {
        public static string data = string.Empty;
        public REGISTER()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn đăng nhập không?", "Đăng Ký Thành Công", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                LOGIN.username = textBox_username.Text;
                LOGIN.password = textBox_pass.Text;
                this.Close();
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
    }
}
