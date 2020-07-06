using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lessons2206.Forms.Additional
{
    public partial class creatorsForm : Form
    {
        public static creatorsForm hndlr;
        public creatorsForm()
        {
            hndlr = this;
            InitializeComponent();
        }
    }
}
