using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StuartsLateFeeCalculator
{
    public static class Validator
    {
        private static string title = "Entry Error";

        // accessors - getters and setter for title
        public static string Title { 
            get { return title; } 
            set { title = value; }
        }

        // checking to see if data is entered by user in text boxes
        public static bool IsPresent(TextBox textBox)
        {
            if (textBox.Text == "" )
            {
                MessageBox.Show(textBox.Tag + " is a required field.", Title);
                textBox.Focus();
                return false;
            }
            return true;
        }

        // checking to see if data entered is an integer
        public static bool IsInteger(TextBox textBox)
        {
            int number = 0;
            if(Int32.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(textBox.Tag + " must be a Integer value.", Title);
                textBox.Focus();
                return false;
            }
        }
    }
}
