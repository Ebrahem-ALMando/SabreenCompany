using DevExpress.XtraEditors;
using SabreenCompany.Classes;
using SabreenCompany.Classes.Connection.BoxMoneyProcess;
using SabreenCompany.Classes.Connection.CustomerProcess;
using SabreenCompany.Classes.Connection.IncomesProcess;
using SabreenCompany.Classes.Connection.InvoiceProcess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SabreenCompany.Forms.FormsIncomes
{
    public partial class Form_AddIncomes : DevExpress.XtraEditors.XtraForm
    {
        float amountRemaining;
        Cls_CustomerDB customerDB = new Cls_CustomerDB();
        Cls_IvoiceDB ivoiceDB = new Cls_IvoiceDB();
        Cls_IncomesDB action = new Cls_IncomesDB();
        Cls_BoxMoneyDB boxMoneyDB = new Cls_BoxMoneyDB();
        private bool isClose;
        private int id;

        public Form_AddIncomes()
        {
            InitializeComponent();
            loadCustomer();
            loadIvoiceToCustomer();
            COMP_IdInvoice.SelectedIndex = -1;
        }
        public Form_AddIncomes(int id, string nameCustomer,string idInvoice, string receivedAmount, DateTime date,float total)
        {
            InitializeComponent();
            loadCustomer();
            loadIvoiceToCustomer();
            loadData(id, nameCustomer, idInvoice, receivedAmount, date, total);

        }
        private int getIdCustomer()
        {
            try
            {
                if (COMP_NameCustomer.SelectedIndex != -1)
                {
                    int idCustomer;
                    Int32.TryParse(COMP_NameCustomer.SelectedValue.ToString(), out idCustomer);
                    return idCustomer;
                }
                else
                {
                    return 0;
                }
           
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }
        private int getIdInvoice()
        {
            try
            {
                if (COMP_IdInvoice.SelectedIndex != -1)
                {
                    int idInvoice;
                    Int32.TryParse(COMP_IdInvoice.SelectedValue.ToString(), out idInvoice);
                    return idInvoice;
                }
                else
                {
                    return 0;
                }
           
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }
        private int getIdIncome()
        {
           
                if (id != 0)
                {

                    return id;
                }
                else
                {
                    return Convert.ToInt32(action.getIdcurrentIncome().Rows[0][0]);
                }
         
        }
        private void loadCustomer()
        {
            COMP_NameCustomer.DataSource = customerDB.getDataCustomer();
         /*   COMP_NameCustomer.DisplayMember = "الاسم";
            COMP_NameCustomer.ValueMember = "المعرف";*/
            COMP_NameCustomer.DisplayMember = "Name";
            COMP_NameCustomer.ValueMember = "id";
        }
        private void loadIvoiceToCustomer()
        {
            COMP_IdInvoice.SelectedIndex = -1;
            COMP_IdInvoice.Text="";
            COMP_IdInvoice.DataSource = customerDB.getInvoiceToCustomer(getIdCustomer());
            COMP_IdInvoice.DisplayMember = "المعرف";
            COMP_IdInvoice.ValueMember = "المعرف";

        }
        private void loadData(int id, string nameCustomer, string idInvoice, string receivedAmount, DateTime date ,float total)
        {
            this.id = id;
            COMP_NameCustomer.Text = nameCustomer;
            COMP_IdInvoice.Text = idInvoice;
            TX_AmountReceived_Income.Text = receivedAmount;
            dateTimePicker_Income.Value = date;
          /*  if (total == 0)
            {
                BTN_Save_Close.Enabled = false;
                BTN_Save.Enabled = false;
                groupBox1.Enabled = false;

            }
            else
            {
                BTN_Save_Close.Enabled = true;
                BTN_Save.Enabled = true;
                groupBox1.Enabled = true;
            }*/
        }
        private void getInvoiceIndividualData()
        {
            if (getIdInvoice() != 0)
            {
                TX_TotalAmount.Text = ivoiceDB.getInvoiceIndividualData(getIdInvoice()).Rows[0][0].ToString();
                TX_AmountReceived.Text = ivoiceDB.getInvoiceIndividualData(getIdInvoice()).Rows[0][1].ToString();
                TX_RemainingAmount.Text = ivoiceDB.getInvoiceIndividualData(getIdInvoice()).Rows[0][2].ToString();
                 amountRemaining = Convert.ToSingle(TX_RemainingAmount.Text.Replace('$', ' '));
            }
            else
            {
                TX_TotalAmount.Clear();
                TX_AmountReceived.Clear();
                TX_RemainingAmount.Clear();
            }
        }
        private  void changeTotalAmount()
        {
            if (TX_AmountReceived_Income.Text != "")
            {
                try
                {
                    float amountReceived = Convert.ToSingle(TX_AmountReceived_Income.Text);
                    if (amountReceived > amountRemaining)
                    {
                        ClsMessageCollections.showWarningReceivedGreaterRemainingMessageData();
                        TX_AmountReceived_Income.Clear();
                        TX_RemainingAmount.Text = amountRemaining.ToString() +"$" ;
                    }
                    else
                    {
                        float amountNew = amountRemaining - amountReceived;
                        TX_RemainingAmount.Text =  amountNew.ToString() + "$";
                    }
                }
                catch
                {
                    TX_AmountReceived_Income.Clear();
                    ClsMessageCollections.showWarningInputJustNumberMessageData();
                }
            }
            else
            {
                TX_RemainingAmount.Text= amountRemaining.ToString() + "$";
            }
        }
        private void clearField()
        {
            COMP_NameCustomer.SelectedIndex = -1;
            COMP_IdInvoice.SelectedIndex = -1;
            TX_AmountReceived_Income.Clear();
            TX_RemainingAmount.Clear();
        }
        private void addData()
        {
            try
            {
                 if (COMP_NameCustomer.SelectedIndex == -1 || COMP_IdInvoice.SelectedIndex == -1 ||
                   dateTimePicker_Income.Value == null || TX_AmountReceived_Income.Text == "")
                {
                    ClsMessageCollections.showEmptyMessageData();
                }
                else
                {

                    if (ClsMessageCollections.showQuitionAddMessageData() == DialogResult.OK)
                    {
                            action.insertIncomes(getIdCustomer(),getIdInvoice(),
                            Convert.ToSingle(TX_AmountReceived_Income.Text), DateTime.Now);
                            boxMoneyDB.depositBoxMony(1, getIdIncome(), 0,
                            Convert.ToSingle(TX_AmountReceived_Income.Text), 0, 1);
                            ClsMessageCollections.showSuccessAddMessageData();
                        clearField();
                        if (isClose)
                        {
                            this.Close();
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }
        private void COMP_NameCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadIvoiceToCustomer();
        }
        private void COMP_IdInvoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            getInvoiceIndividualData();
        }

        private void TX_AmountReceived_Income_TextChanged(object sender, EventArgs e)
        {
            changeTotalAmount();
        }

        private void TX_AmountReceived_Income_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsMessageCollections.checkInputTextBoxNumber(sender, e);
        }

        private void BTN_Save_Click(object sender, EventArgs e)
        {
            isClose = false;
            addData();
        }
    }
}