using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradingLetterMark
{
    public partial class FrmGradingLetterMark : Form
    {
        public FrmGradingLetterMark()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            int grade;
            string mark;

            grade = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Please enter in your mark", "Mark calculator", ""));

            if (grade >= 0 && grade < 50)
            {
                mark = "F";
            }
            else if (grade >=50 && grade < 60)
            {
                mark = "D";
            }
            else if (grade >=60 && grade < 70)
            {
                mark = "C";
            }
            else if (grade >=70 && grade < 80)
            {
                mark = "B";
            }
            else if (grade >= 80 && grade < 100)
            {
                mark = "A";
            }
            else
            {
                mark = "Unable to calculate";
            }

            if (mark == "Unable to calculate")
            {
                MessageBox.Show("Invalid Entry Entered - Cannot calculate grade");
            }
            else
            {
                MessageBox.Show("You have achieved a grade of " + mark);
            }
        }
    }
}
