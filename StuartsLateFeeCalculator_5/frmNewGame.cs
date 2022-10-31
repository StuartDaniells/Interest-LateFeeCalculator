using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentalItemMaintenance;

namespace StuartsLateFeeCalculator
{
    public partial class frmNewGame : Form
    {
        public frmNewGame()
        {
            InitializeComponent();
        }

        private RentalItem rentalItem = null;

        //return the rental item data entered
        public RentalItem GetNewRental()
        {
            this.ShowDialog();
            return rentalItem;
        }

        //on click save button event
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                rentalItem = new RentalItem(Convert.ToInt32(txtStockNumber.Text), txtDescription.Text,
                    txtRating.Text);
                this.Close();
            }
        }

        // validating the users input from New Games form
        private bool IsValidData()
        {
            return Validator.IsPresent(txtStockNumber) &&
                   Validator.IsPresent(txtDescription) &&
                   Validator.IsPresent(txtRating) &&
                   Validator.IsInteger(txtStockNumber);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
