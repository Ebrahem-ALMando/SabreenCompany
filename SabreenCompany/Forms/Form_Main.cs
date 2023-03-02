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

namespace SabreenCompany.Forms
{
    public partial class Form_Main : DevExpress.XtraEditors.XtraForm
    {
        Guna2MessageDialog message = new Guna2MessageDialog();
        private readonly Cls_PageManager pageManager;
        private string userName = "";
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
        #region Event
        private void BTN_Logout_Click(object sender, EventArgs e)
        {
            message.Style = MessageDialogStyle.Light;
            message.Buttons = MessageDialogButtons.YesNo;
            message.Icon = MessageDialogIcon.Question;
            DialogResult check = message.Show("هل تريد تسجيل الخروج \n ", "خروج");
            if (check == DialogResult.Yes)
            {
                this.Hide();
                Form_Login login = new Form_Login();
                login.ShowDialog();
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