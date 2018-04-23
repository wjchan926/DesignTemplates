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

namespace InvAddIn
{
    public partial class CWBasketForm : Form
    {

        Inventor.Application invApp;
        BasketParameters basketParameters = new BasketParameters();
        string version;

        private CWBasketForm()
        {
        }

        public CWBasketForm(Inventor.Application invApp)
        {
            InitializeComponent();
            this.invApp = invApp;

            // Gets assembly version of the addin
            try
            {
                version = Application.ProductVersion;
            }
            catch (Exception)
            {

            }
            if (version == null)
            {
                this.Text = "Crosswire Basket Designer VDebug";
            }
            else
            {
                this.Text = "Crosswire Basket Designer V" + version;
            }
        }

        private void CWBasketForm_Load(object sender, EventArgs e)
        {
            TopMost = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            // Default start folder
            filepathBrowserDialog.SelectedPath = @"C:\_Vault\Designs\";
            filepathBrowserDialog.ShowDialog();
            filepathTb.Text = filepathBrowserDialog.SelectedPath;
        }

        private void filepathBrowserDialog_HelpRequest(object sender, EventArgs e)
        {

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            if (filepathTb.Text == null || filepathTb.Text == "")
            {
                MessageBox.Show("Please select a FilePath Destination for your Crosswire Basket Assembly.");
            }
            else if (partNumberTb.Text == null || partNumberTb.Text == "")
            {
                MessageBox.Show("Please assign a Part Number for your Crosswire Basket Assembly.");
            }
            else
            {
                // Code for creating parts
            }
        }

        /// <summary>
        /// Copies Template files to specified filepath
        /// </summary>
        private void copyAssemblyParts(string filepath)
        {

        }

        /// <summary>
        /// Updates the paramters in the assembly.
        /// May need to tie in PushParams and Update iLogic Addins
        /// </summary>
        private void updateParams()
        {

        }
    }
}
