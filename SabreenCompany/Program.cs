using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using SabreenCompany.Forms;
using SabreenCompany.Gui.GuiCategories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SabreenCompany
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
            Application.Run(new Form_Login());
        }
        /*   Forms.FormsInvoice.Form_AddInvoice()*/
        /*Forms.FormsProducts.Form_AddProducts()  Forms.FormsIncomes.Form_AddIncomes()*/
        /*    Forms.FormsSuppliers.Form__AddSuppliers()*/
    }
}
