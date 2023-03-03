using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using SabreenCompany.Classes.Connection.SettingsProcess;
using SabreenCompany.Classes.Login;
using SabreenCompany.Forms;

namespace SabreenCompany
{
    public partial class Form_Login : DevExpress.XtraEditors.XtraForm
    {
        private string userName = "";
        Guna2MessageDialog message = new Guna2MessageDialog();
        Cls_Login islogin = new Cls_Login();
        Form_Main main;
        public Form_Login()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void Wellcome_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private  void BTN_Login_Click(object sender, EventArgs e)
        {
            message.Buttons = MessageDialogButtons.OK;
            message.Style = MessageDialogStyle.Light;
            message.Icon = MessageDialogIcon.Warning;
            if (TX_UserName.Text == "" || TX_Password.Text == "")
            {
            
                message.Show("يرجى إدخال جميع البيانات\n ", "تنبيه");

            }else if (TX_Password.Text.Length < 8)
            {
                message.Show("كلمة المرور قصيرة جدا\n ", "تنبيه");
            }
            else
            {
                var isLogin = islogin.isLoogin(TX_UserName.Text, TX_Password.Text);
                if (isLogin)
                {
                    main = new Form_Main(userName);
                    this.Hide();
                    main.ShowDialog();
                    main.Dispose();

                }
                else
                {
                    message.Icon = MessageDialogIcon.Error;
                    message.Show("المعلومات خاطئة\n ");
                }
            }
        }
        private void guna2CustomCheckBox1_Click(object sender, EventArgs e)
        {
            if (TX_Password.UseSystemPasswordChar==false)
            {
                TX_Password.UseSystemPasswordChar = true;
            }
            else if(TX_Password.UseSystemPasswordChar == true)
            {
                TX_Password.UseSystemPasswordChar = false;
            }
        }
        private void TX_Password_Enter(object sender, EventArgs e)
        {
            if (TX_Password.Text== "")
            {
                TX_Password.UseSystemPasswordChar = true;
            }
        }
        private void TX_Password_Leave(object sender, EventArgs e)
        {
            if (TX_Password.Text == "")
            {
                TX_Password.UseSystemPasswordChar = false;
            }
           
        }
        private void TX_UserName_KeyPress(object sender, KeyPressEventArgs e)
        {

            message.Style = MessageDialogStyle.Light;
            message.Buttons = MessageDialogButtons.OK;
            message.Icon = MessageDialogIcon.Warning;
            if (e.KeyChar >= 'ا' && e.KeyChar <= 'ي')
            {
                e.Handled = true;

                message.Show(" لا يمكن ان يحتوي الاسم  " + "\n" + " محارف باللغة العربية\n   ", " تنبيه");

            }
            else
            {
                e.Handled = false;
            }
         
        }
        private void TX_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            message.Style = MessageDialogStyle.Light;
            message.Buttons = MessageDialogButtons.OK;
            message.Icon = MessageDialogIcon.Warning;
            if (e.KeyChar >= 'ا' && e.KeyChar <= 'ي')
            {
                e.Handled = true;
                message.Show(" لا يمكن ان تحتوي كلمة المرور " + "\n" + " محارف باللغة العربية\n   ", " تنبيه");


            }
            else
            {
                e.Handled = false;
            }
        }
        private void TX_UserName_TextChanged(object sender, EventArgs e)
        {
            userName = TX_UserName.Text;
            DataUser.userName = TX_UserName.Text;
        }
    }
}
