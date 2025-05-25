using quiz.Controllers;
using quiz.Models;
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
    public partial class EditQuestion : UserControl
    {
        private int quizId;
        private List<Questions> questionsList;
        private int currentQuestionIndex = 0;

        public EditQuestion(int quizId)
        {
            InitializeComponent();
            this.quizId = quizId;

            LoadQuestions();
        }
        private void LoadQuestions()
        {
            var controller = new QuestionController();
            questionsList = controller.GetQuestionsByQuizId(quizId);

            if (questionsList != null && questionsList.Count > 0)
            {
                currentQuestionIndex = 0;
                DisplayQuestion(currentQuestionIndex);
                UpdateNavigationButtons();
            }
            else
            {
                MessageBox.Show("No questions found for this quiz.");
            }
        }
        private void UpdateNavigationButtons()
        {
            button1.Enabled = currentQuestionIndex < questionsList.Count - 1;
            button2.Enabled = currentQuestionIndex > 0; 
        }
        private void DisplayQuestion(int index)
        {
            if (index >= 0 && index < questionsList.Count)
            {
                var q = questionsList[index];
                textBoxQuestion.Text = q.QuestionText;
                textBoxOptionA.Text = q.Options[0];
                textBoxOptionB.Text = q.Options[1];
                textBoxOptionC.Text = q.Options[2];
                textBoxOptionD.Text = q.Options[3];
                textBoxCorrect.Text = q.CorrectOption;
                UpdateNavigationButtons();
            }
        }

        private void next_btn(object sender, EventArgs e)
        {
            SaveCurrentEdits();
            if (currentQuestionIndex < questionsList.Count - 1)
            {
                currentQuestionIndex++;
                DisplayQuestion(currentQuestionIndex);
            }
        }

        private void prev_btn(object sender, EventArgs e)
        {
            SaveCurrentEdits();
            if (currentQuestionIndex > 0)
            {
                currentQuestionIndex--;
                DisplayQuestion(currentQuestionIndex);
            }
        }

        private void sub_CLICKED(object sender, EventArgs e)
        {
            SaveCurrentEdits(); 

            var controller = new QuestionController();

            for (int i = 0; i < questionsList.Count; i++)
            {
                controller.UpdateQuestion(quizId, i, questionsList[i]);
            }

            MessageBox.Show("All questions updated successfully!");
            this.Parent.Controls.Remove(this);
        }

        private void SaveCurrentEdits()
        {
            if (currentQuestionIndex >= 0 && currentQuestionIndex < questionsList.Count)
            {
                questionsList[currentQuestionIndex].QuestionText = textBoxQuestion.Text;
                questionsList[currentQuestionIndex].Options = new List<string>
        {
            textBoxOptionA.Text,
            textBoxOptionB.Text,
            textBoxOptionC.Text,
            textBoxOptionD.Text
        };
                questionsList[currentQuestionIndex].CorrectOption = textBoxCorrect.Text;
            }
        }
    }
}
