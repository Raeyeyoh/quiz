using quiz.Models;
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
        public Creator login(string name, string password)
        {
            dbconnection db = new dbconnection();
            SqlConnection con = db.openConnection();

            string query = "SELECT  creator_id ,name, email, password,status FROM QuestionCreator WHERE name = @name AND password = @pass";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@pass", password);

            SqlDataReader reader = cmd.ExecuteReader();

            Creator creator = null;
            if (reader.Read())
            {
                creator = new Creator
                { Id =(int) reader["creator_id"],
                    Status = reader["status"].ToString(),
                    Name = reader["name"].ToString(),
                    EMAIL = reader["email"].ToString(),
                    Password = reader["password"].ToString()
                };
            }

            reader.Close();
            db.closeConnection();
            return creator;
        }
        public bool UpdateQuestionContributor(string oldUsername, string newName, string newEmail, string newPassword)
        {
            dbconnection db = new dbconnection();
            SqlConnection con = db.openConnection();

            string query = @"
        UPDATE QuestionCreator
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
        public List<Creator> ViewAllContributors()
        {
            List<Creator> contributors = new List<Creator>();

            string query = "SELECT creator_id, name, status FROM QuestionCreator ";

            dbconnection db = new dbconnection();
            using (SqlConnection con = db.openConnection())
            {
                SqlCommand cmd = new SqlCommand(query, con);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Creator contributor = new Creator
                        {
                            Id = Convert.ToInt32(reader["creator_id"]),
                            Name = reader["name"].ToString(),
                            Status = reader["status"].ToString()
                        };

                        contributors.Add(contributor);
                    }
                }
            }

            return contributors;
        }
        public bool UpdateStatus(int userId, string newStatus)
        {
            string query = "UPDATE QuestionCreator SET status = @status WHERE creator_id = @id";

            using (SqlConnection con = new dbconnection().openConnection())
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@status", newStatus);
                cmd.Parameters.AddWithValue("@id", userId);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

    }
}
