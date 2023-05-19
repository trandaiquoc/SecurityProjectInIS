using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace ATBMTHTTT
{
    public partial class TP_TTNV : Form
    {
        public static string data = string.Empty;
        OracleConnection con = new OracleConnection(data);
        public TP_TTNV()
        {
            InitializeComponent();
            con.Open();
        }

        private void TP_TTNV_Load(object sender, EventArgs e)
        {
            OracleCommand tabledgv = new OracleCommand("SELECT * FROM MNG.UV_NHANVIEN_TP", con);

            tabledgv.CommandType = CommandType.Text;

            OracleDataReader _reader = tabledgv.ExecuteReader();

            DataTable tablelist = new DataTable();

            tablelist.Load(_reader);

            dgv.DataSource = tablelist;
        }
    }
}
