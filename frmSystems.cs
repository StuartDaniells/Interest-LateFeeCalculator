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
    public partial class frmSystems : Form
    {
        public frmSystems()
        {
            InitializeComponent();

            // populates Todays's date and displays it in the textbox - txtCurrentDate
            txtCurrentDate.Text = DateTime.Now.ToString(@"MM-dd-yyyy");
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            // Hides this form to show the frmMain
            this.Hide();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // generating the current date
            DateTime dCurrent = DateTime.Now;

            // capturing the due date from the frmSystems Due date textbox
            DateTime due = DateTime.Parse(txtDueDate.Text);

            // Calculating the number of days between the dates
            TimeSpan days = (dCurrent.Date - due.Date);
            double numberOfDays = days.TotalDays;

            // displaying the calculated num of days as text on the form
            txtDaysLate.Text = numberOfDays.ToString();

            // now, calculating the late fee due
            double lateFee = 5 * numberOfDays;

            // displaying the late fee in dollars $
            txtLateFee.Text = lateFee.ToString("c");
        }
    }
}
