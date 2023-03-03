using SabreenCompany.Classes;
using SabreenCompany.Classes.Connection.CustomerProcess;
using SabreenCompany.Forms.FormsCustomers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SabreenCompany.Gui.GuiCustomer
{
    public partial class CustomerUserControl : UserControl
    {   //==> Var Info To Update Or Delete 
        #region Variables
        private int id;
        private string name = "";
        private string place = "";
        private string phone = "";
        private static CustomerUserControl customerUserControl;
        Cls_CustomerDB action = new Cls_CustomerDB();
        Form_AddCustomer addCustomer;
        #endregion
        //<============================================>
        //<============================================>
        //<============================================>
        public CustomerUserControl()
        {
            InitializeComponent();
            getData();
        }
        #region Method 
        private void getData()
        {
            dataGridViewCustomer.DataSource = action.getDataCustomer();
        }
        public static CustomerUserControl Instance()
        {
            //==> Freeing resources and not cloning more than once
            return customerUserControl ?? (new CustomerUserControl());
        }
        private void updateData()
        {
            try
            {
                if (id != 0)
                {
                    addCustomer = new Form_AddCustomer(id, name, phone, place);
                    addCustomer.ShowDialog();
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            Date.Text = DateTime.Now.ToString("d/MM/yyyy");
        }

        private void BTN_Add_Click(object sender, EventArgs e)
        {
            addCustomer = new Form_AddCustomer();
            addCustomer.ShowDialog();
            getData();
        }

        private void dataGridViewCustomer_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewCustomer.CurrentRow != null)
            {
                id = Convert.ToInt32(dataGridViewCustomer.CurrentRow.Cells[0].Value);
                name = dataGridViewCustomer.CurrentRow.Cells[1].Value.ToString();
                phone = dataGridViewCustomer.CurrentRow.Cells[2].Value.ToString();
                place = dataGridViewCustomer.CurrentRow.Cells[3].Value.ToString();
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
                        action.deleteCustomer(id);
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

        private void BTN_Update_Click(object sender, EventArgs e)
        {
            updateData();
        }

        private void dataGridViewCustomer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            updateData();
        }

        private void TX_Serarch_TextChanged(object sender, EventArgs e)
        {
            if (TX_Serarch.Text != "")
            {
                dataGridViewCustomer.DataSource = action.serachDataCustomer(TX_Serarch.Text);

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
                dataGridViewCustomer.DataSource = action.serachDataCustomer(TX_Serarch.Text);

            }
            else
            {
                ClsMessageCollections.showEmptySearchMessageData();
            }
        }
    }
}
