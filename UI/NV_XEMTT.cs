using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace ATBMTHTTT
{
    public partial class NV_XEMTT : Form
    {
        public static string data = string.Empty;
        public static string manv = string.Empty;
        OracleConnection con = new OracleConnection(data);
        public NV_XEMTT()
        {
            InitializeComponent();
            con.Open();
        }

        private void NV_XEMTT_Load(object sender, EventArgs e)
        {
            load();
        }
        void load()
        {
            OracleCommand command = new OracleCommand("SELECT * FROM MNG.UV_NHANVIEN", con);
            command.CommandType = CommandType.Text;
            OracleDataReader Reader = command.ExecuteReader();
            Reader.Read();
            cbb_mnv.Text = Reader["MANV"].ToString();
            CBB_TNV.Text = Reader["TENNV"].ToString();
            CBB_P.Text = Reader["PHAI"].ToString();
            CBB_DC.Text = Reader["DIACHI"].ToString();
            dateTimePicker1.Text = Reader["NGAYSINH"].ToString();
            CBB_L.Text = Reader["LUONG"].ToString();
            CBB_PB.Text = Reader["PHG"].ToString();
            CBB_PC.Text = Reader["PHUCAP"].ToString();
            CBB_SDT.Text = Reader["SDT"].ToString();
            CBB_QL.Text = Reader["MANQL"].ToString();
            CBB_VT.Text = Reader["VAITRO"].ToString();
            Reader.Close();

        }

        private void button_sua_Click(object sender, EventArgs e)
        {
            try
            {
                OracleCommand command = new OracleCommand("UPDATE MNG.UV_NHANVIEN SET DIACHI = '" + CBB_DC.Text + "', SDT = '" + CBB_SDT.Text + "', NGAYSINH = TO_DATE('" + dateTimePicker1.Text + "', 'mm/dd/yyyy') WHERE MANV = '" + manv + "'", con);
                command.CommandType = CommandType.Text;
                int n = command.ExecuteNonQuery();
                if( n > 0 )
                {
                    MessageBox.Show("Thanh Cong");
                    load();
                }
                else
                {
                    MessageBox.Show("That Bai");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }
    }
}
