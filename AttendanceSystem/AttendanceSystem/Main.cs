using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace AttendanceSystem
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        List<Student> GetAllclasses()
        {
            var conn = Database.ConnectDatabase();
            List<Student> Students = new List<Student>();
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            string query = "select * from StudentDB";
            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Student c = new Student();
                    c.StudentId = reader.GetInt32(reader.GetOrdinal("StudentId"));
                    c.StudentName = reader.GetString(reader.GetOrdinal("StudentName"));
                    c.Attendance = reader.GetString(reader.GetOrdinal("Attendance"));
                    Students.Add(c);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            return Students;
        }
        private void Main_Load(object sender, EventArgs e)
        {

            var students = GetAllclasses();
            dtClasses.DataSource = students;

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason != CloseReason.WindowsShutDown)
            { Application.Exit(); }
        }


        private void EditclassBt_Click(object sender, EventArgs e)
        {

        }

        private void dtClasses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var students = GetAllclasses();
            dtClasses.DataSource = students;

        }

        private void addstudentBt_Click(object sender, EventArgs e)
        {
            new Addstudent().Show();
        }

        private void EditstudentBt_Click(object sender, EventArgs e)
        {
            new EditStudent().Show();
        }

        private void delstudentBt_Click(object sender, EventArgs e)
        {
            new DeleteStudent().Show();

        }

        private void LogoutBt_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }
    }
}
