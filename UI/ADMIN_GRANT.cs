using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace ATBMTHTTT
{
    public partial class ADMIN_GRANT : Form
    {
        public static string data = string.Empty;
        public static string user = string.Empty;
        OracleConnection con = new OracleConnection(data);
        public ADMIN_GRANT()
        {
            InitializeComponent();
            con.Open();
        }

        void cleardata()
        {
            comboBox_Att.Text = "";
            comboBox_priv.Text = "";
            comboBox_procedure.Text = "";
            comboBox_role.Text = "";
            comboBox_table.Text = "";
            comboBox_view.Text = "";
        }
        private void button_grant_Click(object sender, EventArgs e)
        {

            if (comboBox_priv.Text == ""  && comboBox_role.Text == ""||
                comboBox_priv.Text == "SELECT" && comboBox_table.Text == "" && comboBox_view.Text == "" ||
                comboBox_priv.Text == "INSERT" && comboBox_table.Text == "" && comboBox_view.Text == "" ||
                comboBox_priv.Text == "UPDATE" && comboBox_table.Text == "" && comboBox_view.Text == "" ||
                comboBox_priv.Text == "DELETE" && comboBox_table.Text == "" && comboBox_view.Text == "" ||
                comboBox_priv.Text == "EXECUTE" && comboBox_procedure.Text == "")
            {
                MessageBox.Show("Không thể cấp quyền khi chưa chọn đủ dữ liệu");
            }
            else
            {
                OracleCommand oracle_script = new OracleCommand("ALTER SESSION SET \"_ORACLE_SCRIPT\"= TRUE", con);
                oracle_script.CommandType = CommandType.Text;
                oracle_script.ExecuteNonQuery();
                OracleCommand command = new OracleCommand();
                String text = string.Empty;
                if (comboBox_Att.Text != "")
                {
                    text = "GRANT " + comboBox_priv.Text + "(" + comboBox_Att.Text + ") ON " + comboBox_table.Text + " TO " + user;
                }
                else if (comboBox_table.Text != "" && comboBox_Att.Text == "")
                {
                    text = "GRANT " + comboBox_priv.Text + " ON " + comboBox_table.Text + " TO " + user;
                }
                else if (comboBox_view.Text != "" )
                {
                    text = "GRANT " + comboBox_priv.Text + " ON " + comboBox_view.Text + " TO " + user;
                }
                else if (comboBox_role.Text != "")
                {
                    command.CommandText = "MNG.USP_ADDUSER_ROLE";
                    command.Connection = con;
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new OracleParameter("PARA_USER", OracleDbType.Varchar2, 32767)).Value = user;
                    command.Parameters.Add(new OracleParameter("PARA_ROLE", OracleDbType.Varchar2, 32767)).Value = comboBox_role.Text.Trim();
                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Đưa user vào role thành công!");

                    }
                    catch (Exception EX)
                    {
                        MessageBox.Show(EX.ToString());
                    }
                    con.Close();
                    this.Close();
                    return;
                }
                else if (comboBox_procedure.Text != "")
                {
                    text = "GRANT " + comboBox_priv.Text + " ON " + comboBox_procedure.Text + " TO " + user;
                }
                else
                {
                    text = "GRANT " + comboBox_priv.Text + " TO " + user;
                }

                if (checkBox_ask.Checked && comboBox_role.Text == "")
                {
                    text += " WITH GRANT OPTION";
                }
                command.CommandText = text;
                command.Connection = con;
                command.CommandType = CommandType.Text;
                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Cấp quyền thành công!");

                }
                catch (Exception EX)
                {
                    MessageBox.Show(EX.ToString());
                }
            }
            con.Close();
            this.Close();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            con.Close();
            this.Close();
        }

        private void ADMIN_GRANT_Load(object sender, EventArgs e)
        {
            loadCBB_ROLE();
        }
        void loadCBB_TABLE()
        {   
            comboBox_Att.Items.Clear();
            comboBox_table.Items.Clear();
            OracleCommand command = new OracleCommand("SELECT TABLE_NAME FROM USER_TABLES", con);
            command.CommandType = CommandType.Text;
            OracleDataReader Reader = command.ExecuteReader();

            while (Reader.Read())
            {
                comboBox_table.Items.Add(Reader[0]);
            }
        }
        void loadCBB_ROLE()
        {
            comboBox_role.Items.Clear();
            OracleCommand command = new OracleCommand("SELECT ROLE FROM DBA_ROLES WHERE ORACLE_MAINTAINED = 'Y' AND ROLE_ID BETWEEN 150 and 500", con);
            command.CommandType = CommandType.Text;
            OracleDataReader Reader = command.ExecuteReader();

            while (Reader.Read())
            {
                comboBox_role.Items.Add(Reader[0]);
            }
        }
        void loadCBB_VIEW()
        {   
            comboBox_view.Items.Clear();
            OracleCommand command = new OracleCommand("SELECT VIEW_NAME FROM USER_VIEWS", con);
            command.CommandType = CommandType.Text;
            OracleDataReader Reader = command.ExecuteReader();

            while (Reader.Read())
            {
                comboBox_view.Items.Add(Reader[0]);
            }
        }
        void loadCBB_PROCEDURE()
        {
            comboBox_procedure.Items.Clear();
            OracleCommand command = new OracleCommand("SELECT OBJECT_NAME FROM USER_PROCEDURES", con);
            command.CommandType = CommandType.Text;
            OracleDataReader Reader = command.ExecuteReader();

            while (Reader.Read())
            {
                comboBox_procedure.Items.Add(Reader[0]);
            }
        }
        void loadCBB_ATT()
        {
            comboBox_Att.Items.Clear();
            OracleCommand command = new OracleCommand("SELECT COLUMN_NAME FROM DBA_TAB_COLUMNS WHERE TABLE_NAME = '" + comboBox_table.Text + "'", con);
            command.CommandType = CommandType.Text;
            OracleDataReader Reader = command.ExecuteReader();

            while (Reader.Read())
            {
                comboBox_Att.Items.Add(Reader[0]);
            }
        }
        private void comboBox_priv_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_role.Text = "";
            if(comboBox_priv.Text == "SELECT" ||  comboBox_priv.Text == "DELETE" || comboBox_priv.Text == "UPDATE" || comboBox_priv.Text == "INSERT")
            {
                loadCBB_TABLE();
                loadCBB_VIEW();
            }
            else if(comboBox_priv.Text ==  "EXECUTE")
            {
                loadCBB_PROCEDURE();
            }
        }

        private void comboBox_table_SelectedIndexChanged(object sender, EventArgs e)
        {
            if( comboBox_table.Text != "" && comboBox_priv.Text == "INSERT" || comboBox_table.Text != "" && comboBox_priv.Text == "UPDATE")
            {
                loadCBB_ATT();
            }
        }
    }
}
