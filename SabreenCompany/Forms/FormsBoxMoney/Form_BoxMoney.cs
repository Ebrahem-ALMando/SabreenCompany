using DevExpress.XtraEditors;
using SabreenCompany.Classes;
using SabreenCompany.Classes.Connection.BoxMoneyProcess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SabreenCompany.Forms.FormsBoxMoney
{
    public partial class Form_BoxMoney : DevExpress.XtraEditors.XtraForm
    {
        private int id;
        Cls_BoxMoneyDB action = new Cls_BoxMoneyDB();

        public Form_BoxMoney()
        {
            InitializeComponent();
            getData();
        }
        private void getData()
        {
            LBL_TotalAmount.Text = action.getDataBoxMoney().Rows[0][2].ToString();
            this.id = Convert.ToInt32(action.getDataBoxMoney().Rows[0][0]);
        }
        private bool checkDataToActions()
        {
            if (TX_TotalAmountProcess.Text != "")
            {
                float totalAmount = Convert.ToSingle(LBL_TotalAmount.Text.Replace('$', ' '));
                float amount = Convert.ToSingle(TX_TotalAmountProcess.Text);
                if (totalAmount >= amount)
                {
                    return true;
                }
                else
                {
                    ClsMessageCollections.showWarningNotEnoughAmountMessageData();
                    return false;
                }
            }
            else
            {
                ClsMessageCollections.showEmptyMessageData();
                return false;
            }
        }  
    private void timer1_Tick(object sender, EventArgs e)
        {
            Date.Text = DateTime.Now.ToString("d/MM/yyyy");
        }

        private void BTN_Withdrawal_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkDataToActions())
                {
                    if (ClsMessageCollections.showQuitionWithdrawalMessageData() == DialogResult.OK)
                    {
                        action.withdrawalBoxMony(id, 0, 0, Convert.ToSingle(TX_TotalAmountProcess.Text), 0, 1);
                        getData();
                        ClsMessageCollections.showSuccessWithdrawalMessageData();
                        TX_TotalAmountProcess.Clear();
                    }
                } 
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void TX_TotalAmountProcess_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsMessageCollections.checkInputTextBoxNumber(sender,e);
        }

        private void BTN_Deposit_Click(object sender, EventArgs e)
        {
            try
            {
                if (TX_TotalAmountProcess.Text != "" )
                {
                    if (ClsMessageCollections.showQuitionDepositMessageData() == DialogResult.OK)
                    {
                        action.depositBoxMony(id, 0, 0, Convert.ToSingle(TX_TotalAmountProcess.Text), 1, 0);
                        getData();
                        ClsMessageCollections.showSuccessDepositMessageData();
                        TX_TotalAmountProcess.Clear();
                    }
                }
                else
                {
                    ClsMessageCollections.showEmptyMessageData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}