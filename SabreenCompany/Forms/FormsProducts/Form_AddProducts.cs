using DevExpress.XtraEditors;
using SabreenCompany.Classes;
using SabreenCompany.Classes.Connection.BoxMoneyProcess;
using SabreenCompany.Classes.Connection.CategoryProcess;
using SabreenCompany.Classes.Connection.ProductsProcess;
using SabreenCompany.Gui.GuiCategories;
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

namespace SabreenCompany.Forms.FormsProducts
{
    public partial class Form_AddProducts : DevExpress.XtraEditors.XtraForm
    {
        private bool isClose;
        private  int id;
        private int idBox;
        private float totalAmount;
        private float totalAmountBox;
        private float totalToUpdate;
        Cls_CategoryDB category = new Cls_CategoryDB();
        Cls_ProductDB action = new Cls_ProductDB();
        Cls_BoxMoneyDB boxMoneyDB = new Cls_BoxMoneyDB();
        public Form_AddProducts()
        {
            InitializeComponent();
            loadCategory();
            loadTotalAmountBoxMoney();
            panelToUpdateNuber.Visible = false;
        }
        public Form_AddProducts(int id,string name,string cat,string pri, string num, string totalAmount,string desc, MemoryStream m)
        {
            InitializeComponent();
            loadCategory();
            loadData(id, name, cat, pri, num, totalAmount, desc, m);
            loadTotalAmountBoxMoney();
            totalToUpdate = Convert.ToSingle(totalAmount.Replace('$', ' '));
        }
        #region method
        private void loadTotalAmountBoxMoney()
        {
            label9.Text = boxMoneyDB.getDataBoxMoney().Rows[0][2].ToString();
            totalAmountBox=Convert.ToSingle(boxMoneyDB.getDataBoxMoney().Rows[0][2].ToString().Replace('$',' '));
            idBox = Convert.ToInt32(boxMoneyDB.getDataBoxMoney().Rows[0][0]);
            
        }
        private int getIdcurrentProduct() {
            if (id != 0)
            {
              
                return id;
            }
            else
            {
                return Convert.ToInt32(action.getIdcurrentProduct().Rows[0][0]);
            }
        }
        private void setTotalAmountToBoxMony()
        {
              boxMoneyDB.withdrawalBoxMony(idBox, 0, getIdcurrentProduct(),
              totalAmount, 0, 1);
              totalAmount = 0;
        }
        private void loadCategory()
        {
            COMP_Name_Category.DataSource = category.getDataCategory();
            COMP_Name_Category.DisplayMember = "الاسم";
            COMP_Name_Category.ValueMember = "المعرف";
            COMP_Name_Category.SelectedIndex = -1;
           
        }

        private void loadTotalAmount()
        {
            if (TX_Price_Product.Text != "" && TX_Number_Product.Text != "")
            {
                float price, number;
                price = Convert.ToSingle(TX_Price_Product.Text);
                number = Convert.ToSingle(TX_Number_Product.Text);
                TX_TotalAmount_Product.Text = " $ "+(price * number).ToString();
                totalAmount = price * number;
            }
            else
            {
                TX_TotalAmount_Product.Text = "";
                
            }
        }
        private void loadData(int id,string name, string cat, string pri, string num, string totalAmount, string desc, MemoryStream me)
        {
            panelToUpdateNuber.Visible = true;
            this.id = id;
            TX_Name_Product.Text = name;
            COMP_Name_Category.Text = cat;
            TX_Number_Product.Text = num;
            TX_Price_Product.Text= pri.Replace('$', ' ');
            TX_TotalAmount_Product.Text = totalAmount;
            RI_Notes.Text = desc;
            picturePhoto_Product.Image = Image.FromStream(me);
        }
        private byte[] saveImage()
        {//===> Convert Image To Byte
            byte[] arrImg=null;
            try
            {
                Image img = picturePhoto_Product.Image;
                ImageConverter converter = new ImageConverter();
                arrImg = (byte[])converter.ConvertTo(img, typeof(byte[]));
             
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return arrImg;

        }
        private void clearField()
        {
            TX_Name_Product.Clear();
            TX_Number_Product.Clear();
            TX_Price_Product.Clear();
            RI_Notes.Clear();
            COMP_Name_Category.SelectedIndex = -1;
            TX_TotalAmount_Product.Clear();
            picturePhoto_Product.Image = Properties.Resources.icons8_aliexpress_500px;
        }
        private void addDate()
        {
            try
            {

                if (TX_Name_Product.Text == "" || TX_Number_Product.Text == "" || TX_Price_Product.Text == ""||COMP_Name_Category.SelectedIndex==-1)
                {
                    ClsMessageCollections.showEmptyMessageData();
                }
                else
                {
                    if (totalAmountBox >= totalAmount)
                    {
                        if (ClsMessageCollections.showQuitionAddMessageData() == DialogResult.OK)
                        {
                            int id_Category;
                            Int32.TryParse(COMP_Name_Category.SelectedValue.ToString(), out id_Category);
                            action.insertProduct(id_Category, TX_Name_Product.Text
                           , Convert.ToSingle(TX_Price_Product.Text), Convert.ToSingle(TX_Number_Product.Text), RI_Notes.Text, saveImage());
                            setTotalAmountToBoxMony();
                            loadTotalAmountBoxMoney();
                            ClsMessageCollections.showSuccessAddMessageData();
                            clearField();
                           
                            if (isClose)
                            {
                                this.Close();
                            }

                        }
                    }
                    else { ClsMessageCollections.showWarningNotEnoughAmountMessageData(); }
                  
                }
            }
            catch(Exception ex)
            {
                ClsMessageCollections.showEmptyMessageData();
                MessageBox.Show(ex.Message);
            }
        }
        private void updateDate()
        {
            try
            {
                if (TX_Name_Product.Text == "" || TX_Number_Product.Text == "" || TX_Price_Product.Text == "" || COMP_Name_Category.SelectedIndex == -1)
                {
                    ClsMessageCollections.showEmptyMessageData();
                }
                else
                {
                    if (totalAmountBox+totalToUpdate >= totalAmount)
                    {
                        if (ClsMessageCollections.showQuitionUpdateMessageData() == DialogResult.OK)
                        {
                            int id_Category;
                            Int32.TryParse(COMP_Name_Category.SelectedValue.ToString(), out id_Category);
                            action.updateProduct(id, id_Category, TX_Name_Product.Text
                           , Convert.ToSingle(TX_Price_Product.Text), Convert.ToSingle(TX_Number_Product.Text), RI_Notes.Text, saveImage());
                            ClsMessageCollections.showSuccessUpdateMessageData();
                            boxMoneyDB.depositBoxMony(idBox, 0, getIdcurrentProduct(),
                                 totalToUpdate, 1, 0);
                            setTotalAmountToBoxMony();
                            loadTotalAmountBoxMoney();
                            totalToUpdate = Convert.ToSingle(TX_TotalAmount_Product.Text.Replace('$', ' '));
                            totalAmount = totalToUpdate;
                            if (isClose)
                            {
                                this.Close();
                            }
                        }
                    }
                    else { ClsMessageCollections.showWarningNotEnoughAmountMessageData(); }
                 
                }
            }
            catch (Exception ex)
            {
                ClsMessageCollections.showEmptyMessageData();
                MessageBox.Show(ex.Message);
            }
        }
        private void saveData()
        {
          
            if (id != 0)
            {
                
                updateDate();
               /* totalAmountBox += totalAmount;*/
            }
            else
            {
                addDate();
              
            }
           
           
        }
        #endregion
        #region Event
        private void BTN_LoadImage_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog opd=new OpenFileDialog())
            {
                try
                {
                    opd.Filter = "all|*.jpg;*.jpeg;*.png;|.jpg|*.jpg;|.jpeg|*.jpeg;|.png|*.png";
                    opd.Title = "Load Image";
                    if (opd.ShowDialog() == DialogResult.OK)
                    {
                        picturePhoto_Product.Image = Image.FromFile(opd.FileName);
                    }
                }
                catch (Exception ex)
                {
                    ClsMessageCollections.showWarningInputImageMessageData();
                    MessageBox.Show(ex.Message);
                }
               
            }
        }
        private void BTN_RemoveImage_Click(object sender, EventArgs e)
        {
            try
            {
                picturePhoto_Product.Image = Properties.Resources.icons8_aliexpress_500px;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BTN_Save_Click(object sender, EventArgs e)
        {
            isClose = false;
            saveData();
        }
        private void BTN_Save_Close_Click(object sender, EventArgs e)
        {
            isClose = true;
            saveData();
        }
        private void BTN_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void TX_Price_Product_TextChanged(object sender, EventArgs e)
        {
            loadTotalAmount();
        }
        private void TX_Number_Product_TextChanged(object sender, EventArgs e)
        {
            loadTotalAmount();
        }
        private void TX_Price_Product_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsMessageCollections.checkInputTextBoxNumber(sender, e);
        }
        private void TX_Number_Product_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsMessageCollections.checkInputTextBoxNumber(sender, e);
        }
        private void new_Category_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_AddCategory form_AddCategory = new Form_AddCategory();
            form_AddCategory.ShowDialog();
            form_AddCategory.Dispose();
            loadCategory();
        }
        #endregion


    }
}