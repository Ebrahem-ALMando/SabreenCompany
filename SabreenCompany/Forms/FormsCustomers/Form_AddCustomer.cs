using DevExpress.XtraEditors;
using SabreenCompany.Classes;
using SabreenCompany.Classes.Connection.CustomerProcess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SabreenCompany.Forms.FormsCustomers
{
    public partial class Form_AddCustomer : DevExpress.XtraEditors.XtraForm
    {
        Cls_CustomerDB action = new Cls_CustomerDB();
        private int id;
        private bool isClose;
        public Form_AddCustomer()
        {
            InitializeComponent();
        }
        public Form_AddCustomer(int id,string n, string p, string l)
        {
            InitializeComponent();
            this.id = id;
            loadData(n,p,l);
        }
        #region Method
        private void loadData(string n, string p, string l)
        {
            TX_Name_Customer.Text = n;
            TX_Phone_Customer.Text = p;
            TX_Locition_Customer.Text = l;
        }
        private void clearField()
        {
            TX_Name_Customer.Clear();
            TX_Phone_Customer.Clear();
            TX_Locition_Customer.Clear();

        }
        private void addData()
        {
            try
            {
                if (TX_Name_Customer.Text == "" || TX_Locition_Customer.Text == "" || TX_Phone_Customer.Text == "")
                {
                    ClsMessageCollections.showEmptyMessageData();

                }
                else
                {
                    if (ClsMessageCollections.showQuitionAddMessageData() == DialogResult.OK)
                    {
                        action.insertCustomer(TX_Name_Customer.Text, TX_Locition_Customer.Text, TX_Phone_Customer.Text,DateTime.Now);
                        ClsMessageCollections.showSuccessAddMessageData();
                        clearField();
                        if (isClose)
                        {
                            this.Close();
                        }

                    }

                }

            }
            catch (Exception ex)
            {
                ClsMessageCollections.showEmptyMessageData();
            }
        }
        private void updateData()
        {
            try
            {
                if (TX_Name_Customer.Text == "" || TX_Locition_Customer.Text == "" || TX_Phone_Customer.Text == "")
                {
                    ClsMessageCollections.showEmptyMessageData();

                }
                else
                {
                    if (ClsMessageCollections.showQuitionUpdateMessageData() == DialogResult.OK)
                    {
                        action.updateCustomer(id,TX_Name_Customer.Text, TX_Locition_Customer.Text, TX_Phone_Customer.Text);
                        ClsMessageCollections.showSuccessUpdateMessageData();
                        if (isClose)
                        {
                            this.Close();
                        }

                    }

                }

            }
            catch (Exception ex)
            {
                ClsMessageCollections.showEmptyMessageData();
            }
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
        #endregion
        #region Event
        private void TX_Phone_Customer_KeyPress(object sender, KeyPressEventArgs e)
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
        #endregion
    }
}