using Lessons2206.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lessons2206.Forms
{
    public partial class Auth : Form
    {
        public static Auth hndlr;
        public Auth()
        {
            hndlr = this;
            InitializeComponent();
        }

        private void auth_btn_Click(object sender, EventArgs e)
        {
            AuthInfo.username = login_tb.Text;
            AuthInfo.password = pass_tb.Text;
            AuthInfo.useQuickAuth = quickauth_cb.Checked;
            if (savepass_cb.Checked) AuthInfo.SavePassword();
            AT();
        }

        private void Auth_Load(object sender, EventArgs e)
        {
            
        }

        private void AT()
        {
            Enums.StatusName res = AuthInfo.MakeAuth();
            if (res == Enums.StatusName.Success)
            {
                Hide();
                if (MainForm.hndlr == null)
                {
                    MainForm mf = new MainForm();
                    mf.Show();
                }
                else MainForm.hndlr.Show();
            }
        }

        private void Auth_Shown(object sender, EventArgs e)
        {
            if (AuthInfo.ini.KeyExists("username", "Auth") && AuthInfo.ini.KeyExists("password", "Auth"))
            {
                login_tb.Text = AuthInfo.ini.Read("username", "Auth");
                pass_tb.Text = AuthInfo.ini.Read("password", "Auth");
                AuthInfo.username = login_tb.Text;
                AuthInfo.password = pass_tb.Text;
                AuthInfo.useQuickAuth = quickauth_cb.Checked = AuthInfo.ini.Read("useQuickAuth", "Auth") == "True" ? true : false;
                savepass_cb.Checked = true;
                if (AuthInfo.useQuickAuth) AT();
            }
        }
    }
}
