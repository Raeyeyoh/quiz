using quiz.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz.Controllers
{
    public class UsersQuizStatusController
    {
        public bool SaveOrUpdateStatus(UsersQuizStatus status)
        {
            dbconnection db = new dbconnection();
            using (SqlConnection con = db.openConnection())
            {
                
                string checkSql = "SELECT COUNT(*) FROM UsersQuizStatus WHERE user_id = @userId AND quiz_id = @quizId";
                SqlCommand checkCmd = new SqlCommand(checkSql, con);
                checkCmd.Parameters.AddWithValue("@userId", status.UserId);
                checkCmd.Parameters.AddWithValue("@quizId", status.QuizId);

                bool exists = (int)checkCmd.ExecuteScalar() > 0;

                string sql = exists ?
                    @"UPDATE UsersQuizStatus 
                  SET status = @status, 
                      score = @score, 
                      completion_date = @date
                  WHERE user_id = @userId AND quiz_id = @quizId" :
                    @"INSERT INTO UsersQuizStatus (user_id, quiz_id, status, score, completion_date)
                  VALUES (@userId, @quizId, @status, @score, @date)";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@userId", status.UserId);
                cmd.Parameters.AddWithValue("@quizId", status.QuizId);
                cmd.Parameters.AddWithValue("@status", status.Status);
                cmd.Parameters.AddWithValue("@score", status.Score);
                cmd.Parameters.AddWithValue("@date", status.CompletionDate ?? DateTime.Now);

                int rows = cmd.ExecuteNonQuery();
                return rows > 0;
            }
        }

        public UsersQuizStatus GetUserQuizStatus(int userId, int quizId)
        {
            dbconnection db = new dbconnection();
            using (SqlConnection con = db.openConnection())
            {
                string query = @"SELECT status_id, user_id, quiz_id, status, score 
                        FROM UsersQuizStatus 
                        WHERE user_id = @userId AND quiz_id = @quizId";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.Parameters.AddWithValue("@quizId", quizId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new UsersQuizStatus
                            {
                                StatusId = Convert.ToInt32(reader["status_id"]),
                                UserId = Convert.ToInt32(reader["user_id"]),
                                QuizId = Convert.ToInt32(reader["quiz_id"]),
                                Status = reader["status"].ToString(),
                                Score = Convert.ToInt32(reader["score"])
                            };
                        }
                    }
                }
            }
            return null; 
        }
        public List<(string QuizName, string Status, DateTime? CompletionDate)> GetUserQuizStatusesWithNames(int userId)
        {
            var list = new List<(string, string, DateTime?)>();
            dbconnection db = new dbconnection();

            using (SqlConnection con = db.openConnection())
            {
                string query = @"
            SELECT q.subject, uqs.status, uqs.completion_date 
            FROM UsersQuizStatus uqs
            INNER JOIN Quiz q ON uqs.quiz_id = q.quiz_id
            WHERE uqs.user_id = @userId";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string quizName = reader["subject"].ToString();
                            string status = reader["status"].ToString();
                            DateTime? completionDate = reader["completion_date"] as DateTime?;

                            list.Add((quizName, status, completionDate));
                        }
                    }
                }
            }
            return list;
        }

    }
}
