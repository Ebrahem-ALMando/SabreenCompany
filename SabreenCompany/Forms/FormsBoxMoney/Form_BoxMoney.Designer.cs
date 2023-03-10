
namespace SabreenCompany.Forms.FormsBoxMoney
{
    partial class Form_BoxMoney
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BoxMoney));
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Date = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LBL_TotalAmount = new System.Windows.Forms.Label();
            this.TX_TotalAmountProcess = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TX_TotalAmount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.flowLayoutPanelSettings = new System.Windows.Forms.FlowLayoutPanel();
            this.BTN_Withdrawal = new System.Windows.Forms.Button();
            this.BTN_Deposit = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanelSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(436, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
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
            this.panel3.Size = new System.Drawing.Size(679, 55);
            this.panel3.TabIndex = 12;
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Dock = System.Windows.Forms.DockStyle.Right;
            this.Date.Font = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.ForeColor = System.Drawing.Color.LavenderBlush;
            this.Date.Location = new System.Drawing.Point(562, 0);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(115, 45);
            this.Date.TabIndex = 9;
            this.Date.Text = "DateHear";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox5.Image = global::SabreenCompany.Properties.Resources.الصندوق;
            this.pictureBox5.Location = new System.Drawing.Point(254, -12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(130, 76);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LBL_TotalAmount);
            this.groupBox1.Controls.Add(this.TX_TotalAmountProcess);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TX_TotalAmount);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.ForeColor = System.Drawing.Color.Indigo;
            this.groupBox1.Location = new System.Drawing.Point(45, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 366);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "معلومات الصندوق";
            // 
            // LBL_TotalAmount
            // 
            this.LBL_TotalAmount.AutoSize = true;
            this.LBL_TotalAmount.ForeColor = System.Drawing.Color.Crimson;
            this.LBL_TotalAmount.Location = new System.Drawing.Point(233, 115);
            this.LBL_TotalAmount.Name = "LBL_TotalAmount";
            this.LBL_TotalAmount.Size = new System.Drawing.Size(71, 37);
            this.LBL_TotalAmount.TabIndex = 22;
            this.LBL_TotalAmount.Text = "المبلغ ";
            // 
            // TX_TotalAmountProcess
            // 
            this.TX_TotalAmountProcess.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TX_TotalAmountProcess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(93)))), ((int)(((byte)(255)))));
            this.TX_TotalAmountProcess.Location = new System.Drawing.Point(17, 277);
            this.TX_TotalAmountProcess.Name = "TX_TotalAmountProcess";
            this.TX_TotalAmountProcess.Size = new System.Drawing.Size(503, 45);
            this.TX_TotalAmountProcess.TabIndex = 21;
            this.TX_TotalAmountProcess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TX_TotalAmountProcess.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TX_TotalAmountProcess_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(233, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 37);
            this.label3.TabIndex = 20;
            this.label3.Text = "المبلغ ";
            // 
            // TX_TotalAmount
            // 
            this.TX_TotalAmount.ForeColor = System.Drawing.Color.Crimson;
            this.TX_TotalAmount.Location = new System.Drawing.Point(17, 112);
            this.TX_TotalAmount.Name = "TX_TotalAmount";
            this.TX_TotalAmount.ReadOnly = true;
            this.TX_TotalAmount.Size = new System.Drawing.Size(503, 45);
            this.TX_TotalAmount.TabIndex = 1;
            this.TX_TotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(208, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 37);
            this.label8.TabIndex = 0;
            this.label8.Text = "الرصيد الحالي";
            // 
            // flowLayoutPanelSettings
            // 
            this.flowLayoutPanelSettings.AutoScroll = true;
            this.flowLayoutPanelSettings.BackColor = System.Drawing.Color.Indigo;
            this.flowLayoutPanelSettings.Controls.Add(this.BTN_Withdrawal);
            this.flowLayoutPanelSettings.Controls.Add(this.BTN_Deposit);
            this.flowLayoutPanelSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanelSettings.Location = new System.Drawing.Point(0, 490);
            this.flowLayoutPanelSettings.Name = "flowLayoutPanelSettings";
            this.flowLayoutPanelSettings.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanelSettings.Size = new System.Drawing.Size(679, 73);
            this.flowLayoutPanelSettings.TabIndex = 14;
            // 
            // BTN_Withdrawal
            // 
            this.BTN_Withdrawal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(220)))), ((int)(((byte)(229)))));
            this.BTN_Withdrawal.Image = global::SabreenCompany.Properties.Resources.icons8_Withdrawal_32px_1;
            this.BTN_Withdrawal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Withdrawal.Location = new System.Drawing.Point(345, 8);
            this.BTN_Withdrawal.Margin = new System.Windows.Forms.Padding(170, 3, 20, 3);
            this.BTN_Withdrawal.Name = "BTN_Withdrawal";
            this.BTN_Withdrawal.Size = new System.Drawing.Size(154, 55);
            this.BTN_Withdrawal.TabIndex = 0;
            this.BTN_Withdrawal.Text = "سحب";
            this.BTN_Withdrawal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Withdrawal.UseVisualStyleBackColor = false;
            this.BTN_Withdrawal.Click += new System.EventHandler(this.BTN_Withdrawal_Click);
            // 
            // BTN_Deposit
            // 
            this.BTN_Deposit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(220)))), ((int)(((byte)(229)))));
            this.BTN_Deposit.Image = global::SabreenCompany.Properties.Resources.icons8_deposit_32px;
            this.BTN_Deposit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Deposit.Location = new System.Drawing.Point(168, 8);
            this.BTN_Deposit.Name = "BTN_Deposit";
            this.BTN_Deposit.Size = new System.Drawing.Size(154, 55);
            this.BTN_Deposit.TabIndex = 1;
            this.BTN_Deposit.Text = "ايداع";
            this.BTN_Deposit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Deposit.UseVisualStyleBackColor = false;
            this.BTN_Deposit.Click += new System.EventHandler(this.BTN_Deposit_Click);
            // 
            // Form_BoxMoney
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 563);
            this.Controls.Add(this.flowLayoutPanelSettings);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cairo", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.Image = global::SabreenCompany.Properties.Resources.icons8_money_bag_32px_3;
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Form_BoxMoney.IconOptions.LargeImage")));
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_BoxMoney";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الصندوق";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.flowLayoutPanelSettings.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TX_TotalAmountProcess;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TX_TotalAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSettings;
        private System.Windows.Forms.Button BTN_Withdrawal;
        private System.Windows.Forms.Button BTN_Deposit;
        private System.Windows.Forms.Label LBL_TotalAmount;
    }
}