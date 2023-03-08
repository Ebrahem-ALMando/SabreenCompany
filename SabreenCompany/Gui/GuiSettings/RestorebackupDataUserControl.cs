using SabreenCompany.Classes;
using SabreenCompany.Forms.FormsSettings;
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
    public partial class RestorebackupDataUserControl : UserControl
    {
    
        SqlConnection connection = new SqlConnection(@"server=.\EBRAHEMSQLSERVER;database=master; integrated security = true; ");
        SqlCommand cmd;
        OpenFileDialog openFile;
        private static   RestorebackupDataUserControl restorebackupDataUserControl;
        public RestorebackupDataUserControl()
        {
            InitializeComponent();
        }
        public static RestorebackupDataUserControl Instance()
        {
            //==> Freeing resources and not cloning more than once
            return restorebackupDataUserControl ?? (new RestorebackupDataUserControl());
        }
        private void restoreBackupDatabase()
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

                    string textQuery = @"Alter database Sabreen_DB Set Offline with Rollback Immediate;
                                         restore Database Sabreen_DB from Disk='" + TX_FileName.Text + "'WITH REPLACE";
                    cmd = new SqlCommand(textQuery, connection);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    TX_FileName.Clear();
              
                    ClsMessageCollections.showSuccessRestoreBackupData();
             
                    progressPanelLoading.Visible = false;

                }

            }
            catch (Exception ex)
            {
                progressPanelLoading.Hide();
                progressPanelLoading.Visible = false;
                connection.Close();
                MessageBox.Show(ex.Message);
            }

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Date.Text = DateTime.Now.ToString("d/MM/yyyy");
        }

        private void BTN_SelectPath_Click(object sender, EventArgs e)
        {
            try
            {
                openFile = new OpenFileDialog();

                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    TX_FileName.Text = openFile.FileName;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }

        private void BTN_Save_Click(object sender, EventArgs e)
        {
          
            restoreBackupDatabase();
      
        }
    }
}
