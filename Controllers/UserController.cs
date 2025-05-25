using quiz.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace quiz.Controllers
{
    internal class UserController
    {
        public bool register(string name, string email, string password)
        {
            dbconnection db = new dbconnection();
            SqlConnection con = db.openConnection();

            string query = "INSERT INTO users (user_name, email, password) VALUES (@name, @mail, @pass)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@mail", email);
            cmd.Parameters.AddWithValue("@pass", password); 

            int result = cmd.ExecuteNonQuery();
            db.closeConnection();
            return result > 0;
        }


        public user login(string name, string password)
        {
            dbconnection db = new dbconnection();
            SqlConnection con = db.openConnection();

            string query = "SELECT user_id, user_name, email, password FROM Users WHERE user_name = @name AND password = @pass";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@pass", password);

            SqlDataReader reader = cmd.ExecuteReader();

            user user1 = null;
            if (reader.Read())
            {
                user1 = new user()
                {
                    Id = (int)reader["user_id"],
                    Name = reader["user_name"].ToString(),
                   email = reader["email"].ToString(),
                    Password = reader["password"].ToString()
                };
            }

            reader.Close();
            db.closeConnection();
            return user1;
        }
        public bool UpdateUser(string oldUsername, string newName, string newEmail, string newPassword)
        {
            dbconnection db = new dbconnection();
            SqlConnection con = db.openConnection();

            string query = @"
        UPDATE Users
        SET user_name = @newName,
            email = @newEmail,
            password = @newPassword
        WHERE user_name = @oldName";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@newName", newName);
            cmd.Parameters.AddWithValue("@newEmail", newEmail);
            cmd.Parameters.AddWithValue("@newPassword", newPassword);
            cmd.Parameters.AddWithValue("@oldName", oldUsername);

            int rowsAffected = cmd.ExecuteNonQuery();

            db.closeConnection();
            return rowsAffected > 0;
        }
    }
}
