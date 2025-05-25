using quiz.Models;
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
        public Admin login(string username, string password)
        {
            dbconnection db = new dbconnection();
            SqlConnection con = db.openConnection();

            string query = "SELECT  name,email, password FROM Admin WHERE name = @name AND password = @pass";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@name", username);
            cmd.Parameters.AddWithValue("@pass", password);
            

            SqlDataReader reader = cmd.ExecuteReader();

            Admin admin = null;
            if (reader.Read())
            {
                admin = new Admin
                {
                    Email = reader["email"].ToString(),
                    Name = reader["name"].ToString(),
                    Password = reader["password"].ToString()
                };
            }

            reader.Close();
            db.closeConnection();
            return admin;
        }
        public bool UpdateAdmin(string oldUsername, string newName, string newEmail, string newPassword)
        {
            dbconnection db = new dbconnection();
            SqlConnection con = db.openConnection();

            string query = @"
        UPDATE Admin
        SET name = @newName,
            email = @newEmail,
            password = @newPassword
        WHERE name = @oldName";

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
