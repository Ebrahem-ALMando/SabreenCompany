
namespace SabreenCompany.Forms.FormsProducts
{
    partial class Form_AddProducts
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
            this.panelToUpdateNuber = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.COM_TypeProcess = new System.Windows.Forms.ComboBox();
            this.TX_Number = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.COMP_Name_Category = new System.Windows.Forms.ComboBox();
            this.new_Category = new System.Windows.Forms.LinkLabel();
            this.BTN_RemoveImage = new System.Windows.Forms.Button();
            this.picturePhoto_Product = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TX_TotalAmount_Product = new System.Windows.Forms.TextBox();
            this.BTN_LoadImage = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RI_Notes = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TX_Number_Product = new System.Windows.Forms.TextBox();
            this.TX_Price_Product = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TX_Name_Product = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.BTN_Save = new System.Windows.Forms.Button();
            this.BTN_Save_Close = new System.Windows.Forms.Button();
            this.BTN_Close = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panelToUpdateNuber.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePhoto_Product)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panelToUpdateNuber);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.COMP_Name_Category);
            this.groupBox1.Controls.Add(this.new_Category);
            this.groupBox1.Controls.Add(this.BTN_RemoveImage);
            this.groupBox1.Controls.Add(this.picturePhoto_Product);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TX_TotalAmount_Product);
            this.groupBox1.Controls.Add(this.BTN_LoadImage);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.RI_Notes);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TX_Number_Product);
            this.groupBox1.Controls.Add(this.TX_Price_Product);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TX_Name_Product);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Indigo;
            this.groupBox1.Location = new System.Drawing.Point(12, -9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 699);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "معلومات المنتج ";
            // 
            // panelToUpdateNuber
            // 
            this.panelToUpdateNuber.Controls.Add(this.label11);
            this.panelToUpdateNuber.Controls.Add(this.COM_TypeProcess);
            this.panelToUpdateNuber.Controls.Add(this.TX_Number);
            this.panelToUpdateNuber.Controls.Add(this.label10);
            this.panelToUpdateNuber.Location = new System.Drawing.Point(17, 213);
            this.panelToUpdateNuber.Name = "panelToUpdateNuber";
            this.panelToUpdateNuber.Size = new System.Drawing.Size(470, 58);
            this.panelToUpdateNuber.TabIndex = 39;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Crimson;
            this.label11.Location = new System.Drawing.Point(333, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 37);
            this.label11.TabIndex = 43;
            this.label11.Text = "العملية";
            // 
            // COM_TypeProcess
            // 
            this.COM_TypeProcess.BackColor = System.Drawing.SystemColors.Window;
            this.COM_TypeProcess.DropDownHeight = 170;
            this.COM_TypeProcess.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COM_TypeProcess.FormattingEnabled = true;
            this.COM_TypeProcess.IntegralHeight = false;
            this.COM_TypeProcess.Items.AddRange(new object[] {
            "كلي",
            "جزئي",
            "مؤجل"});
            this.COM_TypeProcess.Location = new System.Drawing.Point(189, 6);
            this.COM_TypeProcess.MaxDropDownItems = 5;
            this.COM_TypeProcess.Name = "COM_TypeProcess";
            this.COM_TypeProcess.Size = new System.Drawing.Size(127, 45);
            this.COM_TypeProcess.TabIndex = 42;
            // 
            // TX_Number
            // 
            this.TX_Number.Location = new System.Drawing.Point(0, 6);
            this.TX_Number.Name = "TX_Number";
            this.TX_Number.Size = new System.Drawing.Size(127, 45);
            this.TX_Number.TabIndex = 40;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Crimson;
            this.label10.Location = new System.Drawing.Point(128, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 37);
            this.label10.TabIndex = 41;
            this.label10.Text = "العدد";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Crimson;
            this.label9.Location = new System.Drawing.Point(47, 389);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 29);
            this.label9.TabIndex = 27;
            this.label9.Text = " المتاح";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Crimson;
            this.label8.Location = new System.Drawing.Point(38, 360);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 29);
            this.label8.TabIndex = 26;
            this.label8.Text = "المبلغ المتاح";
            // 
            // COMP_Name_Category
            // 
            this.COMP_Name_Category.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.COMP_Name_Category.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.COMP_Name_Category.BackColor = System.Drawing.SystemColors.Window;
            this.COMP_Name_Category.DropDownHeight = 170;
            this.COMP_Name_Category.FormattingEnabled = true;
            this.COMP_Name_Category.IntegralHeight = false;
            this.COMP_Name_Category.Location = new System.Drawing.Point(17, 162);
            this.COMP_Name_Category.MaxDropDownItems = 5;
            this.COMP_Name_Category.Name = "COMP_Name_Category";
            this.COMP_Name_Category.Size = new System.Drawing.Size(503, 45);
            this.COMP_Name_Category.TabIndex = 13;
            // 
            // new_Category
            // 
            this.new_Category.AutoSize = true;
            this.new_Category.Location = new System.Drawing.Point(17, 129);
            this.new_Category.Name = "new_Category";
            this.new_Category.Size = new System.Drawing.Size(55, 37);
            this.new_Category.TabIndex = 25;
            this.new_Category.TabStop = true;
            this.new_Category.Text = "جديد";
            this.new_Category.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.new_Category_LinkClicked);
            // 
            // BTN_RemoveImage
            // 
            this.BTN_RemoveImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(220)))), ((int)(((byte)(229)))));
            this.BTN_RemoveImage.ForeColor = System.Drawing.Color.Indigo;
            this.BTN_RemoveImage.Image = global::SabreenCompany.Properties.Resources.icons8_Remove_Image_32px;
            this.BTN_RemoveImage.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_RemoveImage.Location = new System.Drawing.Point(187, 606);
            this.BTN_RemoveImage.Margin = new System.Windows.Forms.Padding(5);
            this.BTN_RemoveImage.Name = "BTN_RemoveImage";
            this.BTN_RemoveImage.Size = new System.Drawing.Size(160, 55);
            this.BTN_RemoveImage.TabIndex = 24;
            this.BTN_RemoveImage.Text = "حذف الصورة";
            this.BTN_RemoveImage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_RemoveImage.UseVisualStyleBackColor = false;
            this.BTN_RemoveImage.Click += new System.EventHandler(this.BTN_RemoveImage_Click);
            // 
            // picturePhoto_Product
            // 
            this.picturePhoto_Product.Image = global::SabreenCompany.Properties.Resources.icons8_aliexpress_500px;
            this.picturePhoto_Product.Location = new System.Drawing.Point(17, 564);
            this.picturePhoto_Product.Name = "picturePhoto_Product";
            this.picturePhoto_Product.Size = new System.Drawing.Size(139, 119);
            this.picturePhoto_Product.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturePhoto_Product.TabIndex = 23;
            this.picturePhoto_Product.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(210, 540);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 37);
            this.label7.TabIndex = 22;
            this.label7.Text = "صورة المنتج";
            // 
            // TX_TotalAmount_Product
            // 
            this.TX_TotalAmount_Product.Enabled = false;
            this.TX_TotalAmount_Product.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TX_TotalAmount_Product.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(93)))), ((int)(((byte)(255)))));
            this.TX_TotalAmount_Product.Location = new System.Drawing.Point(17, 307);
            this.TX_TotalAmount_Product.Name = "TX_TotalAmount_Product";
            this.TX_TotalAmount_Product.Size = new System.Drawing.Size(127, 45);
            this.TX_TotalAmount_Product.TabIndex = 21;
            // 
            // BTN_LoadImage
            // 
            this.BTN_LoadImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(220)))), ((int)(((byte)(229)))));
            this.BTN_LoadImage.ForeColor = System.Drawing.Color.Indigo;
            this.BTN_LoadImage.Image = global::SabreenCompany.Properties.Resources.icons8_image_file_add_32px;
            this.BTN_LoadImage.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_LoadImage.Location = new System.Drawing.Point(370, 606);
            this.BTN_LoadImage.Margin = new System.Windows.Forms.Padding(5);
            this.BTN_LoadImage.Name = "BTN_LoadImage";
            this.BTN_LoadImage.Size = new System.Drawing.Size(160, 55);
            this.BTN_LoadImage.TabIndex = 5;
            this.BTN_LoadImage.Text = "تحميل صورة";
            this.BTN_LoadImage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_LoadImage.UseVisualStyleBackColor = false;
            this.BTN_LoadImage.Click += new System.EventHandler(this.BTN_LoadImage_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(17, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 37);
            this.label3.TabIndex = 20;
            this.label3.Text = "السعر الاجمالي";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 37);
            this.label2.TabIndex = 19;
            this.label2.Text = "ملاحظات";
            // 
            // RI_Notes
            // 
            this.RI_Notes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RI_Notes.Location = new System.Drawing.Point(17, 424);
            this.RI_Notes.Name = "RI_Notes";
            this.RI_Notes.Size = new System.Drawing.Size(503, 113);
            this.RI_Notes.TabIndex = 18;
            this.RI_Notes.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(215, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 37);
            this.label6.TabIndex = 17;
            this.label6.Text = "العدد الكلي";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(442, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 37);
            this.label5.TabIndex = 16;
            this.label5.Text = "السعر";
            // 
            // TX_Number_Product
            // 
            this.TX_Number_Product.Location = new System.Drawing.Point(206, 307);
            this.TX_Number_Product.Name = "TX_Number_Product";
            this.TX_Number_Product.Size = new System.Drawing.Size(127, 45);
            this.TX_Number_Product.TabIndex = 15;
            this.TX_Number_Product.TextChanged += new System.EventHandler(this.TX_Number_Product_TextChanged);
            this.TX_Number_Product.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TX_Number_Product_KeyPress);
            // 
            // TX_Price_Product
            // 
            this.TX_Price_Product.Location = new System.Drawing.Point(393, 307);
            this.TX_Price_Product.Name = "TX_Price_Product";
            this.TX_Price_Product.Size = new System.Drawing.Size(127, 45);
            this.TX_Price_Product.TabIndex = 14;
            this.TX_Price_Product.TextChanged += new System.EventHandler(this.TX_Price_Product_TextChanged);
            this.TX_Price_Product.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TX_Price_Product_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 37);
            this.label4.TabIndex = 12;
            this.label4.Text = "اسم الصنف";
            // 
            // TX_Name_Product
            // 
            this.TX_Name_Product.Location = new System.Drawing.Point(17, 68);
            this.TX_Name_Product.Name = "TX_Name_Product";
            this.TX_Name_Product.Size = new System.Drawing.Size(503, 45);
            this.TX_Name_Product.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم المنتج";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(30)))), ((int)(((byte)(103)))));
            this.flowLayoutPanel1.Controls.Add(this.BTN_Save);
            this.flowLayoutPanel1.Controls.Add(this.BTN_Save_Close);
            this.flowLayoutPanel1.Controls.Add(this.BTN_Close);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 696);
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
            // Form_AddProducts
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 778);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Cairo", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_AddProducts";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة /تعديل منتج";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelToUpdateNuber.ResumeLayout(false);
            this.panelToUpdateNuber.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePhoto_Product)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TX_Name_Product;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button BTN_Save;
        private System.Windows.Forms.Button BTN_Save_Close;
        private System.Windows.Forms.Button BTN_Close;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TX_Number_Product;
        private System.Windows.Forms.TextBox TX_Price_Product;
        private System.Windows.Forms.ComboBox COMP_Name_Category;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BTN_RemoveImage;
        private System.Windows.Forms.PictureBox picturePhoto_Product;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TX_TotalAmount_Product;
        private System.Windows.Forms.Button BTN_LoadImage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox RI_Notes;
        private System.Windows.Forms.LinkLabel new_Category;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panelToUpdateNuber;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox COM_TypeProcess;
        private System.Windows.Forms.TextBox TX_Number;
        private System.Windows.Forms.Label label10;
    }
}