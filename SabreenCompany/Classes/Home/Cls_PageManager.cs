using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using SabreenCompany.Forms;
using System.Windows.Forms;

namespace SabreenCompany.Classes.Home
{
   public class Cls_PageManager
    {
        private readonly Form_Main main;
        public Cls_PageManager(Form_Main main)
        {
            this.main = main;
        }
        public void LoadPage(UserControl PageUserControl)
        {
            //==>  Load old page
            var oldpage = main.panelContainer.Controls.OfType<UserControl>().FirstOrDefault();
            if (oldpage != null)
            {
                main.panelContainer.Controls.Remove(oldpage);
                //==> Remove To memory 
                oldpage.Dispose();
            }
            //==> Load New Page
            PageUserControl.Dock = DockStyle.Fill;
            main.panelContainer.Controls.Add(PageUserControl);
        }
    }
}
