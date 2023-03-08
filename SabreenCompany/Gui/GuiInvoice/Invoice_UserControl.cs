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

namespace SabreenCompany.Gui.GuiInvoice
{
    public partial class Invoice_UserControl : UserControl
    {
        private static Invoice_UserControl invoice_UserControl;
        Cls_IvoiceDB action = new Cls_IvoiceDB();
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
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Date.Text = DateTime.Now.ToString("d/MM/yyyy");
        }
    }
}
