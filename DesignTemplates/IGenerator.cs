using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvAddIn
{
    interface IGenerator
    {       
        /// <summary>
        /// Copies the template files to the specified filepath
        /// </summary>
        /// <param name="templatePath">template filepath location</param>
        void copyTemplateFiles(string templatePath);

        /// <summary>
        /// Updates the paramters in the assembly.
        /// May need to tie in PushParams and Update iLogic Addins
        /// </summary>
        void updateAssemblyParams();

        /// <summary>
        /// Updates the ilogic in the assembly document
        /// </summary>
        void updateIlogic();

        /// <summary>
        /// Updates the material for all parts
        /// </summary>
        void updateMaterial();
    }
}
