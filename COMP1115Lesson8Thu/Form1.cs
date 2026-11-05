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
        public Form1()
        {
            InitializeComponent();

            // ask 1st question
            lblQuestion.Text = "True or False?";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtAnswer.Text == "False")
            {
                lblMessage.Text = "Correct";
                lblMessage.ForeColor = Color.Green;
            }
            else
            {
                lblMessage.Text = "Incorrect";
                lblMessage.ForeColor = Color.Red;
            }
        }
    }
}
