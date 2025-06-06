using quiz.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz.Controllers
{
    internal class QuizController
    {

        public int GetCreatorIdByName(string creatorName)
        {
            dbconnection db = new dbconnection();
            SqlConnection con = db.openConnection();
            
                string sql = "SELECT creator_id FROM QuestionCreator WHERE name = @username";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@username", creatorName);

                object result = cmd.ExecuteScalar();
                return Convert.ToInt32(result);
            
        }
        public int CreateQuiz(string Subject, int CreatedBy, int noquestion)
        {
            dbconnection db = new dbconnection();
            SqlConnection con = db.openConnection();

            string sql = @"
        INSERT INTO Quiz (subject, created_by, numberofquestion)
        VALUES (@subject, @createdBy, @noquestion);
        SELECT CAST(SCOPE_IDENTITY() as int);
    ";

            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@subject", Subject);
            cmd.Parameters.AddWithValue("@createdBy", CreatedBy);
            cmd.Parameters.AddWithValue("@noquestion", noquestion);
            

            
            int newQuizId = (int)cmd.ExecuteScalar();

            db.closeConnection();

            return newQuizId;
        }

        public List<Quiz> GetAllQuizzes()
        {
            List<Quiz> quizzes = new List<Quiz>();
            dbconnection db = new dbconnection();
            SqlConnection con = db.openConnection();

            string query = "SELECT quiz_id, subject, numberofquestion FROM Quiz";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                quizzes.Add(new Quiz
                {
                    Id = (int) reader["quiz_id"],
                    Subject = reader["subject"].ToString(),
                    NumberOfQuestions = (int) reader["numberofquestion"],
                    
                }); ;
            }

            reader.Close();
            db.closeConnection();

            return quizzes;
        }
        public DataTable GetQuizzesByCreator(int userId)
        {
            dbconnection db = new dbconnection();
            SqlConnection con = db.openConnection();
            
                string query = @"SELECT quiz_id, subject FROM Quiz WHERE created_by = @userId";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@userId", userId);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            
        }

        public bool DeleteQuizById(int quizId)
        {
            var questionController = new QuestionController();

            
            questionController.DeleteQuestionsByQuizId(quizId);

            dbconnection db = new dbconnection();
            SqlConnection con = db.openConnection();
            
                string sql = "DELETE FROM Quiz WHERE quiz_id = @quizId";
            SqlCommand cmd = new SqlCommand(sql, con);
                
                    cmd.Parameters.AddWithValue("@quizId", quizId);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                
            
        }
    }


}
