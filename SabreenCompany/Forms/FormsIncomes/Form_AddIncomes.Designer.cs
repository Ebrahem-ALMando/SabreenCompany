
namespace SabreenCompany.Forms.FormsIncomes
{
    partial class Form_AddIncomes
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
            this.label8 = new System.Windows.Forms.Label();
            this.TX_RemainingAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TX_AmountReceived = new System.Windows.Forms.TextBox();
            this.TX_TotalAmount = new System.Windows.Forms.TextBox();
            this.dateTimePicker_Income = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.COMP_NameCustomer = new System.Windows.Forms.ComboBox();
            this.COMP_IdInvoice = new System.Windows.Forms.ComboBox();
            this.TX_AmountReceived_Income = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.TX_RemainingAmount);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TX_AmountReceived);
            this.groupBox1.Controls.Add(this.TX_TotalAmount);
            this.groupBox1.Controls.Add(this.dateTimePicker_Income);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.COMP_NameCustomer);
            this.groupBox1.Controls.Add(this.COMP_IdInvoice);
            this.groupBox1.Controls.Add(this.TX_AmountReceived_Income);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Indigo;
            this.groupBox1.Location = new System.Drawing.Point(18, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 540);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "معلومات الايراد";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(200, 435);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 37);
            this.label8.TabIndex = 54;
            this.label8.Text = "المبلغ الواصل";
            // 
            // TX_RemainingAmount
            // 
            this.TX_RemainingAmount.Enabled = false;
            this.TX_RemainingAmount.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TX_RemainingAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(93)))), ((int)(((byte)(255)))));
            this.TX_RemainingAmount.Location = new System.Drawing.Point(11, 475);
            this.TX_RemainingAmount.Name = "TX_RemainingAmount";
            this.TX_RemainingAmount.Size = new System.Drawing.Size(127, 45);
            this.TX_RemainingAmount.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(8, 435);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 37);
            this.label5.TabIndex = 52;
            this.label5.Text = "المبلغ المتبقي";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(209, 435);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 37);
            this.label6.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(376, 434);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 37);
            this.label7.TabIndex = 50;
            this.label7.Text = "المبلغ الاجمالي ";
            // 
            // TX_AmountReceived
            // 
            this.TX_AmountReceived.Enabled = false;
            this.TX_AmountReceived.Location = new System.Drawing.Point(200, 475);
            this.TX_AmountReceived.Name = "TX_AmountReceived";
            this.TX_AmountReceived.Size = new System.Drawing.Size(127, 45);
            this.TX_AmountReceived.TabIndex = 49;
            // 
            // TX_TotalAmount
            // 
            this.TX_TotalAmount.Enabled = false;
            this.TX_TotalAmount.Location = new System.Drawing.Point(387, 475);
            this.TX_TotalAmount.Name = "TX_TotalAmount";
            this.TX_TotalAmount.Size = new System.Drawing.Size(127, 45);
            this.TX_TotalAmount.TabIndex = 48;
            // 
            // dateTimePicker_Income
            // 
            this.dateTimePicker_Income.CustomFormat = "";
            this.dateTimePicker_Income.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_Income.Location = new System.Drawing.Point(17, 276);
            this.dateTimePicker_Income.Name = "dateTimePicker_Income";
            this.dateTimePicker_Income.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimePicker_Income.Size = new System.Drawing.Size(503, 45);
            this.dateTimePicker_Income.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 37);
            this.label2.TabIndex = 8;
            this.label2.Text = "التاريخ";
            // 
            // COMP_NameCustomer
            // 
            this.COMP_NameCustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.COMP_NameCustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.COMP_NameCustomer.BackColor = System.Drawing.SystemColors.Window;
            this.COMP_NameCustomer.DropDownHeight = 170;
            this.COMP_NameCustomer.FormattingEnabled = true;
            this.COMP_NameCustomer.IntegralHeight = false;
            this.COMP_NameCustomer.Location = new System.Drawing.Point(17, 67);
            this.COMP_NameCustomer.MaxDropDownItems = 5;
            this.COMP_NameCustomer.Name = "COMP_NameCustomer";
            this.COMP_NameCustomer.Size = new System.Drawing.Size(503, 45);
            this.COMP_NameCustomer.TabIndex = 40;
            this.COMP_NameCustomer.SelectedIndexChanged += new System.EventHandler(this.COMP_NameCustomer_SelectedIndexChanged);
            // 
            // COMP_IdInvoice
            // 
            this.COMP_IdInvoice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.COMP_IdInvoice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.COMP_IdInvoice.BackColor = System.Drawing.SystemColors.Window;
            this.COMP_IdInvoice.DropDownHeight = 170;
            this.COMP_IdInvoice.FormattingEnabled = true;
            this.COMP_IdInvoice.IntegralHeight = false;
            this.COMP_IdInvoice.Location = new System.Drawing.Point(17, 174);
            this.COMP_IdInvoice.MaxDropDownItems = 5;
            this.COMP_IdInvoice.Name = "COMP_IdInvoice";
            this.COMP_IdInvoice.Size = new System.Drawing.Size(503, 45);
            this.COMP_IdInvoice.TabIndex = 13;
            this.COMP_IdInvoice.SelectedIndexChanged += new System.EventHandler(this.COMP_IdInvoice_SelectedIndexChanged);
            // 
            // TX_AmountReceived_Income
            // 
            this.TX_AmountReceived_Income.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TX_AmountReceived_Income.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(93)))), ((int)(((byte)(255)))));
            this.TX_AmountReceived_Income.Location = new System.Drawing.Point(17, 383);
            this.TX_AmountReceived_Income.Name = "TX_AmountReceived_Income";
            this.TX_AmountReceived_Income.Size = new System.Drawing.Size(503, 45);
            this.TX_AmountReceived_Income.TabIndex = 21;
            this.TX_AmountReceived_Income.TextChanged += new System.EventHandler(this.TX_AmountReceived_Income_TextChanged);
            this.TX_AmountReceived_Income.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TX_AmountReceived_Income_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(200, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 37);
            this.label3.TabIndex = 20;
            this.label3.Text = "المبلغ المقبوض";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 37);
            this.label4.TabIndex = 12;
            this.label4.Text = "رقم الفاتورة";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 22);
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
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 569);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 3, 6, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5, 5, 30, 5);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(598, 82);
            this.flowLayoutPanel1.TabIndex = 7;
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
            // 
            // Form_AddIncomes
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 651);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Cairo", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.Image = global::SabreenCompany.Properties.Resources.icons8_sales_performance_32px;
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_AddIncomes";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة/تعديل ايراد";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox COMP_NameCustomer;
        private System.Windows.Forms.ComboBox COMP_IdInvoice;
        private System.Windows.Forms.TextBox TX_AmountReceived_Income;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button BTN_Save;
        private System.Windows.Forms.Button BTN_Save_Close;
        private System.Windows.Forms.Button BTN_Close;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Income;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TX_RemainingAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TX_AmountReceived;
        private System.Windows.Forms.TextBox TX_TotalAmount;
    }
}