using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace ATBMTHTTT
{
    public partial class ADMIN : Form
    {
        public static string data = string.Empty;
        public static string vaitro = string.Empty;
        OracleConnection con = new OracleConnection(data);
        public ADMIN()
        {
            InitializeComponent();
            con.Open();
        }
        private Form currentChildForm = null;

        private void openChildForm(Form child)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = child;
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            panel_child.Controls.Add(child);
            panel_child.Tag = child;
            child.BringToFront();
            child.Show();
        }
        private void button_exit_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có chắc muốn thoát chứ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button_dx_Click(object sender, EventArgs e)
        {
            this.Close();
            LOGIN L = new LOGIN();
            L.Show();
        }

        private void button_user_Click(object sender, EventArgs e)
        {
            openChildForm(new ADMIN_USER());
        }

        private void button_role_Click(object sender, EventArgs e)
        {
            openChildForm(new ADMIN_ROLE());
        }

        private void button_table_Click(object sender, EventArgs e)
        {
            openChildForm(new ADMIN_TABLE());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new ADMIN_VIEW());
        }

        private void ADMIN_Load(object sender, EventArgs e)
        {
            label_user.Text = vaitro;
        }
    }
}
