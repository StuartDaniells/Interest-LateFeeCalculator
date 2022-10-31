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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        // static variables
        public static int totalNumOfGamesReturned = 0;

        // instance variables
        decimal newGamesLateFee = 0m;
        decimal systemsLateFee = 0m;
        decimal libraryLateFee = 0m;

        // Creating new instances of the frmNew, frmSystems and frmLibrary class
        Form NewReleases = new frmNew();
        Form Systems = new frmSystems();
        Form Library = new frmLibrary();
        Form RentalMaintenance = new frmRentalMaintenance();

        public void calulateTotalLateFees()
        {
            newGamesLateFee = Convert.ToDecimal(NewReleases.Tag.ToString());
            systemsLateFee = Convert.ToDecimal(Systems.Tag.ToString());
            libraryLateFee = Convert.ToDecimal(Library.Tag.ToString());

            // total late fee displayed
            lblTotalLateFee.Text = "" + newGamesLateFee + systemsLateFee + libraryLateFee;

            // total number of games returned
            lblTotalGamesReturned.Text = frmLateGames.totalGameCount.ToString();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            // opens up the frmNew instance
            NewReleases.ShowDialog();
            calulateTotalLateFees();
        }

        private void btnLibrary_Click(object sender, EventArgs e)
        {
            // opens up the frmLibrary instance
            Library.ShowDialog();
            calulateTotalLateFees();
        }

        private void btnSystems_Click(object sender, EventArgs e)
        {
            // opens up the frmSystems instance
            Systems.ShowDialog();
            calulateTotalLateFees();
        }

        // on click opens list box for user to add rented game items
        private void btnRentalGameItems_Click(object sender, EventArgs e)
        {
            RentalMaintenance.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // closes the frmMain and exits out
            this.Close();
        }

    }
}
