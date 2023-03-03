
namespace SabreenCompany.Forms.FormsSettings
{
    partial class Form_Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanelSettings = new System.Windows.Forms.FlowLayoutPanel();
            this.BTN_Settings_Account = new System.Windows.Forms.Button();
            this.BTN_Settings_Backup = new System.Windows.Forms.Button();
            this.BTN_Settings_Restore_Backup = new System.Windows.Forms.Button();
            this.panelContainerSettings = new System.Windows.Forms.Panel();
            this.flowLayoutPanelSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelSettings
            // 
            this.flowLayoutPanelSettings.AutoScroll = true;
            this.flowLayoutPanelSettings.BackColor = System.Drawing.Color.Indigo;
            this.flowLayoutPanelSettings.Controls.Add(this.BTN_Settings_Account);
            this.flowLayoutPanelSettings.Controls.Add(this.BTN_Settings_Backup);
            this.flowLayoutPanelSettings.Controls.Add(this.BTN_Settings_Restore_Backup);
            this.flowLayoutPanelSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanelSettings.Location = new System.Drawing.Point(0, 552);
            this.flowLayoutPanelSettings.Name = "flowLayoutPanelSettings";
            this.flowLayoutPanelSettings.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanelSettings.Size = new System.Drawing.Size(791, 73);
            this.flowLayoutPanelSettings.TabIndex = 1;
            // 
            // BTN_Settings_Account
            // 
            this.BTN_Settings_Account.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(220)))), ((int)(((byte)(229)))));
            this.BTN_Settings_Account.Image = global::SabreenCompany.Properties.Resources.icons8_Admin_Settings_Male_32px;
            this.BTN_Settings_Account.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Settings_Account.Location = new System.Drawing.Point(527, 8);
            this.BTN_Settings_Account.Name = "BTN_Settings_Account";
            this.BTN_Settings_Account.Size = new System.Drawing.Size(251, 55);
            this.BTN_Settings_Account.TabIndex = 0;
            this.BTN_Settings_Account.Text = "اعدادات الحساب";
            this.BTN_Settings_Account.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Settings_Account.UseVisualStyleBackColor = false;
            this.BTN_Settings_Account.Click += new System.EventHandler(this.BTN_Settings_Account_Click);
            // 
            // BTN_Settings_Backup
            // 
            this.BTN_Settings_Backup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(220)))), ((int)(((byte)(229)))));
            this.BTN_Settings_Backup.Image = global::SabreenCompany.Properties.Resources.icons8_database_restore_32px;
            this.BTN_Settings_Backup.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Settings_Backup.Location = new System.Drawing.Point(270, 8);
            this.BTN_Settings_Backup.Name = "BTN_Settings_Backup";
            this.BTN_Settings_Backup.Size = new System.Drawing.Size(251, 55);
            this.BTN_Settings_Backup.TabIndex = 1;
            this.BTN_Settings_Backup.Text = "نسخة احتياطية";
            this.BTN_Settings_Backup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Settings_Backup.UseVisualStyleBackColor = false;
            this.BTN_Settings_Backup.Click += new System.EventHandler(this.BTN_Settings_Backup_Click);
            // 
            // BTN_Settings_Restore_Backup
            // 
            this.BTN_Settings_Restore_Backup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(220)))), ((int)(((byte)(229)))));
            this.BTN_Settings_Restore_Backup.Image = global::SabreenCompany.Properties.Resources.icons8_data_backup_32px_1;
            this.BTN_Settings_Restore_Backup.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Settings_Restore_Backup.Location = new System.Drawing.Point(13, 8);
            this.BTN_Settings_Restore_Backup.Name = "BTN_Settings_Restore_Backup";
            this.BTN_Settings_Restore_Backup.Size = new System.Drawing.Size(251, 55);
            this.BTN_Settings_Restore_Backup.TabIndex = 2;
            this.BTN_Settings_Restore_Backup.Text = "استعادة نسخة احتياطية";
            this.BTN_Settings_Restore_Backup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Settings_Restore_Backup.UseVisualStyleBackColor = false;
            this.BTN_Settings_Restore_Backup.Click += new System.EventHandler(this.BTN_Settings_Restore_Backup_Click);
            // 
            // panelContainerSettings
            // 
            this.panelContainerSettings.BackColor = System.Drawing.SystemColors.Control;
            this.panelContainerSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainerSettings.Location = new System.Drawing.Point(0, 0);
            this.panelContainerSettings.Name = "panelContainerSettings";
            this.panelContainerSettings.Size = new System.Drawing.Size(791, 552);
            this.panelContainerSettings.TabIndex = 2;
            // 
            // Form_Settings
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 625);
            this.Controls.Add(this.panelContainerSettings);
            this.Controls.Add(this.flowLayoutPanelSettings);
            this.Font = new System.Drawing.Font("Cairo", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Settings";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الإعدادت";
            this.flowLayoutPanelSettings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSettings;
        private System.Windows.Forms.Button BTN_Settings_Account;
        private System.Windows.Forms.Button BTN_Settings_Backup;
        private System.Windows.Forms.Button BTN_Settings_Restore_Backup;
        public System.Windows.Forms.Panel panelContainerSettings;
    }
}