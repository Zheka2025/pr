using Lessons2206.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lessons2206.Forms.Additional
{
    public partial class Settings : Form
    {
        public static Settings hndlr;
        public Settings()
        {
            hndlr = this;
            InitializeComponent();
        }

        private void deauth_btn_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Вы действительно хотите выйти?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(res == DialogResult.Yes)
            {
                Close();
                MainForm.hndlr.Hide();
                AuthInfo.username = null;
                AuthInfo.password = null;
                Auth.hndlr.Show();
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }
    }
}
