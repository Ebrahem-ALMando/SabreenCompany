using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using SabreenCompany.Classes.Home;
using SabreenCompany.Forms.FormsSettings;
using SabreenCompany.Forms.FormsBoxMoney;

namespace SabreenCompany.Forms
{
    public partial class Form_Main : DevExpress.XtraEditors.XtraForm
    {
        Guna2MessageDialog message = new Guna2MessageDialog();
        private readonly Cls_PageManager pageManager;
        private string userName = "";
        Form_Settings form_Settings;
        Form_BoxMoney form_BoxMoney;
        public Form_Main()
        {
            InitializeComponent();
            pageManager = new Cls_PageManager(this);

            //==> Load Defulat Home page
            pageManager.LoadPage(Gui.GuiHome.Home_UserControl.Instance("Gust"));
        }
        public Form_Main(string userName)
        {
            InitializeComponent();
            pageManager = new Cls_PageManager(this);
            this.userName = userName;
            //==> Load Defulat Home page
            pageManager.LoadPage(Gui.GuiHome.Home_UserControl.Instance(userName));
        }
        private void BTN_Categoryes_Click(object sender, EventArgs e)
        {
            pageManager.LoadPage(Gui.GuiCategories.Category_UserControl.Instance());
        }
        private void BTN_Customers_Click(object sender, EventArgs e)
        {
            pageManager.LoadPage(Gui.GuiCustomer.CustomerUserControl.Instance());
        }
        private void BTN_Setting_Click(object sender, EventArgs e)
        {
             form_Settings = new Form_Settings();
             form_Settings.ShowDialog();
             form_Settings.Dispose();
        }
        private void BTN_Invioce_Click(object sender, EventArgs e)
        {
            pageManager.LoadPage(Gui.GuiInvoice.Invoice_UserControl.Instance());
        }
        private void BTN_BoxMoney_Click(object sender, EventArgs e)
        {
            form_BoxMoney = new Form_BoxMoney();
            form_BoxMoney.ShowDialog();
            form_BoxMoney.Dispose();
        }
        private void BTN_Incomes_Click(object sender, EventArgs e)
        {
            pageManager.LoadPage(Gui.GuiIncomes.Incomes_UserControl.Instance());
        }
        #region Event
        private void BTN_Logout_Click(object sender, EventArgs e)
        {
            message.Style = MessageDialogStyle.Light;
            message.Buttons = MessageDialogButtons.YesNo;
            message.Icon = MessageDialogIcon.Question;
            DialogResult check = message.Show("هل تريد تسجيل الخروج \n ", "خروج");
            if (check == DialogResult.Yes)
            {
                this.Close();
                Application.OpenForms["Form_Login"].Show();

            }

        }
        private void BTN_Home_Click(object sender, EventArgs e)
        {
            pageManager.LoadPage(Gui.GuiHome.Home_UserControl.Instance(userName));
        }
        private void BTN_Suppliers_Click(object sender, EventArgs e)
        {
            pageManager.LoadPage(Gui.GuiSuppliers.Suppliers_UserControl.Instance());
        }
        private void BTN_Products_Click(object sender, EventArgs e)
        {
            pageManager.LoadPage(Gui.GuiProducts.Products_UserControl.Instance());
        }





        #endregion

       
    }
}