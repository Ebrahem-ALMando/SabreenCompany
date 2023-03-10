
namespace SabreenCompany.Forms.FormsInvoice
{
    partial class Form_AddInvoice
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.COM_Name_Cus_Inv = new System.Windows.Forms.ComboBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.BTN_UpdateProduct_Invoice = new System.Windows.Forms.Button();
            this.CheckBoxDiscount = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.TX_AmountReceived = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.COM_TypePayment = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TX_TotalAmountInvoice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewProductsInvoice = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LBL_CountProduct_Invoice = new System.Windows.Forms.Label();
            this.COM_Name_Product_Invoice = new System.Windows.Forms.ComboBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.BTN_DeleteProduct_Invoice = new System.Windows.Forms.Button();
            this.picturePhoto_Product = new System.Windows.Forms.PictureBox();
            this.TX_TotalAmount_Product = new System.Windows.Forms.TextBox();
            this.BTN_AddProduct_Invoice = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TX_Number_Product = new System.Windows.Forms.TextBox();
            this.TX_Price_Product = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.TX_Discount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.RI_Notes_Invoice = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RI_TypeProduct_Invoice = new System.Windows.Forms.RichTextBox();
            this.dateTimePicker_Invoic = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.BTN_Save = new System.Windows.Forms.Button();
            this.BTN_Save_Close = new System.Windows.Forms.Button();
            this.BTN_Close = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BTN_CloseControl = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductsInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePhoto_Product)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.COM_Name_Cus_Inv);
            this.groupBox1.Controls.Add(this.linkLabel2);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.RI_Notes_Invoice);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.RI_TypeProduct_Invoice);
            this.groupBox1.Controls.Add(this.dateTimePicker_Invoic);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.ForeColor = System.Drawing.Color.Indigo;
            this.groupBox1.Location = new System.Drawing.Point(12, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1633, 659);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "معلومات الفاتورة";
            // 
            // COM_Name_Cus_Inv
            // 
            this.COM_Name_Cus_Inv.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.COM_Name_Cus_Inv.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.COM_Name_Cus_Inv.BackColor = System.Drawing.SystemColors.Window;
            this.COM_Name_Cus_Inv.DropDownHeight = 170;
            this.COM_Name_Cus_Inv.FormattingEnabled = true;
            this.COM_Name_Cus_Inv.IntegralHeight = false;
            this.COM_Name_Cus_Inv.Location = new System.Drawing.Point(1226, 114);
            this.COM_Name_Cus_Inv.MaxDropDownItems = 5;
            this.COM_Name_Cus_Inv.Name = "COM_Name_Cus_Inv";
            this.COM_Name_Cus_Inv.Size = new System.Drawing.Size(385, 45);
            this.COM_Name_Cus_Inv.TabIndex = 28;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(1225, 81);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(55, 37);
            this.linkLabel2.TabIndex = 28;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "جديد";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.BTN_UpdateProduct_Invoice);
            this.groupBox2.Controls.Add(this.CheckBoxDiscount);
            this.groupBox2.Controls.Add(this.TX_AmountReceived);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.COM_TypePayment);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.TX_TotalAmountInvoice);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.LBL_CountProduct_Invoice);
            this.groupBox2.Controls.Add(this.COM_Name_Product_Invoice);
            this.groupBox2.Controls.Add(this.linkLabel1);
            this.groupBox2.Controls.Add(this.BTN_DeleteProduct_Invoice);
            this.groupBox2.Controls.Add(this.picturePhoto_Product);
            this.groupBox2.Controls.Add(this.TX_TotalAmount_Product);
            this.groupBox2.Controls.Add(this.BTN_AddProduct_Invoice);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.TX_Number_Product);
            this.groupBox2.Controls.Add(this.TX_Price_Product);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.TX_Discount);
            this.groupBox2.ForeColor = System.Drawing.Color.Indigo;
            this.groupBox2.Location = new System.Drawing.Point(22, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1179, 631);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "معلومات المنتج ";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.SystemColors.Window;
            this.label22.Font = new System.Drawing.Font("Cairo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Crimson;
            this.label22.Location = new System.Drawing.Point(710, 578);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(0, 32);
            this.label22.TabIndex = 50;
            this.label22.Visible = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Cairo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Crimson;
            this.label21.Location = new System.Drawing.Point(877, 274);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(275, 32);
            this.label21.TabIndex = 49;
            this.label21.Text = "الكمية المتاحة  في حال اهمال المنتج ";
            this.label21.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Crimson;
            this.label17.Location = new System.Drawing.Point(801, 226);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(25, 37);
            this.label17.TabIndex = 45;
            this.label17.Text = "*";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Crimson;
            this.label16.Location = new System.Drawing.Point(988, 226);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(25, 37);
            this.label16.TabIndex = 44;
            this.label16.Text = "*";
            // 
            // BTN_UpdateProduct_Invoice
            // 
            this.BTN_UpdateProduct_Invoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(220)))), ((int)(((byte)(229)))));
            this.BTN_UpdateProduct_Invoice.ForeColor = System.Drawing.Color.Indigo;
            this.BTN_UpdateProduct_Invoice.Image = global::SabreenCompany.Properties.Resources.icons8_Edit_32px;
            this.BTN_UpdateProduct_Invoice.Location = new System.Drawing.Point(936, 324);
            this.BTN_UpdateProduct_Invoice.Margin = new System.Windows.Forms.Padding(5);
            this.BTN_UpdateProduct_Invoice.Name = "BTN_UpdateProduct_Invoice";
            this.BTN_UpdateProduct_Invoice.Size = new System.Drawing.Size(98, 55);
            this.BTN_UpdateProduct_Invoice.TabIndex = 40;
            this.BTN_UpdateProduct_Invoice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_UpdateProduct_Invoice.UseVisualStyleBackColor = false;
            this.BTN_UpdateProduct_Invoice.Click += new System.EventHandler(this.BTN_UpdateProduct_Invoice_Click);
            // 
            // CheckBoxDiscount
            // 
            this.CheckBoxDiscount.CheckedState.BorderColor = System.Drawing.Color.Indigo;
            this.CheckBoxDiscount.CheckedState.BorderRadius = 2;
            this.CheckBoxDiscount.CheckedState.BorderThickness = 0;
            this.CheckBoxDiscount.CheckedState.FillColor = System.Drawing.Color.Indigo;
            this.CheckBoxDiscount.ForeColor = System.Drawing.Color.Indigo;
            this.CheckBoxDiscount.Location = new System.Drawing.Point(1131, 429);
            this.CheckBoxDiscount.Name = "CheckBoxDiscount";
            this.CheckBoxDiscount.Size = new System.Drawing.Size(20, 20);
            this.CheckBoxDiscount.TabIndex = 39;
            this.CheckBoxDiscount.Text = "guna2CustomCheckBox1";
            this.CheckBoxDiscount.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(49)))), ((int)(((byte)(170)))));
            this.CheckBoxDiscount.UncheckedState.BorderRadius = 2;
            this.CheckBoxDiscount.UncheckedState.BorderThickness = 0;
            this.CheckBoxDiscount.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(49)))), ((int)(((byte)(170)))));
            this.CheckBoxDiscount.Click += new System.EventHandler(this.CheckBoxDiscount_Click);
            // 
            // TX_AmountReceived
            // 
            this.TX_AmountReceived.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TX_AmountReceived.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(93)))), ((int)(((byte)(255)))));
            this.TX_AmountReceived.Location = new System.Drawing.Point(643, 480);
            this.TX_AmountReceived.Name = "TX_AmountReceived";
            this.TX_AmountReceived.Size = new System.Drawing.Size(345, 45);
            this.TX_AmountReceived.TabIndex = 38;
            this.TX_AmountReceived.TextChanged += new System.EventHandler(this.TX_AmountReceived_TextChanged);
            this.TX_AmountReceived.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TX_AmountReceived_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Indigo;
            this.label13.Location = new System.Drawing.Point(1002, 483);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(151, 37);
            this.label13.TabIndex = 37;
            this.label13.Text = "المبلغ المقبوض";
            // 
            // COM_TypePayment
            // 
            this.COM_TypePayment.BackColor = System.Drawing.SystemColors.Window;
            this.COM_TypePayment.DropDownHeight = 170;
            this.COM_TypePayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COM_TypePayment.FormattingEnabled = true;
            this.COM_TypePayment.IntegralHeight = false;
            this.COM_TypePayment.Items.AddRange(new object[] {
            "كلي",
            "جزئي",
            "مؤجل"});
            this.COM_TypePayment.Location = new System.Drawing.Point(643, 415);
            this.COM_TypePayment.MaxDropDownItems = 5;
            this.COM_TypePayment.Name = "COM_TypePayment";
            this.COM_TypePayment.Size = new System.Drawing.Size(154, 45);
            this.COM_TypePayment.TabIndex = 36;
            this.COM_TypePayment.SelectedIndexChanged += new System.EventHandler(this.COM_TypePayment_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(819, 418);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 37);
            this.label12.TabIndex = 35;
            this.label12.Text = "نوع الدفع";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1071, 418);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 37);
            this.label7.TabIndex = 32;
            this.label7.Text = "حسم";
            // 
            // TX_TotalAmountInvoice
            // 
            this.TX_TotalAmountInvoice.Enabled = false;
            this.TX_TotalAmountInvoice.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TX_TotalAmountInvoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(93)))), ((int)(((byte)(255)))));
            this.TX_TotalAmountInvoice.Location = new System.Drawing.Point(643, 571);
            this.TX_TotalAmountInvoice.Name = "TX_TotalAmountInvoice";
            this.TX_TotalAmountInvoice.Size = new System.Drawing.Size(503, 45);
            this.TX_TotalAmountInvoice.TabIndex = 31;
            this.TX_TotalAmountInvoice.TextChanged += new System.EventHandler(this.TX_TotalAmountInvoice_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Crimson;
            this.label6.Location = new System.Drawing.Point(774, 528);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(248, 45);
            this.label6.TabIndex = 30;
            this.label6.Text = "السعر الاجمالي للفاتورة ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewProductsInvoice);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(614, 587);
            this.panel1.TabIndex = 29;
            // 
            // dataGridViewProductsInvoice
            // 
            this.dataGridViewProductsInvoice.AllowUserToAddRows = false;
            this.dataGridViewProductsInvoice.AllowUserToDeleteRows = false;
            this.dataGridViewProductsInvoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProductsInvoice.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewProductsInvoice.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Cairo", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProductsInvoice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewProductsInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductsInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Cairo", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProductsInvoice.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewProductsInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProductsInvoice.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewProductsInvoice.Name = "dataGridViewProductsInvoice";
            this.dataGridViewProductsInvoice.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Cairo", 12F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProductsInvoice.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewProductsInvoice.RowHeadersWidth = 51;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewProductsInvoice.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewProductsInvoice.RowTemplate.Height = 26;
            this.dataGridViewProductsInvoice.RowTemplate.ReadOnly = true;
            this.dataGridViewProductsInvoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProductsInvoice.Size = new System.Drawing.Size(614, 587);
            this.dataGridViewProductsInvoice.StandardTab = true;
            this.dataGridViewProductsInvoice.TabIndex = 30;
            this.dataGridViewProductsInvoice.SelectionChanged += new System.EventHandler(this.dataGridViewProductsInvoice_SelectionChanged);
            this.dataGridViewProductsInvoice.Click += new System.EventHandler(this.dataGridViewProductsInvoice_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "الاسم";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "السعر";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "العدد";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "السعر الاجمالي";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "id";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // LBL_CountProduct_Invoice
            // 
            this.LBL_CountProduct_Invoice.AutoSize = true;
            this.LBL_CountProduct_Invoice.Font = new System.Drawing.Font("Cairo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_CountProduct_Invoice.ForeColor = System.Drawing.Color.Crimson;
            this.LBL_CountProduct_Invoice.Location = new System.Drawing.Point(922, 140);
            this.LBL_CountProduct_Invoice.Name = "LBL_CountProduct_Invoice";
            this.LBL_CountProduct_Invoice.Size = new System.Drawing.Size(151, 32);
            this.LBL_CountProduct_Invoice.TabIndex = 28;
            this.LBL_CountProduct_Invoice.Text = "الكمية المتاحة  من ";
            // 
            // COM_Name_Product_Invoice
            // 
            this.COM_Name_Product_Invoice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.COM_Name_Product_Invoice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.COM_Name_Product_Invoice.BackColor = System.Drawing.SystemColors.Window;
            this.COM_Name_Product_Invoice.DropDownHeight = 170;
            this.COM_Name_Product_Invoice.FormattingEnabled = true;
            this.COM_Name_Product_Invoice.IntegralHeight = false;
            this.COM_Name_Product_Invoice.Location = new System.Drawing.Point(643, 92);
            this.COM_Name_Product_Invoice.MaxDropDownItems = 5;
            this.COM_Name_Product_Invoice.Name = "COM_Name_Product_Invoice";
            this.COM_Name_Product_Invoice.Size = new System.Drawing.Size(503, 45);
            this.COM_Name_Product_Invoice.TabIndex = 26;
            this.COM_Name_Product_Invoice.SelectedIndexChanged += new System.EventHandler(this.COM_Name_Product_Invoice_SelectedIndexChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(642, 59);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(55, 37);
            this.linkLabel1.TabIndex = 27;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "جديد";
            // 
            // BTN_DeleteProduct_Invoice
            // 
            this.BTN_DeleteProduct_Invoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(220)))), ((int)(((byte)(229)))));
            this.BTN_DeleteProduct_Invoice.ForeColor = System.Drawing.Color.Indigo;
            this.BTN_DeleteProduct_Invoice.Image = global::SabreenCompany.Properties.Resources.icons8_Delete_Trash_32px;
            this.BTN_DeleteProduct_Invoice.Location = new System.Drawing.Point(819, 324);
            this.BTN_DeleteProduct_Invoice.Margin = new System.Windows.Forms.Padding(5);
            this.BTN_DeleteProduct_Invoice.Name = "BTN_DeleteProduct_Invoice";
            this.BTN_DeleteProduct_Invoice.Size = new System.Drawing.Size(98, 55);
            this.BTN_DeleteProduct_Invoice.TabIndex = 24;
            this.BTN_DeleteProduct_Invoice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_DeleteProduct_Invoice.UseVisualStyleBackColor = false;
            this.BTN_DeleteProduct_Invoice.Click += new System.EventHandler(this.BTN_DeleteProduct_Invoice_Click);
            // 
            // picturePhoto_Product
            // 
            this.picturePhoto_Product.Image = global::SabreenCompany.Properties.Resources.icons8_aliexpress_500px;
            this.picturePhoto_Product.Location = new System.Drawing.Point(643, 283);
            this.picturePhoto_Product.Name = "picturePhoto_Product";
            this.picturePhoto_Product.Size = new System.Drawing.Size(139, 119);
            this.picturePhoto_Product.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturePhoto_Product.TabIndex = 23;
            this.picturePhoto_Product.TabStop = false;
            // 
            // TX_TotalAmount_Product
            // 
            this.TX_TotalAmount_Product.Enabled = false;
            this.TX_TotalAmount_Product.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TX_TotalAmount_Product.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(93)))), ((int)(((byte)(255)))));
            this.TX_TotalAmount_Product.Location = new System.Drawing.Point(643, 218);
            this.TX_TotalAmount_Product.Name = "TX_TotalAmount_Product";
            this.TX_TotalAmount_Product.Size = new System.Drawing.Size(127, 45);
            this.TX_TotalAmount_Product.TabIndex = 21;
            // 
            // BTN_AddProduct_Invoice
            // 
            this.BTN_AddProduct_Invoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(220)))), ((int)(((byte)(229)))));
            this.BTN_AddProduct_Invoice.ForeColor = System.Drawing.Color.Indigo;
            this.BTN_AddProduct_Invoice.Image = global::SabreenCompany.Properties.Resources.icons8_add_32px_1;
            this.BTN_AddProduct_Invoice.Location = new System.Drawing.Point(1053, 324);
            this.BTN_AddProduct_Invoice.Margin = new System.Windows.Forms.Padding(5);
            this.BTN_AddProduct_Invoice.Name = "BTN_AddProduct_Invoice";
            this.BTN_AddProduct_Invoice.Size = new System.Drawing.Size(98, 55);
            this.BTN_AddProduct_Invoice.TabIndex = 5;
            this.BTN_AddProduct_Invoice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_AddProduct_Invoice.UseVisualStyleBackColor = false;
            this.BTN_AddProduct_Invoice.Click += new System.EventHandler(this.BTN_AddProduct_Invoice_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(643, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 37);
            this.label5.TabIndex = 20;
            this.label5.Text = "السعر الاجمالي";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(863, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 37);
            this.label8.TabIndex = 17;
            this.label8.Text = "العدد";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1068, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 37);
            this.label9.TabIndex = 16;
            this.label9.Text = "السعر";
            // 
            // TX_Number_Product
            // 
            this.TX_Number_Product.Enabled = false;
            this.TX_Number_Product.Location = new System.Drawing.Point(832, 218);
            this.TX_Number_Product.Name = "TX_Number_Product";
            this.TX_Number_Product.Size = new System.Drawing.Size(127, 45);
            this.TX_Number_Product.TabIndex = 15;
            this.TX_Number_Product.TextChanged += new System.EventHandler(this.TX_Number_Product_TextChanged);
            this.TX_Number_Product.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TX_Number_Product_KeyPress);
            // 
            // TX_Price_Product
            // 
            this.TX_Price_Product.Enabled = false;
            this.TX_Price_Product.Location = new System.Drawing.Point(1019, 218);
            this.TX_Price_Product.Name = "TX_Price_Product";
            this.TX_Price_Product.Size = new System.Drawing.Size(127, 45);
            this.TX_Price_Product.TabIndex = 14;
            this.TX_Price_Product.TextChanged += new System.EventHandler(this.TX_Price_Product_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(841, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 37);
            this.label11.TabIndex = 0;
            this.label11.Text = "اسم المنتج";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Crimson;
            this.label18.Location = new System.Drawing.Point(623, 96);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(25, 37);
            this.label18.TabIndex = 46;
            this.label18.Text = "*";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Crimson;
            this.label19.Location = new System.Drawing.Point(623, 423);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(25, 37);
            this.label19.TabIndex = 47;
            this.label19.Text = "*";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.SystemColors.Window;
            this.label20.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Crimson;
            this.label20.Location = new System.Drawing.Point(944, 417);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(28, 37);
            this.label20.TabIndex = 48;
            this.label20.Text = "$";
            this.label20.Visible = false;
            // 
            // TX_Discount
            // 
            this.TX_Discount.Enabled = false;
            this.TX_Discount.Location = new System.Drawing.Point(940, 414);
            this.TX_Discount.Name = "TX_Discount";
            this.TX_Discount.Size = new System.Drawing.Size(127, 45);
            this.TX_Discount.TabIndex = 34;
            this.TX_Discount.TextChanged += new System.EventHandler(this.TX_Discount_TextChanged);
            this.TX_Discount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TX_Discount_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1364, 473);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 37);
            this.label4.TabIndex = 22;
            this.label4.Text = "ملاحظات";
            // 
            // RI_Notes_Invoice
            // 
            this.RI_Notes_Invoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RI_Notes_Invoice.Location = new System.Drawing.Point(1226, 523);
            this.RI_Notes_Invoice.Name = "RI_Notes_Invoice";
            this.RI_Notes_Invoice.Size = new System.Drawing.Size(385, 113);
            this.RI_Notes_Invoice.TabIndex = 21;
            this.RI_Notes_Invoice.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1304, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 37);
            this.label3.TabIndex = 20;
            this.label3.Text = "نوع البضاعة والمواصفات";
            // 
            // RI_TypeProduct_Invoice
            // 
            this.RI_TypeProduct_Invoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RI_TypeProduct_Invoice.Location = new System.Drawing.Point(1226, 341);
            this.RI_TypeProduct_Invoice.Name = "RI_TypeProduct_Invoice";
            this.RI_TypeProduct_Invoice.Size = new System.Drawing.Size(385, 113);
            this.RI_TypeProduct_Invoice.TabIndex = 19;
            this.RI_TypeProduct_Invoice.Text = "";
            // 
            // dateTimePicker_Invoic
            // 
            this.dateTimePicker_Invoic.CustomFormat = "";
            this.dateTimePicker_Invoic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_Invoic.Location = new System.Drawing.Point(1226, 223);
            this.dateTimePicker_Invoic.Name = "dateTimePicker_Invoic";
            this.dateTimePicker_Invoic.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimePicker_Invoic.Size = new System.Drawing.Size(385, 45);
            this.dateTimePicker_Invoic.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1380, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "التاريخ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1364, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم الزبون";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Crimson;
            this.label10.Location = new System.Drawing.Point(1206, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 37);
            this.label10.TabIndex = 41;
            this.label10.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Crimson;
            this.label14.Location = new System.Drawing.Point(1206, 231);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(25, 37);
            this.label14.TabIndex = 42;
            this.label14.Text = "*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Crimson;
            this.label15.Location = new System.Drawing.Point(1206, 343);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(25, 37);
            this.label15.TabIndex = 43;
            this.label15.Text = "*";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(30)))), ((int)(((byte)(103)))));
            this.flowLayoutPanel1.Controls.Add(this.BTN_Save);
            this.flowLayoutPanel1.Controls.Add(this.BTN_Save_Close);
            this.flowLayoutPanel1.Controls.Add(this.BTN_Close);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 710);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 3, 6, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5, 5, 550, 5);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1669, 71);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // BTN_Save
            // 
            this.BTN_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(220)))), ((int)(((byte)(229)))));
            this.BTN_Save.ForeColor = System.Drawing.Color.Indigo;
            this.BTN_Save.Image = global::SabreenCompany.Properties.Resources.icons8_save_32px_1;
            this.BTN_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Save.Location = new System.Drawing.Point(944, 10);
            this.BTN_Save.Margin = new System.Windows.Forms.Padding(5, 5, 30, 5);
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
            this.BTN_Save_Close.Location = new System.Drawing.Point(744, 10);
            this.BTN_Save_Close.Margin = new System.Windows.Forms.Padding(5, 5, 30, 5);
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
            this.BTN_Close.Location = new System.Drawing.Point(544, 10);
            this.BTN_Close.Margin = new System.Windows.Forms.Padding(5, 5, 30, 5);
            this.BTN_Close.Name = "BTN_Close";
            this.BTN_Close.Size = new System.Drawing.Size(165, 55);
            this.BTN_Close.TabIndex = 4;
            this.BTN_Close.Text = "إغلاق";
            this.BTN_Close.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Close.UseVisualStyleBackColor = false;
            this.BTN_Close.Click += new System.EventHandler(this.BTN_Close_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Indigo;
            this.panel2.Controls.Add(this.BTN_CloseControl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1669, 40);
            this.panel2.TabIndex = 7;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // BTN_CloseControl
            // 
            this.BTN_CloseControl.BackColor = System.Drawing.Color.Indigo;
            this.BTN_CloseControl.FlatAppearance.BorderSize = 0;
            this.BTN_CloseControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_CloseControl.Image = global::SabreenCompany.Properties.Resources.icons8_x_32px;
            this.BTN_CloseControl.Location = new System.Drawing.Point(1613, 1);
            this.BTN_CloseControl.Name = "BTN_CloseControl";
            this.BTN_CloseControl.Size = new System.Drawing.Size(51, 36);
            this.BTN_CloseControl.TabIndex = 51;
            this.BTN_CloseControl.UseVisualStyleBackColor = false;
            this.BTN_CloseControl.Click += new System.EventHandler(this.BTN_CloseControl_Click);
            this.BTN_CloseControl.MouseEnter += new System.EventHandler(this.BTN_CloseControl_MouseEnter);
            this.BTN_CloseControl.MouseLeave += new System.EventHandler(this.BTN_CloseControl_MouseLeave);
            // 
            // Form_AddInvoice
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1669, 781);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Cairo", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_AddInvoice";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة /تعديل فاتورة";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_AddInvoice_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductsInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePhoto_Product)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button BTN_Save;
        private System.Windows.Forms.Button BTN_Save_Close;
        private System.Windows.Forms.Button BTN_Close;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Invoic;
        private System.Windows.Forms.RichTextBox RI_TypeProduct_Invoice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox RI_Notes_Invoice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox COM_Name_Cus_Inv;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox COM_Name_Product_Invoice;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button BTN_DeleteProduct_Invoice;
        private System.Windows.Forms.PictureBox picturePhoto_Product;
        private System.Windows.Forms.TextBox TX_TotalAmount_Product;
        private System.Windows.Forms.Button BTN_AddProduct_Invoice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TX_Number_Product;
        private System.Windows.Forms.TextBox TX_Price_Product;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label LBL_CountProduct_Invoice;
        private System.Windows.Forms.TextBox TX_TotalAmountInvoice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewProductsInvoice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TX_Discount;
        private System.Windows.Forms.TextBox TX_AmountReceived;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox COM_TypePayment;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2CustomCheckBox CheckBoxDiscount;
        private System.Windows.Forms.Button BTN_UpdateProduct_Invoice;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BTN_CloseControl;
    }
}