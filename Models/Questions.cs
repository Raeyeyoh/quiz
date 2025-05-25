using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz.Models
{
    public class Questions
    {
        
            public int Id { get; set; }
        public int QuizId { get; set; }
        public string QuestionText { get; set; }
        public string CorrectOption { get; set; }
        public List<string> Options { get; set; }
        public Quiz Quest { get; set; }
        public string SelectedAnswer { get; set; }

    }
}
