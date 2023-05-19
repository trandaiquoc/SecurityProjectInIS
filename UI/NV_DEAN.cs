using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace ATBMTHTTT
{
    public partial class NV_DEAN : Form
    {
        public static string data = string.Empty;
        OracleConnection con = new OracleConnection(data);
        public NV_DEAN()
        {
            InitializeComponent();
            con.Open();
        }

        private void NV_DEAN_Load(object sender, EventArgs e)
        {
            OracleCommand tabledgv = new OracleCommand("SELECT * FROM MNG.DEAN", con);

            tabledgv.CommandType = CommandType.Text;

            OracleDataReader _reader = tabledgv.ExecuteReader();

            DataTable tablelist = new DataTable();

            tablelist.Load(_reader);

            dgv.DataSource = tablelist;
        }
    }
}
