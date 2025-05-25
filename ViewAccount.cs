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
    public partial class ViewAccount : UserControl
    {
        int role;
        public ViewAccount(int role)
        {
            InitializeComponent();
             this.role=role;
        }

        public string UserName
        {
            get => label12.Text;
            set => label12.Text = value;
        }

        public string Password
        {
            get => label13.Text;
            set => label13.Text = value;
        }
        public string email
        {
            get => label2.Text;
            set => label2.Text = value;
        }
        public String newname { get => textBox13.Text;
            set => textBox13.Text = value;
        }
        public String newpass
        {
            get => textBox14.Text;
            set => textBox14.Text = value;
        }
        public String newemail
        {
            get => textBox1.Text;
            set => textBox1.Text = value;
        }

        public bool updateAccounts() { 

        switch (role)
            {
                case 0: AdminController controller = new AdminController();
            controller.UpdateAdmin(UserName, newname,newpass,newemail);
                    break;
                    case 1:quesitonContributor contributor=new quesitonContributor();
                    contributor.UpdateQuestionContributor(UserName, newname,newpass,newemail);  break;
                default:
                    UserController userController = new UserController();
                    userController.UpdateUser(UserName, newname,newpass,newemail);break;
                
            }
            return true;
}
        private void button12_Click(object sender, EventArgs e)
        {
            updateAccounts();



            if (updateAccounts())
            {
                MessageBox.Show("updated succesfully");
            }
            else { 
                MessageBox.Show("noop something went wrong");
            }
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }
    }
}
