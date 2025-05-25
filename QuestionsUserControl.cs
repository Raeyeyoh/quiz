using quiz.Controllers;
using quiz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace quiz
{
    public partial class QuestionsUserControl : UserControl
    {
       
        public QuestionsUserControl() { }

        private int currentQuestionIndex = 0;
        private List<Questions> questions = new List<Questions>();
        private int quizId;
        private int currentUserId;
        public Action ReturnToQuizSelection { get; set; }

        public int QuestionsCount => questions.Count;
        public int QuizId => quizId;

        public QuestionsUserControl(int userId, Action returnAction)
        {
            InitializeComponent();

            currentUserId = userId;
            ReturnToQuizSelection = returnAction;

            option1.CheckedChanged += Answer_CheckedChanged;
            option2.CheckedChanged += Answer_CheckedChanged;
            option3.CheckedChanged += Answer_CheckedChanged;
            option4.CheckedChanged += Answer_CheckedChanged;
        }

        public void LoadQuestions(int quizId)
        {
            this.quizId = quizId;
            questions = new QuestionController().GetQuestionsByQuizId(quizId);
            var status = new UsersQuizStatus(currentUserId, quizId, "In Progress", 0);
            new UsersQuizStatusController().SaveOrUpdateStatus(status);

            if (questions.Count > 0)
            {
                DisplayQuestion(currentQuestionIndex);
            }
            else
            {
                MessageBox.Show("No questions found for this quiz");
                btnPrevious.Visible = btnNext.Visible = false;
            }
        }
        private Questions _currentQuestion;

       
        private void DisplayQuestion(int index)
        {
            if (index >= 0 && index < questions.Count)
            {
                var question = questions[index];
                _currentQuestion = question;

                lblQuestionText.Text = question.QuestionText;
                option1.Text = question.Options[0];
                option2.Text = question.Options[1];
                option3.Text = question.Options[2];
                option4.Text = question.Options[3];

                
                option1.Checked = option2.Checked = option3.Checked = option4.Checked = false;

                
                if (!string.IsNullOrEmpty(question.SelectedAnswer))
                {
                    if (question.SelectedAnswer == question.Options[0]) option1.Checked = true;
                    else if (question.SelectedAnswer == question.Options[1]) option2.Checked = true;
                    else if (question.SelectedAnswer == question.Options[2]) option3.Checked = true;
                    else if (question.SelectedAnswer == question.Options[3]) option4.Checked = true;
                }

                
                btnPrevious.Enabled = (index > 0);
                btnNext.Enabled = (index < questions.Count - 1);
                btnSubmit.Enabled = (index == questions.Count - 1);

                
                lblQuestionNumber.Text = $"Question {index + 1} of {questions.Count}";
            }
        }

        private void Answer_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton selectedRadio && selectedRadio.Checked)
            {
                questions[currentQuestionIndex].SelectedAnswer = selectedRadio.Text;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentQuestionIndex < questions.Count - 1)
            {
                currentQuestionIndex++;
                DisplayQuestion(currentQuestionIndex);
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentQuestionIndex > 0)
            {
                currentQuestionIndex--;
                DisplayQuestion(currentQuestionIndex);
            }
        }

        public int CalculateScore()
        {
            return questions.Count(q => q.SelectedAnswer == q.CorrectOption);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int score = CalculateScore();
            int totalQuestions = QuestionsCount;

            var quizStatus = new UsersQuizStatus(
                currentUserId,
                quizId,
                "Completed",
                score
            );

            bool saved = new UsersQuizStatusController().SaveOrUpdateStatus(quizStatus);

            if (saved)
            {
                MessageBox.Show($"Quiz completed! Score: {score}/{totalQuestions}");
                ReturnToQuizSelection?.Invoke();
            }
            else
            {
                MessageBox.Show("Error saving your results");
            }
            ReturnToQuizSelection?.Invoke();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit? Your progress will be saved.", "Confirm Exit", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                
                var status = new UsersQuizStatus(currentUserId, quizId, "In Progress", CalculateScore());
                new UsersQuizStatusController().SaveOrUpdateStatus(status);

                
                ReturnToQuizSelection?.Invoke();

                
                this.Dispose();
            }
        }
    }
}