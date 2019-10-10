namespace MobileShopBilling.Admin.AdminSettings
{
    partial class EmployeeDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeDetails));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtSearchItem = new Bunifu.Framework.UI.BunifuTextbox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.DropDownUserRole = new System.Windows.Forms.ComboBox();
            this.TxtUserName = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.BtnInsertUpdate = new System.Windows.Forms.Button();
            this.TxtArSAddrTwo = new System.Windows.Forms.RichTextBox();
            this.TxtArSAddrOne = new System.Windows.Forms.RichTextBox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TxtPassword = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TxtMobileNo = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TxtSEmailId = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.DataGridDetails = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.user_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_role_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobile_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.created_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.LblHeaderText = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.TxtSearchItem);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.DataGridDetails);
            this.panel1.Location = new System.Drawing.Point(61, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1230, 496);
            this.panel1.TabIndex = 7;
            // 
            // TxtSearchItem
            // 
            this.TxtSearchItem.BackColor = System.Drawing.Color.White;
            this.TxtSearchItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TxtSearchItem.BackgroundImage")));
            this.TxtSearchItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TxtSearchItem.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSearchItem.ForeColor = System.Drawing.Color.SeaGreen;
            this.TxtSearchItem.Icon = ((System.Drawing.Image)(resources.GetObject("TxtSearchItem.Icon")));
            this.TxtSearchItem.Location = new System.Drawing.Point(497, 13);
            this.TxtSearchItem.Margin = new System.Windows.Forms.Padding(4);
            this.TxtSearchItem.Name = "TxtSearchItem";
            this.TxtSearchItem.Size = new System.Drawing.Size(330, 29);
            this.TxtSearchItem.TabIndex = 28;
            this.TxtSearchItem.text = "";
            this.TxtSearchItem.OnTextChange += new System.EventHandler(this.TxtSearchItem_OnTextChange);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnRefresh);
            this.groupBox1.Controls.Add(this.DropDownUserRole);
            this.groupBox1.Controls.Add(this.TxtUserName);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel7);
            this.groupBox1.Controls.Add(this.BtnInsertUpdate);
            this.groupBox1.Controls.Add(this.TxtArSAddrTwo);
            this.groupBox1.Controls.Add(this.TxtArSAddrOne);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel5);
            this.groupBox1.Controls.Add(this.TxtPassword);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel6);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel3);
            this.groupBox1.Controls.Add(this.TxtMobileNo);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel2);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel1);
            this.groupBox1.Controls.Add(this.TxtSEmailId);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel4);
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 497);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRefresh.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRefresh.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.BtnRefresh.Location = new System.Drawing.Point(314, 423);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(125, 46);
            this.BtnRefresh.TabIndex = 27;
            this.BtnRefresh.Text = "Refresh";
            this.BtnRefresh.UseVisualStyleBackColor = false;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // DropDownUserRole
            // 
            this.DropDownUserRole.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DropDownUserRole.FormattingEnabled = true;
            this.DropDownUserRole.Location = new System.Drawing.Point(180, 135);
            this.DropDownUserRole.Name = "DropDownUserRole";
            this.DropDownUserRole.Size = new System.Drawing.Size(259, 24);
            this.DropDownUserRole.TabIndex = 3;
            // 
            // TxtUserName
            // 
            this.TxtUserName.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtUserName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUserName.Location = new System.Drawing.Point(180, 36);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(259, 23);
            this.TxtUserName.TabIndex = 1;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(32, 36);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(84, 18);
            this.bunifuCustomLabel7.TabIndex = 26;
            this.bunifuCustomLabel7.Text = "UserName";
            // 
            // BtnInsertUpdate
            // 
            this.BtnInsertUpdate.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnInsertUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnInsertUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInsertUpdate.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInsertUpdate.ForeColor = System.Drawing.Color.White;
            this.BtnInsertUpdate.Location = new System.Drawing.Point(180, 423);
            this.BtnInsertUpdate.Name = "BtnInsertUpdate";
            this.BtnInsertUpdate.Size = new System.Drawing.Size(125, 46);
            this.BtnInsertUpdate.TabIndex = 7;
            this.BtnInsertUpdate.Text = "Add";
            this.BtnInsertUpdate.UseVisualStyleBackColor = false;
            this.BtnInsertUpdate.Click += new System.EventHandler(this.BtnInsertUpdate_Click);
            // 
            // TxtArSAddrTwo
            // 
            this.TxtArSAddrTwo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtArSAddrTwo.Location = new System.Drawing.Point(180, 366);
            this.TxtArSAddrTwo.Name = "TxtArSAddrTwo";
            this.TxtArSAddrTwo.Size = new System.Drawing.Size(259, 47);
            this.TxtArSAddrTwo.TabIndex = 7;
            this.TxtArSAddrTwo.Text = "";
            // 
            // TxtArSAddrOne
            // 
            this.TxtArSAddrOne.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtArSAddrOne.Location = new System.Drawing.Point(180, 284);
            this.TxtArSAddrOne.Name = "TxtArSAddrOne";
            this.TxtArSAddrOne.Size = new System.Drawing.Size(259, 49);
            this.TxtArSAddrOne.TabIndex = 6;
            this.TxtArSAddrOne.Text = "";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(32, 284);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(81, 18);
            this.bunifuCustomLabel5.TabIndex = 25;
            this.bunifuCustomLabel5.Text = "Address-1";
            // 
            // TxtPassword
            // 
            this.TxtPassword.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtPassword.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.Location = new System.Drawing.Point(180, 87);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.Size = new System.Drawing.Size(259, 23);
            this.TxtPassword.TabIndex = 2;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(32, 183);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(119, 18);
            this.bunifuCustomLabel6.TabIndex = 23;
            this.bunifuCustomLabel6.Text = "Mobile Number";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(32, 141);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(77, 18);
            this.bunifuCustomLabel3.TabIndex = 15;
            this.bunifuCustomLabel3.Text = "User Role";
            // 
            // TxtMobileNo
            // 
            this.TxtMobileNo.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtMobileNo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMobileNo.Location = new System.Drawing.Point(180, 183);
            this.TxtMobileNo.Name = "TxtMobileNo";
            this.TxtMobileNo.Size = new System.Drawing.Size(259, 23);
            this.TxtMobileNo.TabIndex = 4;
            this.TxtMobileNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMobileNo_KeyPress);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(32, 238);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(68, 18);
            this.bunifuCustomLabel2.TabIndex = 21;
            this.bunifuCustomLabel2.Text = "Email Id";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(32, 87);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(76, 18);
            this.bunifuCustomLabel1.TabIndex = 17;
            this.bunifuCustomLabel1.Text = "Password";
            // 
            // TxtSEmailId
            // 
            this.TxtSEmailId.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtSEmailId.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSEmailId.Location = new System.Drawing.Point(180, 238);
            this.TxtSEmailId.Name = "TxtSEmailId";
            this.TxtSEmailId.Size = new System.Drawing.Size(259, 23);
            this.TxtSEmailId.TabIndex = 5;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(32, 366);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(82, 18);
            this.bunifuCustomLabel4.TabIndex = 19;
            this.bunifuCustomLabel4.Text = "Address-2";
            // 
            // DataGridDetails
            // 
            this.DataGridDetails.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGridDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
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
            this.user_id,
            this.user_name,
            this.user_role_name,
            this.password,
            this.user_role,
            this.email_id,
            this.mobile_number,
            this.address1,
            this.address2,
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
            this.DataGridDetails.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridDetails.DoubleBuffered = true;
            this.DataGridDetails.EnableHeadersVisualStyles = false;
            this.DataGridDetails.HeaderBgColor = System.Drawing.Color.Blue;
            this.DataGridDetails.HeaderForeColor = System.Drawing.Color.LawnGreen;
            this.DataGridDetails.Location = new System.Drawing.Point(497, 49);
            this.DataGridDetails.Name = "DataGridDetails";
            this.DataGridDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DataGridDetails.RowHeadersVisible = false;
            this.DataGridDetails.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.DataGridDetails.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(4, 0, 0, 4);
            this.DataGridDetails.RowTemplate.Height = 37;
            this.DataGridDetails.Size = new System.Drawing.Size(714, 461);
            this.DataGridDetails.TabIndex = 5;
            this.DataGridDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridDetails_CellContentClick);
            // 
            // user_id
            // 
            this.user_id.DataPropertyName = "user_id";
            this.user_id.HeaderText = "user_id";
            this.user_id.Name = "user_id";
            this.user_id.Visible = false;
            // 
            // user_name
            // 
            this.user_name.DataPropertyName = "user_name";
            this.user_name.HeaderText = "User Name";
            this.user_name.Name = "user_name";
            // 
            // user_role_name
            // 
            this.user_role_name.DataPropertyName = "user_role_name";
            this.user_role_name.HeaderText = "User Role";
            this.user_role_name.Name = "user_role_name";
            // 
            // password
            // 
            this.password.DataPropertyName = "password";
            this.password.HeaderText = "Password";
            this.password.Name = "password";
            this.password.Visible = false;
            // 
            // user_role
            // 
            this.user_role.DataPropertyName = "user_role";
            this.user_role.HeaderText = "user_role_id";
            this.user_role.Name = "user_role";
            this.user_role.Visible = false;
            // 
            // email_id
            // 
            this.email_id.DataPropertyName = "email_id";
            this.email_id.HeaderText = "Email Id";
            this.email_id.Name = "email_id";
            // 
            // mobile_number
            // 
            this.mobile_number.DataPropertyName = "mobile_number";
            this.mobile_number.HeaderText = "Mobile Number";
            this.mobile_number.Name = "mobile_number";
            // 
            // address1
            // 
            this.address1.DataPropertyName = "address1";
            this.address1.HeaderText = "address1";
            this.address1.Name = "address1";
            this.address1.Visible = false;
            // 
            // address2
            // 
            this.address2.DataPropertyName = "address2";
            this.address2.HeaderText = "address2";
            this.address2.Name = "address2";
            this.address2.Visible = false;
            // 
            // created_date
            // 
            this.created_date.DataPropertyName = "created_date";
            this.created_date.HeaderText = "Created Date";
            this.created_date.Name = "created_date";
            // 
            // edit
            // 
            this.edit.DataPropertyName = "edit";
            this.edit.FillWeight = 70F;
            this.edit.HeaderText = "Edit";
            this.edit.Name = "edit";
            // 
            // delete
            // 
            this.delete.DataPropertyName = "delete";
            this.delete.FillWeight = 70F;
            this.delete.HeaderText = "Delete";
            this.delete.Name = "delete";
            // 
            // LblHeaderText
            // 
            this.LblHeaderText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LblHeaderText.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblHeaderText.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.LblHeaderText.ForeColor = System.Drawing.Color.Blue;
            this.LblHeaderText.Location = new System.Drawing.Point(0, 0);
            this.LblHeaderText.Name = "LblHeaderText";
            this.LblHeaderText.Size = new System.Drawing.Size(1352, 31);
            this.LblHeaderText.TabIndex = 40;
            this.LblHeaderText.Text = "Employee Details";
            this.LblHeaderText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EmployeeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 575);
            this.Controls.Add(this.LblHeaderText);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmployeeDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeDetails";
            this.Load += new System.EventHandler(this.EmployeeDetails_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuTextbox TxtSearchItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtUserName;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private System.Windows.Forms.Button BtnInsertUpdate;
        private System.Windows.Forms.RichTextBox TxtArSAddrTwo;
        private System.Windows.Forms.RichTextBox TxtArSAddrOne;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtPassword;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtMobileNo;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtSEmailId;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DataGridDetails;
        private System.Windows.Forms.ComboBox DropDownUserRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_role_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_role;
        private System.Windows.Forms.DataGridViewTextBoxColumn email_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobile_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn address1;
        private System.Windows.Forms.DataGridViewTextBoxColumn address2;
        private System.Windows.Forms.DataGridViewTextBoxColumn created_date;
        private System.Windows.Forms.DataGridViewButtonColumn edit;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
        private System.Windows.Forms.Button BtnRefresh;
        private Bunifu.Framework.UI.BunifuCustomLabel LblHeaderText;

    }
}