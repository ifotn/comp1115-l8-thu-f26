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
            SuspendLayout();
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(361, 101);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(177, 20);
            lblMessage.TabIndex = 0;
            lblMessage.Text = "Enter your answer to start";
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Location = new Point(52, 181);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(50, 20);
            lblQuestion.TabIndex = 1;
            lblQuestion.Text = "label1";
            // 
            // txtAnswer
            // 
            txtAnswer.Location = new Point(361, 183);
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Size = new Size(391, 27);
            txtAnswer.TabIndex = 2;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(360, 238);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 3;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnRestart
            // 
            btnRestart.Location = new Point(495, 241);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(94, 29);
            btnRestart.TabIndex = 4;
            btnRestart.Text = "Restart";
            btnRestart.UseVisualStyleBackColor = true;
            btnRestart.Click += btnRestart_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRestart);
            Controls.Add(btnSubmit);
            Controls.Add(txtAnswer);
            Controls.Add(lblQuestion);
            Controls.Add(lblMessage);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMessage;
        private Label lblQuestion;
        private TextBox txtAnswer;
        private Button btnSubmit;
        private Button btnRestart;
    }
}