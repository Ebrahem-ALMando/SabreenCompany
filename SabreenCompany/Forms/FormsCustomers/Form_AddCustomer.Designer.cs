
namespace SabreenCompany.Forms.FormsCustomers
{
    partial class Form_AddCustomer
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TX_Locition_Customer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TX_Phone_Customer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TX_Name_Customer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.BTN_Save = new System.Windows.Forms.Button();
            this.BTN_Save_Close = new System.Windows.Forms.Button();
            this.BTN_Close = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TX_Locition_Customer);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TX_Phone_Customer);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TX_Name_Customer);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Indigo;
            this.groupBox1.Location = new System.Drawing.Point(12, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 514);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "معلومات الزبون";
            // 
            // TX_Locition_Customer
            // 
            this.TX_Locition_Customer.Location = new System.Drawing.Point(17, 327);
            this.TX_Locition_Customer.Name = "TX_Locition_Customer";
            this.TX_Locition_Customer.Size = new System.Drawing.Size(503, 45);
            this.TX_Locition_Customer.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "موقع الزبون";
            // 
            // TX_Phone_Customer
            // 
            this.TX_Phone_Customer.Location = new System.Drawing.Point(17, 211);
            this.TX_Phone_Customer.Name = "TX_Phone_Customer";
            this.TX_Phone_Customer.Size = new System.Drawing.Size(503, 45);
            this.TX_Phone_Customer.TabIndex = 5;
            this.TX_Phone_Customer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TX_Phone_Customer_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "رقم الهاتف";
            // 
            // TX_Name_Customer
            // 
            this.TX_Name_Customer.Location = new System.Drawing.Point(17, 95);
            this.TX_Name_Customer.Name = "TX_Name_Customer";
            this.TX_Name_Customer.Size = new System.Drawing.Size(503, 45);
            this.TX_Name_Customer.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم الزبون";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(30)))), ((int)(((byte)(103)))));
            this.flowLayoutPanel1.Controls.Add(this.BTN_Save);
            this.flowLayoutPanel1.Controls.Add(this.BTN_Save_Close);
            this.flowLayoutPanel1.Controls.Add(this.BTN_Close);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 543);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 3, 6, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5, 5, 30, 5);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(598, 82);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // BTN_Save
            // 
            this.BTN_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(220)))), ((int)(((byte)(229)))));
            this.BTN_Save.ForeColor = System.Drawing.Color.Indigo;
            this.BTN_Save.Image = global::SabreenCompany.Properties.Resources.icons8_save_32px_1;
            this.BTN_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Save.Location = new System.Drawing.Point(393, 10);
            this.BTN_Save.Margin = new System.Windows.Forms.Padding(5);
            this.BTN_Save.Name = "BTN_Save";
            this.BTN_Save.Size = new System.Drawing.Size(165, 55);
            this.BTN_Save.TabIndex = 2;
            this.BTN_Save.Text = "حفظ";
            this.BTN_Save.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Save.UseVisualStyleBackColor = false;
            this.BTN_Save.Click += new System.EventHandler(this.BTN_Save_Click);
            // 
            // BTN_Save_Close
            // 
            this.BTN_Save_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(220)))), ((int)(((byte)(229)))));
            this.BTN_Save_Close.ForeColor = System.Drawing.Color.Indigo;
            this.BTN_Save_Close.Image = global::SabreenCompany.Properties.Resources.icons8_save_32px;
            this.BTN_Save_Close.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Save_Close.Location = new System.Drawing.Point(218, 10);
            this.BTN_Save_Close.Margin = new System.Windows.Forms.Padding(5);
            this.BTN_Save_Close.Name = "BTN_Save_Close";
            this.BTN_Save_Close.Size = new System.Drawing.Size(165, 55);
            this.BTN_Save_Close.TabIndex = 3;
            this.BTN_Save_Close.Text = "حفظ وإغلاق";
            this.BTN_Save_Close.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Save_Close.UseVisualStyleBackColor = false;
            this.BTN_Save_Close.Click += new System.EventHandler(this.BTN_Save_Close_Click);
            // 
            // BTN_Close
            // 
            this.BTN_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(220)))), ((int)(((byte)(229)))));
            this.BTN_Close.ForeColor = System.Drawing.Color.Indigo;
            this.BTN_Close.Image = global::SabreenCompany.Properties.Resources.icons8_circled_x_32px;
            this.BTN_Close.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Close.Location = new System.Drawing.Point(43, 10);
            this.BTN_Close.Margin = new System.Windows.Forms.Padding(5);
            this.BTN_Close.Name = "BTN_Close";
            this.BTN_Close.Size = new System.Drawing.Size(165, 55);
            this.BTN_Close.TabIndex = 4;
            this.BTN_Close.Text = "إغلاق";
            this.BTN_Close.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Close.UseVisualStyleBackColor = false;
            this.BTN_Close.Click += new System.EventHandler(this.BTN_Close_Click);
            // 
            // Form_AddCustomer
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 625);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Cairo", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_AddCustomer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة /تعديل زبون";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TX_Locition_Customer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TX_Phone_Customer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TX_Name_Customer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button BTN_Save;
        private System.Windows.Forms.Button BTN_Save_Close;
        private System.Windows.Forms.Button BTN_Close;
    }
}