using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SabreenCompany.Classes;
using SabreenCompany.Connection;
using SabreenCompany.Forms.FormsSuppliers;
namespace SabreenCompany.Gui.GuiSuppliers
{
    public partial class Suppliers_UserControl : UserControl
    {
        //==> Var Info To Update Or Delete 

        private int id;
        private string name="";
        private string phone="";
        private string locition="";
        //==>
        private static Suppliers_UserControl suppliers_UserControl;
        Form__AddSuppliers addSuppliers;
        Cls_ProcessDB action = new Cls_ProcessDB();
      static  Cls_ProcessDB actionLoadData = new Cls_ProcessDB();
        public Suppliers_UserControl()
        {
            InitializeComponent();
            getData();
          
        }
        public  void getData()
        {
            dataGridViewSuppliers.DataSource = action.getDataSuppliers();
        }
        public static Suppliers_UserControl Instance()
        {

            //==> Freeing resources and not cloning more than once
            return suppliers_UserControl ?? (new Suppliers_UserControl());
        }
        private void BTN_Add_Click(object sender, EventArgs e)
        {
            addSuppliers = new Form__AddSuppliers();
            addSuppliers.ShowDialog();
            getData();

        }

        private void dataGridViewSuppliers_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewSuppliers.CurrentRow != null)
            {
                id =Convert.ToInt32(  dataGridViewSuppliers.CurrentRow.Cells[0].Value);
                name = dataGridViewSuppliers.CurrentRow.Cells[1].Value.ToString();
                phone = dataGridViewSuppliers.CurrentRow.Cells[2].Value.ToString();
                locition = dataGridViewSuppliers.CurrentRow.Cells[3].Value.ToString();
            }
        }

        private void BTN_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (id!=0)
                {
                    if (ClsMessageCollections.showQuitionDeleteMessageData() == DialogResult.OK)
                    {
                        action.deleteSupplier(id);
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            Date.Text = DateTime.Now.ToString("d/MM/yyyy");
        }

        private void BTN_Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (id != 0)
                {
                        addSuppliers = new Form__AddSuppliers(id, name, phone, locition);
                        addSuppliers.ShowDialog();
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

        private void TX_Serarch_TextChanged(object sender, EventArgs e)
        {
            if (TX_Serarch.Text != "")
            {
                dataGridViewSuppliers.DataSource = action.serachDataSupplier(TX_Serarch.Text);

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
                dataGridViewSuppliers.DataSource = action.serachDataSupplier(TX_Serarch.Text);

            }
            else
            {
                ClsMessageCollections.showEmptySearchMessageData();
            }
        }
    }
}
