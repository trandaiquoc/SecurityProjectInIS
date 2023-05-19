using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace ATBMTHTTT
{
    public partial class TDA_DA : Form
    {
        public static string data = string.Empty;
        OracleConnection con = new OracleConnection(data);
        public TDA_DA()
        {
            InitializeComponent();
            con.Open();
        }
        void load()
        {
            OracleCommand tabledgv = new OracleCommand("SELECT * FROM MNG.DEAN", con);

            tabledgv.CommandType = CommandType.Text;

            OracleDataReader _reader = tabledgv.ExecuteReader();

            DataTable tablelist = new DataTable();

            tablelist.Load(_reader);

            dgv.DataSource = tablelist;
        }
        private void TDA_DA_Load(object sender, EventArgs e)
        {
            load();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgv.Rows[e.RowIndex];
            cbb_mda.Text = Convert.ToString(row.Cells["MADA"].Value);
            cbb_p.Text = Convert.ToString(row.Cells["PHONG"].Value);
            cbb_tda.Text = Convert.ToString(row.Cells["TENDA"].Value);
            DTP.Text = Convert.ToString(row.Cells["NGAYBD"].Value);
        }

        private void b_t_Click(object sender, EventArgs e)
        {
            if (cbb_mda.Text != "")
            {
                OracleCommand command = new OracleCommand("INSERT INTO MNG.DEAN VALUES (" + cbb_mda.Text + ",'" + cbb_tda.Text + "', TO_DATE('" + DTP.Text + "','mm/dd/yyyy'), " + cbb_p.Text + ")", con);

                command.CommandType = CommandType.Text;

                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Thêm đề án thành công!");
                    load();

                }
                catch (Exception E)
                {
                    MessageBox.Show(E.ToString());
                }
            }
            else MessageBox.Show("Chưa nhập đề án");
        }

        private void b_x_Click(object sender, EventArgs e)
        {
            if (cbb_mda.Text != "")
            {
                OracleCommand command = new OracleCommand("DELETE FROM MNG.DEAN WHERE MADA = " + cbb_mda.Text , con);

                command.CommandType = CommandType.Text;

                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Xoá đề án thành công!");
                    load();

                }
                catch (Exception)
                {
                    MessageBox.Show("Đề án không tồn tại");
                }
            }
            else MessageBox.Show("Chưa chọn đề án");
        }

        private void b_s_Click(object sender, EventArgs e)
        {
            if (cbb_mda.Text != "")
            {
                OracleCommand command = new OracleCommand("UPDATE MNG.DEAN SET PHONG = " + cbb_p.Text + ", TENDA = '" + cbb_tda.Text +"', NGAYBD = TO_DATE('" + DTP.Text + "','mm/dd/yyyy') WHERE MADA = " + cbb_mda.Text , con);

                command.CommandType = CommandType.Text;

                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Sửa Đề án thành công!");
                    load();

                }
                catch (Exception)
                {
                    MessageBox.Show("Đề án không tồn tại");
                }
            }
            else MessageBox.Show("Chưa chọn đề án");
        }
    }
}
