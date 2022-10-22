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

        // Creating new instances of the frmNew, frmSystems and frmLibrary class
        frmNew NewReleases = new frmNew();
        frmSystems Systems = new frmSystems();
        frmLibrary Library = new frmLibrary();

        // left empty for now
        private void frmMain_Load(object sender, EventArgs e)
        {

        }
        
        private void btnNew_Click(object sender, EventArgs e)
        {
            // opens up the frmNew instance
            NewReleases.ShowDialog();
        }

        private void btnLibrary_Click(object sender, EventArgs e)
        {
            // opens up the frmLibrary instance
            Library.ShowDialog();
        }

        private void btnSystems_Click(object sender, EventArgs e)
        {
            // opens up the frmSystems instance
            Systems.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
