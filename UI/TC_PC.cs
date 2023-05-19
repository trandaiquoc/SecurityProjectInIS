using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace ATBMTHTTT
{
    public partial class TC_PC : Form
    {
        public static string data = string.Empty;
        OracleConnection con = new OracleConnection(data);
        public TC_PC()
        {
            InitializeComponent();
            con.Open();
        }

        private void TC_PC_Load(object sender, EventArgs e)
        {
            OracleCommand tabledgv = new OracleCommand("SELECT * FROM MNG.PHANCONG", con);

            tabledgv.CommandType = CommandType.Text;

            OracleDataReader _reader = tabledgv.ExecuteReader();

            DataTable tablelist = new DataTable();

            tablelist.Load(_reader);

            dgv.DataSource = tablelist;
        }
    }
}
