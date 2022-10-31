using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StuartsLateFeeCalculator
{
    public partial class frmLibrary : Form
    {
        decimal lateFeeCalculated = 0m;

        public frmLibrary()
        {
            InitializeComponent();

            // populates Todays's date and displays it in the textbox - txtCurrentDate
            txtCurrentDate.Text = DateTime.Now.ToString(@"MM-dd-yyyy");

            // setting the focus at the first item in customer type drop down box
            comboBoxCusType.SelectedIndex = 0;

            // resetting the Tag data to 0m
            this.Tag = 0m;
        }

        // calculate the number of games returned late and display the count in a label
        private void btnAddLateGames_Click(object sender, EventArgs e)
        {
            // clearing old values in text boxes after clicking return button
            lblNumOfLateGames.Text = "";
            txtDaysLate.Clear();
            txtLateFee.Clear();

            // getting number of games from LateGames form
            Form LateGamesForm = new frmLateGames();
            DialogResult selectedButton = LateGamesForm.ShowDialog();

            // checking if user clicked ok button
            if(selectedButton == DialogResult.OK)
                lblNumOfLateGames.Text = LateGamesForm.Tag.ToString();
        }

        private String calculateLateFee(double daysLate, double discount, int numOfGamesReturned)
        {
            // now, calculating the late fee due after discount
            discount = 0.77 * daysLate * numOfGamesReturned * discount;
            double lateFee = (0.77 * daysLate * numOfGamesReturned) - discount;
            lateFee = Math.Round(lateFee, 2);

            // to be added to Tag object to be shared with other forms
            lateFeeCalculated = (Decimal)lateFee;

            return lateFee.ToString("c");
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            // clearing old values in text boxes after clicking return button
            lblNumOfLateGames.Text = "";
            txtDaysLate.Clear();
            txtLateFee.Clear();
            comboBoxCusType.SelectedIndex = -1;

            // adding late fee to the tag to be shared in other forms
            this.Tag = lateFeeCalculated;

            // Hides this form to show the frmMain
            this.Hide();
        }

        // Calculating and returning the customer type discount 
        public double customerTypeDiscount(String customerType)
        {
            switch (customerType)
            {
                case "N":
                    return 0;
                case "J":
                    return 0.07;
                case "L":
                    return 0.12;
                default:
                    return 0;
            }
        }

        // Checking if input values are present
        public bool isPresent(Label labelData, String name)
        {
            if (labelData.Text == "")
            {
                MessageBox.Show(name + " is a required field.", "Entry Error");
                labelData.Focus();
                return false;
            }
            return true;
        }


        // checking if due date is in the past of curent date
        public bool isPast(DateTime dueDate, String name)
        {
            if (dueDate.Date > DateTime.Now.Date)
            {
                MessageBox.Show(name + " must be less than the current date.", "Entry Error");
                return false;
            }
            return true;
        }

        // validation of games returned
        public bool isValidData()
        {
            return (isPresent(lblNumOfLateGames, "Number of games returned") &&
                isPast(DateTime.Parse(dueDatePicker1.Text), "Due Date"));
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // getting number of games from users
                if (this.isValidData())
                {
                    double discount = 0;

                    int numOfGamesReturned = Int32.Parse(lblNumOfLateGames.Text);

                    // capturing the due date from the frmSystems date 
                    DateTime due = DateTime.Parse(dueDatePicker1.Text);

                    // customer type selected from the dropdown list &
                    // selecting first character of items string - N, L, J
                    // setting the discount value based on customer type
                    discount = customerTypeDiscount(comboBoxCusType.Text.Substring(0, 1));

                    // Calculating the number of days between current date and hand in date
                    TimeSpan days = DateTime.Now.Date - due.Date;
                    double daysLate = days.TotalDays;

                    // displaying the calculated num of days as text on the form
                    txtDaysLate.Text = daysLate.ToString();

                    // displaying the late fee in dollars $
                    txtLateFee.Text = calculateLateFee(daysLate, discount, numOfGamesReturned);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" +
                    ex.GetType().ToString() + "\n\n", "Exception error handling");
            }

        }

        private void ClearTextBox(object sender, EventArgs e)
        {
            // clearing old values when new values 
            txtDaysLate.Clear();
            txtLateFee.Clear();
        }

    }
}
