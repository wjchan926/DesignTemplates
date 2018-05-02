using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using Inventor;
using System.Collections;

namespace InvAddIn
{
    /// <summary>
    /// Utility class for updating iLogic
    /// </summary>
    static class UpdateIlogic
    {
        // ilogic is a prexisting addin
        private readonly static string iLogicAddinGuid = "{3BDD8D79-2179-4B11-8A5A-257B1C0263AC}";
        
        public static void updateParametersRule(Application currentApp)
        {
            Application invApp = currentApp;
            AssemblyDocument currentAssembly = (AssemblyDocument)invApp.ActiveDocument;
            AssemblyComponentDefinition currentAssemblyCompDef = currentAssembly.ComponentDefinition;
            Parameters currentParameters = currentAssemblyCompDef.Parameters;
            string ruleName = "Dimensions to Parts";

            ApplicationAddIn iLogicAddin = invApp.ApplicationAddIns.ItemById[iLogicAddinGuid];

            if (iLogicAddin != null)
            {
                // Get Key Parameters                           
                UserParameters userParams = currentParameters.UserParameters;
                       
                // Create iLogic code as string
                StringBuilder iLogicCode = new StringBuilder();
                iLogicCode.Append("Dim oDoc As Document\noDoc = ThisDoc.Document\nDim partFile As Document\n");
                iLogicCode.AppendLine("For Each partFile In oDoc.AllReferencedDocuments");
                iLogicCode.AppendLine("Dim fileNameLocation As Long");
                iLogicCode.AppendLine("fileNameLocation = InStrRev(partFile.FullFileName, \"\\\", -1)");
                iLogicCode.Append("Dim oPart As String\noPart = Right(partFile.FullFileName, Len(partFile.FullFileName) - fileNameLocation)\n");
                iLogicCode.Append("Parameter.Quiet = True\nTry\n");

                // Add Parameters to iLogic code
                foreach (UserParameter userParam in userParams)
                {
                    if (userParam.IsKey)
                    {
                        iLogicCode.AppendLine(parameterParser(userParam.Name));
                    }
                }

                iLogicCode.Append("Catch\nEnd Try\nInventorVb.DocumentUpdate()\nNext\n");

                // Enter Addin
                dynamic iLogicAuto = iLogicAddin.Automation;

                //Update Code
                try
                {
                    iLogicAuto.DeleteRule((Document)currentAssembly, ruleName);
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.ToString());
                }
                finally
                {
                    iLogicAuto.AddRule((Document)currentAssembly, ruleName, iLogicCode.ToString());
                }                
                
            }
        }

        private static string parameterParser(string parameter)
        {
            return "Parameter(oPart, \"" + parameter + "\") = " + parameter;
        }
    }
}
