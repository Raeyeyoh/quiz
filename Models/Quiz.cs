using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz.Models
{
    public class Quiz
    {
       
        
            
            public string Subject { get; set; }
          
            public int NumberOfQuestions { get; set; }
        
            public int Id { get; set; }
            public string Title { get; set; }
            public Creator Creator { get; set; }
            public List<Questions> Questions { get; set; }
        

    }
}
