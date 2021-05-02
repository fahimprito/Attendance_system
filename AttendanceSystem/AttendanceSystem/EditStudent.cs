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
    public partial class EditStudent : Form
    {
        public EditStudent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var conn = Database.ConnectDatabase();
            conn.Open();
            int id = Int32.Parse(Tbidupdate.Text);
            string query = "select * from StudentDB where StudentId = " + id;
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Student c = new Student();

            while (reader.Read())
            {
                c.StudentId = reader.GetInt32(reader.GetOrdinal("StudentId"));
                c.StudentName = reader.GetString(reader.GetOrdinal("StudentName"));
                c.Attendance = reader.GetString(reader.GetOrdinal("Attendance"));

            }
            conn.Close();
            SnameTBupdate.Text = c.StudentName;
            attendanceTbupdate.Text = c.Attendance;

        }

        private void updateBt_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(Tbidupdate.Text); ;
            string Stuname = SnameTBupdate.Text.Trim();
            string att = attendanceTbupdate.Text;

            var conn = Database.ConnectDatabase();
            conn.Open();
            string query = string.Format("update StudentDB set StudentName='{0}',Attendance='{1}' where StudentId={2}", Stuname, att, id);
            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                int r = cmd.ExecuteNonQuery();
                if (r > 0)
                {
                    MessageBox.Show(" Updated ");
                }
                else
                {
                    MessageBox.Show(" Update Failed ");
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
