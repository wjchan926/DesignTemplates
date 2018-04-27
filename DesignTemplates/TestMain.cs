using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvAddIn
{
    class TestMain
    {
        /// <summary>
        /// For testing only
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {
            CWBasketForm cwBasketForm = new CWBasketForm();

            cwBasketForm.ShowDialog();
        }

    }
}
