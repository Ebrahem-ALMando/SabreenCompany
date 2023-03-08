using SabreenCompany.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SabreenCompany.Gui.GuiSettings
{   
    public partial class BackupdData_UserControl : UserControl
    {
        SqlConnection connection =new SqlConnection( @"server=.\EBRAHEMSQLSERVER;database=Sabreen_DB; integrated security = true; ");
        SqlCommand cmd;
        private static BackupdData_UserControl backupdData_User;
        FolderBrowserDialog folder;
        public BackupdData_UserControl()
        {
            InitializeComponent();
         
        }
        //==>  Save To Backup Data
        private  void saveBackupDatabase()
        {
            try
            {
                if (TX_FileName.Text == "")
                {
                    ClsMessageCollections.showWarningInputPathBackupMessage();
                }
                else
                {
                    progressPanelLoading.Visible = true;
                    string fileName = TX_FileName.Text + "\\Sabreen_DB-" + DateTime.Now.ToShortDateString().Replace('/', '-')
                     + " - " + DateTime.Now.ToLongTimeString().Replace(':', '-');
                    string textQuery = "backup database Sabreen_DB to disk='" + fileName + ".bak'";
                    cmd = new SqlCommand(textQuery, connection);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    TX_FileName.Clear();
                    ClsMessageCollections.showSuccessSaveBackupData();
                    progressPanelLoading.Visible = false;
                }
        
            }
            catch(Exception ex)
            {
                progressPanelLoading.Hide();
                progressPanelLoading.Visible = false;
                connection.Close();
                ClsMessageCollections.showErroeSaveBackupIn_C_DiskMessage();
            }
     

        }
        public static BackupdData_UserControl Instance()
        {
            //==> Freeing resources and not cloning more than once
            return backupdData_User ?? (new BackupdData_UserControl());
        }
        private void BTN_SelectPath_Click(object sender, EventArgs e)
        {
            try
            {
                folder = new FolderBrowserDialog();
                
                if (folder.ShowDialog() == DialogResult.OK)
                {
                    TX_FileName.Text = folder.SelectedPath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Date.Text = DateTime.Now.ToString("d/MM/yyyy");
        }
        private void BTN_Save_Click(object sender, EventArgs e)
        {
            saveBackupDatabase();
        }

    }
}
