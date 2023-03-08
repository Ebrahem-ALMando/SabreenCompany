using DevExpress.XtraEditors;
using SabreenCompany.Classes.Home;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SabreenCompany.Forms.FormsSettings
{
    public partial class Form_Settings : DevExpress.XtraEditors.XtraForm
    {
        private readonly Cls_PageManager pageManager;
        public Form_Settings()
        {
            InitializeComponent();
            pageManager = new Cls_PageManager(this);
            //==> Load Defulat Settings Account page
            pageManager.LoadPageSettings(Gui.GuiSettings.SettingsAccount_UserControl.Instance());
        }
        #region Event
        private void BTN_Settings_Account_Click(object sender, EventArgs e)
        {
            pageManager.LoadPageSettings(Gui.GuiSettings.SettingsAccount_UserControl.Instance());
        }
        private void BTN_Settings_Backup_Click(object sender, EventArgs e)
        {
            pageManager.LoadPageSettings(Gui.GuiSettings.BackupdData_UserControl.Instance());

        }
        private void BTN_Settings_Restore_Backup_Click(object sender, EventArgs e)
        {
            pageManager.LoadPageSettings(Gui.GuiSettings.RestorebackupDataUserControl.Instance());
        }
        #endregion
    }
}