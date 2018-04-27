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
using System.IO;

namespace InvAddIn
{
    public partial class CWBasketForm : Form
    {
        Inventor.Application invApp;
        BasketParameters basketParameters = new BasketParameters();

        private string cwBasketTemplatePath = @"C:\_Vault\Standards\Inventor\Templates\Crosswire Basket\";
        private string generatePath;

        /// <summary>
        /// For testing only.  Class will always need the Invnentor Application object passed to it
        /// </summary>
        public CWBasketForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor for the CWBasket Form.
        /// </summary>
        /// <param name="invApp">Current Inventor Applciation</param>
        public CWBasketForm(Inventor.Application invApp)
        {
            InitializeComponent();
            this.invApp = invApp;
        }

        /// <summary>
        /// Load method for form.  When the form is loaded, the following is executed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CWBasketForm_Load(object sender, EventArgs e)
        {

            // Gets assembly version of the addin and Puts in title
            this.Text = getVersion();

            // Always put tool on top
      //      TopMost = true;

            // Set Default Values for text blocks
            lengthTb.Text = "15";
            widthTb.Text = "10";
            heightTb.Text = "5";
            frameDiaTb.Text = "0.25";
            cwDiaTb.Text = "0.1205";
            midFrameDiaTb.Text = "0.1205";
            lengthCWSpcTb.Text = "1.5";
            widthCWSpcTb.Text = "1.5";
            midFrameSpcTb.Text = "2.5";
        }

        /// <summary>
        /// Gets the assembly version of the Design Template Solution
        /// </summary>
        /// <returns>A title of type string conatining the assembly version</returns>
        private string getVersion()
        {
            string assemblyVersion = null;

            // Gets assembly version of the addin
            try
            {
                assemblyVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
            catch (Exception)
            {

            }
            if (assemblyVersion == null)
            {
                return "Crosswire Basket Designer VDebug";
            }
            else
            {
                return "Crosswire Basket Designer V" + assemblyVersion;
            }
        }

        /// <summary>
        /// Opens a folder browser dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void browseBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog filepathBrowserDialog = new FolderBrowserDialog();

            filepathBrowserDialog.Description = "Select the destination client folder: ";
            filepathBrowserDialog.ShowNewFolderButton = true;
            filepathBrowserDialog.RootFolder = System.Environment.SpecialFolder.Desktop;
            filepathBrowserDialog.SelectedPath = @"C:\_Vault\Designs\";
    
            // Show FolderBrowswerDialog
            DialogResult result = filepathBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                filepathTb.Text = filepathBrowserDialog.SelectedPath;
                // Set path of generation
                generatePath = @"" + filepathBrowserDialog.SelectedPath + "\\" + partNumberTb.Text;
            }

            filepathBrowserDialog.Dispose();
        }

        /// <summary>`
        /// Closes the tool
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
            this.Dispose();
        }

        /// <summary>
        /// Generates the designed product.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void generateBtn_Click(object sender, EventArgs e)
        {
            // Check if any of the fields are emtpy.       
            if (allFieldsNonEmpty())
            {
                copyAssemblyParts(generatePath);
            }            
        }
        
        private bool allFieldsNonEmpty()
        {
            // Check if any of the fields are emtpy.       
            StringBuilder emptyTextBoxes = new StringBuilder();

            foreach (Control control in ActiveForm.Controls)
            {
                if (control is TextBox && string.IsNullOrWhiteSpace(control.Text))
                {
                    emptyTextBoxes.AppendLine(control.Tag.ToString());
                }
            }

            foreach (Control control in dimsGb.Controls)
            {
                if (control is TextBox && string.IsNullOrWhiteSpace(control.Text))
                {
                    emptyTextBoxes.AppendLine(control.Tag.ToString());
                }
            }

            if (!string.IsNullOrWhiteSpace(emptyTextBoxes.ToString()))
            {
                MessageBox.Show("Please fill out the following:\n" + emptyTextBoxes.ToString(), "Parameters Not Filled Out!");
                return false;
            }
            else
            {
                return true;
            }

        }        

        /// <summary>
        /// Copies Template files to specified filepath
        /// </summary>
        private void copyAssemblyParts(string filepath)
        {        
            Directory.CreateDirectory(filepath);

            File.Copy(cwBasketTemplatePath, filepath);
            File.Move(filepath + "\\" + "Crosswire Basket.iam", filepath + "\\" + partNumberTb.Text + ".iam");

            // Make all files read-write
            foreach (string file in Directory.GetFiles(filepath))
            {
                FileInfo fileInfo = new FileInfo(file);
                fileInfo.IsReadOnly = false;                
            }
        }

        /// <summary>
        /// Updates the paramters in the assembly.
        /// May need to tie in PushParams and Update iLogic Addins
        /// </summary>
        private void updateParams()
        {
            
        }

        /// <summary>
        /// Resets the form with default values.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resetBtn_Click(object sender, EventArgs e)
        {
            lengthTb.Text = "15";
            widthTb.Text = "10";
            heightTb.Text = "5";
            frameDiaTb.Text = "0.25";
            cwDiaTb.Text = "0.1205";
            midFrameDiaTb.Text = "0.1205";
            lengthCWSpcTb.Text = "1.5";
            widthCWSpcTb.Text = "1.5";
            midFrameSpcTb.Text = "2.5";
        }
    }
}
