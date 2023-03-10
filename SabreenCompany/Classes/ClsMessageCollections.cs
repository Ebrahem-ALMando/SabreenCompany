using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using SabreenCompany.Properties;
namespace SabreenCompany.Classes
{
   public static class ClsMessageCollections
    {
     static readonly Guna2MessageDialog  messageShow = new Guna2MessageDialog();
        //==>Show Message Empty Data
        public static void showEmptyMessageData()
        {
            messageShow.Buttons = MessageDialogButtons.OK;
            messageShow.Style = MessageDialogStyle.Light;
            messageShow.Icon = MessageDialogIcon.Warning;
            messageShow.Show(Resources.EmptyData+"\n ",Resources.CaptionWarningData);
        }
        public static void showEmptyProductMessageData()
        {
            messageShow.Buttons = MessageDialogButtons.OK;
            messageShow.Style = MessageDialogStyle.Light;
            messageShow.Icon = MessageDialogIcon.Warning;
            messageShow.Show(Resources.EmptyDataProduct + "\n ", Resources.CaptionWarningData);
        }
        public static void showWarningNumberProductMessageData()
        {
            messageShow.Buttons = MessageDialogButtons.OK;
            messageShow.Style = MessageDialogStyle.Light;
            messageShow.Icon = MessageDialogIcon.Warning;
            messageShow.Show(Resources.WarningInputNumberProducts+ "\n ", Resources.CaptionWarningData);
        }
        public static void showWarningProductExisteInInvoiceMessageData()
        {
            messageShow.Buttons = MessageDialogButtons.OK;
            messageShow.Style = MessageDialogStyle.Light;
            messageShow.Icon = MessageDialogIcon.Warning;
            messageShow.Show(Resources.WarningProductExisteInInvoice + "\n ", Resources.CaptionWarningData);
        }
        //==>Show Message Empty Data Serach
        public static void showEmptySearchMessageData()
        {
            messageShow.Buttons = MessageDialogButtons.OK;
            messageShow.Style = MessageDialogStyle.Light;
            messageShow.Icon = MessageDialogIcon.Warning;
            messageShow.Show(Resources.EmptyDataSerarch + "\n ", Resources.CaptionWarningData);
        }
        //==>Show Message Warning Input less length Password  
        public static void showWarningInputlesslengthPasswordMessage()
        {
            messageShow.Buttons = MessageDialogButtons.OK;
            messageShow.Style = MessageDialogStyle.Light;
            messageShow.Icon = MessageDialogIcon.Warning;
            messageShow.Show(Resources.WarningInputPasswordlesslenth + "\n ", Resources.CaptionWarningData);
        }
        public static void WarningAmountReceivedGreaterTotalAmountMessageData()
        {
            messageShow.Buttons = MessageDialogButtons.OK;
            messageShow.Style = MessageDialogStyle.Light;
            messageShow.Icon = MessageDialogIcon.Warning;
            messageShow.Show(Resources.WarningAmountReceivedGreaterTotalAmount + "\n ", Resources.CaptionWarningData);
        }
        public static void WarningDiscountGreaterTotalAmountMessageData()
        {
            messageShow.Buttons = MessageDialogButtons.OK;
            messageShow.Style = MessageDialogStyle.Light;
            messageShow.Icon = MessageDialogIcon.Warning;
            messageShow.Show(Resources.WarningDiscountGreaterTotalAmount + "\n ", Resources.CaptionWarningData);
        }
        public static void WarningIgnoreCountProductMessageData()
        {
            messageShow.Buttons = MessageDialogButtons.OK;
            messageShow.Style = MessageDialogStyle.Light;
            messageShow.Icon = MessageDialogIcon.Warning;
            messageShow.Show(Resources.WarningIgnoreCountProduct + "\n ", Resources.CaptionWarningData);
        }
        //===>Show Warning InputAlready Password Message
        public static void showWarningInputAlreadyPasswordMessage()
        {
            messageShow.Buttons = MessageDialogButtons.OK;
            messageShow.Style = MessageDialogStyle.Light;
            messageShow.Icon = MessageDialogIcon.Warning;
            messageShow.Show(Resources.WarningInputAlreadyPassword + "\n ", Resources.CaptionWarningData);
        }
        public static void showWarningInputImageMessageData()
        {
            messageShow.Buttons = MessageDialogButtons.OK;
            messageShow.Style = MessageDialogStyle.Light;
            messageShow.Icon = MessageDialogIcon.Warning;
            messageShow.Show(Resources.WarningInputImage + "\n ", Resources.CaptionWarningData);
        }
        //==>Show Message Success Add Data
        public static void showSuccessAddMessageData()
        {
            messageShow.Buttons = MessageDialogButtons.OK;
            messageShow.Style = MessageDialogStyle.Dark;
            messageShow.Icon = MessageDialogIcon.Information;
            messageShow.Show(Resources.SuccessAddData + "\n ", Resources.CaptionSuccessActionData);
        }
        //==>Show Message Quition Add Data
        public static DialogResult showQuitionAddMessageData()
        {
            messageShow.Buttons = MessageDialogButtons.OKCancel;
            messageShow.Style = MessageDialogStyle.Dark;
            messageShow.Icon = MessageDialogIcon.Question;
            DialogResult check = messageShow.Show(Resources.QuitionAddData + "\n ", Resources.CaptionQuitionAddData);
            return check;
        }
        //==>Show Message Quition Add Data
        public static DialogResult showQuitionDepositMessageData()
        {
            messageShow.Buttons = MessageDialogButtons.OKCancel;
            messageShow.Style = MessageDialogStyle.Dark;
            messageShow.Icon = MessageDialogIcon.Question;
            DialogResult check = messageShow.Show(Resources.QuitionDepositData + "\n ", Resources.CaptionQuitionDepositData);
            return check;
        }
        public static DialogResult showQuitionWithdrawalMessageData()
        {
            messageShow.Buttons = MessageDialogButtons.OKCancel;
            messageShow.Style = MessageDialogStyle.Dark;
            messageShow.Icon = MessageDialogIcon.Question;
            DialogResult check = messageShow.Show(Resources.QuitionWithdrawalData + "\n ", Resources.CaptionQuitionwithdrawalData);
            return check;
        }
        public static void showSuccessWithdrawalMessageData()
        {
            messageShow.Buttons = MessageDialogButtons.OK;
            messageShow.Style = MessageDialogStyle.Dark;
            messageShow.Icon = MessageDialogIcon.Information;
            messageShow.Show(Resources.SuccessWithdrawalData + "\n ", Resources.CaptionSuccessActionData);
        }
        public static void showSuccessDepositMessageData()
        {
            messageShow.Buttons = MessageDialogButtons.OK;
            messageShow.Style = MessageDialogStyle.Dark;
            messageShow.Icon = MessageDialogIcon.Information;
            messageShow.Show(Resources.SuccessDepositData + "\n ", Resources.CaptionSuccessActionData);
        }
        public static void showWarningNotEnoughAmountMessageData()
        {
            messageShow.Buttons = MessageDialogButtons.OK;
            messageShow.Style = MessageDialogStyle.Light;
            messageShow.Icon = MessageDialogIcon.Warning;
            messageShow.Show(Resources.WarningNotEnoughAmount + "\n ", Resources.CaptionWarningData);
        }
        public static void showWarningReceivedGreaterRemainingMessageData()
        {
            messageShow.Buttons = MessageDialogButtons.OK;
            messageShow.Style = MessageDialogStyle.Light;
            messageShow.Icon = MessageDialogIcon.Warning;
            messageShow.Show(Resources.WarningAmountReceivedGreaterRemainingAmount + "\n ", Resources.CaptionWarningData);
        }
        //==>Show Message Quition Add Data
        public static void showWarningInputJustNumberMessageData()
        {
            messageShow.Style = MessageDialogStyle.Light;
            messageShow.Buttons = MessageDialogButtons.OK;
            messageShow.Icon = MessageDialogIcon.Warning;
            messageShow.Show(Resources.WarningInputJustNumber + "\n ", Resources.CaptionWarningData);
        }
        public static DialogResult showQuitionDeleteIncomeMessageData()
        {
            messageShow.Buttons = MessageDialogButtons.OKCancel;
            messageShow.Style = MessageDialogStyle.Dark;
            messageShow.Icon = MessageDialogIcon.Question;
            DialogResult check = messageShow.Show(Resources.WarningIncomeExisteInInvoice + "\n "+
                Resources.QuitionDeleteData + "\n ", Resources.CaptionQuitionDeleteData);
            return check;
        }
        //==>Show Message Quition Delete Data
        public static DialogResult showQuitionDeleteMessageData()
        {
            messageShow.Buttons = MessageDialogButtons.OKCancel;
            messageShow.Style = MessageDialogStyle.Dark;
            messageShow.Icon = MessageDialogIcon.Question;
            DialogResult check = messageShow.Show(Resources.QuitionDeleteData + "\n ", Resources.CaptionQuitionDeleteData);
            return check;
        }
        public static DialogResult showQuitionSaveInvoiceMessageData()
        {
            messageShow.Buttons = MessageDialogButtons.OKCancel;
            messageShow.Style = MessageDialogStyle.Dark;
            messageShow.Icon = MessageDialogIcon.Question;
            DialogResult check = messageShow.Show(Resources.QuitionSaveInvoiceData + "\n ", Resources.CaptionSaveData);
            return check;
        }
        //==>Show Message Success Delete Data
        public static void showSuccessDeleteMessageData()
        {
            messageShow.Buttons = MessageDialogButtons.OK;
            messageShow.Style = MessageDialogStyle.Dark;
            messageShow.Icon = MessageDialogIcon.Information;
            messageShow.Show(Resources.SuccessDeleteData + "\n ", Resources.CaptionSuccessActionData);
        }
        //==>Show Message Warning Id Delete Data
        public static void showWarningIdSelectMessageData()
        {
            messageShow.Buttons = MessageDialogButtons.OK;
            messageShow.Style = MessageDialogStyle.Light;
            messageShow.Icon = MessageDialogIcon.Warning;
            messageShow.Show(Resources.WarningIdSelectData + "\n ", Resources.CaptionWarningData);
        }

        //==>Show Message Quition Update Data
        public static DialogResult showQuitionUpdateMessageData()
        {
            messageShow.Buttons = MessageDialogButtons.OKCancel;
            messageShow.Style = MessageDialogStyle.Dark;
            messageShow.Icon = MessageDialogIcon.Question;
            DialogResult check = messageShow.Show(Resources.QuitionUpdateData + "\n ", Resources.CaptionQuitionUpdateData);
            return check;
        }
        //==>Show Message Success Update Data
        public static void showSuccessUpdateMessageData()
        {
            messageShow.Buttons = MessageDialogButtons.OK;
            messageShow.Style = MessageDialogStyle.Dark;
            messageShow.Icon = MessageDialogIcon.Information;
            messageShow.Show(Resources.SuccessUpdateData + "\n ", Resources.CaptionSuccessActionData);
        }
        //==>Show Message SaveBackup  Data
        public static void showSuccessSaveBackupData()
        {
            messageShow.Buttons = MessageDialogButtons.OK;
            messageShow.Style = MessageDialogStyle.Dark;
            messageShow.Icon = MessageDialogIcon.Information;
            messageShow.Show(Resources.SuccessSaveBackup + "\n ", Resources.CaptionSuccessActionData);
        }
        public static void showErroeSaveBackupIn_C_DiskMessage()
        {
            messageShow.Buttons = MessageDialogButtons.OK;
            messageShow.Style = MessageDialogStyle.Light;
            messageShow.Icon = MessageDialogIcon.Error;
            messageShow.Show(Resources.ErrorSaveBackupIndesk_C + "\n ", Resources.CaptionWarningData);
        }
        public static void showWarningInputPathBackupMessage()
        {
            messageShow.Buttons = MessageDialogButtons.OK;
            messageShow.Style = MessageDialogStyle.Light;
            messageShow.Icon = MessageDialogIcon.Error;
            messageShow.Show(Resources.WarningInputPathToBackup + "\n ", Resources.CaptionWarningData);
        }
        public static void showSuccessRestoreBackupData()
        {
            messageShow.Buttons = MessageDialogButtons.OK;
            messageShow.Style = MessageDialogStyle.Dark;
            messageShow.Icon = MessageDialogIcon.Information;
            messageShow.Show(Resources.SuccessRestoreBackup + "\n ", Resources.CaptionSuccessActionData);
        }
        //---------------------------
        //==========================
        public static void checkInputTextBoxNumber(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar >= 'a' && e.KeyChar <= 'z' ||
                e.KeyChar >= 'ا' && e.KeyChar <= 'ي' || e.KeyChar == ' ' || e.KeyChar == '`'
                 || e.KeyChar == '-' || e.KeyChar == '*' || e.KeyChar == '@'
                || e.KeyChar == '!' || e.KeyChar == '^' || e.KeyChar == '&' || e.KeyChar == '('
                || e.KeyChar == ')' || e.KeyChar == '_' || e.KeyChar == '~'
                || e.KeyChar == '/' || e.KeyChar == ';' || e.KeyChar == '+')
            {
                e.Handled = true;
                showWarningInputJustNumberMessageData();
            }
            else
            {
                e.Handled = false;
            }
        }
    }
}
