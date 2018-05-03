using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventor;

namespace InvAddIn
{
    /// <summary>
    /// This struct represents the user parameters needed to generate the part
    /// </summary>
    struct BasketSpecs : IGenerator
    {
        public Application invApp;
        public string partNumber;
        public string location;
        public double length;
        public double width;
        public double height;
        public double frameDia;
        public double cwDia;
        public double cwSpcX;
        public double cwSpcZ;
        public double midFrameDia;
        public double midFrameNum;
        public string material;
        public string finish;
        public string description;     

        /// <summary>
        /// Copies the template files to the specified filepath
        /// </summary>
        /// <param name="templatePath">template filepath location</param>        
        public void copyTemplateFiles(string templatePath)
        {
            // Create if directory if it doesnt exist
            if (!System.IO.Directory.Exists(location))
            {
                System.IO.Directory.CreateDirectory(location);
            }                 

            // Try to copy template files
            try
            {
                // Copy all files in tempalte folder over
                foreach (string file in System.IO.Directory.GetFiles(templatePath))
                {
                    System.IO.File.Copy(file, file.Replace(templatePath, location), true);
                }
                // Rename Assembly to part number
                System.IO.File.Move(location + "\\" + "Crosswire Basket.iam", location + "\\" + partNumber + ".iam");

                // Rename Drawing to part number
                System.IO.File.Move(location + "\\" + "Crosswire Basket.dwg", location + "\\" + partNumber + ".dwg");

                // Make all files read-write
                foreach (string file in System.IO.Directory.GetFiles(location))
                {
                    System.IO.FileInfo fileInfo = new System.IO.FileInfo(file);
                    fileInfo.IsReadOnly = false;
                }
            }
            catch (System.IO.FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
                System.Windows.Forms.MessageBox.Show("Template files not found.\nPlease Get updated template files from the Vault.", 
                    "Templates Not Found");
            } 
                
    
        }

        /// <summary>
        /// Opens the assembly file and turns off workplanes
        /// </summary>
        public void openAssemblyFile()
        {   
            invApp.Documents.Open(location + "\\" + partNumber + ".iam", true);
            workPlanesInvisible();
        }

        /// <summary>
        /// Make the workplanes in the model invisible
        /// </summary>
        private void workPlanesInvisible()
        {
            AssemblyDocument assemblyDoc = (AssemblyDocument)invApp.ActiveDocument;

            DocumentsEnumerator allRefDocs = assemblyDoc.AllReferencedDocuments;

            foreach (Document oDoc in allRefDocs)
            {
                if (oDoc.DocumentType.Equals(DocumentTypeEnum.kPartDocumentObject) ||
                    oDoc.DocumentType.Equals(DocumentTypeEnum.kAssemblyDocumentObject))
                {
                    dynamic oCompDef = ((PartDocument)oDoc).ComponentDefinition;
                    WorkPlanes oDocWorkPlanes = oCompDef.WorkPlanes;

                    foreach (WorkPlane oWp in oDocWorkPlanes)
                    {
                        oWp.Visible = false;
                    }

                    // Release objects
                    oDocWorkPlanes = null;
                    oCompDef = null;
                }

            }

            // Release objects
            allRefDocs = null;
            assemblyDoc = null;
        }

        /// <summary>
        /// Updates the paramters in the assembly.
        /// May need to tie in PushParams and Update iLogic Addins
        /// </summary>
        public void updateAssemblyParams()
        {
            AssemblyDocument assemblyDoc = (AssemblyDocument)invApp.ActiveDocument;
            AssemblyComponentDefinition assemblyDef = assemblyDoc.ComponentDefinition;
            Parameters assemblyParameters = assemblyDef.Parameters;
            UserParameters assemblyUserParams = assemblyParameters.UserParameters;
            UserParameter assemblyUserParam;
            
            #region "User Parameters Update"
            assemblyUserParam = assemblyUserParams["length"];
            assemblyUserParam.Expression = length + " in";
            assemblyUserParam = assemblyUserParams["width"];
            assemblyUserParam.Expression = width + " in";
            assemblyUserParam = assemblyUserParams["height"];
            assemblyUserParam.Expression = height + " in";
            assemblyUserParam = assemblyUserParams["frameDia"];
            assemblyUserParam.Expression = frameDia + " in";
            assemblyUserParam = assemblyUserParams["cwDia"];
            assemblyUserParam.Expression = cwDia + " in";
            assemblyUserParam = assemblyUserParams["cwSpcX"];
            assemblyUserParam.Expression = cwSpcX + " in";
            assemblyUserParam = assemblyUserParams["cwSpcZ"];
            assemblyUserParam.Expression = cwSpcZ + " in";
            assemblyUserParam = assemblyUserParams["midFrameDia"];
            assemblyUserParam.Expression = midFrameDia + " in";
            assemblyUserParam = assemblyUserParams["midFrameNum"];
            assemblyUserParam.Expression = midFrameNum + " ul";
            #endregion

            invApp.ActiveView.Fit();    // Fit part to view

            assemblyDoc.Update2();
            assemblyDoc.Save2();

            // Release objects
            assemblyUserParams = null;
            assemblyParameters = null;
            assemblyDef = null;
            assemblyDoc = null;
        }

        /// <summary>
        /// Update the ilogic Rule
        /// </summary>
        public void updateIlogic()
        {
            UpdateIlogic.updateParametersRule(invApp);
        }

        /// <summary>
        /// Updates the material for all parts
        /// </summary>
        public void updateMaterial()
        {
            AssemblyDocument assemblyDoc = (AssemblyDocument)invApp.ActiveDocument;
            DocumentsEnumerator allRefDocs = assemblyDoc.AllReferencedDocuments;

            // Find all part files and change the material
            foreach(Document oDoc in allRefDocs)
            {
                if (oDoc.DocumentType.Equals(DocumentTypeEnum.kPartDocumentObject))
                {
                    PartDocument partDoc = (PartDocument)oDoc;
                    PartComponentDefinition partDef = partDoc.ComponentDefinition;

                    // Try to set the material
                    try
                    {
                        partDef.Material.Name = material;
                    }
                    catch
                    {

                    }
                    finally
                    {
                        // Release objects
                        partDoc = null;
                        partDef = null;
                    }
                }
            }

            // Release objects
            allRefDocs = null;
            assemblyDoc = null;
        }

        /// <summary>
        /// Updates the finish for all parts
        /// </summary>
        public void updateFinish()
        {
            AssemblyDocument assemblyDoc = (AssemblyDocument)invApp.ActiveDocument;
            DocumentsEnumerator allRefDocs = assemblyDoc.AllReferencedDocuments;

            // Find all part files and change the finish
            foreach (Document oDoc in allRefDocs)
            {
                if (oDoc.DocumentType.Equals(DocumentTypeEnum.kPartDocumentObject))
                {
                    PartDocument partDoc = (PartDocument)oDoc;
                    PropertySet partCustomPropSet = partDoc.PropertySets["Inventor User Defined Properties"];
                    Property partProperty = partCustomPropSet["Finish"];

                    partProperty.Value = finish;

                    // Release Objectsz
                    partDoc = null;
                    partCustomPropSet = null;
                    partProperty = null;
                }      
            }

            // Release objects
            allRefDocs = null;
            assemblyDoc = null;
        }

        /// <summary>
        /// Opens the drawing file
        /// </summary>
        public void openDrawingFile()
        {
            invApp.Documents.Open(location + "\\" + partNumber + ".dwg", true);
            DrawingDocument oDrawing = (DrawingDocument)invApp.ActiveDocument;

            replaceDrawingRef(oDrawing);    // Update drawing references

            PropertySet oDrawingPropSet;
            Property oDrawingProperty;

            // Set Drawing part number
            oDrawingPropSet = oDrawing.PropertySets["Inventor Summary Information"];
            oDrawingProperty = oDrawingPropSet["Title"];
            oDrawingProperty.Value = partNumber;

            // Set Part Number
            oDrawingPropSet = oDrawing.PropertySets["Design Tracking Properties"];
            oDrawingProperty = oDrawingPropSet["Part Number"];
            oDrawingProperty.Value = partNumber;

            // Set Drawing description
            oDrawingProperty = oDrawingPropSet["Description"];
            oDrawingProperty.Value = description;

            // Update Drawing
            oDrawing.Update2();
            oDrawing.Save2();

            // Release Objects
            oDrawingProperty = null;
            oDrawingPropSet = null;
            oDrawing = null;
        }

        /// <summary>
        /// Replace drawing references
        /// </summary>
        /// <param name="drawingDocument">Drawing with dirty references</param>
        public void replaceDrawingRef(DrawingDocument drawingDocument)
        { 
            File drawingFile = drawingDocument.File;
            FileDescriptorsEnumerator fileDescriptors = drawingFile.ReferencedFileDescriptors;

            using (System.IO.StreamWriter refList = System.IO.File.CreateText(@"\\msw-fp1\user$\wchan\Documents\References.txt"))
            {
                foreach (FileDescriptor f in fileDescriptors)
                {
                    refList.WriteLine(f.FullFileName);                    
                }
            }

            Dictionary<string, string> referencedFiles = new Dictionary<string, string>();

            foreach (FileDescriptor f in fileDescriptors){
                int idx = f.FullFileName.LastIndexOf('\\');
                referencedFiles.Add(f.FullFileName.Substring(idx + 1), f.FullFileName.Substring(0, idx));
            }

            fileDescriptors[referencedFiles["Crosswire Basket.iam"] + "\\Crosswire Basket.iam"].ReplaceReference(location + "\\" + partNumber + ".iam");
            fileDescriptors[referencedFiles["Crosswire X.ipt"] + "\\Crosswire X.ipt"].ReplaceReference(location + "\\Crosswire X.ipt");
            fileDescriptors[referencedFiles["Crosswire Z.ipt"] + "\\Crosswire Z.ipt"].ReplaceReference(location + "\\Crosswire Z.ipt");
            fileDescriptors[referencedFiles["Mid Frame.ipt"] + "\\Mid Frame.ipt"].ReplaceReference(location + "\\Mid Frame.ipt");
            fileDescriptors[referencedFiles["Top Frame.ipt"] + "\\Top Frame.ipt"].ReplaceReference(location + "\\Top Frame.ipt");
        }

        /// <summary>
        /// Creates a listof the property set and properties.
        /// For Testing purposes only.
        /// </summary>
        private void getPropertyList()
        {
            invApp.Documents.Open(location + "\\" + partNumber + ".dwg", true);
            DrawingDocument oDrawing = (DrawingDocument)invApp.ActiveDocument;

            using (System.IO.StreamWriter psList = System.IO.File.CreateText(@"\\msw-fp1\user$\wchan\Documents\PropertySetList.txt"))
            {
                foreach (PropertySet ps in oDrawing.PropertySets)
                {
                    foreach (Property p in ps)
                    {
                        psList.WriteLine(ps.Name + ": " + p.Name);
                    }
                }
            }
        }
    }

    /// <summary>
    /// Represents a dictionary where keys are string and case insensitive.
    /// May Need to use this later.
    /// </summary>
    public class CaseInsensitiveDictionary<TValue> : Dictionary<string, TValue>
    {
        public new bool ContainsKey(string key)
        {
            if (base.ContainsKey(key))
                return true;

            return !string.IsNullOrEmpty(GetActualKey(key));
        }

        public new TValue this[string key]
        {
            get
            {
                key = GetActualKey(key);
                return base[key];
            }
            set
            {
                key = GetActualKey(key);
                base[key] = value;
            }
        }

        public new void Add(string key, TValue value)
        {
            key = GetActualKey(key);
            base.Add(key, value);
        }
        /// <summary>
        /// Tries to get the key in other case if present
        /// </summary>
        /// <param name="passedKey"></param>
        /// <returns></returns>
        private string GetActualKey(string passedKey)
        {
            return base.Keys.FirstOrDefault(x => string.Equals(x, passedKey, StringComparison.OrdinalIgnoreCase));
        }
    }
}
