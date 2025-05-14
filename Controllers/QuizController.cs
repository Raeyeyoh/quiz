using System;
using System.Collections.Generic;
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
        public bool CreateQuiz(String Subject,int CreatedBy ,int noquestion,int TimeLimit =30 )
        {
            dbconnection db = new dbconnection();
            SqlConnection con = db.openConnection();
            

                string sql = @"
                    INSERT INTO Quiz ( subject,  created_by,numberofquestion ,time_limit)
                    VALUES ( @subject, @createdBy,@noquestion , @timeLimit)";

            SqlCommand command = new SqlCommand(sql, con);
                
                    command.Parameters.AddWithValue("@subject", Subject);
            command.Parameters.AddWithValue("@createdBy", CreatedBy);
            command.Parameters.AddWithValue("@timeLimit", TimeLimit);
            command.Parameters.AddWithValue("@noquestion", noquestion);
            command.Parameters.AddWithValue("@timeLimit", TimeLimit);
            int rowsAffected = command.ExecuteNonQuery();
            return rowsAffected > 0; 
                  
            
        }
    }
}
