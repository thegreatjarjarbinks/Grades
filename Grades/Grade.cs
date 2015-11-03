/*
 * Created by: Alex Mathias
 * Created on: 03-Nov-2015
 * Created for: ICS3U
 * Daily Assignment – Unit 4-04
 * This program displays a number grade conversion to percentage
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grades
{
    public partial class frmGrades : Form
    {
        public string PercentageMaker(string letter)
        {
            // Conversion process

            string mark = "Nothing there.";

            if (letter == "4+")
            {
                mark = "Your percentage is: 95%";
            }
            else if(letter == "4")
            {
                mark = ("Your percentage is 90%");
            }
            else if (letter == "4-")
            {
                mark = ("Your percentage is 85%");
            }
            else if (letter == "3+")
            {
                mark = ("Your percentage is 77%");
            }
            else if (letter == "3")
            {
                mark = ("Your percentage is 75%");
            }
            else if (letter == "3-")
            {
                mark = ("Your percentage is 72%");
            }
            else if (letter == "2+")
            {
                mark = ("Your percentage is 67%");
            }
            else if (letter == "2")
            {
                mark = ("Your percentage is 65%");
            }
            else if (letter == "2-")
            {
                mark = ("Your percentage is 62%");
            }
            else if (letter == "1+")
            {
                mark = ("Your percentage is 57%");
            }
            else if (letter == "1")
            {
                mark = ("Your percentage is 55%");
            }
            else if (letter == "1-")
            {
                mark = ("Your percentage is 52%");
            }
            else if (letter == "R")
            {
                mark = ("Your percentage is 30%");
            }
            else if (letter == "NE")
            {
                mark = ("Your percentage is 0%");
            }

            return mark;
        }

        public frmGrades()
        {
            InitializeComponent();
        }

        private void btnGetPercentage_Click(object sender, EventArgs e)
        {
            // Displaying the Percentage

            string mark;

            //Input 
            mark = this.txtNumber.Text;

            // Process & output
            this.lblPercentage.Text = PercentageMaker(mark);
        }
    }
}
