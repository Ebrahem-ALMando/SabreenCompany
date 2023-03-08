
namespace SabreenCompany.Forms
{
    partial class Form_Main
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.BTN_Home = new System.Windows.Forms.Button();
            this.BTN_Suppliers = new System.Windows.Forms.Button();
            this.BTN_Categoryes = new System.Windows.Forms.Button();
            this.BTN_Products = new System.Windows.Forms.Button();
            this.BTN_Customers = new System.Windows.Forms.Button();
            this.BTN_Invioce = new System.Windows.Forms.Button();
            this.BTN_Incomes = new System.Windows.Forms.Button();
            this.BTN_BoxMoney = new System.Windows.Forms.Button();
            this.BTN_Setting = new System.Windows.Forms.Button();
            this.BTN_About = new System.Windows.Forms.Button();
            this.BTN_Logout = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Indigo;
            this.flowLayoutPanel1.Controls.Add(this.BTN_Home);
            this.flowLayoutPanel1.Controls.Add(this.BTN_Suppliers);
            this.flowLayoutPanel1.Controls.Add(this.BTN_Categoryes);
            this.flowLayoutPanel1.Controls.Add(this.BTN_Products);
            this.flowLayoutPanel1.Controls.Add(this.BTN_Customers);
            this.flowLayoutPanel1.Controls.Add(this.BTN_Invioce);
            this.flowLayoutPanel1.Controls.Add(this.BTN_Incomes);
            this.flowLayoutPanel1.Controls.Add(this.BTN_BoxMoney);
            this.flowLayoutPanel1.Controls.Add(this.BTN_Setting);
            this.flowLayoutPanel1.Controls.Add(this.BTN_About);
            this.flowLayoutPanel1.Controls.Add(this.BTN_Logout);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 607);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1278, 73);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // BTN_Home
            // 
            this.BTN_Home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(220)))), ((int)(((byte)(229)))));
            this.BTN_Home.Image = global::SabreenCompany.Properties.Resources.icons8_home_32px_1;
            this.BTN_Home.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Home.Location = new System.Drawing.Point(1079, 8);
            this.BTN_Home.Name = "BTN_Home";
            this.BTN_Home.Size = new System.Drawing.Size(165, 55);
            this.BTN_Home.TabIndex = 0;
            this.BTN_Home.Text = "الرئيسية";
            this.BTN_Home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Home.UseVisualStyleBackColor = false;
            this.BTN_Home.Click += new System.EventHandler(this.BTN_Home_Click);
            // 
            // BTN_Suppliers
            // 
            this.BTN_Suppliers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(220)))), ((int)(((byte)(229)))));
            this.BTN_Suppliers.Image = global::SabreenCompany.Properties.Resources.icons8_supplier_32px;
            this.BTN_Suppliers.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Suppliers.Location = new System.Drawing.Point(908, 8);
            this.BTN_Suppliers.Name = "BTN_Suppliers";
            this.BTN_Suppliers.Size = new System.Drawing.Size(165, 55);
            this.BTN_Suppliers.TabIndex = 1;
            this.BTN_Suppliers.Text = "الموردين";
            this.BTN_Suppliers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Suppliers.UseVisualStyleBackColor = false;
            this.BTN_Suppliers.Click += new System.EventHandler(this.BTN_Suppliers_Click);
            // 
            // BTN_Categoryes
            // 
            this.BTN_Categoryes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(220)))), ((int)(((byte)(229)))));
            this.BTN_Categoryes.Image = global::SabreenCompany.Properties.Resources.icons8_categorize_32px;
            this.BTN_Categoryes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Categoryes.Location = new System.Drawing.Point(737, 8);
            this.BTN_Categoryes.Name = "BTN_Categoryes";
            this.BTN_Categoryes.Size = new System.Drawing.Size(165, 55);
            this.BTN_Categoryes.TabIndex = 2;
            this.BTN_Categoryes.Text = "الاصناف";
            this.BTN_Categoryes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Categoryes.UseVisualStyleBackColor = false;
            this.BTN_Categoryes.Click += new System.EventHandler(this.BTN_Categoryes_Click);
            // 
            // BTN_Products
            // 
            this.BTN_Products.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(220)))), ((int)(((byte)(229)))));
            this.BTN_Products.Image = global::SabreenCompany.Properties.Resources.icons8_add_shopping_cart_32px;
            this.BTN_Products.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Products.Location = new System.Drawing.Point(566, 8);
            this.BTN_Products.Name = "BTN_Products";
            this.BTN_Products.Size = new System.Drawing.Size(165, 55);
            this.BTN_Products.TabIndex = 3;
            this.BTN_Products.Text = "المنتجات";
            this.BTN_Products.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Products.UseVisualStyleBackColor = false;
            this.BTN_Products.Click += new System.EventHandler(this.BTN_Products_Click);
            // 
            // BTN_Customers
            // 
            this.BTN_Customers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(220)))), ((int)(((byte)(229)))));
            this.BTN_Customers.Image = global::SabreenCompany.Properties.Resources.icons8_users_32px;
            this.BTN_Customers.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Customers.Location = new System.Drawing.Point(395, 8);
            this.BTN_Customers.Name = "BTN_Customers";
            this.BTN_Customers.Size = new System.Drawing.Size(165, 55);
            this.BTN_Customers.TabIndex = 4;
            this.BTN_Customers.Text = "الزبائن";
            this.BTN_Customers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Customers.UseVisualStyleBackColor = false;
            this.BTN_Customers.Click += new System.EventHandler(this.BTN_Customers_Click);
            // 
            // BTN_Invioce
            // 
            this.BTN_Invioce.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(220)))), ((int)(((byte)(229)))));
            this.BTN_Invioce.Image = global::SabreenCompany.Properties.Resources.icons8_cheque_32px;
            this.BTN_Invioce.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Invioce.Location = new System.Drawing.Point(224, 8);
            this.BTN_Invioce.Name = "BTN_Invioce";
            this.BTN_Invioce.Size = new System.Drawing.Size(165, 55);
            this.BTN_Invioce.TabIndex = 10;
            this.BTN_Invioce.Text = "الفواتير";
            this.BTN_Invioce.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Invioce.UseVisualStyleBackColor = false;
            this.BTN_Invioce.Click += new System.EventHandler(this.BTN_Invioce_Click);
            // 
            // BTN_Incomes
            // 
            this.BTN_Incomes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(220)))), ((int)(((byte)(229)))));
            this.BTN_Incomes.Image = global::SabreenCompany.Properties.Resources.icons8_sales_performance_32px;
            this.BTN_Incomes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Incomes.Location = new System.Drawing.Point(53, 8);
            this.BTN_Incomes.Name = "BTN_Incomes";
            this.BTN_Incomes.Size = new System.Drawing.Size(165, 55);
            this.BTN_Incomes.TabIndex = 5;
            this.BTN_Incomes.Text = "الايرادات";
            this.BTN_Incomes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Incomes.UseVisualStyleBackColor = false;
            // 
            // BTN_BoxMoney
            // 
            this.BTN_BoxMoney.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(220)))), ((int)(((byte)(229)))));
            this.BTN_BoxMoney.Image = global::SabreenCompany.Properties.Resources.icons8_money_bag_32px_3;
            this.BTN_BoxMoney.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_BoxMoney.Location = new System.Drawing.Point(1079, 69);
            this.BTN_BoxMoney.Name = "BTN_BoxMoney";
            this.BTN_BoxMoney.Size = new System.Drawing.Size(165, 55);
            this.BTN_BoxMoney.TabIndex = 6;
            this.BTN_BoxMoney.Text = "الصندوق";
            this.BTN_BoxMoney.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_BoxMoney.UseVisualStyleBackColor = false;
            // 
            // BTN_Setting
            // 
            this.BTN_Setting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(220)))), ((int)(((byte)(229)))));
            this.BTN_Setting.Image = global::SabreenCompany.Properties.Resources.icons8_settings_32px_2;
            this.BTN_Setting.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Setting.Location = new System.Drawing.Point(908, 69);
            this.BTN_Setting.Name = "BTN_Setting";
            this.BTN_Setting.Size = new System.Drawing.Size(165, 55);
            this.BTN_Setting.TabIndex = 7;
            this.BTN_Setting.Text = "الإعدادات";
            this.BTN_Setting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Setting.UseVisualStyleBackColor = false;
            this.BTN_Setting.Click += new System.EventHandler(this.BTN_Setting_Click);
            // 
            // BTN_About
            // 
            this.BTN_About.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(220)))), ((int)(((byte)(229)))));
            this.BTN_About.Image = global::SabreenCompany.Properties.Resources.icons8_about_32px;
            this.BTN_About.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_About.Location = new System.Drawing.Point(737, 69);
            this.BTN_About.Name = "BTN_About";
            this.BTN_About.Size = new System.Drawing.Size(165, 55);
            this.BTN_About.TabIndex = 8;
            this.BTN_About.Text = "حول";
            this.BTN_About.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_About.UseVisualStyleBackColor = false;
            // 
            // BTN_Logout
            // 
            this.BTN_Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(220)))), ((int)(((byte)(229)))));
            this.BTN_Logout.Image = global::SabreenCompany.Properties.Resources.icons8_logout_32px;
            this.BTN_Logout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Logout.Location = new System.Drawing.Point(566, 69);
            this.BTN_Logout.Name = "BTN_Logout";
            this.BTN_Logout.Size = new System.Drawing.Size(165, 55);
            this.BTN_Logout.TabIndex = 9;
            this.BTN_Logout.Text = "تسجيل خروج";
            this.BTN_Logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Logout.UseVisualStyleBackColor = false;
            this.BTN_Logout.Click += new System.EventHandler(this.BTN_Logout_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.SystemColors.Control;
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.MinimumSize = new System.Drawing.Size(1278, 607);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1278, 607);
            this.panelContainer.TabIndex = 1;
            // 
            // Form_Main
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 680);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.Name = "Form_Main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sabreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button BTN_Home;
        private System.Windows.Forms.Button BTN_Suppliers;
        private System.Windows.Forms.Button BTN_Categoryes;
        private System.Windows.Forms.Button BTN_Products;
        private System.Windows.Forms.Button BTN_Customers;
        private System.Windows.Forms.Button BTN_Incomes;
        private System.Windows.Forms.Button BTN_BoxMoney;
        private System.Windows.Forms.Button BTN_Setting;
        private System.Windows.Forms.Button BTN_About;
        private System.Windows.Forms.Button BTN_Logout;
        public System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Button BTN_Invioce;
    }
}