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
        private SqlDataAdapter adapter;
        private string table_name;

        public TableView(string table_name)
        {
            this.table_name = table_name;
            InitializeComponent();
            
            string cmd = $"SELECT * FROM {table_name}";
                adapter = new SqlDataAdapter(cmd, Program.db.cnn);
            adapter.Fill(table_ds);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
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
            if (tableData_dg.ColumnCount > 0) table_ds.Tables[0].Rows.Add(1);
            else MessageBox.Show("Table has 0 columns");
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            //StringBuilder sb = new StringBuilder();
            //sb.Append($"INSERT INTO {table_name} (");
            //for (int i = 0; i < tableData_dg.ColumnCount; i++)
            //{
            //    if(i == tableData_dg.ColumnCount-1) sb.Append(tableData_dg.Columns[i].HeaderText);
            //    else sb.Append(tableData_dg.Columns[i].HeaderText + ","); 

            //}
            //sb.Append(") VALUES (");
            //for (int i = 0; i < tableData_dg.ColumnCount; i++)
            //{

            //}
            //adapter.InsertCommand = new SqlCommand($"INSERT INTO {table_name}");
            adapter.Update(table_ds);
        }
    }
}
