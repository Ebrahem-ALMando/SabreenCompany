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
        public static void showWarningInputJustNumberMessageData()
        {
            messageShow.Style = MessageDialogStyle.Light;
            messageShow.Buttons = MessageDialogButtons.OK;
            messageShow.Icon = MessageDialogIcon.Warning;
            messageShow.Show(Resources.WarningInputJustNumber + "\n ", Resources.CaptionWarningData);
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
    }
}
