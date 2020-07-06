using DB_Editor.Manage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace DB_Editor.Forms
{
    public partial class Main : Form
    {
        public static Main window;
        public static List<string> table_names = new List<string>();
        public Main()
        {
            InitializeComponent();
            window = this;
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            status_lbl.Text = "Current Database: " + DB_User.current_db;
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM SYSOBJECTS WHERE xtype = 'u'", Program.db.cnn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            
            foreach(DataTable dt in ds.Tables) foreach (DataRow dr in dt.Rows) table_names.Add(dr.ItemArray[0].ToString());

            foreach (var item in table_names) table_dg.Rows.Add(item);

        }

        private async void UpdateFor(string newtext, int time = 3000)
        {
            string oldtext = status_lbl.Text;

            Dispatcher.CurrentDispatcher.Invoke(
                    DispatcherPriority.Normal,
                    new Action(() =>
                    {
                        status_lbl.Text = newtext;
                    }));

            Thread.Sleep(time);
            status_lbl.Text = oldtext;
        }

        private void table_dg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Tables t = new Tables(table_names[e.RowIndex]);
            t.ShowDialog();
        }
    }
}
