using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace ATBMTHTTT
{
    public partial class TC_NV : Form
    {
        public static string data = string.Empty;
        OracleConnection con = new OracleConnection(data);
        public TC_NV()
        {
            InitializeComponent();
            con.Open();
        }
        void load()
        {
            OracleCommand tabledgv = new OracleCommand("SELECT * FROM MNG.NHANVIEN", con);

            tabledgv.CommandType = CommandType.Text;

            OracleDataReader _reader = tabledgv.ExecuteReader();

            DataTable tablelist = new DataTable();

            tablelist.Load(_reader);

            dgv.DataSource = tablelist;
        }
        private void TC_NV_Load(object sender, EventArgs e)
        {
            load();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgv.Rows[e.RowIndex];
            cbb_mnv.Text = Convert.ToString(row.Cells["MANV"].Value);
            cbb_l.Text = Convert.ToString(row.Cells["LUONG"].Value);
            cbb_pc.Text = Convert.ToString(row.Cells["PHUCAP"].Value);
        }

        private void b_s_Click(object sender, EventArgs e)
        {
            if (cbb_mnv.Text != "")
            {
                OracleCommand command = new OracleCommand("UPDATE MNG.NHANVIEN SET LUONG = " + cbb_l.Text + ", PHUCAP = " + cbb_pc.Text + " WHERE MANV = '" + cbb_mnv.Text + "'", con);

                command.CommandType = CommandType.Text;

                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Sửa thành công!");
                    load();

                }
                catch (Exception)
                {
                    MessageBox.Show("Nhân Viên không tồn tại");
                }
            }
            else MessageBox.Show("Chưa chọn nhân viên");
        }
    }
}
