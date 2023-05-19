using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace ATBMTHTTT
{
    public partial class NS_PB : Form
    {
        public static string data = string.Empty;
        OracleConnection con = new OracleConnection(data);
        public NS_PB()
        {
            InitializeComponent();
            con.Open();
        }
        void load()
        {
            OracleCommand tabledgv = new OracleCommand("SELECT * FROM MNG.PHONGBAN", con);

            tabledgv.CommandType = CommandType.Text;

            OracleDataReader _reader = tabledgv.ExecuteReader();

            DataTable tablelist = new DataTable();

            tablelist.Load(_reader);

            dgv.DataSource = tablelist;
        }
        void loadCBB_TP()
        {
            cbb_trp.Items.Clear();
            OracleCommand command = new OracleCommand("SELECT MANV FROM MNG.NHANVIEN WHERE VAITRO = 'TRUONGPHONG'", con);
            command.CommandType = CommandType.Text;
            OracleDataReader Reader = command.ExecuteReader();

            while (Reader.Read())
            {
                cbb_trp.Items.Add(Reader[0]);
            }
        }
        private void NS_PB_Load(object sender, EventArgs e)
        {
            load();
            loadCBB_TP();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgv.Rows[e.RowIndex];
            cbb_mpb.Text = Convert.ToString(row.Cells["MAPB"].Value);
            cbb_tp.Text = Convert.ToString(row.Cells["TENPB"].Value);
            cbb_trp.Text = Convert.ToString(row.Cells["TRPHG"].Value);
        }

        private void b_t_Click(object sender, EventArgs e)
        {
            if (cbb_mpb.Text != "")
            {
                OracleCommand command = new OracleCommand("INSERT INTO MNG.PHONGBAN VALUES (" + cbb_mpb.Text + ",'" + cbb_tp.Text + "','" + cbb_trp.Text + "')", con);

                command.CommandType = CommandType.Text;

                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Thêm phòng ban thành công!");
                    load();

                }
                catch (Exception)
                {
                    MessageBox.Show("Phòng ban đã tồn tại");
                }
            }
            else MessageBox.Show("Chưa nhập phòng ban");
        }

        private void b_s_Click(object sender, EventArgs e)
        {
            if (cbb_mpb.Text != "")
            {
                OracleCommand command = new OracleCommand("UPDATE MNG.PHONGBAN SET TRPHG = '" + cbb_trp.Text + "', TENPB ='" + cbb_tp.Text +"'  WHERE MAPB = '" + cbb_mpb.Text + "'", con);

                command.CommandType = CommandType.Text;

                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Sửa phòng ban thành công!");
                    load();

                }
                catch (Exception)
                {
                    MessageBox.Show("phòng ban không tồn tại");
                }
            }
            else MessageBox.Show("Chưa chọn phòng ban");
        }
    }
}
