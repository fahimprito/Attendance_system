using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AttendanceSystem
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Registrationbt_Click(object sender, EventArgs e)
        {
            
            string uname = textBoxuser.Text;
            string upass = textBoxpass.Text;

            var conn = Database.ConnectDatabase();
            try
            {
                if (textBoxpass.Text == textBoxCpass.Text)
                {
                    conn.Open();
                }
                else
                {
                    MessageBox.Show("Password not match");
                    conn.Close();
                }
                    
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            string query = string.Format("insert into UserTable values ('{0}','{1}')", uname, upass);
            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                int r = cmd.ExecuteNonQuery();
                if (r > 0)
                {
                    MessageBox.Show(" Registration Completed ");
                }
                else
                {
                    MessageBox.Show(" Registration Failed ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();



        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason != CloseReason.WindowsShutDown)
            { Application.Exit(); }
        }

        private void backbt_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }
    }
}
