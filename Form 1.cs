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
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            login.Visible = true;
            login.BringToFront();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
                
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            allPages.TabPages.Clear();
            
          
                allPages.TabPages.Add(viewAccount);
                allPages.TabPages.Add(quizzes);
                //it saves the users session
                login.Visible = false;

            
             if (comboBox1.SelectedIndex == 0) {
                allPages.TabPages.Add(viewAccount);
                allPages.TabPages.Add(viewAllAccount);
               


                login.Visible = false;
            }
            else if (comboBox1.SelectedIndex == 1) {
                allPages.TabPages.Add(viewAccount);
                allPages.TabPages.Add(addQuiz);


                login.Visible = false;
            }

            }

        private void homepage_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           signup.Visible = true;
            signup.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            login.Visible=true;
            signup.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void viewAllAccount_Click(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
