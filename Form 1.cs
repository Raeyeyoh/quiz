using Microsoft.Extensions.Options;
using quiz.Controllers;
using quiz.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IdentityModel.Protocols.WSTrust;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace quiz
{
    public partial class Form1 : Form

    {
        private thequizzes quizControl;
        private QuestionsUserControl questionControl;
        TabPage addquiztabpage;
        public Form1()
        {
            InitializeComponent();
            quizControl = new thequizzes();
            dataGridViewContributors.CellContentClick += DataGridViewContributors_CellContentClick;
            LoadContributorsTable();
            addquiztabpage =addQuiz;
            allPages.TabPages.Remove(addquiztabpage);
            LoadQuizzes();

        }
        
       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            login.Visible = true;
            login.BringToFront();
        }

    
             string name ;
            string password;
        String EMAIL;
        int user_id;
        int selectedRole;
        String status;
        private void login_btn(object sender, EventArgs e)
        {
            name=namee.Text;
            password = pass.Text;
             selectedRole = comboBox1.SelectedIndex; 

            allPages.TabPages.Clear();

           
            if (selectedRole == 0)
            {
                AdminController adminc = new AdminController();
                Admin admin = adminc.login(name, password);
                

                if (admin!=null)
                {
                    
                     name = admin.Name;
                     password = admin.Password;
                     EMAIL = admin.Email;
                    allPages.TabPages.Add(viewAllAccount);
                    login.Visible = false;
                   
                }
                else
                {
                    MessageBox.Show("Incorrect username or password");
                }
            }

            else if (selectedRole == 1)
            {
               
                quesitonContributor creator = new quesitonContributor();
                Creator creator1 = creator.login(name, password);
                if (creator1!=null)
                {   user_id = creator1.Id;
                    status=creator1.Status;
                    name = creator1.Name;
                    password = creator1.Password;
                    EMAIL = creator1.EMAIL;
                    allPages.TabPages.Add(viewQuiz);
                    login.Visible = false;
                    LoadCreatorQuizzes(user_id);
                }
                    
              
                else
                {
                    MessageBox.Show("Incorrect username or password");
                }
            }

            
            else
            {
                UserController User = new UserController();
                user users=User.login(name, password);

                if (users!=null)
                {
                    user_id = users.Id;
                    name = users.Name;
                    password = users.Password;
                    EMAIL = users.email;
                    allPages.TabPages.Add(quizzes);
                    allPages.TabPages.Add(tabPage1);
                    LoadUserQuizStatuses(user_id);
                    login.Visible = false;
                }
                else
                {
                    MessageBox.Show("Incorrect username or password");
                }
            }
        }




        private void signupcomboboxclicked(object sender, EventArgs e)
        {
            
           signup.Visible = true;
            signup.BringToFront();
        }

        private void signup_Click(object sender, EventArgs e)
        {
            string name = textBox8.Text;
            string email = textBox9.Text;
            string password = textBox10.Text;

            bool success = false;

            if (comboBox2.SelectedIndex == 1) 
            {
                UserController userController = new UserController();
                success = userController.register(name, email, password);
            }
            else if (comboBox2.SelectedIndex == 0) 
            {
                quesitonContributor creatorController = new quesitonContributor();
                success = creatorController.register(name, email, password);
                LoadContributorsTable();
            }
           

            if (success)
            {
                MessageBox.Show("Registration successful!");
                login.Visible = true;
                signup.Visible = false;
            }
            else
            {
                MessageBox.Show("Registration failed. Try again.");
            }
        }


       

        private void Form1_Load(object sender, EventArgs e)
        {
            var seeder = new AdminSeeder();
            seeder.SeedSuperAdmin();
        }

    

        private void logout_Click(object sender, EventArgs e)
        {
            login.Visible=true;
            login.BringToFront();
            namee.Text=null;
            pass.Text=null;
        }
       
        private void LoadQuizzes()
        {
          
                quizFlowPanel.Controls.Clear();

                var quizzes = new QuizController().GetAllQuizzes();
 
                foreach (var quiz in quizzes)
                {
                    var quizControl = new thequizzes();

                    
                    quizControl.QuizId = quiz.Id;
               

                 quizControl.SetQuizData(quiz.Subject, quiz.NumberOfQuestions);

                    
                    quizControl.QuizStarted += QuizControl_QuizStarted;

                    
                    quizFlowPanel.Controls.Add(quizControl);

                    
                }

                
                quizFlowPanel.Visible = true;
                quizFlowPanel.PerformLayout();
                quizFlowPanel.Refresh();
            }

        private void QuizControl_QuizStarted(object sender, EventArgs e)
        {
            var quizControl = (thequizzes)sender;
            int quizId = quizControl.QuizId;

           
            allPages.Visible = false;

            
            questionControl = new QuestionsUserControl(user_id, returnAction: () =>
            {
                
                allPages.Visible = true;
                questionControl.Visible = false;
            });
            questionControl.Dock = DockStyle.Fill;

   

            questionControl.LoadQuestions(quizId);

            this.Controls.Add(questionControl);
            questionControl.Visible = true;
            questionControl.BringToFront();
            allPages.Visible = false;
        }
         
         
        private void button14_Click(object sender, EventArgs e)
        {

            if (status != "Approved") {
                MessageBox.Show("can not add questions,your account isnt not approved account contact us");
            }
            else {
            if (!allPages.TabPages.Contains(addquiztabpage))
            {
                allPages.TabPages.Add(addquiztabpage);
            }

            allPages.SelectedTab = addquiztabpage;
                }
        }

       
     
     

        

       
 

        private void ViewAccount(object sender, EventArgs e)
        {
            
            ViewAccount view=new ViewAccount( selectedRole);
            view.UserName = name;
            view.Password = password;
            view.email = EMAIL;
            this.Controls.Add(view);
            view.Dock = DockStyle.Fill;
            view.BringToFront();
        }

        private void submitQuizInfo(object sender, EventArgs e)
        {
                 panel1.Visible = false;
            
        }


        string sub;
        int totalQuestions;
        
        private void addbtn_Click(object sender, EventArgs e)
        {
            sub = textBox6.Text;
            totalQuestions = Convert.ToInt32(textBox7.Text);
             

            string questionText = textBox19.Text;
            List<string> options = new List<string>
    {
        textBox15.Text,
        textBox16.Text,
        textBox17.Text,
        textBox18.Text
    };
            string correctOption = textBox13.Text;

            Questions question = new Questions
            {
                QuestionText = questionText,
                Options = options,
                CorrectOption = correctOption
            };

            questionsList.Add(question);

            ClearInputFields();
            

            if (questionsList.Count == totalQuestions)
            {
                addbtn.Enabled = false;
                subbtn.Enabled = true;
            }
            
        }



        private List<Questions> questionsList = new List<Questions>();
        private int currentQuestionIndex = 0;
       
        private int createdQuizId;


        private void subtn_Click(object sender, EventArgs e)
        {
            QuizController quizController = new QuizController();
            int creatorId = quizController.GetCreatorIdByName(name);

            int quizId = quizController.CreateQuiz(sub, creatorId, totalQuestions);

            QuestionController qc = new QuestionController();
            foreach (var q in questionsList)
            {
                qc.AddQuestion(q.QuestionText, q.Options, q.CorrectOption, quizId);
                currentQuestionIndex ++;
            }

            MessageBox.Show("Quiz and questions created successfully!");
            subbtn.Enabled = false;
            questionsList.Clear();
            allPages.TabPages.Remove(addquiztabpage);
            allPages.SelectedTab = viewQuiz;
            LoadCreatorQuizzes(user_id);
        }    
            private void ClearInputFields()
        {
          textBox15.Clear();
        textBox16.Clear();
        textBox17.Clear();
        textBox18.Clear();
         textBox13.Clear();
            textBox19.Clear();
       }
       

       

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewQuizzes.Columns[e.ColumnIndex].Name == "edit")
            {
                int quizId = Convert.ToInt32(dataGridViewQuizzes.Rows[e.RowIndex].Cells["quiz_id"].Value);
                 EditQuestion editQuestion = new EditQuestion(quizId);
                editQuestion.Dock = DockStyle.Fill;
                this.Controls.Add(editQuestion);
                editQuestion.BringToFront();
            }
                
           
            else if (dataGridViewQuizzes.Columns[e.ColumnIndex].Name == "delete")
            {
                int quizId = Convert.ToInt32(dataGridViewQuizzes.Rows[e.RowIndex].Cells["quiz_id"].Value);

                var confirm = MessageBox.Show("Are you sure you want to delete this quiz and all its questions?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    var controller = new QuizController();
                    bool deleted = controller.DeleteQuizById(quizId);

                    if (deleted)
                    {
                        MessageBox.Show("Quiz and its questions deleted successfully.");
                        dataGridViewQuizzes.Rows.RemoveAt(e.RowIndex);
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete quiz.");
                    }
                }
            }

        }
        public void LoadCreatorQuizzes(int creatorId)
        {
            dataGridViewQuizzes.AutoGenerateColumns = false;

            DataTable quizzesTable = new QuizController().GetQuizzesByCreator(creatorId);

            dataGridViewQuizzes.DataSource = quizzesTable;
        }


        public void LoadContributorsTable()
        {
            dataGridViewContributors.Rows.Clear();

            var contributors = new quesitonContributor().ViewAllContributors();
            foreach (var contributor in contributors)
            {
                int rowIndex = dataGridViewContributors.Rows.Add(
                    contributor.Id,
                    contributor.Name,
                    contributor.Status
                );

                var actionCell = dataGridViewContributors.Rows[rowIndex].Cells["apprDis"];

                string buttonText = contributor.Status == "Approved" ? "Disapprove" : "Approve";
                actionCell.Value = buttonText;
            }
        }




        private void DataGridViewContributors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridViewContributors.Columns[e.ColumnIndex].Name == "apprDis")
            {
                int userId = Convert.ToInt32(dataGridViewContributors.Rows[e.RowIndex].Cells["creator_id"].Value);
                string currentStatus = dataGridViewContributors.Rows[e.RowIndex].Cells["Status1"].Value.ToString();

                
                string newStatus = currentStatus == "Approved" ? "Disapproved" : "Approved";

                bool updated = new quesitonContributor().UpdateStatus(userId, newStatus);

                if (updated)
                {
                    MessageBox.Show($"account status changed to: {newStatus}");
                    LoadContributorsTable();
                }
                else
                {
                    MessageBox.Show("Failed to update status");
                }
            }
        }

        
            

        
        private void LoadUserQuizStatuses(int userId)
        {
            var controller = new UsersQuizStatusController();
            var statuses = controller.GetUserQuizStatusesWithNames(userId);

            listBoxQuizStatus.Items.Clear();

            foreach (var entry in statuses)
            {
                string completion = entry.CompletionDate != null? entry.CompletionDate.Value.ToString("yyyy-MM-dd")
                     : "Not completed";
                   
                string displayText = $"{entry.QuizName} / {entry.Status} / {completion}";
                listBoxQuizStatus.Items.Add(displayText);
            }
        }

    }

}