using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz.Controllers
{
    internal class AdminController
    {
        public bool login(string username, string password)
        {
            dbconnection db = new dbconnection();
            SqlConnection con = db.openConnection();

            string query = "SELECT COUNT(*) FROM Admin WHERE name = @name AND password = @pass";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@name", username);
            cmd.Parameters.AddWithValue("@pass", password);

            int count = (int)cmd.ExecuteScalar();
            db.closeConnection();

            return count > 0;
        }
    }
}
