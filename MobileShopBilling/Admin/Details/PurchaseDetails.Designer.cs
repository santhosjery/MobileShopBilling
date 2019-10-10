namespace MobileShopBilling.Admin.Details
{
    partial class PurchaseDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseDetails));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnRefresgList = new System.Windows.Forms.Button();
            this.LblInvoiceNo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.PanelAdvanceSearch = new System.Windows.Forms.Panel();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.DatePickerTo = new System.Windows.Forms.DateTimePicker();
            this.DatePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.DropDownSupplierMobile = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.DropDownSupplierName = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SwitchAdvanceSearch = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.DropDownInvoiceNumber = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.DataGridLineDetails = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.purchase_line_id_line = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sr_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchase_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.no_of_items = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchasing_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selling_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tax_sum_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cgst_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sgst_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.net_amount_purchase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DropDownBrandName = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.DataGridHeaderDetails = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.purchase_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchase_line_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchase_invoice_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gross_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tax_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discount_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.net_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payment_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paid_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dues_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoice_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.LblHeaderText = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1.SuspendLayout();
            this.PanelAdvanceSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridLineDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridHeaderDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.BtnRefresgList);
            this.panel1.Controls.Add(this.LblInvoiceNo);
            this.panel1.Controls.Add(this.PanelAdvanceSearch);
            this.panel1.Controls.Add(this.SwitchAdvanceSearch);
            this.panel1.Controls.Add(this.bunifuCustomLabel3);
            this.panel1.Controls.Add(this.DropDownInvoiceNumber);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.DataGridLineDetails);
            this.panel1.Controls.Add(this.DropDownBrandName);
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Controls.Add(this.DataGridHeaderDetails);
            this.panel1.Location = new System.Drawing.Point(12, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1335, 418);
            this.panel1.TabIndex = 2;
            // 
            // BtnRefresgList
            // 
            this.BtnRefresgList.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnRefresgList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnRefresgList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRefresgList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRefresgList.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRefresgList.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnRefresgList.Location = new System.Drawing.Point(615, 98);
            this.BtnRefresgList.Name = "BtnRefresgList";
            this.BtnRefresgList.Size = new System.Drawing.Size(80, 38);
            this.BtnRefresgList.TabIndex = 65;
            this.BtnRefresgList.Text = "Refresh";
            this.BtnRefresgList.UseVisualStyleBackColor = false;
            this.BtnRefresgList.Click += new System.EventHandler(this.BtnRefresgList_Click);
            // 
            // LblInvoiceNo
            // 
            this.LblInvoiceNo.AutoSize = true;
            this.LblInvoiceNo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInvoiceNo.Location = new System.Drawing.Point(709, 120);
            this.LblInvoiceNo.Name = "LblInvoiceNo";
            this.LblInvoiceNo.Size = new System.Drawing.Size(87, 16);
            this.LblInvoiceNo.TabIndex = 39;
            this.LblInvoiceNo.Text = "invoice_no";
            this.LblInvoiceNo.Visible = false;
            // 
            // PanelAdvanceSearch
            // 
            this.PanelAdvanceSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PanelAdvanceSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelAdvanceSearch.Controls.Add(this.BtnSearch);
            this.PanelAdvanceSearch.Controls.Add(this.DatePickerTo);
            this.PanelAdvanceSearch.Controls.Add(this.DatePickerFrom);
            this.PanelAdvanceSearch.Controls.Add(this.DropDownSupplierMobile);
            this.PanelAdvanceSearch.Controls.Add(this.bunifuCustomLabel7);
            this.PanelAdvanceSearch.Controls.Add(this.DropDownSupplierName);
            this.PanelAdvanceSearch.Controls.Add(this.bunifuCustomLabel6);
            this.PanelAdvanceSearch.Controls.Add(this.bunifuCustomLabel5);
            this.PanelAdvanceSearch.Controls.Add(this.bunifuCustomLabel4);
            this.PanelAdvanceSearch.Location = new System.Drawing.Point(205, 14);
            this.PanelAdvanceSearch.Name = "PanelAdvanceSearch";
            this.PanelAdvanceSearch.Size = new System.Drawing.Size(1055, 81);
            this.PanelAdvanceSearch.TabIndex = 38;
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearch.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearch.ForeColor = System.Drawing.Color.White;
            this.BtnSearch.Location = new System.Drawing.Point(955, 23);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(85, 37);
            this.BtnSearch.TabIndex = 43;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // DatePickerTo
            // 
            this.DatePickerTo.CalendarFont = new System.Drawing.Font("Georgia", 9.75F);
            this.DatePickerTo.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.DatePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePickerTo.Location = new System.Drawing.Point(217, 36);
            this.DatePickerTo.Name = "DatePickerTo";
            this.DatePickerTo.Size = new System.Drawing.Size(171, 23);
            this.DatePickerTo.TabIndex = 42;
            this.DatePickerTo.Value = new System.DateTime(2019, 5, 19, 0, 0, 0, 0);
            this.DatePickerTo.ValueChanged += new System.EventHandler(this.DatePickerTo_ValueChanged);
            // 
            // DatePickerFrom
            // 
            this.DatePickerFrom.CalendarFont = new System.Drawing.Font("Georgia", 9.75F);
            this.DatePickerFrom.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.DatePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePickerFrom.Location = new System.Drawing.Point(3, 36);
            this.DatePickerFrom.Name = "DatePickerFrom";
            this.DatePickerFrom.Size = new System.Drawing.Size(171, 23);
            this.DatePickerFrom.TabIndex = 39;
            this.DatePickerFrom.ValueChanged += new System.EventHandler(this.DatePickerFrom_ValueChanged);
            // 
            // DropDownSupplierMobile
            // 
            this.DropDownSupplierMobile.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.DropDownSupplierMobile.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.DropDownSupplierMobile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.DropDownSupplierMobile.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DropDownSupplierMobile.FormattingEnabled = true;
            this.DropDownSupplierMobile.Location = new System.Drawing.Point(707, 39);
            this.DropDownSupplierMobile.Name = "DropDownSupplierMobile";
            this.DropDownSupplierMobile.Size = new System.Drawing.Size(217, 24);
            this.DropDownSupplierMobile.TabIndex = 41;
            this.DropDownSupplierMobile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DropDownSupplierMobile_KeyPress);
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Georgia", 10F);
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(704, 19);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(130, 17);
            this.bunifuCustomLabel7.TabIndex = 40;
            this.bunifuCustomLabel7.Text = "Supplier Mobile No";
            // 
            // DropDownSupplierName
            // 
            this.DropDownSupplierName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.DropDownSupplierName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.DropDownSupplierName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.DropDownSupplierName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DropDownSupplierName.FormattingEnabled = true;
            this.DropDownSupplierName.Location = new System.Drawing.Point(436, 36);
            this.DropDownSupplierName.Name = "DropDownSupplierName";
            this.DropDownSupplierName.Size = new System.Drawing.Size(217, 24);
            this.DropDownSupplierName.TabIndex = 39;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Georgia", 10F);
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(433, 16);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(101, 17);
            this.bunifuCustomLabel6.TabIndex = 38;
            this.bunifuCustomLabel6.Text = "Supplier Name";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Georgia", 10F);
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(223, 17);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(58, 17);
            this.bunifuCustomLabel5.TabIndex = 35;
            this.bunifuCustomLabel5.Text = "To Date";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Georgia", 10F);
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(16, 17);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(74, 17);
            this.bunifuCustomLabel4.TabIndex = 34;
            this.bunifuCustomLabel4.Text = "From Date";
            // 
            // SwitchAdvanceSearch
            // 
            this.SwitchAdvanceSearch.BackColor = System.Drawing.Color.Transparent;
            this.SwitchAdvanceSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SwitchAdvanceSearch.BackgroundImage")));
            this.SwitchAdvanceSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SwitchAdvanceSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SwitchAdvanceSearch.Location = new System.Drawing.Point(128, 31);
            this.SwitchAdvanceSearch.Name = "SwitchAdvanceSearch";
            this.SwitchAdvanceSearch.OffColor = System.Drawing.Color.Gray;
            this.SwitchAdvanceSearch.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.SwitchAdvanceSearch.Size = new System.Drawing.Size(35, 20);
            this.SwitchAdvanceSearch.TabIndex = 37;
            this.SwitchAdvanceSearch.Value = true;
            this.SwitchAdvanceSearch.OnValueChange += new System.EventHandler(this.SwitchAdvanceSearch_OnValueChange);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Georgia", 10F);
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(13, 34);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(109, 17);
            this.bunifuCustomLabel3.TabIndex = 36;
            this.bunifuCustomLabel3.Text = "Advance Search";
            // 
            // DropDownInvoiceNumber
            // 
            this.DropDownInvoiceNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.DropDownInvoiceNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.DropDownInvoiceNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.DropDownInvoiceNumber.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DropDownInvoiceNumber.FormattingEnabled = true;
            this.DropDownInvoiceNumber.Location = new System.Drawing.Point(128, 101);
            this.DropDownInvoiceNumber.Name = "DropDownInvoiceNumber";
            this.DropDownInvoiceNumber.Size = new System.Drawing.Size(183, 24);
            this.DropDownInvoiceNumber.TabIndex = 34;
            this.DropDownInvoiceNumber.TextChanged += new System.EventHandler(this.DropDownInvoiceNumber_TextChanged);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Georgia", 10F);
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(11, 101);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(111, 17);
            this.bunifuCustomLabel1.TabIndex = 33;
            this.bunifuCustomLabel1.Text = "Invoice Number";
            // 
            // DataGridLineDetails
            // 
            this.DataGridLineDetails.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGridLineDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridLineDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridLineDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridLineDetails.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DataGridLineDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridLineDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.LawnGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridLineDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridLineDetails.ColumnHeadersHeight = 47;
            this.DataGridLineDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.purchase_line_id_line,
            this.sr_no,
            this.purchase_date,
            this.product_name,
            this.no_of_items,
            this.purchasing_price,
            this.selling_price,
            this.amount,
            this.tax_sum_amount,
            this.cgst_amount,
            this.sgst_amount,
            this.net_amount_purchase});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridLineDetails.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridLineDetails.DoubleBuffered = true;
            this.DataGridLineDetails.EnableHeadersVisualStyles = false;
            this.DataGridLineDetails.HeaderBgColor = System.Drawing.Color.Blue;
            this.DataGridLineDetails.HeaderForeColor = System.Drawing.Color.LawnGreen;
            this.DataGridLineDetails.Location = new System.Drawing.Point(712, 142);
            this.DataGridLineDetails.Name = "DataGridLineDetails";
            this.DataGridLineDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DataGridLineDetails.RowHeadersVisible = false;
            this.DataGridLineDetails.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.DataGridLineDetails.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(4, 0, 0, 4);
            this.DataGridLineDetails.RowTemplate.Height = 37;
            this.DataGridLineDetails.Size = new System.Drawing.Size(620, 254);
            this.DataGridLineDetails.TabIndex = 32;
            // 
            // purchase_line_id_line
            // 
            this.purchase_line_id_line.DataPropertyName = "purchase_line_id_line";
            this.purchase_line_id_line.HeaderText = "purchase_line_id_line";
            this.purchase_line_id_line.Name = "purchase_line_id_line";
            this.purchase_line_id_line.Visible = false;
            // 
            // sr_no
            // 
            this.sr_no.DataPropertyName = "sr_no";
            this.sr_no.FillWeight = 60F;
            this.sr_no.HeaderText = "S.no";
            this.sr_no.Name = "sr_no";
            this.sr_no.Visible = false;
            // 
            // purchase_date
            // 
            this.purchase_date.DataPropertyName = "purchase_date";
            this.purchase_date.FillWeight = 120F;
            this.purchase_date.HeaderText = "Purchase Date";
            this.purchase_date.Name = "purchase_date";
            // 
            // product_name
            // 
            this.product_name.DataPropertyName = "product_name";
            this.product_name.FillWeight = 180F;
            this.product_name.HeaderText = "Product Name";
            this.product_name.Name = "product_name";
            // 
            // no_of_items
            // 
            this.no_of_items.DataPropertyName = "no_of_items";
            this.no_of_items.FillWeight = 60F;
            this.no_of_items.HeaderText = "Qty";
            this.no_of_items.Name = "no_of_items";
            // 
            // purchasing_price
            // 
            this.purchasing_price.DataPropertyName = "purchasing_price";
            this.purchasing_price.HeaderText = "Purchase Price";
            this.purchasing_price.Name = "purchasing_price";
            // 
            // selling_price
            // 
            this.selling_price.DataPropertyName = "selling_price";
            this.selling_price.HeaderText = "Selling price";
            this.selling_price.Name = "selling_price";
            // 
            // amount
            // 
            this.amount.DataPropertyName = "amount";
            this.amount.HeaderText = "Amount";
            this.amount.Name = "amount";
            this.amount.Visible = false;
            // 
            // tax_sum_amount
            // 
            this.tax_sum_amount.DataPropertyName = "tax_sum_amount";
            this.tax_sum_amount.HeaderText = "Tax Amount";
            this.tax_sum_amount.Name = "tax_sum_amount";
            // 
            // cgst_amount
            // 
            this.cgst_amount.DataPropertyName = "cgst_amount";
            this.cgst_amount.HeaderText = "CGST (Rs.)";
            this.cgst_amount.Name = "cgst_amount";
            this.cgst_amount.Visible = false;
            // 
            // sgst_amount
            // 
            this.sgst_amount.DataPropertyName = "sgst_amount";
            this.sgst_amount.HeaderText = "SGST (Rs.)";
            this.sgst_amount.Name = "sgst_amount";
            this.sgst_amount.Visible = false;
            // 
            // net_amount_purchase
            // 
            this.net_amount_purchase.DataPropertyName = "net_amount_purchase";
            this.net_amount_purchase.HeaderText = "Net Amount (Purchase)";
            this.net_amount_purchase.Name = "net_amount_purchase";
            // 
            // DropDownBrandName
            // 
            this.DropDownBrandName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.DropDownBrandName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.DropDownBrandName.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DropDownBrandName.FormattingEnabled = true;
            this.DropDownBrandName.Location = new System.Drawing.Point(411, 101);
            this.DropDownBrandName.Name = "DropDownBrandName";
            this.DropDownBrandName.Size = new System.Drawing.Size(183, 24);
            this.DropDownBrandName.TabIndex = 31;
            this.DropDownBrandName.SelectedIndexChanged += new System.EventHandler(this.DropDownBrandName_SelectedIndexChanged);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Georgia", 10F);
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(319, 101);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(86, 17);
            this.bunifuCustomLabel2.TabIndex = 30;
            this.bunifuCustomLabel2.Text = "Brand Name";
            // 
            // DataGridHeaderDetails
            // 
            this.DataGridHeaderDetails.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGridHeaderDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridHeaderDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DataGridHeaderDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridHeaderDetails.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DataGridHeaderDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridHeaderDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.LawnGreen;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridHeaderDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridHeaderDetails.ColumnHeadersHeight = 43;
            this.DataGridHeaderDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.purchase_id,
            this.purchase_line_id,
            this.purchase_invoice_number,
            this.gross_amount,
            this.tax_amount,
            this.discount_amount,
            this.net_amount,
            this.payment_type,
            this.paid_amount,
            this.dues_amount,
            this.invoice_date,
            this.edit,
            this.Delete});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridHeaderDetails.DefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridHeaderDetails.DoubleBuffered = true;
            this.DataGridHeaderDetails.EnableHeadersVisualStyles = false;
            this.DataGridHeaderDetails.HeaderBgColor = System.Drawing.Color.Blue;
            this.DataGridHeaderDetails.HeaderForeColor = System.Drawing.Color.LawnGreen;
            this.DataGridHeaderDetails.Location = new System.Drawing.Point(14, 142);
            this.DataGridHeaderDetails.Name = "DataGridHeaderDetails";
            this.DataGridHeaderDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DataGridHeaderDetails.RowHeadersVisible = false;
            this.DataGridHeaderDetails.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.DataGridHeaderDetails.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(4, 0, 0, 4);
            this.DataGridHeaderDetails.RowTemplate.Height = 37;
            this.DataGridHeaderDetails.Size = new System.Drawing.Size(681, 254);
            this.DataGridHeaderDetails.TabIndex = 6;
            this.DataGridHeaderDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridHeaderDetails_CellClick);
            // 
            // purchase_id
            // 
            this.purchase_id.DataPropertyName = "purchase_id";
            this.purchase_id.HeaderText = "purchase_id";
            this.purchase_id.Name = "purchase_id";
            this.purchase_id.Visible = false;
            // 
            // purchase_line_id
            // 
            this.purchase_line_id.DataPropertyName = "purchase_line_id";
            this.purchase_line_id.HeaderText = "purchase_line_id";
            this.purchase_line_id.Name = "purchase_line_id";
            this.purchase_line_id.Visible = false;
            // 
            // purchase_invoice_number
            // 
            this.purchase_invoice_number.DataPropertyName = "purchase_invoice_number";
            this.purchase_invoice_number.HeaderText = "Invoice Number";
            this.purchase_invoice_number.Name = "purchase_invoice_number";
            // 
            // gross_amount
            // 
            this.gross_amount.DataPropertyName = "gross_amount";
            this.gross_amount.HeaderText = "Gross Amount";
            this.gross_amount.Name = "gross_amount";
            // 
            // tax_amount
            // 
            this.tax_amount.DataPropertyName = "tax_amount";
            this.tax_amount.HeaderText = "Tax(Rs.)";
            this.tax_amount.Name = "tax_amount";
            // 
            // discount_amount
            // 
            this.discount_amount.DataPropertyName = "discount_amount";
            this.discount_amount.HeaderText = "Discount (Rs.)";
            this.discount_amount.Name = "discount_amount";
            this.discount_amount.Visible = false;
            // 
            // net_amount
            // 
            this.net_amount.DataPropertyName = "net_amount";
            this.net_amount.HeaderText = "Net Amount";
            this.net_amount.Name = "net_amount";
            // 
            // payment_type
            // 
            this.payment_type.DataPropertyName = "payment_type";
            this.payment_type.HeaderText = "Payment Type";
            this.payment_type.Name = "payment_type";
            // 
            // paid_amount
            // 
            this.paid_amount.DataPropertyName = "paid_amount";
            this.paid_amount.HeaderText = "Paid Amount";
            this.paid_amount.Name = "paid_amount";
            // 
            // dues_amount
            // 
            this.dues_amount.DataPropertyName = "dues_amount";
            this.dues_amount.HeaderText = "Dues Amount";
            this.dues_amount.Name = "dues_amount";
            // 
            // invoice_date
            // 
            this.invoice_date.DataPropertyName = "invoice_date";
            this.invoice_date.FillWeight = 130F;
            this.invoice_date.HeaderText = "Invoice Date";
            this.invoice_date.Name = "invoice_date";
            // 
            // edit
            // 
            this.edit.DataPropertyName = "edit";
            this.edit.FillWeight = 70F;
            this.edit.HeaderText = "Edit";
            this.edit.Name = "edit";
            this.edit.Visible = false;
            // 
            // Delete
            // 
            this.Delete.DataPropertyName = "deletepurchase";
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // LblHeaderText
            // 
            this.LblHeaderText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LblHeaderText.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblHeaderText.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.LblHeaderText.ForeColor = System.Drawing.Color.Blue;
            this.LblHeaderText.Location = new System.Drawing.Point(0, 0);
            this.LblHeaderText.Name = "LblHeaderText";
            this.LblHeaderText.Size = new System.Drawing.Size(1359, 31);
            this.LblHeaderText.TabIndex = 38;
            this.LblHeaderText.Text = "Purchase Details";
            this.LblHeaderText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PurchaseDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 488);
            this.Controls.Add(this.LblHeaderText);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PurchaseDetails";
            this.Text = "PurchaseDetails";
            this.Load += new System.EventHandler(this.PurchaseDetails_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PanelAdvanceSearch.ResumeLayout(false);
            this.PanelAdvanceSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridLineDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridHeaderDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel LblInvoiceNo;
        private System.Windows.Forms.Panel PanelAdvanceSearch;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.DateTimePicker DatePickerTo;
        private System.Windows.Forms.DateTimePicker DatePickerFrom;
        private System.Windows.Forms.ComboBox DropDownSupplierMobile;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private System.Windows.Forms.ComboBox DropDownSupplierName;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuiOSSwitch SwitchAdvanceSearch;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.ComboBox DropDownInvoiceNumber;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DataGridLineDetails;
        private System.Windows.Forms.ComboBox DropDownBrandName;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DataGridHeaderDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchase_line_id_line;
        private System.Windows.Forms.DataGridViewTextBoxColumn sr_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchase_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn no_of_items;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchasing_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn selling_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn tax_sum_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn cgst_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn sgst_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn net_amount_purchase;
        private System.Windows.Forms.Button BtnRefresgList;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchase_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchase_line_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchase_invoice_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn gross_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn tax_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn discount_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn net_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn payment_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn paid_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dues_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoice_date;
        private System.Windows.Forms.DataGridViewButtonColumn edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private Bunifu.Framework.UI.BunifuCustomLabel LblHeaderText;
    }
}