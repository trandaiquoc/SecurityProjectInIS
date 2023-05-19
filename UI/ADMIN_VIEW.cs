using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace ATBMTHTTT
{
    public partial class ADMIN_VIEW : Form
    {
        public static string data = string.Empty;
        OracleConnection con = new OracleConnection(data);
        public ADMIN_VIEW()
        {
            InitializeComponent();
            con.Open();
        }
        void load()
        {
            OracleCommand viewdgv = new OracleCommand("SELECT VIEW_NAME FROM USER_VIEWS", con);

            viewdgv.CommandType = CommandType.Text;

            OracleDataReader _reader = viewdgv.ExecuteReader();

            DataTable viewlist = new DataTable();

            viewlist.Load(_reader);

            dgv_view.DataSource = viewlist;
        }

        private void button_rf_Click(object sender, EventArgs e)
        {
            load();
        }

        private void ADMIN_VIEW_Load(object sender, EventArgs e)
        {
            load();
        }

        private void button_xoá_Click(object sender, EventArgs e)
        {
            if (comboBox_viewname.Text != "")
            {
                OracleCommand command = new OracleCommand("DROP VIEW " + comboBox_viewname.Text, con);

                command.CommandType = CommandType.Text;

                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Xoá view thành công!");
                    load();

                }
                catch (Exception)
                {
                    MessageBox.Show("View không tồn tại");
                }
            }
            else MessageBox.Show("Chưa chọn view");
        }

        private void dgv_view_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgv_view.Rows[e.RowIndex];
            comboBox_viewname.Text = Convert.ToString(row.Cells["VIEW_NAME"].Value);
        }
    }
}
