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
using MSSQL_SDK;

namespace Lessons1506
{
    public partial class Form1 : Form
    {
        public static Form1 window;
        public Form1()
        {
            InitializeComponent();
            window = this;
        }

        private void auth_btn_Click(object sender, EventArgs e)
        {
            string l = login_tb.Text;
            string p = pass_tb.Text;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Program.db.cnn;
            cmd.CommandText = "SELECT * FROM users WHERE username = @param1 AND password = @param2";
            cmd.Parameters.AddWithValue("@param1", l);
            cmd.Parameters.AddWithValue("@param2", p);

            SqlDataReader reader = cmd.ExecuteReader();
            if(reader.HasRows)
            {
                while(reader.Read())
                {
                    MessageBox.Show("Welcome, " + reader.GetValue(1));
                }
            }
            else
            {
                MessageBox.Show("Username not valid");
            }
            reader.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (authed.window == null)
            {
                authed p = new authed();
                p.Show();
                Hide();
            }
            else
            {
                authed.window.Show();
                Hide();
            }
        }
    }
}
