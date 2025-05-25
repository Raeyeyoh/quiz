using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz.Models
{
    public class UsersQuizStatus
    {
        public int StatusId { get; set; }
        public int UserId { get; set; }
        public int QuizId { get; set; }
        public string Status { get; set; } 
        public int Score { get; set; }
        public DateTime? CompletionDate { get; set; }

        public UsersQuizStatus() { }

        public UsersQuizStatus(int userId, int quizId, string status, int score)
        {
            UserId = userId;
            QuizId = quizId;
            Status = status;
            Score = score;
            CompletionDate = DateTime.Now;
        }
    }
}
