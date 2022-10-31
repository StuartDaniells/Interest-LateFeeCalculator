using System;
using System.Collections;
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
    public partial class frmLateGames : Form
    {
        public frmLateGames()
        {
            InitializeComponent();
        }

        // static variables
        // initilizing total game count & declaring sorted games list variables
        public static int totalGameCount = 0;

        // instance variables
        int currentFormGameCount = 1;
        SortedList<int, string> sortedGamesList = new SortedList<int, string> ();


        // Checking if input value is present
        public bool isPresent(TextBox textBox, String name)
        {
            if (textBox.Text == "" || textBox.Text == " ")
            {
                MessageBox.Show(name + " is a required field.", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        // validation of games returned
        public bool isValidData()
        {
            return isPresent(txtLateGameReturned, "The games returned");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // getting the games from the user
                if (this.isValidData())
                {
                    sortedGamesList.Add(currentFormGameCount, txtLateGameReturned.Text);
                    lstLateGamesReturned.Text += (currentFormGameCount) + ". " + 
                                                 txtLateGameReturned.Text + "\n";
                    currentFormGameCount++;
                    totalGameCount++;

                }

                // clearing games returned text box
                txtLateGameReturned.Text = "";

                //moving focus of cursor back to text box
                txtLateGameReturned.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" +
                    ex.GetType().ToString() + "\n\n" +
                    ex.StackTrace, "Exception error handling");
            }
        }

        /* this method may seem unnecessary since in my version of Assignment 4, I don't need to
           loop over each item in a sorted list and calculate game count for each form
        -> but have anyhow added it in since the rubrics require its creation */

        /* could also get count with .count property on sortedGamesList, but am choosing
           the long way here */

        // here the returned 'gameCount' is equal to 'currentFormGameCount' in the instance variable
        private int calculateGameCount()
        {
            int gameCount = 0;
            foreach (KeyValuePair<int, string> lateGameCount in sortedGamesList)
                gameCount = lateGameCount.Key;

            return gameCount;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            currentFormGameCount = calculateGameCount();

            // passing the number of games returned to the other forms via the Tag
            this.Tag = currentFormGameCount;
            this.DialogResult = DialogResult.OK; 
        }

        private void clearingEnteredData()
        {
            lstLateGamesReturned.Text = "";
            currentFormGameCount = 1;
            totalGameCount = totalGameCount - currentFormGameCount;
            sortedGamesList.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            string message = "Would you like to clear your entered games list and start again?";

            DialogResult buttonChoice = MessageBox.Show(message, "Unsaved data",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            // responding to choice made in dialog box
            if (buttonChoice == DialogResult.Yes)
            {
                clearingEnteredData();

                //moving focus of cursor back to text box
                txtLateGameReturned.Focus();
            }
            else
                this.Close();
        }
    }
}
