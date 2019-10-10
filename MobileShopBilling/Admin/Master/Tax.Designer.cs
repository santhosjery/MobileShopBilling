namespace MobileShopBilling.Admin.Master
{
    partial class Tax
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tax));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnRefresgList = new System.Windows.Forms.Button();
            this.ChkBoxIsActive = new System.Windows.Forms.CheckBox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TxtIGST = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.BtnInsertUpdate = new System.Windows.Forms.Button();
            this.TxtCGST = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TxtSGST = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.DataGridDetails = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.tax_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CGST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sgst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.igst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_active = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.LblHeaderText = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.BtnRefresgList);
            this.groupBox1.Controls.Add(this.ChkBoxIsActive);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel4);
            this.groupBox1.Controls.Add(this.TxtIGST);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel2);
            this.groupBox1.Controls.Add(this.BtnInsertUpdate);
            this.groupBox1.Controls.Add(this.TxtCGST);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel3);
            this.groupBox1.Controls.Add(this.TxtSGST);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel1);
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(113, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 320);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tax Details";
            // 
            // BtnRefresgList
            // 
            this.BtnRefresgList.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnRefresgList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnRefresgList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRefresgList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRefresgList.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRefresgList.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnRefresgList.Location = new System.Drawing.Point(311, 249);
            this.BtnRefresgList.Name = "BtnRefresgList";
            this.BtnRefresgList.Size = new System.Drawing.Size(114, 46);
            this.BtnRefresgList.TabIndex = 66;
            this.BtnRefresgList.Text = "Refresh";
            this.BtnRefresgList.UseVisualStyleBackColor = false;
            this.BtnRefresgList.Click += new System.EventHandler(this.BtnRefresgList_Click);
            // 
            // ChkBoxIsActive
            // 
            this.ChkBoxIsActive.AutoSize = true;
            this.ChkBoxIsActive.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkBoxIsActive.Location = new System.Drawing.Point(180, 205);
            this.ChkBoxIsActive.Name = "ChkBoxIsActive";
            this.ChkBoxIsActive.Size = new System.Drawing.Size(257, 18);
            this.ChkBoxIsActive.TabIndex = 4;
            this.ChkBoxIsActive.Text = "(Check or Uncheck to change status)";
            this.ChkBoxIsActive.UseVisualStyleBackColor = true;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(32, 205);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(71, 18);
            this.bunifuCustomLabel4.TabIndex = 20;
            this.bunifuCustomLabel4.Text = "Is Active";
            // 
            // TxtIGST
            // 
            this.TxtIGST.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtIGST.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIGST.Location = new System.Drawing.Point(180, 150);
            this.TxtIGST.Name = "TxtIGST";
            this.TxtIGST.Size = new System.Drawing.Size(259, 27);
            this.TxtIGST.TabIndex = 3;
            this.TxtIGST.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtIGST_KeyPress);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(32, 150);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(64, 18);
            this.bunifuCustomLabel2.TabIndex = 19;
            this.bunifuCustomLabel2.Text = "IGST %";
            // 
            // BtnInsertUpdate
            // 
            this.BtnInsertUpdate.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnInsertUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnInsertUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInsertUpdate.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInsertUpdate.ForeColor = System.Drawing.Color.White;
            this.BtnInsertUpdate.Location = new System.Drawing.Point(180, 249);
            this.BtnInsertUpdate.Name = "BtnInsertUpdate";
            this.BtnInsertUpdate.Size = new System.Drawing.Size(125, 46);
            this.BtnInsertUpdate.TabIndex = 5;
            this.BtnInsertUpdate.Text = "Save";
            this.BtnInsertUpdate.UseVisualStyleBackColor = false;
            this.BtnInsertUpdate.Click += new System.EventHandler(this.BtnInsertUpdate_Click);
            // 
            // TxtCGST
            // 
            this.TxtCGST.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtCGST.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCGST.Location = new System.Drawing.Point(180, 37);
            this.TxtCGST.Name = "TxtCGST";
            this.TxtCGST.Size = new System.Drawing.Size(259, 27);
            this.TxtCGST.TabIndex = 1;
            this.TxtCGST.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCGST_KeyPress);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(32, 37);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(67, 18);
            this.bunifuCustomLabel3.TabIndex = 15;
            this.bunifuCustomLabel3.Text = "CGST %";
            // 
            // TxtSGST
            // 
            this.TxtSGST.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtSGST.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSGST.Location = new System.Drawing.Point(180, 91);
            this.TxtSGST.Name = "TxtSGST";
            this.TxtSGST.Size = new System.Drawing.Size(259, 27);
            this.TxtSGST.TabIndex = 2;
            this.TxtSGST.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSGST_KeyPress);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(32, 91);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(66, 18);
            this.bunifuCustomLabel1.TabIndex = 17;
            this.bunifuCustomLabel1.Text = "SGST %";
            // 
            // DataGridDetails
            // 
            this.DataGridDetails.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGridDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridDetails.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.tax_code,
            this.CGST,
            this.sgst,
            this.igst,
            this.is_active,
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
            this.DataGridDetails.Location = new System.Drawing.Point(580, 52);
            this.DataGridDetails.Name = "DataGridDetails";
            this.DataGridDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DataGridDetails.RowHeadersVisible = false;
            this.DataGridDetails.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.DataGridDetails.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(4, 0, 0, 4);
            this.DataGridDetails.RowTemplate.Height = 37;
            this.DataGridDetails.Size = new System.Drawing.Size(358, 310);
            this.DataGridDetails.TabIndex = 9;
            this.DataGridDetails.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DataGridDetails_MouseClick);
            // 
            // tax_code
            // 
            this.tax_code.DataPropertyName = "tax_code";
            this.tax_code.HeaderText = "Tax Code";
            this.tax_code.Name = "tax_code";
            this.tax_code.Visible = false;
            // 
            // CGST
            // 
            this.CGST.DataPropertyName = "cgst";
            this.CGST.FillWeight = 80F;
            this.CGST.HeaderText = "CGST";
            this.CGST.Name = "CGST";
            // 
            // sgst
            // 
            this.sgst.DataPropertyName = "sgst";
            this.sgst.FillWeight = 80F;
            this.sgst.HeaderText = "SGST";
            this.sgst.Name = "sgst";
            // 
            // igst
            // 
            this.igst.DataPropertyName = "igst";
            this.igst.FillWeight = 80F;
            this.igst.HeaderText = "IGST";
            this.igst.Name = "igst";
            // 
            // is_active
            // 
            this.is_active.DataPropertyName = "is_active";
            this.is_active.FillWeight = 80F;
            this.is_active.HeaderText = "Active Status";
            this.is_active.Name = "is_active";
            // 
            // delete
            // 
            this.delete.DataPropertyName = "delete";
            this.delete.HeaderText = "Action";
            this.delete.Name = "delete";
            this.delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // LblHeaderText
            // 
            this.LblHeaderText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LblHeaderText.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblHeaderText.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.LblHeaderText.ForeColor = System.Drawing.Color.Blue;
            this.LblHeaderText.Location = new System.Drawing.Point(0, 0);
            this.LblHeaderText.Name = "LblHeaderText";
            this.LblHeaderText.Size = new System.Drawing.Size(1013, 31);
            this.LblHeaderText.TabIndex = 38;
            this.LblHeaderText.Text = "Tax Master";
            this.LblHeaderText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Tax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 450);
            this.Controls.Add(this.LblHeaderText);
            this.Controls.Add(this.DataGridDetails);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tax";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tax";
            this.Load += new System.EventHandler(this.Tax_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnInsertUpdate;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtCGST;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtSGST;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtIGST;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DataGridDetails;
        private System.Windows.Forms.CheckBox ChkBoxIsActive;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn tax_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn CGST;
        private System.Windows.Forms.DataGridViewTextBoxColumn sgst;
        private System.Windows.Forms.DataGridViewTextBoxColumn igst;
        private System.Windows.Forms.DataGridViewTextBoxColumn is_active;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
        private System.Windows.Forms.Button BtnRefresgList;
        private Bunifu.Framework.UI.BunifuCustomLabel LblHeaderText;
    }
}