using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            messageShow.Show(Resources.EmptyData,Resources.CaptionEmptyData);
        }

    }
}
