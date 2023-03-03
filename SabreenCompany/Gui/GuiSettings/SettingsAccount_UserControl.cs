using SabreenCompany.Classes;
using SabreenCompany.Classes.Connection.SettingsProcess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SabreenCompany.Gui.GuiSettings
{
    public partial class SettingsAccount_UserControl : UserControl
    {    //==> Var Info To Update 
        #region Variables
        private string userName = "", password = "";
        private int id = 0;
        private static SettingsAccount_UserControl settingsAccount_User;
        Cls_SettingsDB action = new Cls_SettingsDB();
        #endregion
        //<============================================>
        //<============================================>
        //<============================================>
        public SettingsAccount_UserControl()
        {
            InitializeComponent();
            getData();
        }
        #region Method
        private void getData()
        {
            if (id == 0 && userName == "" && password == "")
            {
                id = Convert.ToInt32(action.getDataUser(DataUser.userName).Rows[0][0]);
                userName = action.getDataUser(DataUser.userName).Rows[0][1].ToString();
                password = action.getDataUser(DataUser.userName).Rows[0][2].ToString();
            }
            loadData();
        }
        private void loadData()
        {
            TX_Name_User.Text = userName;
        }
        private void clearField()
        {
            TX_Last_Password.Clear();
            TX_New_Password.Clear();
            pictureBoxCheckPassword.Visible = false;
        }
        private void checkPassword()
        {
            if (TX_Last_Password.Text == "")
            {
                TX_New_Password.Enabled = false;
                TX_New_Password.Clear();
                pictureBoxCheckPassword.Visible = false;
            }
            else if (TX_Last_Password.Text == password)
            {
                TX_New_Password.Enabled = true;
                pictureBoxCheckPassword.Visible = true;
                pictureBoxCheckPassword.Image = Properties.Resources.icons8_Checkmark_32px_1;

            }
            else
            {
                TX_New_Password.Enabled = false;
                pictureBoxCheckPassword.Visible = true;
                pictureBoxCheckPassword.Image = Properties.Resources.icons8_cancel_32px_2;
                TX_New_Password.Clear();
            }
        }
        private void updatePasswordData()
        {
            if (TX_New_Password.Text == "" || TX_Last_Password.Text == "")
            {
                ClsMessageCollections.showEmptyMessageData();
            }
            else
            {
                if (TX_New_Password.Text.Length < 8)
                {
                    ClsMessageCollections.showWarningInputlesslengthPasswordMessage();
                }
                else
                {
                    if (TX_New_Password.Text == password)
                    {
                        ClsMessageCollections.showWarningInputAlreadyPasswordMessage();
                    }
                    else
                    {
                        if (ClsMessageCollections.showQuitionUpdateMessageData() == DialogResult.OK)
                        {
                            action.updateUserPassword(id, TX_New_Password.Text);
                            password = TX_New_Password.Text;
                            ClsMessageCollections.showSuccessUpdateMessageData();
                            clearField();
                        }
                    }
                }

            }
        }
        public static SettingsAccount_UserControl Instance()
        {
            //==> Freeing resources and not cloning more than once
            return settingsAccount_User ?? (new SettingsAccount_UserControl());
        }
        #endregion
        #region Event
        private void TX_Last_Password_TextChanged(object sender, EventArgs e)
        {
            checkPassword();
        }
        private void BTN_Save_Click(object sender, EventArgs e)
        {
            updatePasswordData();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Date.Text = DateTime.Now.ToString("d/MM/yyyy");
        }
        #endregion
    }
}
