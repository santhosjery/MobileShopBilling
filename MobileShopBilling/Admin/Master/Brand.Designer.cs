namespace MobileShopBilling.Admin.Master
{
    partial class Brand
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Brand));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnRefresgList = new System.Windows.Forms.Button();
            this.TxtSearchItem = new Bunifu.Framework.UI.BunifuTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.DropDownProductName = new System.Windows.Forms.ComboBox();
            this.DropDownItemName = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.BtnInsertUpdate = new System.Windows.Forms.Button();
            this.DataGridItemMaster = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.brand_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brand_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.created_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TxtBrandName = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.LblHeaderText = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridItemMaster)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.BtnRefresgList);
            this.panel1.Controls.Add(this.TxtSearchItem);
            this.panel1.Controls.Add(this.bunifuCustomLabel3);
            this.panel1.Controls.Add(this.DropDownProductName);
            this.panel1.Controls.Add(this.DropDownItemName);
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Controls.Add(this.BtnInsertUpdate);
            this.panel1.Controls.Add(this.DataGridItemMaster);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.TxtBrandName);
            this.panel1.Location = new System.Drawing.Point(36, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1015, 550);
            this.panel1.TabIndex = 6;
            // 
            // BtnRefresgList
            // 
            this.BtnRefresgList.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnRefresgList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnRefresgList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRefresgList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRefresgList.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRefresgList.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnRefresgList.Location = new System.Drawing.Point(905, 67);
            this.BtnRefresgList.Name = "BtnRefresgList";
            this.BtnRefresgList.Size = new System.Drawing.Size(87, 35);
            this.BtnRefresgList.TabIndex = 62;
            this.BtnRefresgList.Text = "Refresh";
            this.BtnRefresgList.UseVisualStyleBackColor = false;
            this.BtnRefresgList.Click += new System.EventHandler(this.BtnRefresgList_Click);
            // 
            // TxtSearchItem
            // 
            this.TxtSearchItem.BackColor = System.Drawing.Color.White;
            this.TxtSearchItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TxtSearchItem.BackgroundImage")));
            this.TxtSearchItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TxtSearchItem.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSearchItem.ForeColor = System.Drawing.Color.SeaGreen;
            this.TxtSearchItem.Icon = ((System.Drawing.Image)(resources.GetObject("TxtSearchItem.Icon")));
            this.TxtSearchItem.Location = new System.Drawing.Point(22, 73);
            this.TxtSearchItem.Margin = new System.Windows.Forms.Padding(4);
            this.TxtSearchItem.Name = "TxtSearchItem";
            this.TxtSearchItem.Size = new System.Drawing.Size(330, 29);
            this.TxtSearchItem.TabIndex = 15;
            this.TxtSearchItem.text = "";
            this.TxtSearchItem.OnTextChange += new System.EventHandler(this.TxtSearchItem_OnTextChange);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(433, 80);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(97, 18);
            this.bunifuCustomLabel3.TabIndex = 13;
            this.bunifuCustomLabel3.Text = "Brand Name";
            // 
            // DropDownProductName
            // 
            this.DropDownProductName.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DropDownProductName.FormattingEnabled = true;
            this.DropDownProductName.Location = new System.Drawing.Point(550, 25);
            this.DropDownProductName.Name = "DropDownProductName";
            this.DropDownProductName.Size = new System.Drawing.Size(226, 24);
            this.DropDownProductName.TabIndex = 12;
            // 
            // DropDownItemName
            // 
            this.DropDownItemName.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DropDownItemName.FormattingEnabled = true;
            this.DropDownItemName.Location = new System.Drawing.Point(133, 25);
            this.DropDownItemName.Name = "DropDownItemName";
            this.DropDownItemName.Size = new System.Drawing.Size(219, 24);
            this.DropDownItemName.TabIndex = 11;
            this.DropDownItemName.SelectedIndexChanged += new System.EventHandler(this.DropDownItemName_SelectedIndexChanged);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(19, 26);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(89, 18);
            this.bunifuCustomLabel2.TabIndex = 8;
            this.bunifuCustomLabel2.Text = "Item Name";
            // 
            // BtnInsertUpdate
            // 
            this.BtnInsertUpdate.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnInsertUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnInsertUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInsertUpdate.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInsertUpdate.ForeColor = System.Drawing.Color.White;
            this.BtnInsertUpdate.Location = new System.Drawing.Point(792, 67);
            this.BtnInsertUpdate.Name = "BtnInsertUpdate";
            this.BtnInsertUpdate.Size = new System.Drawing.Size(107, 35);
            this.BtnInsertUpdate.TabIndex = 14;
            this.BtnInsertUpdate.Text = "Save";
            this.BtnInsertUpdate.UseVisualStyleBackColor = false;
            this.BtnInsertUpdate.Click += new System.EventHandler(this.BtnInsertUpdate_Click);
            // 
            // DataGridItemMaster
            // 
            this.DataGridItemMaster.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGridItemMaster.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridItemMaster.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridItemMaster.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridItemMaster.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DataGridItemMaster.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridItemMaster.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.LawnGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridItemMaster.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridItemMaster.ColumnHeadersHeight = 43;
            this.DataGridItemMaster.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.brand_code,
            this.brand_name,
            this.product_name,
            this.item_code,
            this.item_name,
            this.product_code,
            this.created_date,
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
            this.DataGridItemMaster.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridItemMaster.DoubleBuffered = true;
            this.DataGridItemMaster.EnableHeadersVisualStyles = false;
            this.DataGridItemMaster.HeaderBgColor = System.Drawing.Color.Blue;
            this.DataGridItemMaster.HeaderForeColor = System.Drawing.Color.LawnGreen;
            this.DataGridItemMaster.Location = new System.Drawing.Point(22, 109);
            this.DataGridItemMaster.Name = "DataGridItemMaster";
            this.DataGridItemMaster.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DataGridItemMaster.RowHeadersVisible = false;
            this.DataGridItemMaster.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.DataGridItemMaster.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(4, 0, 0, 4);
            this.DataGridItemMaster.RowTemplate.Height = 37;
            this.DataGridItemMaster.Size = new System.Drawing.Size(970, 463);
            this.DataGridItemMaster.TabIndex = 4;
            this.DataGridItemMaster.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DataGridItemMaster_MouseClick);
            // 
            // brand_code
            // 
            this.brand_code.DataPropertyName = "brand_code";
            this.brand_code.FillWeight = 60F;
            this.brand_code.HeaderText = "Brand Code";
            this.brand_code.Name = "brand_code";
            // 
            // brand_name
            // 
            this.brand_name.DataPropertyName = "brand_name";
            this.brand_name.FillWeight = 180F;
            this.brand_name.HeaderText = "Brand Name";
            this.brand_name.Name = "brand_name";
            // 
            // product_name
            // 
            this.product_name.DataPropertyName = "product_name";
            this.product_name.FillWeight = 180F;
            this.product_name.HeaderText = "Product Name";
            this.product_name.Name = "product_name";
            // 
            // item_code
            // 
            this.item_code.DataPropertyName = "item_code";
            this.item_code.HeaderText = "Item Code";
            this.item_code.Name = "item_code";
            this.item_code.Visible = false;
            // 
            // item_name
            // 
            this.item_name.DataPropertyName = "item_name";
            this.item_name.HeaderText = "Item Name";
            this.item_name.Name = "item_name";
            // 
            // product_code
            // 
            this.product_code.DataPropertyName = "product_code";
            this.product_code.FillWeight = 60F;
            this.product_code.HeaderText = "Product Code";
            this.product_code.Name = "product_code";
            this.product_code.Visible = false;
            // 
            // created_date
            // 
            this.created_date.DataPropertyName = "created_date";
            this.created_date.HeaderText = "Cretated Date";
            this.created_date.Name = "created_date";
            this.created_date.ReadOnly = true;
            this.created_date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // edit
            // 
            this.edit.DataPropertyName = "edit";
            this.edit.FillWeight = 50F;
            this.edit.HeaderText = "Edit";
            this.edit.Name = "edit";
            this.edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // delete
            // 
            this.delete.DataPropertyName = "delete";
            this.delete.FillWeight = 70F;
            this.delete.HeaderText = "Delete";
            this.delete.Name = "delete";
            this.delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(433, 25);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(110, 18);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Product Name";
            // 
            // TxtBrandName
            // 
            this.TxtBrandName.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtBrandName.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBrandName.Location = new System.Drawing.Point(550, 75);
            this.TxtBrandName.Name = "TxtBrandName";
            this.TxtBrandName.Size = new System.Drawing.Size(226, 26);
            this.TxtBrandName.TabIndex = 13;
            // 
            // LblHeaderText
            // 
            this.LblHeaderText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LblHeaderText.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblHeaderText.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.LblHeaderText.ForeColor = System.Drawing.Color.Blue;
            this.LblHeaderText.Location = new System.Drawing.Point(0, 0);
            this.LblHeaderText.Name = "LblHeaderText";
            this.LblHeaderText.Size = new System.Drawing.Size(1063, 31);
            this.LblHeaderText.TabIndex = 33;
            this.LblHeaderText.Text = "Brand Master";
            this.LblHeaderText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Brand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 614);
            this.Controls.Add(this.LblHeaderText);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Brand";
            this.Text = "Brand";
            this.Load += new System.EventHandler(this.Brand_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridItemMaster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox DropDownItemName;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.Button BtnInsertUpdate;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DataGridItemMaster;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtBrandName;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.ComboBox DropDownProductName;
        private Bunifu.Framework.UI.BunifuTextbox TxtSearchItem;
        private System.Windows.Forms.Button BtnRefresgList;
        private Bunifu.Framework.UI.BunifuCustomLabel LblHeaderText;
        private System.Windows.Forms.DataGridViewTextBoxColumn brand_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn brand_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn created_date;
        private System.Windows.Forms.DataGridViewButtonColumn edit;
        private System.Windows.Forms.DataGridViewButtonColumn delete;

    }
}