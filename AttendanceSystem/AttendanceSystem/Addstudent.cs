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
    public partial class Addstudent : Form
    {
        public Addstudent()
        {
            InitializeComponent();
        }

        private void addclassBt_Click(object sender, EventArgs e)
        {
            string addstudent = SnameTB.Text;
            string Attendance = attendanceTb.Text;

            var conn = Database.ConnectDatabase();
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            string query = string.Format("insert into StudentDB values ('{0}','{1}')", addstudent, Attendance);
            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                int r = cmd.ExecuteNonQuery();
                if (r > 0)
                {
                    MessageBox.Show(" Student added ");
                }
                else
                {
                    MessageBox.Show(" Student add Failed ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }
    }
}
