namespace MobileShopBilling.Admin.Master
{
    partial class ColorDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColorDetails));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnRefresgList = new System.Windows.Forms.Button();
            this.TxtSearchItem = new Bunifu.Framework.UI.BunifuTextbox();
            this.BtnInsertUpdate = new System.Windows.Forms.Button();
            this.DataGridColorMaster = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.color_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.color_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.created_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TxtColorName = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.LblHeaderText = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridColorMaster)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.BtnRefresgList);
            this.panel1.Controls.Add(this.TxtSearchItem);
            this.panel1.Controls.Add(this.BtnInsertUpdate);
            this.panel1.Controls.Add(this.DataGridColorMaster);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.TxtColorName);
            this.panel1.Location = new System.Drawing.Point(90, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(772, 428);
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
            this.BtnRefresgList.Location = new System.Drawing.Point(649, 13);
            this.BtnRefresgList.Name = "BtnRefresgList";
            this.BtnRefresgList.Size = new System.Drawing.Size(100, 36);
            this.BtnRefresgList.TabIndex = 63;
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
            this.TxtSearchItem.Size = new System.Drawing.Size(276, 29);
            this.TxtSearchItem.TabIndex = 7;
            this.TxtSearchItem.text = "";
            this.TxtSearchItem.OnTextChange += new System.EventHandler(this.TxtSearchItem_OnTextChange);
            // 
            // BtnInsertUpdate
            // 
            this.BtnInsertUpdate.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnInsertUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnInsertUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInsertUpdate.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInsertUpdate.ForeColor = System.Drawing.Color.White;
            this.BtnInsertUpdate.Location = new System.Drawing.Point(518, 13);
            this.BtnInsertUpdate.Name = "BtnInsertUpdate";
            this.BtnInsertUpdate.Size = new System.Drawing.Size(125, 37);
            this.BtnInsertUpdate.TabIndex = 6;
            this.BtnInsertUpdate.Text = "Save";
            this.BtnInsertUpdate.UseVisualStyleBackColor = false;
            this.BtnInsertUpdate.Click += new System.EventHandler(this.BtnInsertUpdate_Click);
            // 
            // DataGridColorMaster
            // 
            this.DataGridColorMaster.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGridColorMaster.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridColorMaster.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridColorMaster.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridColorMaster.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DataGridColorMaster.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridColorMaster.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.LawnGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridColorMaster.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridColorMaster.ColumnHeadersHeight = 43;
            this.DataGridColorMaster.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.color_code,
            this.color_name,
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
            this.DataGridColorMaster.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridColorMaster.DoubleBuffered = true;
            this.DataGridColorMaster.EnableHeadersVisualStyles = false;
            this.DataGridColorMaster.HeaderBgColor = System.Drawing.Color.Blue;
            this.DataGridColorMaster.HeaderForeColor = System.Drawing.Color.LawnGreen;
            this.DataGridColorMaster.Location = new System.Drawing.Point(22, 109);
            this.DataGridColorMaster.Name = "DataGridColorMaster";
            this.DataGridColorMaster.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DataGridColorMaster.RowHeadersVisible = false;
            this.DataGridColorMaster.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.DataGridColorMaster.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(4, 0, 0, 4);
            this.DataGridColorMaster.RowTemplate.Height = 37;
            this.DataGridColorMaster.Size = new System.Drawing.Size(727, 334);
            this.DataGridColorMaster.TabIndex = 4;
            this.DataGridColorMaster.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridColorMaster_CellContentClick);
            // 
            // color_code
            // 
            this.color_code.DataPropertyName = "color_code";
            this.color_code.FillWeight = 60F;
            this.color_code.HeaderText = "Color Code";
            this.color_code.Name = "color_code";
            this.color_code.ReadOnly = true;
            this.color_code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // color_name
            // 
            this.color_name.DataPropertyName = "color_name";
            this.color_name.FillWeight = 300F;
            this.color_name.HeaderText = "Name";
            this.color_name.Name = "color_name";
            this.color_name.ReadOnly = true;
            this.color_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(139, 22);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(91, 18);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Color Name";
            // 
            // TxtColorName
            // 
            this.TxtColorName.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtColorName.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtColorName.Location = new System.Drawing.Point(247, 23);
            this.TxtColorName.Name = "TxtColorName";
            this.TxtColorName.Size = new System.Drawing.Size(241, 26);
            this.TxtColorName.TabIndex = 1;
            // 
            // LblHeaderText
            // 
            this.LblHeaderText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LblHeaderText.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblHeaderText.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.LblHeaderText.ForeColor = System.Drawing.Color.Blue;
            this.LblHeaderText.Location = new System.Drawing.Point(0, 0);
            this.LblHeaderText.Name = "LblHeaderText";
            this.LblHeaderText.Size = new System.Drawing.Size(890, 31);
            this.LblHeaderText.TabIndex = 35;
            this.LblHeaderText.Text = "Color Master";
            this.LblHeaderText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ColorDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 487);
            this.Controls.Add(this.LblHeaderText);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ColorDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ColorDetails";
            this.Load += new System.EventHandler(this.ColorDetails_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridColorMaster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuTextbox TxtSearchItem;
        private System.Windows.Forms.Button BtnInsertUpdate;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DataGridColorMaster;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtColorName;
        private System.Windows.Forms.Button BtnRefresgList;
        private Bunifu.Framework.UI.BunifuCustomLabel LblHeaderText;
        private System.Windows.Forms.DataGridViewTextBoxColumn color_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn color_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn created_date;
        private System.Windows.Forms.DataGridViewButtonColumn edit;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
    }
}