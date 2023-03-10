using DevExpress.XtraEditors;
using SabreenCompany.Classes;
using SabreenCompany.Classes.Connection.CustomerProcess;
using SabreenCompany.Classes.Connection.InvoiceProcess;
using SabreenCompany.Classes.Connection.ProductsProcess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
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
     
        private int idInvoice=0;
        private int processNumberProduct;
        private float countProduct;
        private float lastNumberProduct;
        private float lastToatlPrice;
        private float discount = 0;
        private float amountReceived = 0;
        private string nameProduct;
        private bool isSaveProduct = false;
        private bool isClose;
        Cls_CustomerDB custmoer = new Cls_CustomerDB();
        Cls_ProductDB products = new Cls_ProductDB();
        Cls_IvoiceDB action = new Cls_IvoiceDB();
        private int isPaymentDone = 0;
        #endregion
        public Form_AddInvoice()
        {
            InitializeComponent();
            loadCustomer();
            loadproducts();

        }
        public Form_AddInvoice(int id, string name_Cus, string totalAm, string discount, string receivedAm,
            string remainingAm, string typePay, string desc, string note, string date, int isPayDone)
        {
            InitializeComponent();
            loadCustomer();
            loadproducts();
            loadData(id, name_Cus, totalAm, discount, receivedAm, remainingAm, typePay, desc, note, date, isPayDone);

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #region Method
        // ========>  Load Data <======= 
        private void loadData(int id,string name_Cus,string totalAm, string discount,string receivedAm,
            string remainingAm, string typePay, string desc, string note, string date, int isPayDone)
        {
            this.id = id;
            COM_Name_Cus_Inv.Text = name_Cus;
            dateTimePicker_Invoic.Value = Convert.ToDateTime(date);
            RI_TypeProduct_Invoice.Text = desc;
            RI_Notes_Invoice.Text = note;
            TX_Discount.Text = discount;
            this.discount = Convert.ToSingle(discount.Replace('$', ' '));
            TX_TotalAmountInvoice.Text = totalAm;
            lastToatlPrice = Convert.ToSingle(totalAm.Replace('$', ' '));
            TX_AmountReceived.Text = receivedAm;
            float totalAmpont= Convert.ToSingle(totalAm.Replace('$',' ')) -Convert.ToSingle(discount);
            label22.Text = "المبلغ المتبقي" + " (  " + remainingAm + ")";
            label22.BackColor = Color.FromArgb(240, 240, 240);
            label22.Visible = true;
            COM_TypePayment.Text = typePay;
            loadProductToInvoice();
        }

        private void loadProductToInvoice()
        {
            int n = products.getProductsToInvoice(id).Rows.Count;
            for(int i = 0; i < n; i++)
            {
                dataGridViewProductsInvoice.Rows.Add(products.getProductsToInvoice(id).Rows[i][0].ToString(),
                products.getProductsToInvoice(id).Rows[i][1], products.getProductsToInvoice(id).Rows[i][2],
                products.getProductsToInvoice(id).Rows[i][3], products.getProductsToInvoice(id).Rows[i][4]);
            }
     
        }
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
                    lastToatlPrice = price;
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

        // ========>  Get Data Product and Customer  <======= 
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
            catch (Exception ex)
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }
        private int getCustomerID()
        {
            try
            {
                int idCustomer;
                Int32.TryParse(COM_Name_Cus_Inv.SelectedValue.ToString(), out idCustomer);
                return idCustomer;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }
        private void getDataForDatagridView()
        {
            try
            {
                if (dataGridViewProductsInvoice.CurrentRow != null)
                {
                   
                    COM_Name_Product_Invoice.Text = dataGridViewProductsInvoice.CurrentRow.Cells[0].Value.ToString();
                    TX_Price_Product.Text = dataGridViewProductsInvoice.CurrentRow.Cells[1].Value.ToString();
                    TX_Number_Product.Text = dataGridViewProductsInvoice.CurrentRow.Cells[2].Value.ToString();
                    TX_TotalAmount_Product.Text = dataGridViewProductsInvoice.CurrentRow.Cells[3].Value.ToString();
                    lastNumberProduct = Convert.ToSingle(TX_Number_Product.Text);
                    label21.Text = "الكمية المتاحة  في حال اهمال المنتج " + "(" + (lastNumberProduct + countProduct) + ")";
                    label21.Visible = true;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }
        // ========>  End Get Data Product and Customer <======= 
        private void getIDInvoiceCurrent()
        {
            idInvoice = Convert.ToInt32(action.getIDInvoiceToAddProduct().Rows[0][0]);
        }
        // ========>  Check and Clear Data Products <======= 
        private void checkIsPayment()
        {
            if (COM_TypePayment.SelectedIndex == 0)
            {
                isPaymentDone = 1;
            }
            else
            {
                isPaymentDone = 0;
            }
        }
        private void checkTypePayment()
        {
            try
            {
                if (COM_TypePayment.SelectedIndex == 0)
                {
                    TX_AmountReceived.Enabled = false;
                    TX_AmountReceived.Text = TX_TotalAmountInvoice.Text;
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
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private bool checkEmptyFieldsInvoice()
        {
            if (COM_Name_Cus_Inv.SelectedIndex == -1 || dateTimePicker_Invoic.Value == null ||
                dataGridViewProductsInvoice.Rows.Count <= 0|| COM_TypePayment.SelectedIndex==-1|| 
                RI_TypeProduct_Invoice.Text==""|| TX_TotalAmountInvoice.Text=="")
            {
                ClsMessageCollections.showEmptyMessageData();
                return false;
            }
            else if (TX_Discount.Enabled == true && TX_Discount.Text == "")
            {
                ClsMessageCollections.showEmptyMessageData();
                return false;
            }
            else if (TX_AmountReceived.Enabled == true&& TX_AmountReceived.Text=="")
            {
                ClsMessageCollections.showEmptyMessageData();
                return false;
            }
            return true;
        }
        private bool checkEmptyFieldsProducts()
        {
            try
            {
                if (TX_Number_Product.Text == "" || TX_Price_Product.Text == ""
                          || COM_Name_Product_Invoice.Text == "" || TX_TotalAmount_Product.Text == ""
                          || Convert.ToInt32(TX_Number_Product.Text) <= 0)
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
            catch(Exception ex) { MessageBox.Show(ex.Message); return false; }
        }
        private void clearFieldsProducr()
        {
            COM_Name_Product_Invoice.SelectedIndex = 0;
            TX_Price_Product.Clear();
            TX_TotalAmount_Product.Clear();
            TX_Number_Product.Clear();
        }
        private void clearFieldsIvoice()
        {
            clearFieldsProducr();
            int n = dataGridViewProductsInvoice.Rows.Count;
            for (int i = 0; i < n; i++)
            {
                dataGridViewProductsInvoice.Rows.Remove(dataGridViewProductsInvoice.Rows[0]);
            }
            COM_Name_Cus_Inv.SelectedIndex = -1;
            RI_Notes_Invoice.Clear();
            RI_TypeProduct_Invoice.Clear();
            TX_Discount.Clear();
            discount = 0;
            amountReceived = 0;
            lastToatlPrice = 0;
            COM_TypePayment.SelectedIndex = 0;
            isPaymentDone = 0;
            TX_AmountReceived.Clear();
            TX_TotalAmountInvoice.Clear();
            idInvoice = 0;
        }
        private void checkInputNumber(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar >= 'a' && e.KeyChar <= 'z' ||
            e.KeyChar >= 'ا' && e.KeyChar <= 'ي' || e.KeyChar == ' ' || e.KeyChar == '`'
            || e.KeyChar == '-' || e.KeyChar == '*' || e.KeyChar == '@'
            || e.KeyChar == '!' || e.KeyChar == '^' || e.KeyChar == '&' || e.KeyChar == '('
            || e.KeyChar == ')' || e.KeyChar == '_' || e.KeyChar == '~'
            || e.KeyChar == '/' || e.KeyChar == '$' || e.KeyChar == ';')
            {
                e.Handled = true;
                ClsMessageCollections.showWarningInputJustNumberMessageData();
            }
            else
            {
                e.Handled = false;
            }
        }
        private void checkSaveProduct()
        {
            int n = dataGridViewProductsInvoice.Rows.Count;
            if (n > 0)
            {
                if (isSaveProduct)
                {
                    this.Close();
                }
                else
                {
                    if (ClsMessageCollections.showQuitionSaveInvoiceMessageData() == DialogResult.OK)
                    {
                        checkIsPayment();
                        if (checkEmptyFieldsInvoice())
                        {
                                isSaveProduct = true;
                                action.insertInvoice(getCustomerID(), dateTimePicker_Invoic.Value,
                                lastToatlPrice, discount, amountReceived,
                                RI_TypeProduct_Invoice.Text, RI_Notes_Invoice.Text, COM_TypePayment.Text, isPaymentDone);
                                getIDInvoiceCurrent();
                                insertProductToInvoice();
                                clearFieldsIvoice();
                                ClsMessageCollections.showSuccessAddMessageData();
                                this.Close();
                        };
                    }
                    else
                    {
                        this.Close();
                    }
                }
            }
            else
            {
                this.Close();
            }
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
        private void textChangeDiscount()
        {
            try
            {
                float priceNew;
                if (TX_TotalAmountInvoice.Text != "" && TX_Discount.Text != "")
                {
                    discount = Convert.ToSingle(TX_Discount.Text);
                    if (discount > 0)
                    {
                        if (lastToatlPrice > discount)
                        {
                            priceNew = lastToatlPrice - discount;
                            TX_TotalAmountInvoice.Text = "$ " + priceNew.ToString();
                        }
                        else if (lastToatlPrice <= discount)
                        {
                            TX_Discount.Clear();
                            TX_TotalAmountInvoice.Text = "$ " + lastToatlPrice.ToString();
                            ClsMessageCollections.WarningDiscountGreaterTotalAmountMessageData();
                        }
                    }
                }
                else if (TX_Discount.Text == "")
                {
                    loadTotalAmountInvoice();
                }
                checkTypePayment();
            }
            catch
            {
                ClsMessageCollections.showWarningInputJustNumberMessageData();
            }
        }
        private void textChangeAmountReceived()
        {
            try 
            {
                if (TX_AmountReceived.Text != ""  && TX_TotalAmountInvoice.Text != "")
                {
                    float totalAmountInvoice = Convert.ToSingle(TX_TotalAmountInvoice.Text.Replace('$', ' '));
                    amountReceived = Convert.ToSingle(TX_AmountReceived.Text.Replace('$', ' '));
                    if (totalAmountInvoice > amountReceived)
                    {
                        float remainingAmount = totalAmountInvoice - amountReceived;
                        label22.Text = "المبلغ المتبقي" + " ( $ " + remainingAmount + ")";
                        label22.BackColor = Color.FromArgb(240, 240, 240);
                        label22.Visible = true;
                    }
                    else if (totalAmountInvoice == amountReceived)
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
            catch(Exception ex) { MessageBox.Show(ex.Message); }
           
        }
        //================== Action Data ===============
        private void addData()
        {
            checkIsPayment();
            if (checkEmptyFieldsInvoice())
            {
                if (ClsMessageCollections.showQuitionAddMessageData() == DialogResult.OK)
                {
                    isSaveProduct = true;
                    action.insertInvoice(getCustomerID(), dateTimePicker_Invoic.Value,
                    lastToatlPrice, discount, amountReceived,
                    RI_TypeProduct_Invoice.Text, RI_Notes_Invoice.Text, COM_TypePayment.Text, isPaymentDone);
                    getIDInvoiceCurrent();
                    insertProductToInvoice();
                    clearFieldsIvoice();
                    ClsMessageCollections.showSuccessAddMessageData();
                    if (isClose)
                    {
                        this.Close();
                    }
                }

            };
        }
        private void updateData()
        {
            checkIsPayment();
            if (checkEmptyFieldsInvoice())
            {
                if (ClsMessageCollections.showQuitionUpdateMessageData() == DialogResult.OK)
                {
                    isSaveProduct = true;
                    action.updateInvoice(id,getCustomerID(), dateTimePicker_Invoic.Value,
                    lastToatlPrice, discount, amountReceived,
                    RI_TypeProduct_Invoice.Text, RI_Notes_Invoice.Text, COM_TypePayment.Text, isPaymentDone);
                    getIDInvoiceCurrent();
                 /*   insertProductToInvoice();*/
                    clearFieldsIvoice();
                    ClsMessageCollections.showSuccessUpdateMessageData();
                    if (isClose)
                    {
                        this.Close();
                    }
                }

            };
        }
        private void saveData()
        {
            if (id != 0)
            {
                updateData();
            }
            else
            {
                addData();
            }
        }
        private void insertProductToInvoice()
        {
            float price = 0, number = 0, tatalAmount = 0;
            int id=0;
            int n = dataGridViewProductsInvoice.Rows.Count;
            for (int i = 0; i < n; i++)
            {
              price= Convert.ToSingle(dataGridViewProductsInvoice.Rows[i].Cells[1].Value.ToString().Replace('$',' '));
              number=Convert.ToSingle(dataGridViewProductsInvoice.Rows[i].Cells[2].Value);
              tatalAmount=Convert.ToSingle(dataGridViewProductsInvoice.Rows[i].Cells[3].Value.ToString().Replace('$', ' '));
              id=Convert.ToInt32(dataGridViewProductsInvoice.Rows[i].Cells[4].Value);
                action.insertProductToInvoice(idInvoice, id, price, number, tatalAmount);
            }
        }
        #endregion
        private void BTN_Save_Click(object sender, EventArgs e)
        {
            isClose = false;
            saveData();


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
            checkInputNumber(sender, e);
        }
        private void COM_TypePayment_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkTypePayment();
        }
        private void TX_TotalAmountInvoice_TextChanged(object sender, EventArgs e)
        {
            checkTypePayment();
        }
        private void TX_Discount_TextChanged(object sender, EventArgs e)
        {
            textChangeDiscount();
        }
        private void BTN_AddProduct_Invoice_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkEmptyFieldsProducts())
                {
                    processNumberProduct = 1;
                    dataGridViewProductsInvoice.Rows.Add(COM_Name_Product_Invoice.Text, TX_Price_Product.Text, TX_Number_Product.Text, TX_TotalAmount_Product.Text, getProductID());
                    updateCountProducts();
                    ClsMessageCollections.showSuccessAddMessageData();
                    loadTotalAmountInvoice();
                    clearFieldsProducr();
                    label21.Visible = false;
                }
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void dataGridViewProductsInvoice_SelectionChanged(object sender, EventArgs e)
        {
            getDataForDatagridView();
        }
        private void BTN_UpdateProduct_Invoice_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewProductsInvoice.CurrentRow != null)
                {
                    countProduct = countProduct + lastNumberProduct;
                    if (checkEmptyFieldsProducts())
                    {
                        dataGridViewProductsInvoice.CurrentRow.Cells[0].Value = COM_Name_Product_Invoice.Text;
                        dataGridViewProductsInvoice.CurrentRow.Cells[1].Value = TX_Price_Product.Text;
                        dataGridViewProductsInvoice.CurrentRow.Cells[2].Value = TX_Number_Product.Text;
                        dataGridViewProductsInvoice.CurrentRow.Cells[3].Value = TX_TotalAmount_Product.Text;
                        dataGridViewProductsInvoice.CurrentRow.Cells[4].Value = getProductID();
                        processNumberProduct = 1;
                        updateCountProducts();
                        loadTotalAmountInvoice();
                        clearFieldsProducr();
                        label21.Visible = false;
                        ClsMessageCollections.showSuccessUpdateMessageData();
                    }
                }
                else
                {
                    ClsMessageCollections.showWarningIdSelectMessageData();
                }
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void BTN_DeleteProduct_Invoice_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewProductsInvoice.CurrentRow != null && TX_Price_Product.Text != "")
                {
                    if (ClsMessageCollections.showQuitionDeleteMessageData() == DialogResult.OK)
                    {
                        processNumberProduct = 2;
                        updateCountProducts();
                        dataGridViewProductsInvoice.Rows.Remove(dataGridViewProductsInvoice.CurrentRow);
                        loadTotalAmountInvoice();
                        clearFieldsProducr();
                        label21.Visible = false;
                        TX_AmountReceived.Clear();
                        ClsMessageCollections.showSuccessDeleteMessageData();
                    }
                }
                else
                {
                    ClsMessageCollections.showWarningIdSelectMessageData();
                }
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
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
            checkInputNumber(sender, e);
        }
        private void dataGridViewProductsInvoice_Click(object sender, EventArgs e)
        {
            getDataForDatagridView();
        }
        private void TX_AmountReceived_TextChanged(object sender, EventArgs e)
        {
            textChangeAmountReceived();
        }
        private void TX_AmountReceived_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkInputNumber(sender, e);
        }
        private void Form_AddInvoice_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isSaveProduct)
            {
               int n = dataGridViewProductsInvoice.Rows.Count;
                if (n > 0)
                {
                    for (int i = 0; i < n; i++)
                    {
                        float number = Convert.ToSingle(dataGridViewProductsInvoice.Rows[i].Cells[2].Value);
                        int id = Convert.ToInt32(dataGridViewProductsInvoice.Rows[i].Cells[4].Value);
                        products.updateRollbackSetNumberProduct(id, number);
                    }
                    ClsMessageCollections.WarningIgnoreCountProductMessageData();
                }
            }
        }
        private void BTN_CloseControl_MouseLeave(object sender, EventArgs e)
        {
            BTN_CloseControl.BackColor = Color.Indigo;
        }

        private void BTN_CloseControl_MouseEnter(object sender, EventArgs e)
        {
            BTN_CloseControl.BackColor = Color.Brown;
        }

        private void BTN_CloseControl_Click(object sender, EventArgs e)
        {
            checkSaveProduct();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BTN_Close_Click(object sender, EventArgs e)
        {
            checkSaveProduct();
        }

        private void BTN_Save_Close_Click(object sender, EventArgs e)
        {
            isClose = true;
            saveData();
        }
    }
} 