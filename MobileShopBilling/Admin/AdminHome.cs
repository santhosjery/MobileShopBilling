using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MobileShopBilling.Admin.AdminSettings;
using MobileShopBilling.Admin.Details;
using MobileShopBilling.Admin.Master;
using MobileShopBilling.Admin.Transactions;

namespace MobileShopBilling.Admin
{
    public partial class AdminHome : Form
    {
        MsgBoxMessages messageShow = new MsgBoxMessages();
        public AdminHome()
        {
            InitializeComponent();
        }

        private void windowsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AdminHome_Load(object sender, EventArgs e)
        {
           
        }
        
        private void itemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Text = "Item Master";
            ShowItemForm();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowExitForm();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Text = "Product Master";
            ShowProductForm();
        }

        private void productTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Text = "Supplier Ledger Master";
            ShowSupplierForm();
        }

        private void brandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Text = "Brand Master";
            ShowBrandForm();
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void taxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Text = "Tax Master";
            ShowTaxForm();
        }

        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Text = "Purchase Entry";
            ShowPurchaseForm();
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Text = "Sales Entry";
            ShowSalesForm();
        }

        private void stockDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Text = "Stock Details";
            ShowSalesReportForm();
        }

        private void saleDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Text = "Sales Details";
            ShowSalesDetailsForm();
        }

        private void purchaseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Text = "Purchase Details";
            ShowPurchaseDetailsForm();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Text = "Change Password";
            ShowAddChangePasswordForm();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowLogoutForm();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Text = "ColorDetails";
            ShowColorForm();
        }

        private void employeeDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Text = "EmployeeDetails";
            ShowAddEmployeeForm();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowAboutForm();
        }

        private void availableStockReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Text = "AvailableStockReport";
            ShowStockReportForm();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.I))
            {
                ShowItemForm();
                return true;
            }
            if (keyData == (Keys.Control | Keys.P))
            {
                ShowProductForm();
                return true;
            }
            if (keyData == (Keys.Control | Keys.B))
            {
                ShowBrandForm();
                return true;
            }
            if (keyData == (Keys.Control | Keys.L))
            {
                ShowSupplierForm();
                return true;
            }
            if (keyData == (Keys.Control | Keys.R))
            {
                ShowColorForm();
                return true;
            }
            if (keyData == (Keys.Control | Keys.T))
            {
                ShowTaxForm();
                return true;
            }
            if (keyData == (Keys.Control | Keys.N))
            {
                ShowSalesForm();
                return true;
            }
            if (keyData == (Keys.Control | Keys.H))
            {
                ShowPurchaseForm();
                return true;
            }
            if (keyData == (Keys.Control | Keys.Q))
            {
                ShowStockReportForm();
                return true;
            }
            if (keyData == (Keys.Control | Keys.W))
            {
                ShowPurchaseDetailsForm();
                return true;
            }
            if (keyData == (Keys.Control | Keys.E))
            {
                ShowSalesDetailsForm();
                return true;
            }
            if (keyData == (Keys.Control | Keys.D))
            {
                ShowSalesReportForm();
                return true;
            }
            if (keyData == (Keys.Control | Keys.K))
            {
                ShowAddEmployeeForm();
                return true;
            }
            if (keyData == (Keys.Control | Keys.J))
            {
                ShowAddChangePasswordForm();
                return true;
            }
            if (keyData == (Keys.Control | Keys.Y))
            {
                ShowAboutForm();
                return true;
            }
            if (keyData == (Keys.Alt | Keys.F4))
            {
                ShowExitForm();
                return true;
            }
            if (keyData == (Keys.Alt | Keys.F3))
            {
                ShowLogoutForm();
                return true;
            }
            if (keyData == (Keys.Alt | Keys.H))
            {
                ShowHomeForm();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void ShowLogoutForm()
        {
            LoginHome LoginHome = new LoginHome();
            LoginHome.Show();
            this.Close();
        }
        private void ShowExitForm()
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
        private void ShowAboutForm()
        {
            messageShow.singlemsgtext("Developed by Santhos Jery. \r\r\tContact no : 9095349906 \r\r\tVersion : 1.0");
        }
        private void ShowAddChangePasswordForm()
        {
            ChangePassword Itm = new ChangePassword();
            Itm.TopLevel = false;
            this.Controls.Add(Itm);
            Itm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Itm.Dock = DockStyle.Fill;
            Itm.BringToFront();
            Itm.Show();
        }
        private void ShowAddEmployeeForm()
        {
            EmployeeDetails Itm = new EmployeeDetails();
            Itm.TopLevel = false;
            this.Controls.Add(Itm);
            Itm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Itm.Dock = DockStyle.Fill;
            Itm.BringToFront();
            Itm.Show();
        }
        private void ShowSalesReportForm()
        {
            StockDetails Itm = new StockDetails();
            Itm.TopLevel = false;
            this.Controls.Add(Itm);
            Itm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Itm.Dock = DockStyle.Fill;
            Itm.BringToFront();
            Itm.Show();
        }
        private void ShowSalesDetailsForm()
        {
            SalesDetails Itm = new SalesDetails();
            Itm.TopLevel = false;
            this.Controls.Add(Itm);
            Itm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Itm.Dock = DockStyle.Fill;
            Itm.BringToFront();
            Itm.Show();
        }
        private void ShowPurchaseDetailsForm()
        {
            PurchaseDetails Itm = new PurchaseDetails();
            Itm.TopLevel = false;
            this.Controls.Add(Itm);
            Itm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Itm.Dock = DockStyle.Fill;
            Itm.BringToFront();
            Itm.Show();
        }
        private void ShowStockReportForm()
        {
            AvailableStockReport Itm = new AvailableStockReport();
            Itm.TopLevel = false;
            this.Controls.Add(Itm);
            Itm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Itm.Dock = DockStyle.Fill;
            Itm.BringToFront();
            Itm.Show();
        }
        private void ShowPurchaseForm()
        {
            Purchase Itm = new Purchase();
            Itm.TopLevel = false;
            this.Controls.Add(Itm);
            Itm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Itm.Dock = DockStyle.Fill;
            Itm.BringToFront();
            Itm.Show();
        }
        private void ShowSalesForm()
        {
            Sales Itm = new Sales();
            Itm.TopLevel = false;
            this.Controls.Add(Itm);
            Itm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Itm.Dock = DockStyle.Fill;
            Itm.BringToFront();
            Itm.Show();
        }
        private void ShowTaxForm()
        {
            Tax Itm = new Tax();
            Itm.TopLevel = false;
            this.Controls.Add(Itm);
            Itm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Itm.Dock = DockStyle.Fill;
            Itm.BringToFront();
            Itm.Show();
        }
        private void ShowColorForm()
        {
            ColorDetails Itm = new ColorDetails();
            Itm.TopLevel = false;
            this.Controls.Add(Itm);
            Itm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Itm.Dock = DockStyle.Fill;
            Itm.BringToFront();
            Itm.Show();
        }
        private void ShowSupplierForm()
        {
            SupplierLedger Itm = new SupplierLedger();
            Itm.TopLevel = false;
            this.Controls.Add(Itm);
            Itm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Itm.Dock = DockStyle.Fill;
            Itm.BringToFront();
            Itm.Show();
        }
        private void ShowBrandForm()
        {
            Brand Itm = new Brand();
            Itm.TopLevel = false;
            this.Controls.Add(Itm);
            Itm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Itm.Dock = DockStyle.Fill;
            Itm.BringToFront();
            Itm.Show();
        }
        private void ShowProductForm()
        {
            Product Itm = new Product();
            Itm.TopLevel = false;
            this.Controls.Add(Itm);
            Itm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Itm.Dock = DockStyle.Fill;
            Itm.BringToFront();
            Itm.Show();
        }
        private void ShowItemForm()
        {
            Item Itm = new Item();
            Itm.TopLevel = false;
            this.Controls.Add(Itm);
            Itm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Itm.Dock = DockStyle.Fill;
            Itm.BringToFront();
            Itm.Show();
        }
        private void ShowHomeForm()
        {
            AdminHome Itm = new AdminHome();
            Itm.TopLevel = false;
            this.Controls.Add(Itm);
            Itm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Itm.Dock = DockStyle.Fill;
            Itm.BringToFront();
            Itm.Show();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Text = "AdminHome";
            ShowHomeForm();
        }

    }
}
