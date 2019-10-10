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
    public partial class ChangePassword : Form
    {
        LoginRepository _instanceRepository = new LoginRepository();
        MsgBoxMessages messageShow = new MsgBoxMessages();
        CommonModel CmC = new CommonModel();
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearAllText();
        }
        private void ClearAllText()
        {
            TxtNewPassword.Text = "";
            TxtOldPassword.Text = "";
            TxtReTypePassword.Text = ""; 
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtNewPassword.Text.ToString() != TxtReTypePassword.Text.ToString())
                {
                    messageShow.singlemsgtext("Password mismatch occured");
                }
                else
                {
                    var ChangePasswordModel = new ChangePasswordModel
                    {
                        OldPassword = TxtOldPassword.Text.ToString(),
                        NewPassword = TxtNewPassword.Text.ToString(),
                        OperationType = 1
                    };
                    DataTable DtTable = _instanceRepository.ChangePassword(ChangePasswordModel);
                    if (Convert.ToInt32(DtTable.Rows[0][0].ToString()) == 1)
                    {
                        messageShow.singlemsgtext("Your password has been changed successfully");
                        ClearAllText();
                    }
                    else
                    {
                        messageShow.singlemsgtext("Invalid old password");
                    }
                }
            }
            catch (Exception _exception)
            {
                CmC.InsertException(_exception);
                messageShow.singlemsgtext(CmC.ExceptionErrorMessage);
            }
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            TxtOldPassword.Focus();
            this.AcceptButton = BtnUpdate;
            LblHeaderText.BackColor = Color.FromName(CmC.LblBackColor);
            LblHeaderText.Font = new Font(CmC.LblFontStyle, CmC.LblFontSize); //, 17pt, style=Bold
            LblHeaderText.Font = new Font(LblHeaderText.Font, FontStyle.Bold);
            LblHeaderText.ForeColor = Color.FromName(CmC.LblFontColor);
        }
    }
}
