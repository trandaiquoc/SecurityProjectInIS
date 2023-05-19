using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace ATBMTHTTT
{
    public partial class ADMIN_TABLE : Form
    {
        public static string data = string.Empty;
        OracleConnection con = new OracleConnection(data);
        public ADMIN_TABLE()
        {
            InitializeComponent();
            con.Open();
        }

        void load()
        {
            OracleCommand tabledgv = new OracleCommand("SELECT TABLE_NAME FROM USER_TABLES", con);

            tabledgv.CommandType = CommandType.Text;

            OracleDataReader _reader = tabledgv.ExecuteReader();

            DataTable tablelist = new DataTable();

            tablelist.Load(_reader);

            dgv_table.DataSource = tablelist;
        }
        private void button_rf_Click(object sender, EventArgs e)
        {
            load();
        }

        private void ADMIN_TABLE_Load(object sender, EventArgs e)
        {
            load();
        }

        private void dgv_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgv_table.Rows[e.RowIndex];
            comboBox_tablename.Text = Convert.ToString(row.Cells["TABLE_NAME"].Value);
        }

        private void button_xoa_Click(object sender, EventArgs e)
        {
            if (comboBox_tablename.Text != "")
            {
                OracleCommand command = new OracleCommand("DROP TABLE " + comboBox_tablename.Text, con);

                command.CommandType = CommandType.Text;

                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Xoá table thành công!");
                    load();

                }
                catch (Exception)
                {
                    MessageBox.Show("Table không tồn tại");
                }
            }
            else MessageBox.Show("Chưa chọn table");
        }

        private void button_them_Click(object sender, EventArgs e)
        {
            ADMIN_CREATETABLE ACT = new ADMIN_CREATETABLE();
            ACT.ShowDialog();
        }
    }
}
