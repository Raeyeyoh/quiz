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

        private void thequizzes_Load(object sender, EventArgs e)
        {

        }

        private void buttonclicked(object sender, EventArgs e)
        {
            //MessageBox.Show("get ready!"); 

            QuizStarted?.Invoke(this, EventArgs.Empty);

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
