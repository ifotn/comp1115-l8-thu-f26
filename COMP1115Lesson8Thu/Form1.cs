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
        string[,] questions = new string[5, 2];

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
            questions[3, 0] = "What's the capital of Denmark?";
            questions[3, 1] = "Copenhagen";
            questions[4, 0] = "What's 'Mardi Gras' in English?";
            questions[4, 1] = "Fat Tuesday";

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

        /// <summary>
        /// show % of correct answers
        /// </summary>
        /// <param name="correct"># correct answers</param>
        /// <param name="total"># of total questions</param>
        /// <returns>% w/o decimals</returns>
        private int GetPercentScore(int correct, int total)
        {
            if (total == 0)
            {
                return 0;
            }
            return correct * 100 / total;
        }

        /// <summary>
        /// determine letter grade based on % correct
        /// </summary>
        /// <param name="percent">correct %</param>
        /// <returns>letter grade</returns>
        private string GetGrade(int percent)
        {
            if (percent >= 90)
            {
                return "A";
            }
            else if (percent >= 80)
            {
                return "B";
            }
            else if (percent >= 70)
            {
                return "C";
            }
            else if (percent >= 60)
            {
                return "D";
            }
            else 
            {
                return "F";
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                // check for empty or all spaces answer
                if (String.IsNullOrWhiteSpace(txtAnswer.Text))
                {
                    ShowMessage("Please enter an answer", Color.Red);
                    txtAnswer.Focus();
                    return;
                }

                // validate 1st answer as int since 1st answer is numeric
                int answer = int.Parse(txtAnswer.Text);

                if (answer == int.Parse(questions[currentQuestion, 1]))
                {
                    ShowMessage("Correct", Color.Green);
                    correctAnswers++;
                }
                else
                {
                    // user entered a number but not the correct answer
                    ShowMessage("Incorrect", Color.Red);
                }
            }
            catch (FormatException)
            {
                ShowMessage("Enter a whole number", Color.Red);
                txtAnswer.Focus();  // what does Focus() do?
                return; // don't do anything else in this method
            }
            catch (OverflowException)
            {
                ShowMessage("Input too large or too small", Color.Red);
                txtAnswer.Focus();
                return;
            }

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
                FinishQuiz();
            }

            txtAnswer.Text = "";
        }

        /// <summary>
        /// show result and prevent re-submission
        /// </summary>
        private void FinishQuiz()
        {
            // disable Submit button as user has finished
            btnSubmit.Enabled = false;
            //lblQuestion.Text = $"Correct Answers: {correctAnswers}";
            int percent = GetPercentScore(correctAnswers, questions.GetLength(0));
            string letterGrade = GetGrade(percent);
            lblQuestion.Text = $"Score: {correctAnswers}/{questions.GetLength(0)} ({percent})% - Grade: {letterGrade}";
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
