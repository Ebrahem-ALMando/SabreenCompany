using SabreenCompany.Classes;
using SabreenCompany.Classes.Connection.CategoryProcess;
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
        //==> Var Info To Update Or Delete 
        #region Variables
        private int id;
        private string Supplier="";
        private string name="";
        private string type="";
        private string note="";
        Form_AddCategory AddCategory;
        private static Category_UserControl categoryUserControl;
        Cls_CategoryDB action = new Cls_CategoryDB();
        #endregion
        //<============================================>
        //<============================================>
        //<============================================>
        public Category_UserControl()
        {
            InitializeComponent();
            getData();
        }
        #region Method
        public static Category_UserControl Instance()
        {
            //==> Freeing resources and not cloning more than once
            return categoryUserControl ?? (new Category_UserControl());
        }
        private void getData()
        {
            dataGridViewCategory.DataSource = action.getDataCategory();
        }
        private void updateData()
        {
            try
            {
                if (id != 0)
                {
                    AddCategory = new Form_AddCategory(id, Supplier, name, type, note);
                    AddCategory.ShowDialog();
                    getData();
                }
                else
                {
                    ClsMessageCollections.showWarningIdSelectMessageData();
                }
            }
            catch
            {
                ClsMessageCollections.showWarningIdSelectMessageData();
            }
        }
        #endregion
        #region Event
        private void timer1_Tick(object sender, EventArgs e)
        {
            Date.Text = DateTime.Now.ToString("d/MM/yyyy");
        }
        private void BTN_Add_Click(object sender, EventArgs e)
        {
            AddCategory = new Form_AddCategory();
            AddCategory.ShowDialog();
            getData();
        }
        private void BTN_Update_Click(object sender, EventArgs e)
        {
            updateData();


        }
        private void dataGridViewCategory_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewCategory.CurrentRow != null)
            {
                id = Convert.ToInt32(dataGridViewCategory.CurrentRow.Cells[0].Value);
                name = dataGridViewCategory.CurrentRow.Cells[1].Value.ToString();
                Supplier = dataGridViewCategory.CurrentRow.Cells[2].Value.ToString();
                type = dataGridViewCategory.CurrentRow.Cells[3].Value.ToString();
                note= dataGridViewCategory.CurrentRow.Cells[4].Value.ToString();
            }
        }
        private void BTN_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (id != 0)
                {
                    if (ClsMessageCollections.showQuitionDeleteMessageData() == DialogResult.OK)
                    {
                        action.deleteCategory(id);
                        ClsMessageCollections.showSuccessDeleteMessageData();
                        getData();
                        id = 0;
                    }
                }
                else
                {
                    ClsMessageCollections.showWarningIdSelectMessageData();
                }
            }
            catch
            {
                ClsMessageCollections.showWarningIdSelectMessageData();
            }
        }
        private void TX_Serarch_TextChanged(object sender, EventArgs e)
        {
            if (TX_Serarch.Text != "")
            {
                dataGridViewCategory.DataSource = action.serachDataCategory(TX_Serarch.Text);

            }
            else
            {
                getData();
            }
        }
        private void BTN_Search_Click(object sender, EventArgs e)
        {
            if (TX_Serarch.Text != "")
            {
                dataGridViewCategory.DataSource = action.serachDataCategory(TX_Serarch.Text);

            }
            else
            {
                ClsMessageCollections.showEmptySearchMessageData();
            }
        }
        private void dataGridViewCategory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            updateData();
        }
        #endregion


    }
}
