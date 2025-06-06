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
            this.nxt = new System.Windows.Forms.Button();
            this.prev = new System.Windows.Forms.Button();
            this.submitbtn = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.answer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxQuestion
            // 
            this.textBoxQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQuestion.Location = new System.Drawing.Point(27, 106);
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.Size = new System.Drawing.Size(728, 27);
            this.textBoxQuestion.TabIndex = 13;
            this.textBoxQuestion.Text = "the question Goes Here";
            // 
            // textBoxOptionD
            // 
            this.textBoxOptionD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOptionD.Location = new System.Drawing.Point(414, 291);
            this.textBoxOptionD.Name = "textBoxOptionD";
            this.textBoxOptionD.Size = new System.Drawing.Size(352, 27);
            this.textBoxOptionD.TabIndex = 12;
            this.textBoxOptionD.Text = "choice D";
            // 
            // textBoxOptionC
            // 
            this.textBoxOptionC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOptionC.Location = new System.Drawing.Point(30, 288);
            this.textBoxOptionC.Name = "textBoxOptionC";
            this.textBoxOptionC.Size = new System.Drawing.Size(339, 27);
            this.textBoxOptionC.TabIndex = 11;
            this.textBoxOptionC.Text = "choice C";
            // 
            // textBoxOptionB
            // 
            this.textBoxOptionB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOptionB.Location = new System.Drawing.Point(414, 202);
            this.textBoxOptionB.Name = "textBoxOptionB";
            this.textBoxOptionB.Size = new System.Drawing.Size(352, 27);
            this.textBoxOptionB.TabIndex = 10;
            this.textBoxOptionB.Text = "choice B";
            // 
            // textBoxOptionA
            // 
            this.textBoxOptionA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOptionA.Location = new System.Drawing.Point(27, 202);
            this.textBoxOptionA.Name = "textBoxOptionA";
            this.textBoxOptionA.Size = new System.Drawing.Size(339, 27);
            this.textBoxOptionA.TabIndex = 9;
            this.textBoxOptionA.Text = "choice A";
            // 
            // nxt
            // 
            this.nxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nxt.Location = new System.Drawing.Point(445, 425);
            this.nxt.Name = "nxt";
            this.nxt.Size = new System.Drawing.Size(89, 31);
            this.nxt.TabIndex = 15;
            this.nxt.Text = "next";
            this.nxt.UseVisualStyleBackColor = true;
            this.nxt.Click += new System.EventHandler(this.next_btn);
            // 
            // prev
            // 
            this.prev.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prev.Location = new System.Drawing.Point(139, 425);
            this.prev.Name = "prev";
            this.prev.Size = new System.Drawing.Size(89, 31);
            this.prev.TabIndex = 16;
            this.prev.Text = "prev";
            this.prev.UseVisualStyleBackColor = true;
            this.prev.Click += new System.EventHandler(this.prev_btn);
            // 
            // submitbtn
            // 
            this.submitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitbtn.Location = new System.Drawing.Point(653, 483);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(89, 36);
            this.submitbtn.TabIndex = 17;
            this.submitbtn.Text = "submit";
            this.submitbtn.UseVisualStyleBackColor = true;
            this.submitbtn.Click += new System.EventHandler(this.sub_CLICKED);
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(13, 13);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(27, 29);
            this.exit.TabIndex = 19;
            this.exit.Text = "❌";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // answer
            // 
            this.answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer.FormattingEnabled = true;
            this.answer.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.answer.Location = new System.Drawing.Point(603, 377);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(126, 26);
            this.answer.TabIndex = 20;
            this.answer.Text = "ANSWER";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(641, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Answer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(387, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(387, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "D";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(8, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(8, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "C";
            // 
            // EditQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.submitbtn);
            this.Controls.Add(this.prev);
            this.Controls.Add(this.nxt);
            this.Controls.Add(this.textBoxQuestion);
            this.Controls.Add(this.textBoxOptionD);
            this.Controls.Add(this.textBoxOptionC);
            this.Controls.Add(this.textBoxOptionB);
            this.Controls.Add(this.textBoxOptionA);
            this.Name = "EditQuestion";
            this.Size = new System.Drawing.Size(791, 547);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxQuestion;
        private System.Windows.Forms.TextBox textBoxOptionD;
        private System.Windows.Forms.TextBox textBoxOptionC;
        private System.Windows.Forms.TextBox textBoxOptionB;
        private System.Windows.Forms.TextBox textBoxOptionA;
        private System.Windows.Forms.Button nxt;
        private System.Windows.Forms.Button prev;
        private System.Windows.Forms.Button submitbtn;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.ComboBox answer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
