using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace ATBMTHTTT
{
    public partial class NS_NV : Form
    {
        public static string data = string.Empty;
        OracleConnection con = new OracleConnection(data);
        public NS_NV()
        {
            InitializeComponent();
            con.Open();
        }
        void load()
        {
            OracleCommand tabledgv = new OracleCommand("SELECT * FROM MNG.UV_NHANVIEN_NS", con);

            tabledgv.CommandType = CommandType.Text;

            OracleDataReader _reader = tabledgv.ExecuteReader();

            DataTable tablelist = new DataTable();

            tablelist.Load(_reader);

            dgv.DataSource = tablelist;
        }
        void loadCBB_QL()
        {
            CBB_QL.Items.Clear();
            OracleCommand command = new OracleCommand("SELECT MANV FROM MNG.NHANVIEN WHERE VAITRO = 'QUANLY'", con);
            command.CommandType = CommandType.Text;
            OracleDataReader Reader = command.ExecuteReader();

            while (Reader.Read())
            {
                CBB_QL.Items.Add(Reader[0]);
            }
        }
        void loadCBB_VT()
        {
            CBB_VT.Items.Clear();
            OracleCommand command = new OracleCommand("SELECT DISTINCT VAITRO FROM MNG.NHANVIEN", con);
            command.CommandType = CommandType.Text;
            OracleDataReader Reader = command.ExecuteReader();

            while (Reader.Read())
            {
                CBB_VT.Items.Add(Reader[0]);
            }
        }
        private void NS_NV_Load(object sender, EventArgs e)
        {
            load();
            loadCBB_QL();
            loadCBB_VT();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgv.Rows[e.RowIndex];
            cbb_mnv.Text = Convert.ToString(row.Cells["MANV"].Value);
            CBB_TNV.Text = Convert.ToString(row.Cells["TENNV"].Value);
            CBB_P.Text = Convert.ToString(row.Cells["PHAI"].Value);
            CBB_DC.Text = Convert.ToString(row.Cells["DIACHI"].Value);
            dateTimePicker1.Text = Convert.ToString(row.Cells["NGAYSINH"].Value);
            CBB_PB.Text = Convert.ToString(row.Cells["PHG"].Value);
            CBB_SDT.Text = Convert.ToString(row.Cells["SDT"].Value);
            CBB_QL.Text = Convert.ToString(row.Cells["MANQL"].Value);
            CBB_VT.Text = Convert.ToString(row.Cells["VAITRO"].Value);
        }

        private void b_t_Click(object sender, EventArgs e)
        {
            if (cbb_mnv.Text != "")
            {
                OracleCommand command = new OracleCommand("INSERT INTO MNG.NHANVIEN(MANV, TENNV, PHAI, NGAYSINH, DIACHI, SDT, VAITRO, MANQL, PHG) " +
                    "VALUES ('" + cbb_mnv.Text + "','" + CBB_TNV.Text + "','" + CBB_P.Text + "', TO_DATE('" + dateTimePicker1.Text + "', 'mm/dd/yyyy'),'" + CBB_DC.Text +"','" + CBB_SDT.Text + "','" + CBB_VT.Text + "','" + CBB_QL.Text + "'," + CBB_PB.Text + ")", con);

                command.CommandType = CommandType.Text;

                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Thêm nhân viên thành công!");
                    load();

                }
                catch (Exception E)
                {
                    MessageBox.Show(E.ToString());
                }
            }
            else MessageBox.Show("Chưa nhập nhân viên");
        }

        private void b_s_Click(object sender, EventArgs e)
        {
            if (cbb_mnv.Text != "")
            {
                OracleCommand command = new OracleCommand("UPDATE MNG.NHANVIEN SET TENNV = '" + CBB_TNV.Text + "', PHAI ='" + CBB_P.Text + "', NGAYSINH = TO_DATE('" + dateTimePicker1.Text + "', 'mm/dd/yyyy'), DIACHI = '" + CBB_DC.Text +"', SDT = '" + CBB_SDT.Text +"', VAITRO = '" + CBB_VT.Text +"', MANQL ='" + CBB_QL.Text + "', PHG = " + CBB_PB.Text + "  WHERE MANV = '" + cbb_mnv.Text + "'", con);

                command.CommandType = CommandType.Text;

                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Sửa nhân viên thành công!");
                    load();

                }
                catch (Exception E)
                {
                    MessageBox.Show(E.ToString());
                }
            }
            else MessageBox.Show("Chưa chọn nhân viên");
        }
    }
}
