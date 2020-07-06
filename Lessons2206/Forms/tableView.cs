using Lessons2206.Engine;
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

namespace Lessons2206.Forms
{
    public partial class TableView : Form
    {

        private DataSet table_ds = new DataSet();
        public TableView(string table_name)
        {
            InitializeComponent();

            string cmd = $"SELECT * FROM {table_name}";
                SqlDataAdapter adapter = new SqlDataAdapter(cmd, Program.db.cnn);
            adapter.Fill(table_ds);

        }

        private void tableView_Load(object sender, EventArgs e)
        {
            tableData_dg.DataSource = table_ds.Tables[0];
            CAction.AutoSizeColumns(tableData_dg);
        }

        private void tableData_dg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void quite_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (tableData_dg.ColumnCount > 0) tableData_dg.Rows.Add();
            else MessageBox.Show("Table has 0 columns");
        }
    }
}
