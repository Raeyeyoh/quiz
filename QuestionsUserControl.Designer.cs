namespace quiz
{
    partial class QuestionsUserControl
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
            this.lblQuestionText = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.option1 = new System.Windows.Forms.RadioButton();
            this.option3 = new System.Windows.Forms.RadioButton();
            this.option2 = new System.Windows.Forms.RadioButton();
            this.option4 = new System.Windows.Forms.RadioButton();
            this.lblQuestionNumber = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblQuestionText
            // 
            this.lblQuestionText.AutoSize = true;
            this.lblQuestionText.BackColor = System.Drawing.Color.White;
            this.lblQuestionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionText.Location = new System.Drawing.Point(225, 95);
            this.lblQuestionText.Name = "lblQuestionText";
            this.lblQuestionText.Size = new System.Drawing.Size(201, 20);
            this.lblQuestionText.TabIndex = 0;
            this.lblQuestionText.Text = "the question goes here";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.White;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(434, 353);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(73, 40);
            this.btnNext.TabIndex = 9;
            this.btnNext.Text = "next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.White;
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(113, 353);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(53, 40);
            this.btnPrevious.TabIndex = 10;
            this.btnPrevious.Text = "prev";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.White;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(537, 406);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(93, 27);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // option1
            // 
            this.option1.AutoSize = true;
            this.option1.BackColor = System.Drawing.Color.White;
            this.option1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option1.Location = new System.Drawing.Point(115, 183);
            this.option1.Name = "option1";
            this.option1.Size = new System.Drawing.Size(42, 24);
            this.option1.TabIndex = 12;
            this.option1.TabStop = true;
            this.option1.Text = "A";
            this.option1.UseVisualStyleBackColor = false;
            // 
            // option3
            // 
            this.option3.AutoSize = true;
            this.option3.BackColor = System.Drawing.Color.White;
            this.option3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option3.Location = new System.Drawing.Point(115, 268);
            this.option3.Name = "option3";
            this.option3.Size = new System.Drawing.Size(43, 24);
            this.option3.TabIndex = 13;
            this.option3.TabStop = true;
            this.option3.Text = "C";
            this.option3.UseVisualStyleBackColor = false;
            // 
            // option2
            // 
            this.option2.AutoSize = true;
            this.option2.BackColor = System.Drawing.Color.White;
            this.option2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option2.Location = new System.Drawing.Point(434, 183);
            this.option2.Name = "option2";
            this.option2.Size = new System.Drawing.Size(43, 24);
            this.option2.TabIndex = 14;
            this.option2.TabStop = true;
            this.option2.Text = "B";
            this.option2.UseVisualStyleBackColor = false;
            // 
            // option4
            // 
            this.option4.AutoSize = true;
            this.option4.BackColor = System.Drawing.Color.White;
            this.option4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option4.Location = new System.Drawing.Point(434, 281);
            this.option4.Name = "option4";
            this.option4.Size = new System.Drawing.Size(44, 24);
            this.option4.TabIndex = 15;
            this.option4.TabStop = true;
            this.option4.Text = "D";
            this.option4.UseVisualStyleBackColor = false;
            // 
            // lblQuestionNumber
            // 
            this.lblQuestionNumber.AutoSize = true;
            this.lblQuestionNumber.BackColor = System.Drawing.Color.White;
            this.lblQuestionNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionNumber.Location = new System.Drawing.Point(40, 95);
            this.lblQuestionNumber.Name = "lblQuestionNumber";
            this.lblQuestionNumber.Size = new System.Drawing.Size(54, 20);
            this.lblQuestionNumber.TabIndex = 16;
            this.lblQuestionNumber.Text = "numb";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 36);
            this.button1.TabIndex = 17;
            this.button1.Text = "❎ ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.X_Click);
            // 
            // QuestionsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblQuestionNumber);
            this.Controls.Add(this.option4);
            this.Controls.Add(this.option2);
            this.Controls.Add(this.option3);
            this.Controls.Add(this.option1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblQuestionText);
            this.Name = "QuestionsUserControl";
            this.Size = new System.Drawing.Size(651, 440);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestionText;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.RadioButton option1;
        private System.Windows.Forms.RadioButton option3;
        private System.Windows.Forms.RadioButton option2;
        private System.Windows.Forms.RadioButton option4;
        private System.Windows.Forms.Label lblQuestionNumber;
        private System.Windows.Forms.Button button1;
    }
}
