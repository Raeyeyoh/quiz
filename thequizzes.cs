using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz
{
    public partial class thequizzes : UserControl
    {
        public event EventHandler QuizStarted;

        public thequizzes()
        {
            InitializeComponent();
        }

        public int QuizId { get; set; }

       

        public void SetQuizData(string subject, int totalQuestions)
        {
            label1.Text = subject;
            label2.Text = $"Questions: {totalQuestions}";
            
        }

        private void buttonclicked(object sender, EventArgs e)
        {
            MessageBox.Show("get ready!"); 

            QuizStarted?.Invoke(this, EventArgs.Empty);

        }

      
    }
}
