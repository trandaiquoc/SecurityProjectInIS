using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace ATBMTHTTT
{
    public partial class ADMIN_ROLEGRANT : Form
    {
        public static string data = string.Empty;
        public static string role = string.Empty;
        OracleConnection con = new OracleConnection(data);
        public ADMIN_ROLEGRANT()
        {
            InitializeComponent();
            con.Open();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            con.Close();
            this.Close();
        }
        private void ADMIN_ROLEGRANT_Load(object sender, EventArgs e)
        {
            loadCBB_USER();
        }
        void loadCBB_TABLE()
        {
            comboBox_table.Items.Clear();
            OracleCommand command = new OracleCommand("SELECT TABLE_NAME FROM USER_TABLES", con);
            command.CommandType = CommandType.Text;
            OracleDataReader Reader = command.ExecuteReader();

            while (Reader.Read())
            {
                comboBox_table.Items.Add(Reader[0]);
            }
        }
        void loadCBB_USER()
        {
            comboBox_user.Items.Clear();
            OracleCommand command = new OracleCommand("SELECT USERNAME FROM all_users WHERE CREATED > TO_DATE('2023/01/01', 'yyyy/mm/dd')", con);
            command.CommandType = CommandType.Text;
            OracleDataReader Reader = command.ExecuteReader();

            while (Reader.Read())
            {
                comboBox_user.Items.Add(Reader[0]);
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
            comboBox_user.Text = "";
            if (comboBox_priv.Text == "SELECT" || comboBox_priv.Text == "DELETE" || comboBox_priv.Text == "UPDATE" || comboBox_priv.Text == "INSERT")
            {
                loadCBB_TABLE();
                loadCBB_VIEW();
            }
            else if (comboBox_priv.Text == "EXECUTE")
            {
                loadCBB_PROCEDURE();
            }
        }

        private void comboBox_table_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_table.Text != "" && comboBox_priv.Text == "INSERT" || comboBox_table.Text != "" && comboBox_priv.Text == "UPDATE")
            {
                loadCBB_ATT();
            }
        }

        private void button_grant_Click(object sender, EventArgs e)
        {
            if (comboBox_priv.Text == "" && comboBox_user.Text == "" ||
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
                if (comboBox_table.Text != "" && comboBox_Att.Text != "")
                {
                    text = "GRANT " + comboBox_priv.Text + "(" + comboBox_Att.Text + ") ON " + comboBox_table.Text + " TO " + role;
                }
                else if (comboBox_table.Text != "" && comboBox_Att.Text == "")
                {
                    text = "GRANT " + comboBox_priv.Text + " ON " + comboBox_table.Text + " TO " + role;
                }
                else if (comboBox_view.Text != "")
                {
                    text = "GRANT " + comboBox_priv.Text + " ON " + comboBox_view.Text + " TO " + role;
                }
                else if (comboBox_user.Text != "")
                {
                    command.CommandText = "MNG.USP_ADDUSER_ROLE";
                    command.Connection = con;
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new OracleParameter("PARA_USER", OracleDbType.Varchar2, 32767)).Value = comboBox_user.Text.Trim();
                    command.Parameters.Add(new OracleParameter("PARA_ROLE", OracleDbType.Varchar2, 32767)).Value = role;
                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Đưa user vào role thành công!");

                    }
                    catch (Exception EX)
                    {
                        MessageBox.Show(EX.ToString());
                    }
                    return;
                }
                else if (comboBox_procedure.Text != "")
                {
                    text = "GRANT " + comboBox_priv.Text + " ON " + comboBox_procedure.Text + " TO " + role;
                }
                else
                {
                    text = "GRANT " + comboBox_priv.Text + " TO " + role;
                }

                if (checkBox_ask.Checked && comboBox_user.Text == "")
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
                catch (Exception)
                {
                    MessageBox.Show("Cấp quyền thất bại");
                }
            }
            con.Close();
            this.Close();
        }
    }
}
