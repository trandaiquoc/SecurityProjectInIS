using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace ATBMTHTTT
{
    public partial class NV_PHONGBAN : Form
    {
        public static string data = string.Empty;
        OracleConnection con = new OracleConnection(data);
        public NV_PHONGBAN()
        {
            InitializeComponent();
            con.Open();
        }

        private void NV_PHONGBAN_Load(object sender, EventArgs e)
        {
            OracleCommand tabledgv = new OracleCommand("SELECT * FROM MNG.PHONGBAN", con);

            tabledgv.CommandType = CommandType.Text;

            OracleDataReader _reader = tabledgv.ExecuteReader();

            DataTable tablelist = new DataTable();

            tablelist.Load(_reader);

            dgv.DataSource = tablelist;
        }
    }
}
