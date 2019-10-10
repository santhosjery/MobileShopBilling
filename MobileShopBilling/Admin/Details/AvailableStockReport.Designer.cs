namespace MobileShopBilling.Admin.Details
{
    partial class AvailableStockReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AvailableStockReport));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DropDownColorName = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.BtnRefresgList = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.DropDownBrandName = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TxtSearchItem = new Bunifu.Framework.UI.BunifuTextbox();
            this.DataGridDetails = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.availability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brand_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brand_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_stock_items = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_stock_amount_purchase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_stock_amount_sales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_purchase_items = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_sales_items = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_purchasing_price_p = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_sales_price_s = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_discount_price_s = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.color_to_show = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblHeaderText = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.DropDownColorName);
            this.panel1.Controls.Add(this.bunifuCustomLabel3);
            this.panel1.Controls.Add(this.BtnRefresgList);
            this.panel1.Controls.Add(this.BtnSearch);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.DropDownBrandName);
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Controls.Add(this.TxtSearchItem);
            this.panel1.Controls.Add(this.DataGridDetails);
            this.panel1.Location = new System.Drawing.Point(12, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1178, 498);
            this.panel1.TabIndex = 1;
            // 
            // DropDownColorName
            // 
            this.DropDownColorName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropDownColorName.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DropDownColorName.FormattingEnabled = true;
            this.DropDownColorName.Location = new System.Drawing.Point(536, 41);
            this.DropDownColorName.Name = "DropDownColorName";
            this.DropDownColorName.Size = new System.Drawing.Size(226, 24);
            this.DropDownColorName.TabIndex = 65;
            this.DropDownColorName.SelectedIndexChanged += new System.EventHandler(this.DropDownColorName_SelectedIndexChanged);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(533, 14);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(45, 18);
            this.bunifuCustomLabel3.TabIndex = 64;
            this.bunifuCustomLabel3.Text = "Color";
            // 
            // BtnRefresgList
            // 
            this.BtnRefresgList.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnRefresgList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnRefresgList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRefresgList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRefresgList.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRefresgList.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnRefresgList.Location = new System.Drawing.Point(788, 29);
            this.BtnRefresgList.Name = "BtnRefresgList";
            this.BtnRefresgList.Size = new System.Drawing.Size(75, 38);
            this.BtnRefresgList.TabIndex = 63;
            this.BtnRefresgList.Text = "Refresh";
            this.BtnRefresgList.UseVisualStyleBackColor = false;
            this.BtnRefresgList.Click += new System.EventHandler(this.BtnRefresgList_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearch.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearch.ForeColor = System.Drawing.Color.White;
            this.BtnSearch.Location = new System.Drawing.Point(1063, 19);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(84, 37);
            this.BtnSearch.TabIndex = 44;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Visible = false;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(15, 19);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(97, 18);
            this.bunifuCustomLabel1.TabIndex = 32;
            this.bunifuCustomLabel1.Text = "Brand Name";
            // 
            // DropDownBrandName
            // 
            this.DropDownBrandName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropDownBrandName.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DropDownBrandName.FormattingEnabled = true;
            this.DropDownBrandName.Location = new System.Drawing.Point(304, 41);
            this.DropDownBrandName.Name = "DropDownBrandName";
            this.DropDownBrandName.Size = new System.Drawing.Size(226, 24);
            this.DropDownBrandName.TabIndex = 31;
            this.DropDownBrandName.SelectedIndexChanged += new System.EventHandler(this.DropDownBrandName_SelectedIndexChanged);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(301, 14);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(97, 18);
            this.bunifuCustomLabel2.TabIndex = 30;
            this.bunifuCustomLabel2.Text = "Brand Name";
            // 
            // TxtSearchItem
            // 
            this.TxtSearchItem.BackColor = System.Drawing.Color.White;
            this.TxtSearchItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TxtSearchItem.BackgroundImage")));
            this.TxtSearchItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TxtSearchItem.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSearchItem.ForeColor = System.Drawing.Color.SeaGreen;
            this.TxtSearchItem.Icon = ((System.Drawing.Image)(resources.GetObject("TxtSearchItem.Icon")));
            this.TxtSearchItem.Location = new System.Drawing.Point(18, 41);
            this.TxtSearchItem.Margin = new System.Windows.Forms.Padding(4);
            this.TxtSearchItem.Name = "TxtSearchItem";
            this.TxtSearchItem.Size = new System.Drawing.Size(279, 28);
            this.TxtSearchItem.TabIndex = 29;
            this.TxtSearchItem.text = "";
            this.TxtSearchItem.OnTextChange += new System.EventHandler(this.TxtSearchItem_OnTextChange);
            // 
            // DataGridDetails
            // 
            this.DataGridDetails.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGridDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridDetails.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DataGridDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.LawnGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridDetails.ColumnHeadersHeight = 46;
            this.DataGridDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.availability,
            this.stock_code,
            this.brand_code,
            this.brand_name,
            this.product_name,
            this.total_stock_items,
            this.total_stock_amount_purchase,
            this.total_stock_amount_sales,
            this.total_purchase_items,
            this.total_sales_items,
            this.total_purchasing_price_p,
            this.total_sales_price_s,
            this.total_discount_price_s,
            this.color_to_show});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridDetails.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridDetails.DoubleBuffered = true;
            this.DataGridDetails.EnableHeadersVisualStyles = false;
            this.DataGridDetails.HeaderBgColor = System.Drawing.Color.Blue;
            this.DataGridDetails.HeaderForeColor = System.Drawing.Color.LawnGreen;
            this.DataGridDetails.Location = new System.Drawing.Point(14, 73);
            this.DataGridDetails.Name = "DataGridDetails";
            this.DataGridDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DataGridDetails.RowHeadersVisible = false;
            this.DataGridDetails.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.DataGridDetails.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(4, 0, 0, 4);
            this.DataGridDetails.RowTemplate.Height = 37;
            this.DataGridDetails.Size = new System.Drawing.Size(1161, 401);
            this.DataGridDetails.TabIndex = 6;
            this.DataGridDetails.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataGridDetails_CellFormatting);
            // 
            // availability
            // 
            this.availability.DataPropertyName = "availability";
            this.availability.FillWeight = 20F;
            this.availability.HeaderText = "";
            this.availability.Name = "availability";
            this.availability.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.availability.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // stock_code
            // 
            this.stock_code.DataPropertyName = "stock_code";
            this.stock_code.HeaderText = "Stock Code";
            this.stock_code.Name = "stock_code";
            this.stock_code.Visible = false;
            // 
            // brand_code
            // 
            this.brand_code.HeaderText = "brand_code";
            this.brand_code.Name = "brand_code";
            this.brand_code.Visible = false;
            // 
            // brand_name
            // 
            this.brand_name.DataPropertyName = "brand_name";
            this.brand_name.HeaderText = "Brand Name";
            this.brand_name.Name = "brand_name";
            // 
            // product_name
            // 
            this.product_name.DataPropertyName = "product_name";
            this.product_name.FillWeight = 140F;
            this.product_name.HeaderText = "Product Name";
            this.product_name.Name = "product_name";
            // 
            // total_stock_items
            // 
            this.total_stock_items.DataPropertyName = "total_stock_items";
            this.total_stock_items.HeaderText = "Total Stock Items (No)";
            this.total_stock_items.Name = "total_stock_items";
            // 
            // total_stock_amount_purchase
            // 
            this.total_stock_amount_purchase.DataPropertyName = "total_stock_amount_purchase";
            this.total_stock_amount_purchase.HeaderText = "Total Stock Amount Purchase";
            this.total_stock_amount_purchase.Name = "total_stock_amount_purchase";
            // 
            // total_stock_amount_sales
            // 
            this.total_stock_amount_sales.DataPropertyName = "total_stock_amount_sales";
            this.total_stock_amount_sales.HeaderText = "Total Stock Amount Sales";
            this.total_stock_amount_sales.Name = "total_stock_amount_sales";
            // 
            // total_purchase_items
            // 
            this.total_purchase_items.DataPropertyName = "total_purchase_items";
            this.total_purchase_items.HeaderText = "Total Purchas Items (No)";
            this.total_purchase_items.Name = "total_purchase_items";
            // 
            // total_sales_items
            // 
            this.total_sales_items.DataPropertyName = "total_sales_items";
            this.total_sales_items.HeaderText = "Total Sales Items (No)";
            this.total_sales_items.Name = "total_sales_items";
            // 
            // total_purchasing_price_p
            // 
            this.total_purchasing_price_p.DataPropertyName = "total_purchasing_price_p";
            this.total_purchasing_price_p.HeaderText = "Total Purchase Amount";
            this.total_purchasing_price_p.Name = "total_purchasing_price_p";
            // 
            // total_sales_price_s
            // 
            this.total_sales_price_s.DataPropertyName = "total_sales_price_s";
            this.total_sales_price_s.HeaderText = "Total Sales Amount";
            this.total_sales_price_s.Name = "total_sales_price_s";
            // 
            // total_discount_price_s
            // 
            this.total_discount_price_s.DataPropertyName = "total_discount_price_s";
            this.total_discount_price_s.HeaderText = "Total Sales Discount (Rs)";
            this.total_discount_price_s.Name = "total_discount_price_s";
            // 
            // color_to_show
            // 
            this.color_to_show.DataPropertyName = "color_to_show";
            this.color_to_show.HeaderText = "color_to_show";
            this.color_to_show.Name = "color_to_show";
            this.color_to_show.Visible = false;
            // 
            // LblHeaderText
            // 
            this.LblHeaderText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LblHeaderText.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblHeaderText.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.LblHeaderText.ForeColor = System.Drawing.Color.Blue;
            this.LblHeaderText.Location = new System.Drawing.Point(0, 0);
            this.LblHeaderText.Name = "LblHeaderText";
            this.LblHeaderText.Size = new System.Drawing.Size(1202, 31);
            this.LblHeaderText.TabIndex = 37;
            this.LblHeaderText.Text = "Stock Report";
            this.LblHeaderText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AvailableStockReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 554);
            this.Controls.Add(this.LblHeaderText);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AvailableStockReport";
            this.Text = "Available Stock Report";
            this.Load += new System.EventHandler(this.AvailableStockReport_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnRefresgList;
        private System.Windows.Forms.Button BtnSearch;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.ComboBox DropDownBrandName;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuTextbox TxtSearchItem;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DataGridDetails;
        private System.Windows.Forms.ComboBox DropDownColorName;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn availability;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn brand_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn brand_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_stock_items;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_stock_amount_purchase;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_stock_amount_sales;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_purchase_items;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_sales_items;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_purchasing_price_p;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_sales_price_s;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_discount_price_s;
        private System.Windows.Forms.DataGridViewTextBoxColumn color_to_show;
        private Bunifu.Framework.UI.BunifuCustomLabel LblHeaderText;
    }
}