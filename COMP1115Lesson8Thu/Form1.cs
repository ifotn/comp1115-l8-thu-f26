using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace COMP1115Lesson8Thu
{
    public partial class Form1 : Form
    {
        // create array of questions & answers
        string[,] questions = new string[3, 2];

        int currentQuestion = 0;
        int correctAnswers = 0;

        public Form1()
        {
            InitializeComponent();

            // populate question & answer array
            questions[0, 0] = "What is 2+2?";
            questions[0, 1] = "4";
            questions[1, 0] = "What day is our class?";
            questions[1, 1] = "Thursday";
            questions[2, 0] = "What language are we using?";
            questions[2, 1] = "C#";

            // ask 1st question
            lblQuestion.Text = questions[0, 0];
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // does user answer match the answer value for current question
            if (txtAnswer.Text == questions[currentQuestion, 1])
            {
                lblMessage.Text = "Correct";
                lblMessage.ForeColor = Color.Green;

                // add 1 to user's score
                correctAnswers++;
            }
            else
            {
                lblMessage.Text = "Incorrect";
                lblMessage.ForeColor = Color.Red;
            }

            // move to next question
            currentQuestion++;

            // if there are more questions, show next question
            if (currentQuestion < questions.GetLength(0))
            {
                lblQuestion.Text = questions[currentQuestion, 0];
            }
            else
            {
                // disable Submit button as user has finished
                btnSubmit.Enabled = false;
                lblQuestion.Text = $"Correct Answers: {correctAnswers}";
            }
           
            txtAnswer.Text = "";  
        }
    }
}
