
namespace SabreenCompany.Gui.GuiInvoice
{
    partial class Invoice_UserControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewInvoice = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.BTN_Add = new System.Windows.Forms.Button();
            this.BTN_Update = new System.Windows.Forms.Button();
            this.BTN_Delete = new System.Windows.Forms.Button();
            this.BTN_Print = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TX_Serarch = new System.Windows.Forms.TextBox();
            this.BTN_Search = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Date = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoice)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewInvoice
            // 
            this.dataGridViewInvoice.AllowUserToAddRows = false;
            this.dataGridViewInvoice.AllowUserToDeleteRows = false;
            this.dataGridViewInvoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewInvoice.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewInvoice.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Cairo", 12F);
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewInvoice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Cairo", 12F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewInvoice.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewInvoice.Location = new System.Drawing.Point(0, 128);
            this.dataGridViewInvoice.Name = "dataGridViewInvoice";
            this.dataGridViewInvoice.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Cairo", 12F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewInvoice.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewInvoice.RowHeadersWidth = 20;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewInvoice.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewInvoice.RowTemplate.Height = 26;
            this.dataGridViewInvoice.RowTemplate.ReadOnly = true;
            this.dataGridViewInvoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewInvoice.Size = new System.Drawing.Size(1278, 479);
            this.dataGridViewInvoice.StandardTab = true;
            this.dataGridViewInvoice.TabIndex = 19;
            this.dataGridViewInvoice.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewInvoice_CellFormatting);
            this.dataGridViewInvoice.SelectionChanged += new System.EventHandler(this.dataGridViewInvoice_SelectionChanged);
            this.dataGridViewInvoice.Click += new System.EventHandler(this.dataGridViewInvoice_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(30)))), ((int)(((byte)(103)))));
            this.flowLayoutPanel1.Controls.Add(this.BTN_Add);
            this.flowLayoutPanel1.Controls.Add(this.BTN_Update);
            this.flowLayoutPanel1.Controls.Add(this.BTN_Delete);
            this.flowLayoutPanel1.Controls.Add(this.BTN_Print);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 55);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1278, 73);
            this.flowLayoutPanel1.TabIndex = 18;
            // 
            // BTN_Add
            // 
            this.BTN_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(220)))), ((int)(((byte)(229)))));
            this.BTN_Add.ForeColor = System.Drawing.Color.Indigo;
            this.BTN_Add.Image = global::SabreenCompany.Properties.Resources.icons8_add_32px_1;
            this.BTN_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Add.Location = new System.Drawing.Point(1100, 8);
            this.BTN_Add.Name = "BTN_Add";
            this.BTN_Add.Size = new System.Drawing.Size(165, 55);
            this.BTN_Add.TabIndex = 1;
            this.BTN_Add.Text = "إضافة";
            this.BTN_Add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Add.UseVisualStyleBackColor = false;
            this.BTN_Add.Click += new System.EventHandler(this.BTN_Add_Click);
            // 
            // BTN_Update
            // 
            this.BTN_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(220)))), ((int)(((byte)(229)))));
            this.BTN_Update.ForeColor = System.Drawing.Color.Indigo;
            this.BTN_Update.Image = global::SabreenCompany.Properties.Resources.icons8_Edit_32px;
            this.BTN_Update.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Update.Location = new System.Drawing.Point(929, 8);
            this.BTN_Update.Name = "BTN_Update";
            this.BTN_Update.Size = new System.Drawing.Size(165, 55);
            this.BTN_Update.TabIndex = 2;
            this.BTN_Update.Text = "تعديل";
            this.BTN_Update.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Update.UseVisualStyleBackColor = false;
            this.BTN_Update.Click += new System.EventHandler(this.BTN_Update_Click);
            // 
            // BTN_Delete
            // 
            this.BTN_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(220)))), ((int)(((byte)(229)))));
            this.BTN_Delete.ForeColor = System.Drawing.Color.Indigo;
            this.BTN_Delete.Image = global::SabreenCompany.Properties.Resources.icons8_Delete_Trash_32px;
            this.BTN_Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Delete.Location = new System.Drawing.Point(758, 8);
            this.BTN_Delete.Name = "BTN_Delete";
            this.BTN_Delete.Size = new System.Drawing.Size(165, 55);
            this.BTN_Delete.TabIndex = 3;
            this.BTN_Delete.Text = "حذف";
            this.BTN_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Delete.UseVisualStyleBackColor = false;
            this.BTN_Delete.Click += new System.EventHandler(this.BTN_Delete_Click);
            // 
            // BTN_Print
            // 
            this.BTN_Print.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(220)))), ((int)(((byte)(229)))));
            this.BTN_Print.ForeColor = System.Drawing.Color.Indigo;
            this.BTN_Print.Image = global::SabreenCompany.Properties.Resources.icons8_print_32px;
            this.BTN_Print.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Print.Location = new System.Drawing.Point(587, 8);
            this.BTN_Print.Name = "BTN_Print";
            this.BTN_Print.Size = new System.Drawing.Size(165, 55);
            this.BTN_Print.TabIndex = 8;
            this.BTN_Print.Text = "طباعة";
            this.BTN_Print.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Print.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.TX_Serarch);
            this.panel1.Controls.Add(this.BTN_Search);
            this.panel1.Location = new System.Drawing.Point(155, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 55);
            this.panel1.TabIndex = 7;
            // 
            // TX_Serarch
            // 
            this.TX_Serarch.BackColor = System.Drawing.Color.White;
            this.TX_Serarch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TX_Serarch.Font = new System.Drawing.Font("Cairo", 16F);
            this.TX_Serarch.Location = new System.Drawing.Point(94, 0);
            this.TX_Serarch.Name = "TX_Serarch";
            this.TX_Serarch.Size = new System.Drawing.Size(330, 57);
            this.TX_Serarch.TabIndex = 9;
            this.TX_Serarch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TX_Serarch.TextChanged += new System.EventHandler(this.TX_Serarch_TextChanged);
            // 
            // BTN_Search
            // 
            this.BTN_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(220)))), ((int)(((byte)(229)))));
            this.BTN_Search.Dock = System.Windows.Forms.DockStyle.Left;
            this.BTN_Search.FlatAppearance.BorderSize = 0;
            this.BTN_Search.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Search.ForeColor = System.Drawing.Color.Indigo;
            this.BTN_Search.Image = global::SabreenCompany.Properties.Resources.icons8_Search_32px_1;
            this.BTN_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Search.Location = new System.Drawing.Point(0, 0);
            this.BTN_Search.Name = "BTN_Search";
            this.BTN_Search.Size = new System.Drawing.Size(94, 53);
            this.BTN_Search.TabIndex = 8;
            this.BTN_Search.Text = "بحث";
            this.BTN_Search.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Search.UseVisualStyleBackColor = false;
            this.BTN_Search.Click += new System.EventHandler(this.BTN_Search_Click);
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
            this.panel3.Size = new System.Drawing.Size(1278, 55);
            this.panel3.TabIndex = 17;
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Dock = System.Windows.Forms.DockStyle.Right;
            this.Date.Font = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.ForeColor = System.Drawing.Color.LavenderBlush;
            this.Date.Location = new System.Drawing.Point(1161, 0);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(115, 45);
            this.Date.TabIndex = 9;
            this.Date.Text = "DateHear";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox5.Image = global::SabreenCompany.Properties.Resources.الفواتير;
            this.pictureBox5.Location = new System.Drawing.Point(587, -9);
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
            // Invoice_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewInvoice);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Cairo", 12F);
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.Name = "Invoice_UserControl";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1278, 607);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoice)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewInvoice;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button BTN_Add;
        private System.Windows.Forms.Button BTN_Update;
        private System.Windows.Forms.Button BTN_Delete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TX_Serarch;
        private System.Windows.Forms.Button BTN_Search;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button BTN_Print;
    }
}
