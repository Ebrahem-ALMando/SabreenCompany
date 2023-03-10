using SabreenCompany.Classes;
using SabreenCompany.Classes.Connection.InvoiceProcess;
using SabreenCompany.Forms.FormsInvoice;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SabreenCompany.Gui.GuiInvoice
{
    public partial class Invoice_UserControl : UserControl
    {


        //==> Var Info To Update Or Delete 
        #region Variables
        private int id;
        string nameCustomer;
        string totalAmount;
        string discount;
        //المبلغ المقبوض
        string receivedAmount;
        //-المبلغ المتبقي
        string remainingAmount;
        //--==========
        string typePayment;
        string description;
        string note;
        string date;
        int isPaymentDone;
        private static Invoice_UserControl invoice_UserControl;
        Cls_IvoiceDB action = new Cls_IvoiceDB();
        Form_AddInvoice addInvoice;
        #endregion
        //<============================================>
        //<============================================>
        //<============================================>
        public Invoice_UserControl()
        {
            InitializeComponent();
            getData();
     
        }
        public static Invoice_UserControl Instance()
        {
            //==> Freeing resources and not cloning more than once
            return invoice_UserControl ?? (new Invoice_UserControl());
        }
        private void getData()
        {
            dataGridViewInvoice.DataSource = action.getDataInvoice();
            bool check = dataGridViewInvoice.Columns[10].Visible;
            if (check) { dataGridViewInvoice.Columns[10].Visible = false; }
        }
        private void getDataFromDGV()
        {
            try 
            {
                if (dataGridViewInvoice.CurrentRow != null)
                {
                    id = Convert.ToInt32(dataGridViewInvoice.CurrentRow.Cells[0].Value);
                    nameCustomer = dataGridViewInvoice.CurrentRow.Cells[1].Value.ToString();
                    totalAmount = dataGridViewInvoice.CurrentRow.Cells[2].Value.ToString().Replace('$', ' ');
                    discount = dataGridViewInvoice.CurrentRow.Cells[3].Value.ToString().Replace('$', ' ');
                    receivedAmount = dataGridViewInvoice.CurrentRow.Cells[4].Value.ToString().Replace('$', ' ');
                    remainingAmount = dataGridViewInvoice.CurrentRow.Cells[5].Value.ToString().Replace('$', ' ');
                    typePayment = dataGridViewInvoice.CurrentRow.Cells[6].Value.ToString();
                    description = dataGridViewInvoice.CurrentRow.Cells[7].Value.ToString();
                    note = dataGridViewInvoice.CurrentRow.Cells[8].Value.ToString();
                    date = dataGridViewInvoice.CurrentRow.Cells[9].Value.ToString();
                    isPaymentDone = Convert.ToInt32(dataGridViewInvoice.CurrentRow.Cells[10].Value);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
       
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Date.Text = DateTime.Now.ToString("d/MM/yyyy");
        }

        private void BTN_Add_Click(object sender, EventArgs e)
        {
            addInvoice = new Form_AddInvoice();
            addInvoice.ShowDialog();
            getData();
            addInvoice.Dispose();
        }

        private void dataGridViewInvoice_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewInvoice.Rows)
            {
                int val = Convert.ToInt32(row.Cells[10].Value);
                if (val == 1)
                {
                    /*row.DefaultCellStyle.BackColor= Color.FromArgb(48, 30, 103);*/
                    row.DefaultCellStyle.BackColor = Color.FromArgb(191, 220, 229);
                    row.DefaultCellStyle.ForeColor = Color.Indigo;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
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
                        action.deleteInvoice(id);
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

        private void dataGridViewInvoice_SelectionChanged(object sender, EventArgs e)
        {
            getDataFromDGV();
        }

        private void dataGridViewInvoice_Click(object sender, EventArgs e)
        {
            getDataFromDGV();
        }
    }
}
