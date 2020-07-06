using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lessons2206.Forms.Additional
{
    public partial class About : Form
    {
        public static About hndlr;
        public About()
        {
            hndlr = this;
            InitializeComponent();
        }

        private void About_Shown(object sender, EventArgs e)
        {
            version_lbl.Text = Assembly.GetEntryAssembly().GetName().Version.ToString();
        }
    }
}
