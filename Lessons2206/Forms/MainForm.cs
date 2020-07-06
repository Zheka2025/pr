using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lessons2206.Engine;
using Lessons2206.Forms.Additional;
using FastColoredTextBoxNS;
using System.Data.SqlClient;

namespace Lessons2206.Forms
{
    public partial class MainForm : Form
    {
        public static MainForm hndlr;
        private static DataSet tables_ds;
        public MainForm()
        {
            hndlr = this;
            InitializeComponent();
            query_tb.Language = Language.SQL;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void publicInformation_btn_Click(object sender, EventArgs e)
        {
            if (PublicInformation.hndlr == null)
            {
                PublicInformation creators = new PublicInformation();
                creators.ShowDialog();
            }
            else PublicInformation.hndlr.ShowDialog();
        }

        private void creators_btn_Click(object sender, EventArgs e)
        {
            if (creatorsForm.hndlr == null)
            {
                creatorsForm creators = new creatorsForm();
                creators.ShowDialog();
            }
            else creatorsForm.hndlr.ShowDialog();
        }

        private void about_btn_Click(object sender, EventArgs e)
        {
            if (About.hndlr == null)
            {
                About creators = new About();
                creators.ShowDialog();
            }
            else About.hndlr.ShowDialog();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            status_lbl.Text = "Current user: " + AuthInfo.username;
        }

        private void settings_btn_Click(object sender, EventArgs e)
        {
            if (Settings.hndlr == null)
            {
                Settings creators = new Settings();
                creators.ShowDialog();
            }
            else Settings.hndlr.ShowDialog();
        }

        private void query_rtb_TextChanged(object sender, EventArgs e)
        {

        }

        private void queryTB_tab_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string sql = "SELEC name, create_date FROM sys.objects WHERE type in(N'U')";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, Program.db.cnn);
            tables_ds = new DataSet();
         
            adapter.Fill(tables_ds);
         
            tables_dg.DataSource = tables_ds.Tables[0];
            tables_dg.Update();
            foreach (DataGridViewRow r in tables_dg.Rows) if (r.Cells[0].Value.ToString() == "accounts") tables_dg.Rows.Remove(r);
            CAction.AutoSizeColumns(tables_dg);
        }

        private void send_query_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(query_tb.Text))
            {
                MessageBox.Show("Query was empty.");
                return;
            }
            if (query_tb.Text.Contains("select")||
                query_tb.Text.Contains("SELECT"))
            {
                try
                {
                    SqlDataAdapter ad = new SqlDataAdapter(query_tb.Text, Program.db.cnn);
                    DataSet ds = new DataSet();
                    ad.Fill(ds);
                    result_dg.DataSource = ds.Tables[0];
                    result_dg.Update();
                    CAction.AutoSizeColumns(result_dg);
                }
                catch(SqlException s)
                {
                    result_dg.Columns.Add("Query", "Query result");
                    result_dg.Rows.Add(s.Message);
                    CAction.AutoSizeColumns(result_dg);
                }
               
            }
            else
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query_tb.Text);
                    cmd.Connection = Program.db.cnn;
                   int buffer = cmd.ExecuteNonQuery();
                    result_dg.Columns.Add("Query", "Query result");
                    result_dg.Rows.Add("Inherit rows: " + buffer);
                    CAction.AutoSizeColumns(result_dg);
                }
                catch (SqlException s)
                {
                    result_dg.Columns.Add("Query", "Query result");
                    result_dg.Rows.Add(s.Message);
                    CAction.AutoSizeColumns(result_dg);
                }
            }
        }
  
       

        private void tables_dg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string table_name = tables_dg.Rows[e.RowIndex].Cells[0].Value.ToString();
            TableView table = new TableView(table_name);
            table.ShowDialog();
        }
        private void updateTables()
        {
            string sql = "SELEC name, create_date FROM sys.objects WHERE type in(N'U')";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, Program.db.cnn);
            tables_ds = new DataSet();

            adapter.Fill(tables_ds);

            tables_dg.DataSource = tables_ds.Tables[0];
            tables_dg.Update();
            foreach (DataGridViewRow r in tables_dg.Rows) if (r.Cells[0].Value.ToString() == "accounts") tables_dg.Rows.Remove(r);
            CAction.AutoSizeColumns(tables_dg);
        }

       

        private void tabNameWindow_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (tabNameWindow.SelectedIndex == 0) updateTables();
                
            
        }

        private void menu_st_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
