using DB_Editor.Forms;
using DB_Editor.Manage;
using MSSQL_SDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Editor
{
    static class Program
    {
        public static Connection db { get; set; }
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if(!DB_User.isAuthed) Application.Run(new Auth());
        }
    }
}
