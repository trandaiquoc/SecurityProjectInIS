using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace ATBMTHTTT
{
    public partial class TP_PC : Form
    {
        public static string data = string.Empty;
        OracleConnection con = new OracleConnection(data);
        public TP_PC()
        {
            InitializeComponent();
            con.Open();
        }
        void load()
        {
            OracleCommand tabledgv = new OracleCommand("SELECT * FROM MNG.UV_PHANCONG_TP", con);

            tabledgv.CommandType = CommandType.Text;

            OracleDataReader _reader = tabledgv.ExecuteReader();

            DataTable tablelist = new DataTable();

            tablelist.Load(_reader);

            dgv.DataSource = tablelist;
        }
        private void TP_PC_Load(object sender, EventArgs e)
        {
            load();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgv.Rows[e.RowIndex];
            cbb_mnv.Text = Convert.ToString(row.Cells["MANV"].Value);
            cbb_mda.Text = Convert.ToString(row.Cells["MADA"].Value);
            cbb_tg.Text = Convert.ToString(row.Cells["THOIGIAN"].Value);
        }

        private void b_t_Click(object sender, EventArgs e)
        {
            if (cbb_mda.Text != "" || cbb_mnv.Text != "")
            {
                OracleCommand command = new OracleCommand("INSERT INTO MNG.UV_PHANCONG_TP VALUES ('" + cbb_mnv.Text + "','" + cbb_mda.Text + "'," + cbb_tg.Text + ")", con);

                command.CommandType = CommandType.Text;

                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Thêm Phân công thành công!");
                    load();

                }
                catch (Exception)
                {
                    MessageBox.Show("Phân Công đã tồn tại");
                }
            }
            else MessageBox.Show("Chưa nhập phân công");
        }
  

        private void b_x_Click(object sender, EventArgs e)
        {
            if (cbb_mda.Text != "" || cbb_mnv.Text != "")
            {
                OracleCommand command = new OracleCommand("DELETE FROM MNG.UV_PHANCONG_TP WHERE MANV = '" + cbb_mnv.Text + "' AND MADA =' " + cbb_mda.Text +"'", con);

                command.CommandType = CommandType.Text;

                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Xoá Phân công thành công!");
                    load();

                }
                catch (Exception)
                {
                    MessageBox.Show("Phân Công không tồn tại");
                }
            }
            else MessageBox.Show("Chưa chọn phân công");
        }

        private void b_s_Click(object sender, EventArgs e)
        {
            if (cbb_mda.Text != "" || cbb_mnv.Text != "")
            {
                OracleCommand command = new OracleCommand("UPDATE MNG.UV_PHANCONG_TP SET THOIGIAN = " + cbb_tg.Text + " WHERE MANV = '" + cbb_mnv.Text + "' AND MADA = '" + cbb_mda.Text + "'", con);

                command.CommandType = CommandType.Text;

                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Sửa Phân công thành công!");
                    load();

                }
                catch (Exception)
                {
                    MessageBox.Show("Phân Công không tồn tại");
                }
            }
            else MessageBox.Show("Chưa chọn phân công");
        }
    }
}
