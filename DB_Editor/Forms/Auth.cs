using DB_Editor.Manage;
using MSSQL_SDK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Editor.Forms
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void tryAuth_Click(object sender, EventArgs e)
        {
            status_lbl.Text = null;
            bool connstatus = false;

            try
            {
                Program.db = new Connection("itstep-work.database.windows.net", db_login.Text, db_pass.Text, db_name.Text);
                connstatus = Program.db.MakeConnection();
            }
            catch(Exception s)
            {
                status_lbl.Text = s.Message;
            }

            if (connstatus)
            {
                DB_User.current_db = db_name.Text;
                DB_User.username = db_login.Text;
                DB_User.isAuthed = true;
                Main m = new Main();
                m.Show();
                Hide();
            }
            else status_lbl.Text = "Something wrong with you.";
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
