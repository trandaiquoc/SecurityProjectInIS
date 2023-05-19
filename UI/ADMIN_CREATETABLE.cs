using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace ATBMTHTTT
{
    public partial class ADMIN_CREATETABLE : Form
    {
        public static string data = string.Empty;
        OracleConnection con = new OracleConnection(data);
        public ADMIN_CREATETABLE()
        {
            InitializeComponent();
            con.Open();
        }

        private void ADMIN_CREATETABLE_Load(object sender, EventArgs e)
        {
            load();
        }

        void load()
        {
            label_attri.Hide();
            label_table.Hide();
            comboBox_attri.Hide();
            comboBox_table.Hide();
        }
    }
}
