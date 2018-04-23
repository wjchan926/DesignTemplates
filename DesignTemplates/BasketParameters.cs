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
    struct BasketParameters
    {
        public Application invApp;
        public double length;
        public double width;
        public double height;
        public double frameDia;
        public double cwDia;
        public double cwSpcX;
        public double cwSpcZ;
        public double xTaper;
        public double zTaper;
        public double midFrameDia;
        public double midFrameNum;       
    }
}
