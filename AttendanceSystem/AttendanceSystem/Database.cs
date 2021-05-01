using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AttendanceSystem
{
    class Database
    {
        public static SqlConnection ConnectDatabase()
        {
            string connString = @"Server=DESKTOP-FE8QDML;Database=Attendance_system;Integrated Security=true;";
            SqlConnection conn = new SqlConnection(connString);
            return conn;
        
        }
    }
}
