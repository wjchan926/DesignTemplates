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
        BasketSpecs basketSpecs;        
        private string generatePath;
        private RadioButton materialRbChecked = null;
        private RadioButton finishRbChecked = null;
        private string cwBasketTemplatePath = @"C:\_Vault\Standards\Inventor\Templates\Crosswire Basket\";
        

        /// <summary>
        /// For testing only.  Class will always need the Invnentor Application object passed to it
        /// </summary>
        private CWBasketForm()
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
            this.CenterToParent();
            this.invApp = invApp;
        }

        /// <summary>
        /// Load method for form.  When the form is loaded, the following is executed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CWBasketForm_Load(object sender, EventArgs e)
        {            
            this.Text = getVersion(); // Gets assembly version of the addin and Puts in title            
     //       TopMost = true; // Always put tool on top          
            resetDefault();   // Set Default Values for text blocks
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
                mapParameters();    // Map Parameters to object

                basketSpecs.copyTemplateFiles(cwBasketTemplatePath);   // Copy files

                invApp.SilentOperation = true;  // Inventor silent operation               

                basketSpecs.openAssemblyFile();     // Open assembly file and turn off workplanes
                basketSpecs.updateAssemblyParams();    // Updated parameters in assembly
                basketSpecs.updateIlogic();    // update ilogic
                basketSpecs.updateMaterial();   // Update Material
                basketSpecs.updateFinish(); // Update Finish
                basketSpecs.openDrawingFile();  // Open Drawing file

                // Close form
                this.DialogResult = DialogResult.OK;
                this.Close();
                this.Dispose();
            }            
        }
        
        /// <summary>
        /// Checks if all the fields in the form are nonempty
        /// </summary>
        /// <returns></returns>
        private bool allFieldsNonEmpty()
        {
            // Check if any of the fields are emtpy.       
            StringBuilder emptyTextBoxes = new StringBuilder();
            ArrayList allControls = new ArrayList();

            allControls.AddRange(ActiveForm.Controls);
            allControls.AddRange(dimsGb.Controls);

            foreach (Control control in allControls)
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
        /// Maps parameters to the basketSpecs object
        /// </summary>
        private void mapParameters()
        {
            basketSpecs = new BasketSpecs();

            // Set path of generation
            generatePath = filepathTb.Text + "\\" + partNumberTb.Text + "\\";

            basketSpecs.invApp = invApp;
            basketSpecs.partNumber = partNumberTb.Text;
            basketSpecs.location = generatePath;
            basketSpecs.length = Double.Parse(lengthTb.Text);
            basketSpecs.width = Double.Parse(widthTb.Text);
            basketSpecs.height = Double.Parse(heightTb.Text);
            basketSpecs.frameDia = Double.Parse(frameDiaTb.Text);
            basketSpecs.cwDia = Double.Parse(cwDiaTb.Text);
            basketSpecs.cwSpcX = Double.Parse(lengthCWSpcTb.Text);
            basketSpecs.cwSpcZ = Double.Parse(widthCWSpcTb.Text);
            basketSpecs.midFrameDia = Double.Parse(midFrameDiaTb.Text);
            basketSpecs.midFrameNum = Double.Parse(midFrameNumTb.Text);
            basketSpecs.material = materialRbChecked.Tag.ToString();
            basketSpecs.finish = finishRbChecked.Text.ToUpper();
            basketSpecs.description = descriptionTb.Text.ToUpper();
        }

        /// <summary>
        /// Resets the form with default values.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resetBtn_Click(object sender, EventArgs e)
        {
            resetDefault();
        }

        private void resetDefault()
        {
            lengthTb.Text = "15";
            widthTb.Text = "10";
            heightTb.Text = "5";
            frameDiaTb.Text = "0.25";
            cwDiaTb.Text = "0.1205";
            midFrameDiaTb.Text = "0.1205";
            lengthCWSpcTb.Text = "1.5";
            widthCWSpcTb.Text = "1.5";
            midFrameNumTb.Text = "2";
            midFrameSpcTb.Text = String.Format("{0:#,0.000}", (Double.Parse(heightTb.Text) - Double.Parse(frameDiaTb.Text)) 
                / (Double.Parse(midFrameNumTb.Text) + 1));
            ss304Rb.Checked = true;
            naturalRb.Checked = true;
            otherFinishTb.Text = "Generic";
            descriptionTb.Text = "";
        }

        private void calcWeigth()
        {
            double weight = 0.0;

            weightLb.Text = String.Format("{0:#,0.000}", weight);
        }

        private void ss304Rb_CheckedChanged(object sender, EventArgs e)
        {
            materialRbChecked = sender as RadioButton;
        }

        private void ss316Rb_CheckedChanged(object sender, EventArgs e)
        {
            materialRbChecked = sender as RadioButton;
        }

        private void psRb_CheckedChanged(object sender, EventArgs e)
        {
            materialRbChecked = sender as RadioButton;
        }

        private void gsRb_CheckedChanged(object sender, EventArgs e)
        {
            materialRbChecked = sender as RadioButton;
        }

        private void otherMatRb_CheckedChanged(object sender, EventArgs e)
        {
            materialRbChecked = sender as RadioButton;
        }

        private void naturalRb_CheckedChanged(object sender, EventArgs e)
        {
            finishRbChecked = sender as RadioButton;
        }

        private void electroRb_CheckedChanged(object sender, EventArgs e)
        {
            finishRbChecked = sender as RadioButton;
        }

        private void powderRb_CheckedChanged(object sender, EventArgs e)
        {
            finishRbChecked = sender as RadioButton;
        }

        private void otherFinishRb_CheckedChanged(object sender, EventArgs e)
        {
            finishRbChecked = sender as RadioButton;
            otherFinishTb.Enabled = otherFinishRb.Checked;
        }

        private void midFrameNumTb_TextChanged(object sender, EventArgs e)
        {
            if (Double.Parse(midFrameNumTb.Text) == 0.0)
            {
                midFrameSpcTb.Text = "0.0";
            }
            else if (!string.IsNullOrWhiteSpace(midFrameNumTb.Text))
            {
                midFrameSpcTb.Text = String.Format("{0:#,0.000}", (Double.Parse(heightTb.Text) - Double.Parse(frameDiaTb.Text))
                    / (Double.Parse(midFrameNumTb.Text) + 1));
            }
        }

        private void heightTb_TextChanged(object sender, EventArgs e)
        {
            //if (Double.Parse(midFrameNumTb.Text) == 0.0)
            //{
            //    midFrameSpcTb.Text = "0.0";
            //}
            //else if (!string.IsNullOrWhiteSpace(heightTb.Text) && !string.IsNullOrWhiteSpace(midFrameNumTb.Text))
            //{
            //    midFrameSpcTb.Text = String.Format("{0:#,0.000}", (Double.Parse(heightTb.Text) - Double.Parse(frameDiaTb.Text))
            //        / (Double.Parse(midFrameNumTb.Text) + 1));
            //}
        }

        
    }
}
