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
using DomainModel;
using DomainModel.Users;
using MobileShopBilling.Admin;
using MobileShopBilling.Admin.CommonClasses;
using MobileShopBilling.Admin.Transactions;

namespace MobileShopBilling
{
    public partial class LoginHome : Form
    {
        CommonModel CmC = new CommonModel();
        LoginRepository _instanceRepository = new LoginRepository();
        MsgBoxMessages messageShow = new MsgBoxMessages();
        public LoginHome()
        {
            InitializeComponent();
        }

        private void loginbtnexit_Click(object sender, EventArgs e)
        {
            string result = messageShow.show("Exit", "Do you want to Exit?");
            if (result == "1")
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void hmetxtlogpass_Enter(object sender, EventArgs e)
        {

        }

        private void hmetxtlogpass_Click(object sender, EventArgs e)
        {
        }
        
        private void btnloginmain_Click(object sender, EventArgs e)
        {
            try
            {
                var user = new Users
                {
                    UserName = hmetxtloguname.Text.ToString(),
                    Password = hmetxtlogpass.Text.ToString()
                };
                DataTable dt = new DataTable();
                dt = _instanceRepository.LoginUser(user);
                if (dt.Rows.Count > 0)
                {
                    UserInfo.UserName = dt.Rows[0]["user_name"].ToString();
                    UserInfo.UserId = Convert.ToInt32(dt.Rows[0]["user_id"].ToString());
                    UserInfo.UserRole = Convert.ToInt32(dt.Rows[0]["user_role"].ToString());
                    if (Convert.ToInt32(dt.Rows[0]["user_role"].ToString()) == 1)
                    {
                        AdminHome ah = new AdminHome();
                        this.Hide();
                        ah.Show();
                    }
                    else
                    {
                        Sales sl = new Sales();
                        sl.WindowState = FormWindowState.Maximized;
                        sl.Show();
                        this.Hide();
                    }
                }
                else
                {
                    messageShow.singlemsgtext("Invalid username or password");
                }
            }
            catch (Exception _exception)
            {
                CmC.InsertException(_exception);
                messageShow.singlemsgtext(CmC.ExceptionErrorMessage);
            }
        }

        private void loginbtnexit_MouseHover(object sender, EventArgs e)
        {
            loginbtnexit.BackColor = Color.FromArgb(36, 129, 77);
        }

        private void loginbtnexit_MouseLeave(object sender, EventArgs e)
        {
            loginbtnexit.BackColor = Color.FromArgb(41, 121, 254);
        }

        private void btnloginmain_MouseHover(object sender, EventArgs e)
        {
            btnloginmain.BackColor = Color.FromArgb(36, 129, 77);
        }

        private void btnloginmain_MouseLeave(object sender, EventArgs e)
        {
            btnloginmain.BackColor = Color.FromArgb(41, 121, 254);
        }

        private void LoginHome_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnloginmain;
        }
    }
}
