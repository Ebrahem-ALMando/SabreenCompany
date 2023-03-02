using DevExpress.XtraEditors;
using SabreenCompany.Classes;
using SabreenCompany.Classes.Connection.CategoryProcess;
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

namespace SabreenCompany.Gui.GuiCategories
{
    public partial class Form_AddCategory : DevExpress.XtraEditors.XtraForm
    {

        private bool isClose;
        private int id;
        Cls_SuppliersDB supllier = new Cls_SuppliersDB();
        Cls_CategoryDB action = new Cls_CategoryDB();
        public Form_AddCategory()
        {
            InitializeComponent();
            loadSuppliers();
        }
        public Form_AddCategory(int id, string Supplier,string name, string type, string note)
        {
            InitializeComponent();
            loadSuppliers();
            this.id = id;
            loadData(name, Supplier, type, note);
        }
        #region Method 
        private void loadSuppliers()
        {
            COMP_Name_Supplier.DataSource = supllier.getDataSuppliers();
            COMP_Name_Supplier.DisplayMember = "الاسم";
            COMP_Name_Supplier.ValueMember = "المعرف";
            COMP_Name_Supplier.SelectedIndex = -1;
        }
        private void loadData(string n,string Supplier, string t, string note)
        {
            TX_Name_Category.Text=n;
            TX_Type_Category.Text=t;
            COMP_Name_Supplier.Text = Supplier;
            RI_Notes.Text= note;
        }
        private void clearField()
        {
            TX_Name_Category.Clear();
            TX_Type_Category.Clear();
            COMP_Name_Supplier.SelectedIndex = -1;
            RI_Notes.Clear();
        }
        private void addData()
        {
            try
            {
                if(TX_Name_Category.Text==""||TX_Type_Category.Text==""||
                    COMP_Name_Supplier.SelectedIndex == -1)
                {
                    ClsMessageCollections.showEmptyMessageData();
                }
                else
                {
                    if (ClsMessageCollections.showQuitionAddMessageData()== DialogResult.OK)
                    {
                        action.insertCategory(Convert.ToInt32(COMP_Name_Supplier.SelectedValue), TX_Name_Category.Text,
                        TX_Type_Category.Text, RI_Notes.Text, DateTime.Now);
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
                ClsMessageCollections.showEmptyMessageData();
                MessageBox.Show(ex.Message);
            }
        }
        private void updateData()
        {
            try
            {
                if (TX_Name_Category.Text == "" || TX_Type_Category.Text == "" ||
                    COMP_Name_Supplier.SelectedIndex == -1)
                {
                    ClsMessageCollections.showEmptyMessageData();
                }
                else
                {
                    if (ClsMessageCollections.showQuitionUpdateMessageData() == DialogResult.OK)
                    {
                        action.updateCategory(Convert.ToInt32(id),
                            Convert.ToInt32(COMP_Name_Supplier.SelectedValue)
                            , TX_Name_Category.Text,TX_Type_Category.Text, RI_Notes.Text, DateTime.Now);

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
                MessageBox.Show(ex.Message);
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
        private void BTN_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BTN_Save_Close_Click(object sender, EventArgs e)
        {
            isClose = true;
            saveData();
        }
        #endregion


    }
}