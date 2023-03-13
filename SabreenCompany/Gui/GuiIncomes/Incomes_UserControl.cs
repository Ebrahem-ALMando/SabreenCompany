
using SabreenCompany.Classes;
using SabreenCompany.Classes.Connection.BoxMoneyProcess;
using SabreenCompany.Classes.Connection.IncomesProcess;
using SabreenCompany.Forms.FormsIncomes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SabreenCompany.Gui.GuiIncomes
{
    public partial class Incomes_UserControl : UserControl
    {  //==> Var Info To Update Or Delete 
        #region Variables
        private int id;
        private string idInvoice = "";
        private string receivedAmount = "";
        private static Incomes_UserControl incomes_UserControl;
        Cls_IncomesDB action = new Cls_IncomesDB();
        Cls_BoxMoneyDB boxMoneyDB = new Cls_BoxMoneyDB();
        Form_AddIncomes addIncomes;
        #endregion
        //<============================================>
        //<============================================>
        //<==
        public Incomes_UserControl()
        {
            InitializeComponent();
            getData();
        }
        #region Method
        public static Incomes_UserControl Instance()
        {
            //==> Freeing resources and not cloning more than once
            return incomes_UserControl ?? (new Incomes_UserControl());
        }
        private void getData()
        {
            dataGridViewIncomes.DataSource = action.getDataIncomes();
        }
        private void getDataFromDGV()
        {
            try
            {
                if (dataGridViewIncomes.CurrentRow != null)
                {
                    id = Convert.ToInt32(dataGridViewIncomes.CurrentRow.Cells[0].Value);
                    idInvoice = dataGridViewIncomes.CurrentRow.Cells[2].Value.ToString();
                    receivedAmount = dataGridViewIncomes.CurrentRow.Cells[3].Value.ToString().Replace('$', ' ');
                }
            }
            catch
            {
                ClsMessageCollections.showWarningIdSelectMessageData();
         
            }
        }
        #endregion
        #region Event
        private void timer1_Tick(object sender, EventArgs e)
        {
            Date.Text = DateTime.Now.ToString("d/MM/yyyy");
        }
        private void BTN_Add_Click(object sender, EventArgs e)
        {
            addIncomes = new Form_AddIncomes();
            addIncomes.ShowDialog();
            getData();
            addIncomes.Dispose();
           
        }
        private void BTN_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (id != 0)
                {
                    if (action.getIDIncome_FKFromMoneyBox(id).Rows.Count > 0)
                    {
                        if (ClsMessageCollections.showQuitionDeleteIncomeMessageData() == DialogResult.OK)
                        {
                            action.deleteIncome(id,Convert.ToInt32(idInvoice),
                                Convert.ToSingle(receivedAmount.Replace('$',' ')));
                            boxMoneyDB.withdrawalBoxMony(1, Convert.ToInt32(idInvoice), 0,
                                Convert.ToSingle(receivedAmount.Replace('$', ' ')), 1, 0);
                            ClsMessageCollections.showSuccessDeleteMessageData();
                            getData();
                            id = 0;
                        }
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
        private void dataGridViewIncomes_Click(object sender, EventArgs e)
        {
            getDataFromDGV();
        }
        private void dataGridViewIncomes_SelectionChanged(object sender, EventArgs e)
        {
            getDataFromDGV();
        }
        private void TX_Serarch_TextChanged(object sender, EventArgs e)
        {
            if (TX_Serarch.Text != "")
            {
                dataGridViewIncomes.DataSource = action.serachDataIncome(TX_Serarch.Text);

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
                dataGridViewIncomes.DataSource = action.serachDataIncome(TX_Serarch.Text);

            }
            else
            {
                ClsMessageCollections.showEmptySearchMessageData();
            }
        }
        private void dataGridViewIncomes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewIncomes.Rows)
            {
                float val = Convert.ToSingle(row.Cells[5].Value.ToString().Replace('$',' '));
                if (val == 0)
                {
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
        #endregion
    }
}
