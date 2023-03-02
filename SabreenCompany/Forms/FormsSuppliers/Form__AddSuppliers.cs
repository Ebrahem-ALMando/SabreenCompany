using DevExpress.XtraEditors;
using SabreenCompany.Connection;
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
using SabreenCompany.Classes;

namespace SabreenCompany.Forms.FormsSuppliers
{
    public partial class Form__AddSuppliers : DevExpress.XtraEditors.XtraForm
    {
        Cls_SuppliersDB action = new Cls_SuppliersDB();
        private int id;
        private bool isClose;
        Guna2MessageDialog message = new Guna2MessageDialog();
        public Form__AddSuppliers()
        {
            InitializeComponent();
        }
        public Form__AddSuppliers(int id,string name,string phone ,string locition)
        {
            InitializeComponent();
            loadData(name,phone,locition);
            this.id = id;

        }
        #region Method
        private void loadData( string n, string p, string l)
        {
            TX_Name_Supplier.Text = n;
            TX_Phone_Supplier.Text = p;
            TX_Locition_Supplier.Text = l;
        }
        private void clearField()
        {
            TX_Name_Supplier.Clear();
            TX_Phone_Supplier.Clear();
            TX_Locition_Supplier.Clear();

        }
        private void addData()
        {
            try
            {
                if (TX_Name_Supplier.Text == "" || TX_Locition_Supplier.Text == "" || TX_Phone_Supplier.Text == "")
                {
                    ClsMessageCollections.showEmptyMessageData();

                }
                else
                {
                    if (ClsMessageCollections.showQuitionAddMessageData() == DialogResult.OK)
                    {
                        action.insertSupplier(TX_Name_Supplier.Text, TX_Phone_Supplier.Text, TX_Locition_Supplier.Text);
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
                message.Show("يرجى التحقق من البيانات\n ", "خطأ");
            }
        }
        private void updateData()
        {
            try
            {
                if (TX_Name_Supplier.Text == "" || TX_Locition_Supplier.Text == "" || TX_Phone_Supplier.Text == "")
                {
                    ClsMessageCollections.showEmptyMessageData();
                }
                else
                {
                    if (ClsMessageCollections.showQuitionUpdateMessageData() == DialogResult.OK)
                    {
                        action.updateSupplier(id, TX_Name_Supplier.Text, TX_Phone_Supplier.Text, TX_Locition_Supplier.Text);
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
                message.Show("يرجى التحقق من البيانات\n ", "خطأ");
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
        private void BTN_Save_Click(object sender, EventArgs e)
        {
            isClose = false;
            saveData();

        }
        private void TX_Phone_Supplier_KeyPress(object sender, KeyPressEventArgs e)
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
        private void BTN_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void  BTN_Save_Close_Click(object sender, EventArgs e)
        {
            isClose = true;
            saveData();
        }
        #endregion
    }
}