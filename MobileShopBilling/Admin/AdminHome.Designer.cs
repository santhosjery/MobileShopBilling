namespace MobileShopBilling.Admin
{
    partial class AdminHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminHome));
            this.mainmenu = new System.Windows.Forms.MenuStrip();
            this.masterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.availableStockReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saleDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminstrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.PictureBoxHome = new System.Windows.Forms.PictureBox();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxHome)).BeginInit();
            this.SuspendLayout();
            // 
            // mainmenu
            // 
            this.mainmenu.BackColor = System.Drawing.Color.Silver;
            this.mainmenu.Font = new System.Drawing.Font("Georgia", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainmenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.mainmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterToolStripMenuItem,
            this.transactionToolStripMenuItem,
            this.detailsToolStripMenuItem,
            this.adminstrationToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
            this.mainmenu.Location = new System.Drawing.Point(0, 0);
            this.mainmenu.Name = "mainmenu";
            this.mainmenu.Size = new System.Drawing.Size(915, 28);
            this.mainmenu.TabIndex = 0;
            this.mainmenu.Text = "MainMenu";
            // 
            // masterToolStripMenuItem
            // 
            this.masterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemToolStripMenuItem,
            this.productToolStripMenuItem,
            this.brandToolStripMenuItem,
            this.productTypeToolStripMenuItem,
            this.colorToolStripMenuItem,
            this.taxToolStripMenuItem});
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            this.masterToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.masterToolStripMenuItem.Text = "Master";
            // 
            // itemToolStripMenuItem
            // 
            this.itemToolStripMenuItem.Name = "itemToolStripMenuItem";
            this.itemToolStripMenuItem.Size = new System.Drawing.Size(265, 24);
            this.itemToolStripMenuItem.Text = "Item               Ctrl+I";
            this.itemToolStripMenuItem.Click += new System.EventHandler(this.itemToolStripMenuItem_Click);
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(265, 24);
            this.productToolStripMenuItem.Text = "Product         Ctrl+P";
            this.productToolStripMenuItem.Click += new System.EventHandler(this.productToolStripMenuItem_Click);
            // 
            // brandToolStripMenuItem
            // 
            this.brandToolStripMenuItem.Name = "brandToolStripMenuItem";
            this.brandToolStripMenuItem.Size = new System.Drawing.Size(265, 24);
            this.brandToolStripMenuItem.Text = "Brand            Ctrl+B";
            this.brandToolStripMenuItem.Click += new System.EventHandler(this.brandToolStripMenuItem_Click);
            // 
            // productTypeToolStripMenuItem
            // 
            this.productTypeToolStripMenuItem.Name = "productTypeToolStripMenuItem";
            this.productTypeToolStripMenuItem.Size = new System.Drawing.Size(265, 24);
            this.productTypeToolStripMenuItem.Text = "Supplier Ledger    Ctrl+L";
            this.productTypeToolStripMenuItem.Click += new System.EventHandler(this.productTypeToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(265, 24);
            this.colorToolStripMenuItem.Text = "Color             Ctrl+R";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // taxToolStripMenuItem
            // 
            this.taxToolStripMenuItem.Name = "taxToolStripMenuItem";
            this.taxToolStripMenuItem.Size = new System.Drawing.Size(265, 24);
            this.taxToolStripMenuItem.Text = "Tax                Ctrl+T";
            this.taxToolStripMenuItem.Click += new System.EventHandler(this.taxToolStripMenuItem_Click);
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.purchaseToolStripMenuItem,
            this.salesToolStripMenuItem});
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.transactionToolStripMenuItem.Text = "Transaction";
            // 
            // purchaseToolStripMenuItem
            // 
            this.purchaseToolStripMenuItem.Name = "purchaseToolStripMenuItem";
            this.purchaseToolStripMenuItem.Size = new System.Drawing.Size(222, 24);
            this.purchaseToolStripMenuItem.Text = "Purchase  Ctrl+H";
            this.purchaseToolStripMenuItem.Click += new System.EventHandler(this.purchaseToolStripMenuItem_Click);
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(222, 24);
            this.salesToolStripMenuItem.Text = "Sales          Ctrl+N   ";
            this.salesToolStripMenuItem.Click += new System.EventHandler(this.salesToolStripMenuItem_Click);
            // 
            // detailsToolStripMenuItem
            // 
            this.detailsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.availableStockReportToolStripMenuItem,
            this.purchaseDetailsToolStripMenuItem,
            this.saleDetailsToolStripMenuItem,
            this.stockDetailsToolStripMenuItem});
            this.detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            this.detailsToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.detailsToolStripMenuItem.Text = "Details";
            // 
            // availableStockReportToolStripMenuItem
            // 
            this.availableStockReportToolStripMenuItem.Name = "availableStockReportToolStripMenuItem";
            this.availableStockReportToolStripMenuItem.Size = new System.Drawing.Size(313, 24);
            this.availableStockReportToolStripMenuItem.Text = "Available Stock Report  Ctrl+Q";
            this.availableStockReportToolStripMenuItem.Click += new System.EventHandler(this.availableStockReportToolStripMenuItem_Click);
            // 
            // purchaseDetailsToolStripMenuItem
            // 
            this.purchaseDetailsToolStripMenuItem.Name = "purchaseDetailsToolStripMenuItem";
            this.purchaseDetailsToolStripMenuItem.Size = new System.Drawing.Size(313, 24);
            this.purchaseDetailsToolStripMenuItem.Text = "Purchase Details             Ctrl+W";
            this.purchaseDetailsToolStripMenuItem.Click += new System.EventHandler(this.purchaseDetailsToolStripMenuItem_Click);
            // 
            // saleDetailsToolStripMenuItem
            // 
            this.saleDetailsToolStripMenuItem.Name = "saleDetailsToolStripMenuItem";
            this.saleDetailsToolStripMenuItem.Size = new System.Drawing.Size(313, 24);
            this.saleDetailsToolStripMenuItem.Text = "Sale Details                      Ctrl+E";
            this.saleDetailsToolStripMenuItem.Click += new System.EventHandler(this.saleDetailsToolStripMenuItem_Click);
            // 
            // stockDetailsToolStripMenuItem
            // 
            this.stockDetailsToolStripMenuItem.Name = "stockDetailsToolStripMenuItem";
            this.stockDetailsToolStripMenuItem.Size = new System.Drawing.Size(313, 24);
            this.stockDetailsToolStripMenuItem.Text = "Stock Details                    Ctrl+D";
            this.stockDetailsToolStripMenuItem.Click += new System.EventHandler(this.stockDetailsToolStripMenuItem_Click);
            // 
            // adminstrationToolStripMenuItem
            // 
            this.adminstrationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeDetailsToolStripMenuItem,
            this.changePasswordToolStripMenuItem});
            this.adminstrationToolStripMenuItem.Name = "adminstrationToolStripMenuItem";
            this.adminstrationToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.adminstrationToolStripMenuItem.Text = "Adminstration";
            // 
            // employeeDetailsToolStripMenuItem
            // 
            this.employeeDetailsToolStripMenuItem.Name = "employeeDetailsToolStripMenuItem";
            this.employeeDetailsToolStripMenuItem.Size = new System.Drawing.Size(281, 24);
            this.employeeDetailsToolStripMenuItem.Text = "Employee Details     Ctrl+K";
            this.employeeDetailsToolStripMenuItem.Click += new System.EventHandler(this.employeeDetailsToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(281, 24);
            this.changePasswordToolStripMenuItem.Text = "Change Password     Ctrl+J";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
            this.aboutToolStripMenuItem.Text = "About    Ctrl+Y";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
            this.exitToolStripMenuItem.Text = "Exit        Alt+F4";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(78, 24);
            this.toolStripMenuItem1.Text = "LogOut";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(25, 24);
            this.toolStripMenuItem2.Text = " ";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(25, 24);
            this.toolStripMenuItem3.Text = " ";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(25, 24);
            this.toolStripMenuItem4.Text = " ";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(25, 24);
            this.toolStripMenuItem5.Text = " ";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(25, 24);
            this.toolStripMenuItem6.Text = " ";
            // 
            // PictureBoxHome
            // 
            this.PictureBoxHome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBoxHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureBoxHome.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxHome.Image")));
            this.PictureBoxHome.Location = new System.Drawing.Point(22, 51);
            this.PictureBoxHome.Name = "PictureBoxHome";
            this.PictureBoxHome.Size = new System.Drawing.Size(871, 354);
            this.PictureBoxHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxHome.TabIndex = 1;
            this.PictureBoxHome.TabStop = false;
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
            this.homeToolStripMenuItem.Text = "Home     Alt+H";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 417);
            this.Controls.Add(this.PictureBoxHome);
            this.Controls.Add(this.mainmenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MainMenuStrip = this.mainmenu;
            this.Name = "AdminHome";
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminHome_Load);
            this.mainmenu.ResumeLayout(false);
            this.mainmenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainmenu;
        private System.Windows.Forms.ToolStripMenuItem masterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminstrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem itemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saleDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.PictureBox PictureBoxHome;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem availableStockReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;

    }
}