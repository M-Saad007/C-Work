using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grade_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int totmarks = int.Parse(textBox1.Text);
            int obtmarks = int.Parse(textBox2.Text);

            // Ensure to use float for proper division
            float percentage = ((float)obtmarks / totmarks) * 100;

            string grade;
            if (percentage >= 90)
            {
                grade = "A+";
            }
            else if (percentage >= 80)
            {
                grade = "A";
            }
            else if (percentage >= 70)
            {
                grade = "B";
            }
            else if (percentage >= 60)
            {
                grade = "C";
            }
            else if (percentage >= 50)
            {
                grade = "D";
            }
            else if (percentage >= 40)
            {
                grade = "Pass";
            }
            else
            {
                grade = "F";
            }

            MessageBox.Show($"Your Percentage {percentage} & Grade is {grade}" );
        }
    }
}
