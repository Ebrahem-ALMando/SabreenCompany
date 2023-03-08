using SabreenCompany.Classes;
using SabreenCompany.Classes.Connection.ProductsProcess;
using SabreenCompany.Forms.FormsProducts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SabreenCompany.Gui.GuiProducts
{
    public partial class Products_UserControl : UserControl
    {
        //==> Var Info To Update Or Delete 
        #region Variables
        int id;
        string category;
        string name;
        string price;
        string number;
        string totalAmount;
        string description;
        MemoryStream me;
        private static Products_UserControl products_UserControl;
        Form_AddProducts addCategory = new Form_AddProducts();
        Cls_ProductDB action = new Cls_ProductDB();
        #endregion
        //<============================================>
        //<============================================>
        //<============================================>
        public Products_UserControl()
        {
            InitializeComponent();
            getData();
        }

        #region Method
        public static Products_UserControl Instance()
        {
            //==> Freeing resources and not cloning more than once
            return products_UserControl ?? (new Products_UserControl());
        }
        private void getData()
        {
            dataGridViewProducts.DataSource = action.getDataProducts();
            dataGridViewProducts.Columns["الصورة"].Visible = false;
        }
        private void updateData()
        {
            try
            {
                if (id != 0)
                {
                    addCategory = new Form_AddProducts(id, name, category, price, number, totalAmount, description, me);
                    addCategory.ShowDialog();
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
            addCategory = new Form_AddProducts();
            addCategory.ShowDialog();
            getData();
        }
        private void BTN_Update_Click(object sender, EventArgs e)
        {
            updateData();
        }
        private void dataGridViewProducts_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewProducts.CurrentRow != null)
                {
                    id = Convert.ToInt32(dataGridViewProducts.CurrentRow.Cells[0].Value);
                    name = dataGridViewProducts.CurrentRow.Cells[1].Value.ToString();
                    category = dataGridViewProducts.CurrentRow.Cells[2].Value.ToString();
                    price = dataGridViewProducts.CurrentRow.Cells[3].Value.ToString();
                    number = dataGridViewProducts.CurrentRow.Cells[4].Value.ToString();
                    totalAmount = dataGridViewProducts.CurrentRow.Cells[5].Value.ToString();
                    description = dataGridViewProducts.CurrentRow.Cells[6].Value.ToString();
                    byte[] image = (byte[])dataGridViewProducts.CurrentRow.Cells[7].Value;
                    me = new MemoryStream(image);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                        action.deleteProduct(id);
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
                dataGridViewProducts.DataSource = action.serachDataProduct(TX_Serarch.Text);

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
                dataGridViewProducts.DataSource = action.serachDataProduct(TX_Serarch.Text);

            }
            else
            {
                ClsMessageCollections.showEmptySearchMessageData();
            }
        }
        private void dataGridViewProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            updateData();
        }
        #endregion
    }
}
