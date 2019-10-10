namespace MobileShopBilling.Admin.Details
{
    partial class StockDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockDetails));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnRefresgList = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.DatePickerTo = new System.Windows.Forms.DateTimePicker();
            this.DatePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.DropDownBrandName = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TxtSearchItem = new Bunifu.Framework.UI.BunifuTextbox();
            this.DataGridDetails = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.stock_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brand_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.available_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opening_stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_purchase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_sales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closing_stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchasing_price_sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selling_price_sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_purchase_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_sale_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
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
            this.panel1.Controls.Add(this.BtnRefresgList);
            this.panel1.Controls.Add(this.BtnSearch);
            this.panel1.Controls.Add(this.DatePickerTo);
            this.panel1.Controls.Add(this.DatePickerFrom);
            this.panel1.Controls.Add(this.bunifuCustomLabel5);
            this.panel1.Controls.Add(this.bunifuCustomLabel4);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.DropDownBrandName);
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Controls.Add(this.TxtSearchItem);
            this.panel1.Controls.Add(this.DataGridDetails);
            this.panel1.Location = new System.Drawing.Point(12, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1178, 426);
            this.panel1.TabIndex = 0;
            // 
            // BtnRefresgList
            // 
            this.BtnRefresgList.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnRefresgList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnRefresgList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRefresgList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRefresgList.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRefresgList.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnRefresgList.Location = new System.Drawing.Point(1085, 32);
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
            this.BtnSearch.Location = new System.Drawing.Point(995, 33);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(84, 37);
            this.BtnSearch.TabIndex = 44;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // DatePickerTo
            // 
            this.DatePickerTo.CalendarFont = new System.Drawing.Font("Georgia", 9F);
            this.DatePickerTo.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.DatePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePickerTo.Location = new System.Drawing.Point(799, 39);
            this.DatePickerTo.Name = "DatePickerTo";
            this.DatePickerTo.Size = new System.Drawing.Size(180, 23);
            this.DatePickerTo.TabIndex = 46;
            this.DatePickerTo.Value = new System.DateTime(2019, 5, 19, 0, 0, 0, 0);
            this.DatePickerTo.ValueChanged += new System.EventHandler(this.DatePickerTo_ValueChanged);
            // 
            // DatePickerFrom
            // 
            this.DatePickerFrom.CalendarFont = new System.Drawing.Font("Georgia", 9F);
            this.DatePickerFrom.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.DatePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePickerFrom.Location = new System.Drawing.Point(588, 39);
            this.DatePickerFrom.Name = "DatePickerFrom";
            this.DatePickerFrom.Size = new System.Drawing.Size(180, 23);
            this.DatePickerFrom.TabIndex = 45;
            this.DatePickerFrom.ValueChanged += new System.EventHandler(this.DatePickerFrom_ValueChanged);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Georgia", 10F);
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(796, 17);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(58, 17);
            this.bunifuCustomLabel5.TabIndex = 44;
            this.bunifuCustomLabel5.Text = "To Date";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Georgia", 10F);
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(585, 17);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(74, 17);
            this.bunifuCustomLabel4.TabIndex = 43;
            this.bunifuCustomLabel4.Text = "From Date";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(285, 17);
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
            this.DropDownBrandName.Location = new System.Drawing.Point(14, 44);
            this.DropDownBrandName.Name = "DropDownBrandName";
            this.DropDownBrandName.Size = new System.Drawing.Size(256, 24);
            this.DropDownBrandName.TabIndex = 31;
            this.DropDownBrandName.SelectedIndexChanged += new System.EventHandler(this.DropDownBrandName_SelectedIndexChanged);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(11, 17);
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
            this.TxtSearchItem.Location = new System.Drawing.Point(288, 39);
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
            this.DataGridDetails.ColumnHeadersHeight = 43;
            this.DataGridDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stock_code,
            this.product_name,
            this.brand_name,
            this.available_quantity,
            this.opening_stock,
            this.total_purchase,
            this.total_sales,
            this.closing_stock,
            this.purchasing_price_sum,
            this.selling_price_sum,
            this.last_purchase_date,
            this.last_sale_date,
            this.edit,
            this.delete});
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
            this.DataGridDetails.Size = new System.Drawing.Size(1161, 300);
            this.DataGridDetails.TabIndex = 6;
            // 
            // stock_code
            // 
            this.stock_code.DataPropertyName = "stock_code";
            this.stock_code.HeaderText = "Stock Code";
            this.stock_code.Name = "stock_code";
            // 
            // product_name
            // 
            this.product_name.DataPropertyName = "product_name";
            this.product_name.FillWeight = 140F;
            this.product_name.HeaderText = "Product Name";
            this.product_name.Name = "product_name";
            // 
            // brand_name
            // 
            this.brand_name.DataPropertyName = "brand_name";
            this.brand_name.FillWeight = 140F;
            this.brand_name.HeaderText = "Brand Name";
            this.brand_name.Name = "brand_name";
            // 
            // available_quantity
            // 
            this.available_quantity.DataPropertyName = "available_quantity";
            this.available_quantity.HeaderText = "Available Quantity";
            this.available_quantity.Name = "available_quantity";
            this.available_quantity.Visible = false;
            // 
            // opening_stock
            // 
            this.opening_stock.DataPropertyName = "opening_stock";
            this.opening_stock.HeaderText = "Opening Stock";
            this.opening_stock.Name = "opening_stock";
            // 
            // total_purchase
            // 
            this.total_purchase.DataPropertyName = "total_purchase";
            this.total_purchase.HeaderText = "Purchased Items (Tot)";
            this.total_purchase.Name = "total_purchase";
            // 
            // total_sales
            // 
            this.total_sales.DataPropertyName = "total_sales";
            this.total_sales.HeaderText = "Total Sales Items(Tot)";
            this.total_sales.Name = "total_sales";
            // 
            // closing_stock
            // 
            this.closing_stock.DataPropertyName = "closing_stock";
            this.closing_stock.HeaderText = "Closing Stock";
            this.closing_stock.Name = "closing_stock";
            // 
            // purchasing_price_sum
            // 
            this.purchasing_price_sum.DataPropertyName = "purchasing_price_sum";
            this.purchasing_price_sum.HeaderText = "Total Purchase Amount";
            this.purchasing_price_sum.Name = "purchasing_price_sum";
            this.purchasing_price_sum.Visible = false;
            // 
            // selling_price_sum
            // 
            this.selling_price_sum.DataPropertyName = "selling_price_sum";
            this.selling_price_sum.HeaderText = "Total Sales Amount";
            this.selling_price_sum.Name = "selling_price_sum";
            this.selling_price_sum.Visible = false;
            // 
            // last_purchase_date
            // 
            this.last_purchase_date.DataPropertyName = "last_purchase_date";
            this.last_purchase_date.HeaderText = "Purchased Date(Last)";
            this.last_purchase_date.Name = "last_purchase_date";
            this.last_purchase_date.Visible = false;
            // 
            // last_sale_date
            // 
            this.last_sale_date.DataPropertyName = "last_sale_date";
            this.last_sale_date.HeaderText = "Sales Date(Last)";
            this.last_sale_date.Name = "last_sale_date";
            this.last_sale_date.Visible = false;
            // 
            // edit
            // 
            this.edit.DataPropertyName = "edit";
            this.edit.FillWeight = 60F;
            this.edit.HeaderText = "Edit";
            this.edit.Name = "edit";
            this.edit.Visible = false;
            // 
            // delete
            // 
            this.delete.DataPropertyName = "delete";
            this.delete.FillWeight = 60F;
            this.delete.HeaderText = "Delete";
            this.delete.Name = "delete";
            this.delete.Visible = false;
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
            this.LblHeaderText.TabIndex = 39;
            this.LblHeaderText.Text = "Stock Details";
            this.LblHeaderText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StockDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 488);
            this.Controls.Add(this.LblHeaderText);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StockDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StockDetails";
            this.Load += new System.EventHandler(this.StockDetails_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DataGridDetails;
        private Bunifu.Framework.UI.BunifuTextbox TxtSearchItem;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.ComboBox DropDownBrandName;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.DateTimePicker DatePickerTo;
        private System.Windows.Forms.DateTimePicker DatePickerFrom;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnRefresgList;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn brand_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn available_quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn opening_stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_purchase;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_sales;
        private System.Windows.Forms.DataGridViewTextBoxColumn closing_stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchasing_price_sum;
        private System.Windows.Forms.DataGridViewTextBoxColumn selling_price_sum;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_purchase_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_sale_date;
        private System.Windows.Forms.DataGridViewButtonColumn edit;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
        private Bunifu.Framework.UI.BunifuCustomLabel LblHeaderText;
    }
}