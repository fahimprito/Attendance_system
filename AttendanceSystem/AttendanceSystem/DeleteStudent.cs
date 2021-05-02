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
    public partial class DeleteStudent : Form
    {
        public DeleteStudent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var conn = Database.ConnectDatabase();
            conn.Open();
            int id = Int32.Parse(Tbiddel.Text);
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
            SnameTBdel.Text = c.StudentName;
            attendanceTbdel.Text = c.Attendance;
        }

        private void deleteBt_Click(object sender, EventArgs e)
        {
            var conn = Database.ConnectDatabase();
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            int id = Int32.Parse(Tbiddel.Text); ;
            string query = "delete from StudentDB where StudentId = " + id;
           
            
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Student c = new Student();

            while (reader.Read())
            {
                c.StudentId = reader.GetInt32(reader.GetOrdinal("StudentId"));

            }
            conn.Close();
            MessageBox.Show("Deleted");
        }
    }
}
