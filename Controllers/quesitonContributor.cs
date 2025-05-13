using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz.Controllers
{
    internal class quesitonContributor
    {
        public bool register(string name, string email, string password)
        {
            dbconnection db = new dbconnection();
            SqlConnection con = db.openConnection();

            string query = "INSERT INTO QuestionCreator (name, email, password) VALUES (@name, @mail, @pass)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@mail", email);
            cmd.Parameters.AddWithValue("@pass", password);

            int result = cmd.ExecuteNonQuery();
            db.closeConnection();

            return result > 0;
        }
        public bool login(string email, string password)
        {
            dbconnection db = new dbconnection();
            SqlConnection con = db.openConnection();

            string query = "SELECT COUNT(*) FROM QuestionCreator WHERE email = @mail AND password = @pass";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@mail", email);
            cmd.Parameters.AddWithValue("@pass", password);

            int count = (int)cmd.ExecuteScalar();
            db.closeConnection();

            return count > 0;
        }
    }
}
