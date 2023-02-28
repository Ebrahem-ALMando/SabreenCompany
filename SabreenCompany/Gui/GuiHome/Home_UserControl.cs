using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SabreenCompany.Gui.GuiHome
{
    public partial class Home_UserControl : UserControl
    {
        private  static Home_UserControl homeUserControl;
        static String userName = "";
    
        public Home_UserControl()
        {
            InitializeComponent();
            {
                if (userName == "ebrahem-m")
                {
                   
                    LBL_Wellcome.Text = LBL_Wellcome.Text + "ابراهيم";
                }
                else if (userName == "omar")
                {
                  
                    LBL_Wellcome.Text = LBL_Wellcome.Text + "عمر";

                }
                else
                {
                  
                    LBL_Wellcome.Text = LBL_Wellcome.Text + userName;
                }

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            /*time_now.Text = DateTime.Now.ToString("h:mm:ss ");*/
            Date.Text = DateTime.Now.ToString("d/MM/yyyy");
        }
        public static Home_UserControl Instance(String userName_)
        {
           userName = userName_;
            //==> Freeing resources and not cloning more than once
            return homeUserControl ?? (new Home_UserControl());
        }
    }
}
