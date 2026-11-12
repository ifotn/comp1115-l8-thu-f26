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
        bool isDark = false;

        public Form1()
        {
            InitializeComponent();
            LoadQuestions();            
        }

        /// <summary>
        /// populate array of questions & answers, show 1st question
        /// </summary>
        private void LoadQuestions()
        {
            questions[0, 0] = "What is 2+2?";
            questions[0, 1] = "4";
            questions[1, 0] = "What day is our class?";
            questions[1, 1] = "Thursday";
            questions[2, 0] = "What language are we using?";
            questions[2, 1] = "C#";

            // show 1st question
            ShowQuestion(0);
        }

        /// <summary>
        /// display question
        /// </summary>
        /// <param name="index">position in array of current question</param>
        private void ShowQuestion(int index)
        {
            lblQuestion.Text = questions[index, 0];
        }

        /// <summary>
        /// show message in response to user answer
        /// </summary>
        /// <param name="text">message to display</param>
        /// <param name="colour">text colour to use</param>
        private void ShowMessage(string text, Color colour)
        {
            lblMessage.Text = text;
            lblMessage.ForeColor = colour;
        } 

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // does user answer match the answer value for current question
            // use ToLower to compare both strings all lowercase
            if (txtAnswer.Text.ToLower() == questions[currentQuestion, 1].ToLower())
            {
                ShowMessage("Correct", Color.Green);
                // add 1 to user's score
                correctAnswers++;
            }
            else
            {
               ShowMessage("Incorrect", Color.Red);
            }

            // move to next question
            currentQuestion++;

            // if there are more questions, show next question
            if (currentQuestion < questions.GetLength(0))
            {
                ShowQuestion(currentQuestion);
            }
            else
            {
                // disable Submit button as user has finished
                btnSubmit.Enabled = false;
                lblQuestion.Text = $"Correct Answers: {correctAnswers}";
            }

            txtAnswer.Text = "";
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            // reset questions to start of array
            currentQuestion = 0;

            // reset score
            correctAnswers = 0;

            // update UI
            ShowMessage("Enter your answer to start", Color.Black);
            ShowQuestion(0);

            btnSubmit.Enabled = true;
        }

        private void btnTheme_Click(object sender, EventArgs e)
        {
            if (isDark == true)
            {
                BackColor = Color.Black;
                lblMessage.ForeColor = Color.White;
                lblQuestion.ForeColor = Color.White;
                txtAnswer.BackColor = Color.DimGray;
                btnSubmit.BackColor = Color.DarkSlateGray;
                btnSubmit.ForeColor = Color.White;
                btnRestart.BackColor = Color.DarkSlateGray;
                btnRestart.ForeColor = Color.White;
                btnTheme.BackColor = Color.DarkSlateGray;
                btnTheme.ForeColor = Color.White;
                isDark = false;
            }
            else
            {
                BackColor = Color.White;
                lblMessage.ForeColor = Color.Black;
                lblQuestion.ForeColor = Color.Black;
                txtAnswer.BackColor = Color.White;
                btnSubmit.BackColor = Color.DimGray;
                btnSubmit.ForeColor = Color.White;
                btnRestart.BackColor = Color.DimGray;
                btnRestart.ForeColor = Color.White;
                btnTheme.BackColor = Color.DimGray;
                btnTheme.ForeColor = Color.White;
                isDark = true;
            }
        }
    }
}
