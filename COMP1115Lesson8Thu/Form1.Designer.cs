namespace COMP1115Lesson8Thu
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblMessage = new Label();
            lblQuestion = new Label();
            txtAnswer = new TextBox();
            btnSubmit = new Button();
            btnRestart = new Button();
            btnTheme = new Button();
            lblTimeLimit = new Label();
            txtTimeLimit = new TextBox();
            btnSetTimeLimit = new Button();
            SuspendLayout();
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(587, 157);
            lblMessage.Margin = new Padding(5, 0, 5, 0);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(287, 32);
            lblMessage.TabIndex = 0;
            lblMessage.Text = "Enter your answer to start";
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Location = new Point(84, 281);
            lblQuestion.Margin = new Padding(5, 0, 5, 0);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(78, 32);
            lblQuestion.TabIndex = 1;
            lblQuestion.Text = "label1";
            // 
            // txtAnswer
            // 
            txtAnswer.Location = new Point(587, 284);
            txtAnswer.Margin = new Padding(5);
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Size = new Size(633, 39);
            txtAnswer.TabIndex = 2;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(585, 369);
            btnSubmit.Margin = new Padding(5);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(153, 45);
            btnSubmit.TabIndex = 3;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnRestart
            // 
            btnRestart.Location = new Point(804, 374);
            btnRestart.Margin = new Padding(5);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(153, 45);
            btnRestart.TabIndex = 4;
            btnRestart.Text = "Restart";
            btnRestart.UseVisualStyleBackColor = true;
            btnRestart.Click += btnRestart_Click;
            // 
            // btnTheme
            // 
            btnTheme.Location = new Point(1019, 374);
            btnTheme.Margin = new Padding(5);
            btnTheme.Name = "btnTheme";
            btnTheme.Size = new Size(203, 45);
            btnTheme.TabIndex = 5;
            btnTheme.Text = "Toggle Theme";
            btnTheme.UseVisualStyleBackColor = true;
            btnTheme.Click += btnTheme_Click;
            // 
            // lblTimeLimit
            // 
            lblTimeLimit.AutoSize = true;
            lblTimeLimit.Location = new Point(86, 65);
            lblTimeLimit.Margin = new Padding(5, 0, 5, 0);
            lblTimeLimit.Name = "lblTimeLimit";
            lblTimeLimit.Size = new Size(126, 32);
            lblTimeLimit.TabIndex = 6;
            lblTimeLimit.Text = "Time Limit";
            // 
            // txtTimeLimit
            // 
            txtTimeLimit.Location = new Point(322, 68);
            txtTimeLimit.Margin = new Padding(5);
            txtTimeLimit.Name = "txtTimeLimit";
            txtTimeLimit.Size = new Size(201, 39);
            txtTimeLimit.TabIndex = 7;
            // 
            // btnSetTimeLimit
            // 
            btnSetTimeLimit.Location = new Point(587, 65);
            btnSetTimeLimit.Margin = new Padding(5);
            btnSetTimeLimit.Name = "btnSetTimeLimit";
            btnSetTimeLimit.Size = new Size(153, 45);
            btnSetTimeLimit.TabIndex = 8;
            btnSetTimeLimit.Text = "Set";
            btnSetTimeLimit.UseVisualStyleBackColor = true;
            btnSetTimeLimit.Click += btnSetTimeLimit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 698);
            Controls.Add(btnSetTimeLimit);
            Controls.Add(txtTimeLimit);
            Controls.Add(lblTimeLimit);
            Controls.Add(btnTheme);
            Controls.Add(btnRestart);
            Controls.Add(btnSubmit);
            Controls.Add(txtAnswer);
            Controls.Add(lblQuestion);
            Controls.Add(lblMessage);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Windows Forms Quiz";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMessage;
        private Label lblQuestion;
        private TextBox txtAnswer;
        private Button btnSubmit;
        private Button btnRestart;
        private Button btnTheme;
        private Label lblTimeLimit;
        private TextBox txtTimeLimit;
        private Button btnSetTimeLimit;
    }
}