using SabreenCompany.Forms;
using SabreenCompany.Forms.FormsCustomers;
using SabreenCompany.Forms.FormsProducts;
using SabreenCompany.Forms.FormsSuppliers;
using SabreenCompany.Gui.GuiCategories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SabreenCompany.Gui.GuiHome
{
    public partial class Home_UserControl : UserControl
    {// ================= Create To Reagin =================
        private  static Home_UserControl homeUserControl;
        Form__AddSuppliers addSuppliers;
        Form_AddCategory addCategory;
        Form_AddProducts addProduct;
        Form_AddCustomer addCustomer;
        static String userName = "";
        public Home_UserControl()
        {
            InitializeComponent();
            loadName();
        }
        private void loadName()
        {
            if (userName == "ebrahem-m")
            {
                LBL_Wellcome.Text = LBL_Wellcome.Text + "ابراهيم";
            }
            else if (userName == "omar")
            {
                LBL_Wellcome.Text = LBL_Wellcome.Text + "عمر";
            }
            else
            {
                LBL_Wellcome.Text = LBL_Wellcome.Text + userName;
            }
        }
        public static Home_UserControl Instance(String userName_)
        {
            userName = userName_;
            //==> Freeing resources and not cloning more than once
            return homeUserControl ?? (new Home_UserControl());
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            /*time_now.Text = DateTime.Now.ToString("h:mm:ss ");*/
            Date.Text = DateTime.Now.ToString("d/MM/yyyy");
        }
        private void BTN_Add_Supplier_Click(object sender, EventArgs e)
        {
            addSuppliers = new Form__AddSuppliers();
            addSuppliers.ShowDialog();
        }
        private void BTN_Add_Category_Click(object sender, EventArgs e)
        {
            addCategory = new Form_AddCategory();
            addCategory.ShowDialog();
        }
        private void BTN_Add_Product_Click(object sender, EventArgs e)
        {
            addProduct = new Form_AddProducts();
            addProduct.ShowDialog();
        }

        private void BTN_Add_Customer_Click(object sender, EventArgs e)
        {
            addCustomer = new Form_AddCustomer();
            addCustomer.ShowDialog();
        }
    }
}
