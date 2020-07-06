using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lessons1506
{
    public partial class authed : Form
    {
        public static authed window;
        public authed()
        {
            InitializeComponent();
            window = this;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1.window.Show();
            Hide();
        }
    }
}
