using DevExpress.XtraEditors;
using SabreenCompany.Classes;
using SabreenCompany.Classes.Connection.CustomerProcess;
using SabreenCompany.Classes.Connection.ProductsProcess;
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

namespace SabreenCompany.Forms.FormsInvoice
{
    public partial class Form_AddInvoice : DevExpress.XtraEditors.XtraForm
    {
        //==> Var Info To Update Or Delete 
        # region Variables
        private int id;
        private int processNumberProduct;
        private float countProduct;
        private float lastNumberProduct;
        private string nameProduct;
        Cls_CustomerDB custmoer = new Cls_CustomerDB();
        Cls_ProductDB products = new Cls_ProductDB();
        #endregion
        public Form_AddInvoice()
        {
            InitializeComponent();
            loadCustomer();
            loadproducts();
          
        }
        #region Method
        // ========>  Load Data <======= 
        private void loadCustomer()
        {
            COM_Name_Cus_Inv.DataSource = custmoer.getDataCustomer();
            COM_Name_Cus_Inv.DisplayMember = "Name";
            COM_Name_Cus_Inv.ValueMember = "id";
            COM_TypePayment.SelectedIndex = 0;
        }
        private void loadproducts()
        {
            COM_Name_Product_Invoice.DataSource = products.getDataProducts();
            COM_Name_Product_Invoice.DisplayMember = "الاسم";
            COM_Name_Product_Invoice.ValueMember = "المعرف";
        }
        private void loadTotalAmount()
        {
            try
            {
                if (TX_Price_Product.Text != "" && TX_Number_Product.Text != "" && Convert.ToInt32(TX_Number_Product.Text) > 0)
                {
                    float price, number;
                    price = Convert.ToSingle(TX_Price_Product.Text.Replace('$', ' '));
                    number = Convert.ToSingle(TX_Number_Product.Text);
                    TX_TotalAmount_Product.Text = " $ " + (price * number).ToString();
                }
                else
                {
                    TX_TotalAmount_Product.Text = "";
                }
            }
            catch
            {
                ClsMessageCollections.showWarningInputJustNumberMessageData();
            }
        }
        private void loadTotalAmountInvoice()
        {
            try
            {
                if (dataGridViewProductsInvoice.Rows.Count > 0)
                {
                    int n = dataGridViewProductsInvoice.Rows.Count;
                    float price = 0;
                    for (int i = 0; i < n; i++)
                    {
                        price = price + Convert.ToSingle(dataGridViewProductsInvoice.Rows[i].Cells[3].Value.ToString().Replace('$', ' '));
                    }
                    TX_TotalAmountInvoice.Text = "$" + price.ToString();
                    checkTypePayment();
                }
                else
                {
                    TX_TotalAmountInvoice.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // ========>  End Load Data <======= 

        // ========>  Get Data Product <======= 
        private void getProductIndividualData()
        {
            try
            {
                if (COM_Name_Product_Invoice.SelectedValue.ToString().Length < 10)
                {
                    nameProduct = products.getproductIndividualData(getProductID()).Rows[0][1].ToString();
                    countProduct = Convert.ToSingle(products.getproductIndividualData(getProductID()).Rows[0][4]);
                    TX_Price_Product.Text = products.getproductIndividualData(getProductID()).Rows[0][3].ToString();
                    LBL_CountProduct_Invoice.Text = "الكمية المتاحة  من " + nameProduct + " (" + countProduct.ToString() + ")";
                    byte[] image = (byte[])products.getproductIndividualData(getProductID()).Rows[0][7];
                    MemoryStream me = new MemoryStream(image);
                    picturePhoto_Product.Image = Image.FromStream(me);
                    TX_TotalAmount_Product.Clear();
                    TX_Number_Product.Clear();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
    
        }
        private int getProductID()
        {
            try
            {
                int idProduct;
                Int32.TryParse(COM_Name_Product_Invoice.SelectedValue.ToString(), out idProduct);
                return idProduct;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }
        // ========>  End Get Data Product <======= 

        // ========>  Check and Clear Data Products <======= 
        //==========================================================================
        private void checkTypePayment()
        {
            if (COM_TypePayment.SelectedIndex == 0)
            {
                TX_AmountReceived.Enabled = false;
                TX_AmountReceived.Text = TX_TotalAmountInvoice.Text ;

            }
            else if (COM_TypePayment.SelectedIndex == 1) 
            {
                TX_AmountReceived.Enabled = true;
                TX_AmountReceived.Clear();
            }
            else if (COM_TypePayment.SelectedIndex == 2)
            {
                TX_AmountReceived.Enabled = false;
                TX_AmountReceived.Clear();
            }
        }
        private bool checkEmptyFields()
        {
            if (COM_Name_Cus_Inv.SelectedIndex == -1 || dateTimePicker_Invoic.Value == null || dataGridViewProductsInvoice.Rows.Count <= 0)
            {
                ClsMessageCollections.showEmptyMessageData();
                return false;
            }
           
            return true;
        }

        private bool checkEmptyFieldsProducts()
        {
        
            if(TX_Number_Product.Text==""||TX_Price_Product.Text==""
                || COM_Name_Product_Invoice.Text == "" || TX_TotalAmount_Product.Text == ""
                ||Convert.ToInt32(TX_Number_Product.Text)<=0)
            {
                ClsMessageCollections.showEmptyProductMessageData();
                return false;
            }
            else if (Convert.ToInt32(TX_Number_Product.Text) > Convert.ToInt32(countProduct))
            {
                ClsMessageCollections.showWarningNumberProductMessageData();
                return false;
            }
            return true;


        }
        private void clearFieldsProducr()
        {
            COM_Name_Product_Invoice.SelectedIndex = 0;
            TX_Price_Product.Clear();
            TX_TotalAmount_Product.Clear();
            TX_Number_Product.Clear();
        }
        // ========>  End Check and Clear Data Products <======= 
        private void updateCountProducts()
        {
            if (TX_Number_Product.Text != "")
            {
                float numberProduct = Convert.ToSingle(TX_Number_Product.Text);
                if (processNumberProduct == 1)
                {
                    if (countProduct >= numberProduct)
                    {
                        countProduct = countProduct - numberProduct;
                    }
                }
                else if (processNumberProduct == 2)
                {
                    numberProduct = Convert.ToSingle(dataGridViewProductsInvoice.CurrentRow.Cells[2].Value);
                    countProduct = countProduct + numberProduct;
                }

                products.updateSetNumberProduct(getProductID(), countProduct);
                LBL_CountProduct_Invoice.Text = "الكمية المتاحة  من " + nameProduct + " (" + countProduct.ToString() + ")";
                processNumberProduct = 0;
            }

        }
        #endregion
        private void BTN_Save_Click(object sender, EventArgs e)
        {
            if (checkEmptyFields())
            {

            };
        }

        private void COM_Name_Product_Invoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            getProductIndividualData();
        }

        private void TX_Number_Product_TextChanged(object sender, EventArgs e)
        {
            loadTotalAmount();
        }

        private void CheckBoxDiscount_Click(object sender, EventArgs e)
        {
            if (TX_Discount.Enabled == false)
            {
                TX_Discount.Enabled = true;
                label20.Visible = true;


            }
            else if (TX_Discount.Enabled == true)
            {
                TX_Discount.Enabled = false;
                TX_Discount.Clear();
                label20.Visible = false;
            }
        }

        private void TX_Discount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar >= 'a' && e.KeyChar <= 'z' ||
             e.KeyChar >= 'ا' && e.KeyChar <= 'ي' || e.KeyChar == ' ' || e.KeyChar == '`'
              || e.KeyChar == '-' || e.KeyChar == '*' || e.KeyChar == '@'
             || e.KeyChar == '!' || e.KeyChar == '^' || e.KeyChar == '&' || e.KeyChar == '('
             || e.KeyChar == ')' || e.KeyChar == '_' || e.KeyChar == '~'
             || e.KeyChar == '/' || e.KeyChar == ';')
            {
                e.Handled = true;
                ClsMessageCollections.showWarningInputJustNumberMessageData();
            }
            else
            {
                e.Handled = false;
            }
        }

        private void COM_TypePayment_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkTypePayment();
        }

        private void TX_TotalAmountInvoice_TextChanged(object sender, EventArgs e)
        {

        }

        private void TX_Discount_TextChanged(object sender, EventArgs e)
        {
            float price, priceNew,discount;
            if(TX_TotalAmountInvoice.Text!=""&& TX_Discount.Text!="")
            {
                price = Convert.ToSingle(TX_TotalAmountInvoice.Text.Replace('$',' '));
                discount = Convert.ToSingle(TX_Discount.Text);
                priceNew = price - discount;
                TX_TotalAmountInvoice.Text = "$ " + priceNew.ToString();
            }
           
        }

        private void BTN_AddProduct_Invoice_Click(object sender, EventArgs e)
        {
            /*            string []data = new string[100];
                        data[0] =  COM_Name_Product_Invoice.Text;
                        dataGridViewProductsInvoice.DataSource = data;*/

            if (checkEmptyFieldsProducts())
            {
                processNumberProduct = 1;
                dataGridViewProductsInvoice.Rows.Add(COM_Name_Product_Invoice.Text, TX_Price_Product.Text, TX_Number_Product.Text, TX_TotalAmount_Product.Text, getProductID());
                /*               countProductNew = (Convert.ToInt32(countProduct) - Convert.ToInt32(TX_Number_Product.Text)).ToString();
                */
                updateCountProducts();
                ClsMessageCollections.showSuccessAddMessageData();

                loadTotalAmountInvoice();
                clearFieldsProducr();
                label21.Visible = false;


            }
            
        }

        private void dataGridViewProductsInvoice_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewProductsInvoice.CurrentRow != null)
            {
                COM_Name_Product_Invoice.Text = dataGridViewProductsInvoice.CurrentRow.Cells[0].Value.ToString();
                TX_Price_Product.Text = dataGridViewProductsInvoice.CurrentRow.Cells[1].Value.ToString();
                TX_Number_Product.Text = dataGridViewProductsInvoice.CurrentRow.Cells[2].Value.ToString();
                TX_TotalAmount_Product.Text = dataGridViewProductsInvoice.CurrentRow.Cells[3].Value.ToString();
                id = Convert.ToInt32(dataGridViewProductsInvoice.CurrentRow.Cells[4].Value);

            }
        }

        private void BTN_UpdateProduct_Invoice_Click(object sender, EventArgs e)
        {
            if (dataGridViewProductsInvoice.CurrentRow != null)
            {
                MessageBox.Show(countProduct.ToString() + "Befor");
                countProduct = countProduct + lastNumberProduct;
                MessageBox.Show(countProduct.ToString()+"After");
                if (checkEmptyFieldsProducts())
                {
                    dataGridViewProductsInvoice.CurrentRow.Cells[0].Value = COM_Name_Product_Invoice.Text;
                    dataGridViewProductsInvoice.CurrentRow.Cells[1].Value = TX_Price_Product.Text;
                    dataGridViewProductsInvoice.CurrentRow.Cells[2].Value = TX_Number_Product.Text;
                    dataGridViewProductsInvoice.CurrentRow.Cells[3].Value = TX_TotalAmount_Product.Text;
                    dataGridViewProductsInvoice.CurrentRow.Cells[4].Value = getProductID();
                    processNumberProduct = 1;
                    updateCountProducts();
                    ClsMessageCollections.showSuccessUpdateMessageData();
                    loadTotalAmountInvoice();
                    clearFieldsProducr();
                    label21.Visible = false;
                }
            }
            else
            {
                ClsMessageCollections.showWarningIdSelectMessageData();
            }
        }

        private void BTN_DeleteProduct_Invoice_Click(object sender, EventArgs e)
        {
            if (dataGridViewProductsInvoice.CurrentRow != null&&TX_Price_Product.Text!="")
            {
                if (ClsMessageCollections.showQuitionDeleteMessageData() == DialogResult.OK)
                {
                    processNumberProduct = 2;
                    updateCountProducts();
                    dataGridViewProductsInvoice.Rows.Remove(dataGridViewProductsInvoice.CurrentRow);
                    ClsMessageCollections.showSuccessDeleteMessageData();
                    loadTotalAmountInvoice();
                    clearFieldsProducr();
                    label21.Visible = false;
                    label22.Text = "";
                    label22.Visible = false;
                    TX_AmountReceived.Clear();

                }
            }
            else
            {
                ClsMessageCollections.showWarningIdSelectMessageData();
            }
         
        /*    MessageBox.Show( dataGridViewProductsInvoice.Rows[0].Cells[0].Value.ToString());
            MessageBox.Show(dataGridViewProductsInvoice.Rows[1].Cells[0].Value.ToString());
            MessageBox.Show(dataGridViewProductsInvoice.Rows[2].Cells[0].Value.ToString());*/


        }

        private void TX_Price_Product_TextChanged(object sender, EventArgs e)
        {
            if (TX_Price_Product.Text != "")
            {
                TX_Number_Product.Enabled = true;
            }
            else
            {
                TX_Number_Product.Enabled = false;
            }
        }

        private void TX_Number_Product_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar >= 'a' && e.KeyChar <= 'z' ||
            e.KeyChar >= 'ا' && e.KeyChar <= 'ي' || e.KeyChar == ' ' || e.KeyChar == '`'
             || e.KeyChar == '-' || e.KeyChar == '*' || e.KeyChar == '@'
            || e.KeyChar == '!' || e.KeyChar == '^' || e.KeyChar == '&' || e.KeyChar == '('
            || e.KeyChar == ')' || e.KeyChar == '_' || e.KeyChar == '~'
            || e.KeyChar == '/' || e.KeyChar == '+' || e.KeyChar == ';')
            {
                e.Handled = true;
                ClsMessageCollections.showWarningInputJustNumberMessageData();
            }
            else
            {
                e.Handled = false;
            }
        }

        private void dataGridViewProductsInvoice_Click(object sender, EventArgs e)
        {
            if (dataGridViewProductsInvoice.CurrentRow != null)
            {
                id = Convert.ToInt32(dataGridViewProductsInvoice.CurrentRow.Cells[4].Value);
                COM_Name_Product_Invoice.Text = dataGridViewProductsInvoice.CurrentRow.Cells[0].Value.ToString();
                TX_Price_Product.Text = dataGridViewProductsInvoice.CurrentRow.Cells[1].Value.ToString();
                TX_Number_Product.Text = dataGridViewProductsInvoice.CurrentRow.Cells[2].Value.ToString();
                TX_TotalAmount_Product.Text = dataGridViewProductsInvoice.CurrentRow.Cells[3].Value.ToString();
                lastNumberProduct = Convert.ToSingle(TX_Number_Product.Text);
                label21.Text = "الكمية المتاحة  في حال اهمال المنتج " + "("+(lastNumberProduct + countProduct) +")";
                label21.Visible = true;
            }
         
        }

        private void TX_AmountReceived_TextChanged(object sender, EventArgs e)
        {

            if (TX_AmountReceived.Text != ""&& TX_AmountReceived.Enabled==true&& TX_TotalAmountInvoice.Text!="")
            {
                float totalAmountInvoice = Convert.ToSingle(TX_TotalAmountInvoice.Text.Replace('$', ' '));
                float amountReceived =Convert.ToSingle(TX_AmountReceived.Text.Replace('$', ' '));
                if (totalAmountInvoice > amountReceived)
                {
                    float remainingAmount = totalAmountInvoice - amountReceived;
                    label22.Text = "المبلغ المتبقي" + " ( $ " + remainingAmount + ")";
                    label22.Enabled = false;
                    label22.Visible = true;
                }else if(totalAmountInvoice == amountReceived)
                {
                    COM_TypePayment.SelectedIndex = 0;
                    checkTypePayment();

                    label22.Text = "";
                    label22.Visible = false;
                }
                else
                {
                    TX_AmountReceived.Clear();
                    label22.Visible = false;
                    ClsMessageCollections.WarningAmountReceivedGreaterTotalAmountMessageData();
                }
           

            }
            else
            {
                label22.Text = "";
                label22.Visible = false;
            }
        }
    }
}