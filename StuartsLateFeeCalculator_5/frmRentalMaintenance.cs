using RentalItemMaintenance;
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
    public partial class frmRentalMaintenance : Form
    {
        public frmRentalMaintenance()
        {
            InitializeComponent();
        }

        private List<RentalItem> rentalItems = null;

        private void RentalMaintenance_Load(object sender, EventArgs e)
        {
            rentalItems = RentalItemDB.GetRentalItems();
            FillGamesListBox();
        }

        // fill method to add items from DB to item box
        public void FillGamesListBox()
        {
            lstGameRentals.Items.Clear();
            
            // adding each item to the list box - visual with tab space seperators
            foreach (RentalItem item in rentalItems)
            {
                lstGameRentals.Items.Add(item.GetDisplayText("\t"));
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmNewGame newGameForm = new frmNewGame();
            RentalItem rentalItem = newGameForm.GetNewRental();

            // check if user entered a empty value
            if(rentalItem != null)
            {
                rentalItems.Add(rentalItem);
                RentalItemDB.SaveRentalItems(rentalItems);
                FillGamesListBox();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = lstGameRentals.SelectedIndex;

            // no nonexistant list data index where no data exists
            if(i != -1)
            {
                RentalItem rentalItem = rentalItems[i];
                string message = "Are you sure you'd want to delete " +
                    rentalItem.Description + "?";

                // request confirmation from user - Yes/No
                DialogResult button = MessageBox.Show(message, "Confirm Delete",
                    MessageBoxButtons.YesNo);

                // if user click yes, else leave as is
                if(button == DialogResult.Yes)
                {
                    rentalItems.Remove(rentalItem);
                    RentalItemDB.SaveRentalItems(rentalItems);
                    FillGamesListBox();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
