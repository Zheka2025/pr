using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Editor.Forms
{
    public partial class Tables : Form
    {
        public static string table;
        public static Tables window;
        public Tables(string table_name)
        {
            InitializeComponent();
            table = table_name;
            window = this;
        }

        private void Tables_Load(object sender, EventArgs e)
        {
            MessageBox.Show(table);
            status_lbl.Text = "Current table: " + table;
            SqlDataAdapter adapter = new SqlDataAdapter($"SELECT * FROM {table}", Program.db.cnn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            table_dg.DataSource = ds.Tables[0];
        }
    }
}
