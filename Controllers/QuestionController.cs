using quiz.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz.Controllers
{
    public class QuestionController
    {
        public bool AddQuestion(string questionText, List<string> options, string correctOption, int quizId)
        {
            

            dbconnection db = new dbconnection();
            SqlConnection con = db.openConnection();

            string sql = @"
            INSERT INTO Questions (content, option_a, option_b, option_c, option_d, correctAnswer, quiz_id)
            VALUES (@questionText, @opt1, @opt2, @opt3, @opt4, @correctOption, @quizId)";

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@questionText", questionText);
            cmd.Parameters.AddWithValue("@opt1", options[0]);
            cmd.Parameters.AddWithValue("@opt2", options[1]);
            cmd.Parameters.AddWithValue("@opt3", options[2]);
            cmd.Parameters.AddWithValue("@opt4", options[3]);
            cmd.Parameters.AddWithValue("@correctOption", correctOption);
            cmd.Parameters.AddWithValue("@quizId", quizId);

            int rows = cmd.ExecuteNonQuery();
            db.closeConnection();

            return rows > 0;
        }


        public List<Questions> GetQuestionsByQuizId(int quizId)
        {
            List<Questions> questions = new List<Questions>();
            dbconnection db = new dbconnection();
            SqlConnection con = db.openConnection();

            string query = @"SELECT *
                                FROM Questions 
                                WHERE quiz_id = @quizId";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@quizId", quizId);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                questions.Add(new Questions
                {
                    Id = Convert.ToInt32(reader["question_Id"]),
                    QuestionText = reader["content"].ToString(),
                    Options = new List<string>
                        {
                            reader["option_a"].ToString(),
                            reader["option_b"].ToString(),
                            reader["option_c"].ToString(),
                            reader["option_d"].ToString()
                        },
                    CorrectOption = reader["correctAnswer"].ToString(),
                    QuizId = quizId
                });
            }
            reader.Close();

            db.closeConnection();

            return questions;

        }
        public bool UpdateQuestion(int quizId, int questionId, Questions updatedQuestion)
        {
            dbconnection db = new dbconnection();

            SqlConnection con = db.openConnection();
            
                string query = @"
            UPDATE Questions 
            SET 
                content = @questionText,
                option_a = @option1,
                option_b = @option2,
                option_c = @option3,
                option_d = @option4,
                correctAnswer = @correctOption
            WHERE question_id = @questionId AND quiz_id = @quizId";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@questionText", updatedQuestion.QuestionText);
                cmd.Parameters.AddWithValue("@option1", updatedQuestion.Options[0]);
                cmd.Parameters.AddWithValue("@option2", updatedQuestion.Options[1]);
                cmd.Parameters.AddWithValue("@option3", updatedQuestion.Options[2]);
                cmd.Parameters.AddWithValue("@option4", updatedQuestion.Options[3]);
                cmd.Parameters.AddWithValue("@correctOption", updatedQuestion.CorrectOption);
                cmd.Parameters.AddWithValue("@questionId", questionId);
                cmd.Parameters.AddWithValue("@quizId", quizId);


                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            
        }

        public bool DeleteQuestionsByQuizId(int quizId)
        {
            dbconnection db = new dbconnection();
            SqlConnection con = db.openConnection();

            string sql = "DELETE FROM Questions WHERE quiz_id = @quizId";
            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@quizId", quizId);
            int rows = cmd.ExecuteNonQuery();
            return rows > 0;



        }
        public int CalculateScore(List<Questions> questions)
        {
            int correctCount = 0;

            foreach (var question in questions)
            {
                if (question.SelectedAnswer == question.CorrectOption)
                {
                    correctCount++;
                }
            }

            return correctCount;
        }

    }
}
