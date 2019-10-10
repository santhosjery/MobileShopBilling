using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer.Repository.Login;
using DomainModel.Users;
using MobileShopBilling.Admin.CommonClasses;

namespace MobileShopBilling.Admin.AdminSettings
{
    public partial class EmployeeDetails : Form
    {
        LoginRepository _instanceRepository = new LoginRepository();
        MsgBoxMessages messageShow = new MsgBoxMessages();
        CommonModel CmC = new CommonModel();
        Dictionary<string, string> UserTypeList = new Dictionary<string, string>();
        DataTable DtUserList = new DataTable();
        Dictionary<string, string> DcUserList = new Dictionary<string, string>();
        BindingSource SBind = new BindingSource();
        int SelectedUserId = 0;
        public EmployeeDetails()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnInsertUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string ResultMessage = ValidateControlles();
                if (!string.IsNullOrEmpty(ResultMessage))
                {
                    messageShow.singlemsgtext(ResultMessage);
                    return;
                }
                var user = new Users
                {
                    UserId = SelectedUserId,
                    UserRole = Convert.ToInt32(((KeyValuePair<string, string>)DropDownUserRole.SelectedItem).Key.ToString()),
                    UserName = TxtUserName.Text.ToString(),
                    Password = TxtPassword.Text.ToString(),
                    MobileNumber = Convert.ToUInt64(TxtMobileNo.Text.ToString()),
                    EmailId = TxtSEmailId.Text.ToString(),
                    Address1 = TxtArSAddrOne.Text.ToString(),
                    Address2 = TxtArSAddrTwo.Text.ToString(),
                    OperationType = BtnInsertUpdate.Text == "Add" ? 1 : 2
                };
                int id = _instanceRepository.InsertEmployee(user);
                if (id > 0)
                {
                    messageShow.singlemsgtext(user.OperationType == 1 ? "User created successfully" : "User details are updated successfully");
                    ClearTextField();
                }
                else
                {
                    messageShow.singlemsgtext("Unable to create user");
                }
            }
            catch (Exception _exception)
            {
                CmC.InsertException(_exception);
                messageShow.singlemsgtext(CmC.ExceptionErrorMessage);
            }
        }
        private string ValidateControlles()
        {
            string ValidateMessage = string.Empty;
            if (string.IsNullOrEmpty(TxtUserName.Text.ToString()))
            {
                TxtUserName.Focus();
                return "Please enter the user name";
            }
            if (string.IsNullOrEmpty(TxtPassword.Text.ToString()))
            {
                TxtPassword.Focus();
                return "Please enter the password";
            }
            if (DropDownUserRole.SelectedIndex <= 0)
            {
                DropDownUserRole.Focus();
                return "Please select the role type";
            }
            if (string.IsNullOrEmpty(TxtMobileNo.Text.ToString()))
            {
                TxtMobileNo.Focus();
                return "Please enter the mobile number";
            }
            if (string.IsNullOrEmpty(TxtSEmailId.Text.ToString()))
            {
                TxtSEmailId.Focus();
                return "Please enter email id";
            }
            if (string.IsNullOrEmpty(TxtArSAddrOne.Text.ToString()))
            {
                TxtArSAddrOne.Focus();
                return "Please enter address one";
            }
            
            return ValidateMessage;
        }
        private void ClearTextField()
        {
            SelectedUserId = 0;
            BtnInsertUpdate.Text = "Add";
            TxtUserName.Text = "";
            TxtPassword.Text = "";
            TxtSearchItem.text = "";
            TxtSEmailId.Text = "";
            TxtMobileNo.Text = "";
            TxtArSAddrOne.Text = "";
            TxtArSAddrTwo.Text = "";
            DropDownUserRole.Text = "";
            AddUserRoleList();
            GetUserDetails(0, "");
        }
        private void AddUserRoleList()
        {
            UserTypeList.Clear();
            UserTypeList.Add("0", "--Select--");
            UserTypeList.Add("1" , "Admin");
            UserTypeList.Add("2", "Employee");
            DropDownUserRole.DataSource = new BindingSource(UserTypeList, null);
            DropDownUserRole.DisplayMember = "Value";
            DropDownUserRole.ValueMember = "Key";
        }

        private void EmployeeDetails_Load(object sender, EventArgs e)
        {
            LblHeaderText.BackColor = Color.FromName(CmC.LblBackColor);
            LblHeaderText.Font = new Font(CmC.LblFontStyle, CmC.LblFontSize); //, 17pt, style=Bold
            LblHeaderText.Font = new Font(LblHeaderText.Font, FontStyle.Bold);
            LblHeaderText.ForeColor = Color.FromName(CmC.LblFontColor);

            this.AcceptButton = BtnInsertUpdate;
            TxtUserName.Focus();
            AddUserRoleList();
            GetUserDetails(0, "");
        }
        private void GetUserDetails(int UserId, string UserName)
        {
            try
            {
                DtUserList.Clear();
                DataGridDetails.Refresh();
                DtUserList = CmC.GetUserDetails(UserId, UserName);
                SBind.DataSource = DtUserList;
                datagriddesign();
                DataGridDetails.DataSource = SBind;
            }
            catch (Exception _exception)
            {
                CmC.InsertException(_exception);
                messageShow.singlemsgtext(CmC.ExceptionErrorMessage);
            }
        }
        public void datagriddesign()
        {
            /*This Method for Allow datagrid to perform some Operations */
            DataGridDetails.AllowUserToAddRows = false;
            DataGridDetails.AutoGenerateColumns = false;
            DataGridDetails.RowTemplate.Height = 37;
            DataGridDetails.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            DataGridDetails.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            DataGridDetails.DefaultCellStyle.SelectionBackColor = Color.FromArgb(36, 129, 77);
            DataGridDetails.DefaultCellStyle.SelectionForeColor = Color.White;
            DataGridDetails.DefaultCellStyle.ForeColor = Color.Black;
            this.DataGridDetails.DefaultCellStyle.Font = new Font("Cambria", 10);
        }

        private void TxtSearchItem_OnTextChange(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtSearchItem.text.ToString()))
            {
                GetUserDetails(0, TxtSearchItem.text.ToString());
            }
            else
            {
                GetUserDetails(0, "");
            }
        }

        private void TxtMobileNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CmC.CheckNumberOnlyText(e);
        }

        private void DataGridDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridDetails.Rows.Count > 0)
            {
                int ColumnIndex = DataGridDetails.CurrentCell.ColumnIndex;
                string text = DataGridDetails.Columns[ColumnIndex].HeaderText;
                int RowIndex = DataGridDetails.CurrentCell.RowIndex;
                SelectedUserId = Convert.ToInt32(DataGridDetails.Rows[RowIndex].Cells[0].Value.ToString());
                string UserName = DataGridDetails.Rows[RowIndex].Cells["user_name"].Value.ToString();
                if (text.Equals("Delete"))
                {
                    string result = messageShow.show("Delete!", "Do you want to delete the user permanently?");
                    if (result == "1")
                    {
                        DeleteItemMaster(SelectedUserId);
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    AppendEditDetails(SelectedUserId, UserName);
                }
            }
        }
        public void DeleteItemMaster(int UserId)
        {
            try
            {
                var user = new Users
                {
                    UserId = UserId,
                    UserRole = 0,
                    UserName = "",
                    Password = "",
                    MobileNumber = 0,
                    EmailId = "",
                    Address1 = "",
                    Address2 = "",
                    OperationType = 3 
                };
                int id = _instanceRepository.InsertEmployee(user);
                if (id > 0)
                {
                    messageShow.singlemsgtext("User deleted successfully");
                    ClearTextField();
                }
                else
                {
                    messageShow.singlemsgtext("Unable to delete the user");
                    GetUserDetails(0, "");
                }
            }
            catch (Exception _exception)
            {
                CmC.InsertException(_exception);
                messageShow.singlemsgtext(CmC.ExceptionErrorMessage);
            }
        }
        public void AppendEditDetails(int UserId, string UserName)
        {
            BtnInsertUpdate.Text = "Update";
            AddUserRoleList();
            DataTable dt_single_list = CmC.GetUserDetails(UserId, UserName);
            TxtUserName.Text = dt_single_list.Rows[0]["user_name"].ToString();
            TxtPassword.Text = dt_single_list.Rows[0]["password"].ToString();
            TxtSEmailId.Text = dt_single_list.Rows[0]["email_id"].ToString();
            TxtMobileNo.Text = dt_single_list.Rows[0]["mobile_number"].ToString();
            TxtArSAddrOne.Text = dt_single_list.Rows[0]["address1"].ToString();
            TxtArSAddrTwo.Text = dt_single_list.Rows[0]["address2"].ToString();
            DropDownUserRole.SelectedIndex =Convert.ToInt32(dt_single_list.Rows[0]["user_role"].ToString());
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            ClearTextField();
        }
    }
}
