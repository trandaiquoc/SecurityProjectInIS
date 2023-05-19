using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace ATBMTHTTT
{
    public partial class TRUONGDEAN : Form
    {
        public static string data = string.Empty;
        public static string vaitro = string.Empty;
        public static string tk = string.Empty;
        public static string mk = string.Empty;
        public static string manv = string.Empty;
        public TRUONGDEAN()
        {
            InitializeComponent();
            data = @"Data Source=(DESCRIPTION =
                                                        (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))
                                                        (CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = XE))
                                        );User Id = " + tk + ";password=" + mk;
            OracleConnection con = new OracleConnection(data);
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
        private void TRUONGDEAN_Load(object sender, EventArgs e)
        {
            label_user.Text = vaitro;
        }

        private void button_dx_Click(object sender, EventArgs e)
        {
            this.Close();
            LOGIN L = new LOGIN();
            L.Show();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có chắc muốn thoát chứ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void b_xtt_Click(object sender, EventArgs e)
        {
            NV_XEMTT.data = data;
            NV_XEMTT.manv = manv;
            openChildForm(new NV_XEMTT());
        }

        private void b_pc_Click(object sender, EventArgs e)
        {
            NV_PHANCONG.data = data;
            openChildForm(new NV_PHANCONG());
        }

        private void b_pb_Click(object sender, EventArgs e)
        {
            NV_PHONGBAN.data = data;
            openChildForm(new NV_PHONGBAN());
        }

        private void b_da_Click(object sender, EventArgs e)
        {
            TDA_DA.data = data;
            openChildForm(new TDA_DA());
        }
    }
}
