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
        public long partNumber;
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

        /// <summary>
        /// Copies the template files to the specified filepath
        /// </summary>
        /// <param name="templatePath">template filepath location</param>
        public void copyTemplateFiles(string templatePath)
        {
            System.IO.Directory.CreateDirectory(location);

            System.IO.File.Copy(templatePath, location);
            System.IO.File.Move(location + "\\" + "Crosswire Basket.iam", location + "\\" + partNumber + ".iam");

            // Make all files read-write
            foreach (string file in System.IO.Directory.GetFiles(location))
            {
                System.IO.FileInfo fileInfo = new System.IO.FileInfo(file);
                fileInfo.IsReadOnly = false;
            }
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
            assemblyUserParam.Value = length;
            assemblyUserParam = assemblyUserParams["width"];
            assemblyUserParam.Value = width;
            assemblyUserParam = assemblyUserParams["height"];
            assemblyUserParam.Value = height;
            assemblyUserParam = assemblyUserParams["frameDia"];
            assemblyUserParam.Value = frameDia;
            assemblyUserParam = assemblyUserParams["cwDia"];
            assemblyUserParam.Value = cwDia;
            assemblyUserParam = assemblyUserParams["cwSpcX"];
            assemblyUserParam.Value = cwSpcX;
            assemblyUserParam = assemblyUserParams["cwSpcZ"];
            assemblyUserParam.Value = cwSpcZ;
            assemblyUserParam = assemblyUserParams["midFrameDia"];
            assemblyUserParam.Value = midFrameDia;
            assemblyUserParam = assemblyUserParams["midFrameNum"];
            assemblyUserParam.Value = midFrameNum;
            #endregion

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
            UpdateIlogic updateIlogic = new UpdateIlogic(invApp);
            updateIlogic.updateParametersRule();
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
    }
}
