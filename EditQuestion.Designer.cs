namespace quiz
{
    partial class EditQuestion
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxQuestion = new System.Windows.Forms.TextBox();
            this.textBoxOptionD = new System.Windows.Forms.TextBox();
            this.textBoxOptionC = new System.Windows.Forms.TextBox();
            this.textBoxOptionB = new System.Windows.Forms.TextBox();
            this.textBoxOptionA = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.submitbtn = new System.Windows.Forms.Button();
            this.textBoxCorrect = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxQuestion
            // 
            this.textBoxQuestion.Location = new System.Drawing.Point(112, 91);
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.Size = new System.Drawing.Size(370, 22);
            this.textBoxQuestion.TabIndex = 13;
            this.textBoxQuestion.Text = "the question";
            // 
            // textBoxOptionD
            // 
            this.textBoxOptionD.Location = new System.Drawing.Point(474, 292);
            this.textBoxOptionD.Name = "textBoxOptionD";
            this.textBoxOptionD.Size = new System.Drawing.Size(80, 22);
            this.textBoxOptionD.TabIndex = 12;
            this.textBoxOptionD.Text = "choice D";
            // 
            // textBoxOptionC
            // 
            this.textBoxOptionC.Location = new System.Drawing.Point(26, 280);
            this.textBoxOptionC.Name = "textBoxOptionC";
            this.textBoxOptionC.Size = new System.Drawing.Size(80, 22);
            this.textBoxOptionC.TabIndex = 11;
            this.textBoxOptionC.Text = "choice C";
            // 
            // textBoxOptionB
            // 
            this.textBoxOptionB.Location = new System.Drawing.Point(474, 187);
            this.textBoxOptionB.Name = "textBoxOptionB";
            this.textBoxOptionB.Size = new System.Drawing.Size(80, 22);
            this.textBoxOptionB.TabIndex = 10;
            this.textBoxOptionB.Text = "choice B";
            // 
            // textBoxOptionA
            // 
            this.textBoxOptionA.Location = new System.Drawing.Point(26, 187);
            this.textBoxOptionA.Name = "textBoxOptionA";
            this.textBoxOptionA.Size = new System.Drawing.Size(80, 22);
            this.textBoxOptionA.TabIndex = 9;
            this.textBoxOptionA.Text = "choice A";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(378, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.next_btn);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(72, 386);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "prev";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.prev_btn);
            // 
            // submitbtn
            // 
            this.submitbtn.Location = new System.Drawing.Point(459, 438);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(75, 23);
            this.submitbtn.TabIndex = 17;
            this.submitbtn.Text = "submit";
            this.submitbtn.UseVisualStyleBackColor = true;
            this.submitbtn.Click += new System.EventHandler(this.sub_CLICKED);
            // 
            // textBoxCorrect
            // 
            this.textBoxCorrect.Location = new System.Drawing.Point(243, 280);
            this.textBoxCorrect.Name = "textBoxCorrect";
            this.textBoxCorrect.Size = new System.Drawing.Size(107, 22);
            this.textBoxCorrect.TabIndex = 18;
            this.textBoxCorrect.Text = "correctchoice";
            // 
            // EditQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxCorrect);
            this.Controls.Add(this.submitbtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxQuestion);
            this.Controls.Add(this.textBoxOptionD);
            this.Controls.Add(this.textBoxOptionC);
            this.Controls.Add(this.textBoxOptionB);
            this.Controls.Add(this.textBoxOptionA);
            this.Name = "EditQuestion";
            this.Size = new System.Drawing.Size(595, 478);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxQuestion;
        private System.Windows.Forms.TextBox textBoxOptionD;
        private System.Windows.Forms.TextBox textBoxOptionC;
        private System.Windows.Forms.TextBox textBoxOptionB;
        private System.Windows.Forms.TextBox textBoxOptionA;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button submitbtn;
        private System.Windows.Forms.TextBox textBoxCorrect;
    }
}
