using quiz.Controllers;
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
    public partial class Form1 : Form

    {
        private thequizzes quizControl;
        private Questions questionControl;

        public Form1()
        {
            InitializeComponent();
            quizControl = new thequizzes();
            questionControl = new Questions();

            quizControl.QuizStarted += QuizControl_QuizStarted;

        }

       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            login.Visible = true;
            login.BringToFront();
        }

    
             string name ;
            string password;

        private void button2_Click(object sender, EventArgs e)
        {
            name=namee.Text;
            password = pass.Text;
            int selectedRole = comboBox1.SelectedIndex; 

            allPages.TabPages.Clear();

           
            if (selectedRole == 0)
            {
                AdminController admin = new AdminController();
                if (admin.login(name, password))
                {
                    allPages.TabPages.Add(viewAccount);
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
                if (creator.login(name, password))
                {
                    allPages.TabPages.Add(viewAccount);
                    allPages.TabPages.Add(addQuiz);
                    login.Visible = false;
                }
                else
                {
                    MessageBox.Show("Incorrect username or password");
                }
            }

            
            else
            {
                UserController user = new UserController();
                if (user.login(name, password))
                {
                    allPages.TabPages.Add(viewAccount);
                    allPages.TabPages.Add(quizzes);
                    login.Visible = false;
                }
                else
                {
                    MessageBox.Show("Incorrect username or password");
                }
            }
        }




        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
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
            }
           

            if (success)
            {
                MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                login.Visible = true;
                signup.Visible = false;
            }
            else
            {
                MessageBox.Show("Registration failed. Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
       

      
        public void show_quiz(object sender, EventArgs e)
        {
            if (allPages.SelectedTab == quizzes)
            {
                quizzes.Controls.Add(quizControl);
                
            }
        }
        
        private void QuizControl_QuizStarted(object sender, EventArgs e)
        {
            
            allPages.Visible = false;

         
            questionControl.Dock = DockStyle.Fill;
            this.Controls.Add(questionControl);
            questionControl.Visible=true;
            questionControl.BringToFront();
        }

        private void button13_Click(object sender, EventArgs e)
        {
             string sub= textBox6.Text;
            int numberofquestions = Convert.ToInt32(textBox7.Text);
           int timelim = Convert.ToInt32(textBox20.Text);
            QuizController quizController = new QuizController();
            int creatorId = quizController.GetCreatorIdByName(name);

            quizController.CreateQuiz(sub, creatorId, numberofquestions, timelim);
            panel1.Visible=false;
            //we will insert and create  the quiz with the creators  name  and the sub and no question then git its id from db then


        }

        private void button7_Click(object sender, EventArgs e)
        {
            //we will insert then clear the textboxes for the next question button is disabled until they are approved by admin
        }
    }
}
