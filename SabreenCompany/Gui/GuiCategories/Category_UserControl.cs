using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SabreenCompany.Gui.GuiCategories
{
    public partial class Category_UserControl : UserControl
    {
        Form_AddCategory AddCategory;
        private static Category_UserControl categoryUserControl;
        public Category_UserControl()
        {
            InitializeComponent();
        }
        public static Category_UserControl Instance()
        {

            //==> Freeing resources and not cloning more than once
            return categoryUserControl ?? (new Category_UserControl());
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Date.Text = DateTime.Now.ToString("d/MM/yyyy");
        }
       

        private void BTN_Add_Click(object sender, EventArgs e)
        {
            AddCategory = new Form_AddCategory();
            AddCategory.Show();
        }

        private void BTN_Update_Click(object sender, EventArgs e)
        {
            Classes.ClsMessageCollections.showEmptyMessageData();
        }
    }
}
