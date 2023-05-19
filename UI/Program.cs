using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATBMTHTTT
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            String data = @"Data Source=(DESCRIPTION =
                                                        (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))
                                                        (CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = XE))
                                        );User Id = MNG;password=1";
            inputData(data);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LOGIN());
        }

        private static void inputData( String data)
        {
            //DUNG CHUNG
            LOGIN.data = data;
            REGISTER.data = data;
            //ADMIN
            ADMIN.data = data;
            ADMIN_PRIVILEGE_ROLE.data = data;
            ADMIN_PRIVILEGE_USER.data = data;
            ADMIN_ROLE.data = data;
            ADMIN_TABLE.data = data;
            ADMIN_USER.data = data;
            ADMIN_VIEW.data = data;
            ADMIN_GRANT.data = data;
            ADMIN_ROLEGRANT.data = data;
            ADMIN_CREATETABLE.data = data;
        }
    }
}
