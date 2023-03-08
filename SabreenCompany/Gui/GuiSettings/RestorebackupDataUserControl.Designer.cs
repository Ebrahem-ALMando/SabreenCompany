
namespace SabreenCompany.Gui.GuiSettings
{
    partial class RestorebackupDataUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progressPanelLoading = new DevExpress.XtraWaitForm.ProgressPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_SelectPath = new System.Windows.Forms.Button();
            this.TX_FileName = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.BTN_Save = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Date = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.progressPanelLoading);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BTN_SelectPath);
            this.groupBox1.Controls.Add(this.TX_FileName);
            this.groupBox1.ForeColor = System.Drawing.Color.Indigo;
            this.groupBox1.Location = new System.Drawing.Point(30, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(710, 372);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "معلومات النسخة الاحتياطية";
            // 
            // progressPanelLoading
            // 
            this.progressPanelLoading.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.progressPanelLoading.Appearance.Font = new System.Drawing.Font("Cairo", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressPanelLoading.Appearance.Options.UseBackColor = true;
            this.progressPanelLoading.Appearance.Options.UseFont = true;
            this.progressPanelLoading.AppearanceCaption.Font = new System.Drawing.Font("Cairo", 12F);
            this.progressPanelLoading.AppearanceCaption.Options.UseFont = true;
            this.progressPanelLoading.AppearanceDescription.Font = new System.Drawing.Font("Cairo", 12F);
            this.progressPanelLoading.AppearanceDescription.Options.UseFont = true;
            this.progressPanelLoading.Caption = "يتم الان استعادة النسخة الاحتياطية";
            this.progressPanelLoading.Description = " استغفر الله ريثما يتم الانتهاء";
            this.progressPanelLoading.Location = new System.Drawing.Point(192, 258);
            this.progressPanelLoading.Name = "progressPanelLoading";
            this.progressPanelLoading.Size = new System.Drawing.Size(345, 93);
            this.progressPanelLoading.TabIndex = 21;
            this.progressPanelLoading.Text = "progressPanel1";
            this.progressPanelLoading.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(315, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 37);
            this.label1.TabIndex = 20;
            this.label1.Text = "يرجى تحديد مسار النسخة الاحتياطية لإستعادتها";
            // 
            // BTN_SelectPath
            // 
            this.BTN_SelectPath.BackColor = System.Drawing.Color.Indigo;
            this.BTN_SelectPath.FlatAppearance.BorderSize = 0;
            this.BTN_SelectPath.Font = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_SelectPath.ForeColor = System.Drawing.Color.White;
            this.BTN_SelectPath.Image = global::SabreenCompany.Properties.Resources.icons8_Download_From_Cloud_32px;
            this.BTN_SelectPath.Location = new System.Drawing.Point(36, 174);
            this.BTN_SelectPath.Margin = new System.Windows.Forms.Padding(5);
            this.BTN_SelectPath.Name = "BTN_SelectPath";
            this.BTN_SelectPath.Size = new System.Drawing.Size(155, 50);
            this.BTN_SelectPath.TabIndex = 4;
            this.BTN_SelectPath.UseVisualStyleBackColor = false;
            this.BTN_SelectPath.Click += new System.EventHandler(this.BTN_SelectPath_Click);
            // 
            // TX_FileName
            // 
            this.TX_FileName.Enabled = false;
            this.TX_FileName.Location = new System.Drawing.Point(192, 177);
            this.TX_FileName.Name = "TX_FileName";
            this.TX_FileName.Size = new System.Drawing.Size(512, 45);
            this.TX_FileName.TabIndex = 19;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(30)))), ((int)(((byte)(103)))));
            this.flowLayoutPanel1.Controls.Add(this.BTN_Save);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 55);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(791, 73);
            this.flowLayoutPanel1.TabIndex = 21;
            // 
            // BTN_Save
            // 
            this.BTN_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(220)))), ((int)(((byte)(229)))));
            this.BTN_Save.ForeColor = System.Drawing.Color.Indigo;
            this.BTN_Save.Image = global::SabreenCompany.Properties.Resources.icons8_data_backup_32px_1;
            this.BTN_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Save.Location = new System.Drawing.Point(499, 10);
            this.BTN_Save.Margin = new System.Windows.Forms.Padding(5);
            this.BTN_Save.Name = "BTN_Save";
            this.BTN_Save.Size = new System.Drawing.Size(277, 55);
            this.BTN_Save.TabIndex = 3;
            this.BTN_Save.Text = "استعادة النسخة الاحتياطية";
            this.BTN_Save.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Save.UseVisualStyleBackColor = false;
            this.BTN_Save.Click += new System.EventHandler(this.BTN_Save_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Indigo;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.Date);
            this.panel3.Controls.Add(this.pictureBox5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(791, 55);
            this.panel3.TabIndex = 20;
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Dock = System.Windows.Forms.DockStyle.Right;
            this.Date.Font = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.ForeColor = System.Drawing.Color.LavenderBlush;
            this.Date.Location = new System.Drawing.Point(674, 0);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(115, 45);
            this.Date.TabIndex = 9;
            this.Date.Text = "DateHear";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox5.Image = global::SabreenCompany.Properties.Resources.النسخ_الاحتياطي;
            this.pictureBox5.Location = new System.Drawing.Point(272, -37);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(237, 128);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // RestorebackupDataUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Cairo", 12F);
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.Name = "RestorebackupDataUserControl";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(791, 552);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraWaitForm.ProgressPanel progressPanelLoading;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_SelectPath;
        private System.Windows.Forms.TextBox TX_FileName;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button BTN_Save;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Timer timer1;
    }
}
