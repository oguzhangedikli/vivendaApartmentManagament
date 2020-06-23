using quennta.vivendaApartmentManagament.UI.Win.Forms.baseForms;
using quennta.vivendaApartmentManagament.UI.Win.Forms.sitesForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quennta.vivendaApartmentManagament.UI.Win
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new siteCardForm());
        }
    }
}
