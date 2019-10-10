namespace MobileShopBilling.Admin.Transactions
{
    partial class DataGridPopUp
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataGridPopUp));
            this.DataGridDetails = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.purchase_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchase_line_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoice_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brand_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brand_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hsn_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number_of_items_available = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selling_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cgst_per = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cgst_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sgst_per = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sgst_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.net_amount_sales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblHeaderText = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridDetails
            // 
            this.DataGridDetails.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGridDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.purchase_id,
            this.purchase_line_id,
            this.invoice_number,
            this.brand_code,
            this.brand_name,
            this.product_code,
            this.product_name,
            this.item_code,
            this.item_name,
            this.description,
            this.hsn_code,
            this.number_of_items_available,
            this.selling_price,
            this.cgst_per,
            this.cgst_amount,
            this.sgst_per,
            this.sgst_amount,
            this.net_amount_sales});
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
            this.DataGridDetails.Location = new System.Drawing.Point(12, 57);
            this.DataGridDetails.Name = "DataGridDetails";
            this.DataGridDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DataGridDetails.RowHeadersVisible = false;
            this.DataGridDetails.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.DataGridDetails.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(4, 0, 0, 4);
            this.DataGridDetails.RowTemplate.Height = 37;
            this.DataGridDetails.Size = new System.Drawing.Size(971, 270);
            this.DataGridDetails.TabIndex = 26;
            this.DataGridDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridDetails_CellContentClick);
            this.DataGridDetails.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DataGridDetails_MouseClick);
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
            // invoice_number
            // 
            this.invoice_number.DataPropertyName = "invoice_number";
            this.invoice_number.FillWeight = 130F;
            this.invoice_number.HeaderText = "Invoice No";
            this.invoice_number.Name = "invoice_number";
            this.invoice_number.Width = 80;
            // 
            // brand_code
            // 
            this.brand_code.DataPropertyName = "brand_code";
            this.brand_code.HeaderText = "Brandcode";
            this.brand_code.Name = "brand_code";
            this.brand_code.Visible = false;
            // 
            // brand_name
            // 
            this.brand_name.DataPropertyName = "brand_name";
            this.brand_name.FillWeight = 200F;
            this.brand_name.HeaderText = "Brand Name";
            this.brand_name.Name = "brand_name";
            this.brand_name.Width = 124;
            // 
            // product_code
            // 
            this.product_code.DataPropertyName = "product_code";
            this.product_code.HeaderText = "Productcode";
            this.product_code.Name = "product_code";
            this.product_code.Visible = false;
            // 
            // product_name
            // 
            this.product_name.DataPropertyName = "product_name";
            this.product_name.FillWeight = 200F;
            this.product_name.HeaderText = "Product Name";
            this.product_name.Name = "product_name";
            this.product_name.Width = 123;
            // 
            // item_code
            // 
            this.item_code.DataPropertyName = "item_code";
            this.item_code.HeaderText = "Itemcode";
            this.item_code.Name = "item_code";
            this.item_code.Visible = false;
            // 
            // item_name
            // 
            this.item_name.DataPropertyName = "item_name";
            this.item_name.FillWeight = 150F;
            this.item_name.HeaderText = "Item Name";
            this.item_name.Name = "item_name";
            this.item_name.Width = 93;
            // 
            // description
            // 
            this.description.DataPropertyName = "description";
            this.description.FillWeight = 190F;
            this.description.HeaderText = "Description";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Width = 117;
            // 
            // hsn_code
            // 
            this.hsn_code.DataPropertyName = "hsn_code";
            this.hsn_code.FillWeight = 80F;
            this.hsn_code.HeaderText = "HSN Code";
            this.hsn_code.Name = "hsn_code";
            this.hsn_code.ReadOnly = true;
            this.hsn_code.Width = 49;
            // 
            // number_of_items_available
            // 
            this.number_of_items_available.DataPropertyName = "number_of_items_available";
            this.number_of_items_available.FillWeight = 80F;
            this.number_of_items_available.HeaderText = "Available Quantity";
            this.number_of_items_available.Name = "number_of_items_available";
            this.number_of_items_available.ReadOnly = true;
            this.number_of_items_available.Width = 50;
            // 
            // selling_price
            // 
            this.selling_price.DataPropertyName = "selling_price";
            this.selling_price.HeaderText = "Price";
            this.selling_price.Name = "selling_price";
            this.selling_price.ReadOnly = true;
            this.selling_price.Width = 62;
            // 
            // cgst_per
            // 
            this.cgst_per.DataPropertyName = "cgst_per";
            this.cgst_per.FillWeight = 70F;
            this.cgst_per.HeaderText = "Cgst (%)";
            this.cgst_per.Name = "cgst_per";
            this.cgst_per.ReadOnly = true;
            this.cgst_per.Width = 43;
            // 
            // cgst_amount
            // 
            this.cgst_amount.DataPropertyName = "cgst_amount";
            this.cgst_amount.HeaderText = "Cgst (Rs)";
            this.cgst_amount.Name = "cgst_amount";
            this.cgst_amount.ReadOnly = true;
            this.cgst_amount.Width = 62;
            // 
            // sgst_per
            // 
            this.sgst_per.DataPropertyName = "sgst_per";
            this.sgst_per.FillWeight = 70F;
            this.sgst_per.HeaderText = "Sgst (%)";
            this.sgst_per.Name = "sgst_per";
            this.sgst_per.ReadOnly = true;
            this.sgst_per.Width = 43;
            // 
            // sgst_amount
            // 
            this.sgst_amount.DataPropertyName = "sgst_amount";
            this.sgst_amount.HeaderText = "Sgst (Rs)";
            this.sgst_amount.Name = "sgst_amount";
            this.sgst_amount.ReadOnly = true;
            this.sgst_amount.Width = 62;
            // 
            // net_amount_sales
            // 
            this.net_amount_sales.DataPropertyName = "net_amount_sales";
            this.net_amount_sales.HeaderText = "Total Amount";
            this.net_amount_sales.Name = "net_amount_sales";
            this.net_amount_sales.ReadOnly = true;
            this.net_amount_sales.Width = 62;
            // 
            // LblHeaderText
            // 
            this.LblHeaderText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LblHeaderText.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblHeaderText.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.LblHeaderText.ForeColor = System.Drawing.Color.Blue;
            this.LblHeaderText.Location = new System.Drawing.Point(0, 0);
            this.LblHeaderText.Name = "LblHeaderText";
            this.LblHeaderText.Size = new System.Drawing.Size(995, 31);
            this.LblHeaderText.TabIndex = 37;
            this.LblHeaderText.Text = "Purchased Items";
            this.LblHeaderText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DataGridPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 360);
            this.Controls.Add(this.LblHeaderText);
            this.Controls.Add(this.DataGridDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DataGridPopUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataGridPopUp";
            this.Load += new System.EventHandler(this.DataGridPopUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid DataGridDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchase_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchase_line_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoice_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn brand_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn brand_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn hsn_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn number_of_items_available;
        private System.Windows.Forms.DataGridViewTextBoxColumn selling_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn cgst_per;
        private System.Windows.Forms.DataGridViewTextBoxColumn cgst_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn sgst_per;
        private System.Windows.Forms.DataGridViewTextBoxColumn sgst_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn net_amount_sales;
        private Bunifu.Framework.UI.BunifuCustomLabel LblHeaderText;
    }
}