using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer.Repository.AdminMaster;
using BusinessLayer.Repository.ExceptionRepositoryHandler;
using DomainModel;
using DomainModel.Mater;
using MobileShopBilling.Admin.CommonClasses;

namespace MobileShopBilling.Admin.Master
{
    public partial class SupplierLedger : Form
    {
        AdminMasterRepository _instanceRepository = new AdminMasterRepository();
        ExceptionRepository _exceptionRepository = new ExceptionRepository();
        CommonModel CmC = new CommonModel();
        DataTable DtItemList = new DataTable();
        MsgBoxMessages messageShow = new MsgBoxMessages();
        Dictionary<string, string> DcItemList = new Dictionary<string, string>();
        DataGridViewLinkColumn lm = new DataGridViewLinkColumn();
        DataTable dt = new DataTable();
        BindingSource SBind = new BindingSource();
        int SelectedSupplierCode = 0;
        public SupplierLedger()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SupplierLedger_Load(object sender, EventArgs e)
        {
            LblHeaderText.BackColor = Color.FromName(CmC.LblBackColor);
            LblHeaderText.Font = new Font(CmC.LblFontStyle, CmC.LblFontSize); //, 17pt, style=Bold
            LblHeaderText.Font = new Font(LblHeaderText.Font, FontStyle.Bold);
            LblHeaderText.ForeColor = Color.FromName(CmC.LblFontColor);

            TxtSName.Focus();
            this.AcceptButton = BtnInsertUpdate;
            GetSupplierLedgerList("", 0);
        }
        private void GetSupplierLedgerList(string SearchText, int SupplierCode)
        {
            try
            {
                SelectedSupplierCode = 0;
                dt.Clear();
                DataGridDetails.Refresh();
                dt = CmC.GetSupplierList(SearchText, SupplierCode);
                SBind.DataSource = dt;
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
            this.DataGridDetails.DefaultCellStyle.Font = new Font("Cambria", 14);
        }

        private void TxtSearchItem_OnTextChange(object sender, EventArgs e)
        {
            GetSupplierLedgerList(TxtSearchItem._TextBox.Text.ToString(), 0);
        }

        private void BtnInsertUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(TxtSName.Text.ToString()))
                {
                    messageShow.singlemsgtext("Supplier name should not be empty");
                    TxtSName.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(TxtSMobNum.Text.ToString()))
                {
                    messageShow.singlemsgtext("Supplier mobile number should not be empty");
                    TxtSMobNum.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(TxtSEmailId.Text.ToString()))
                {
                    messageShow.singlemsgtext("Email id should not be empty");
                    TxtSEmailId.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(TxtSGSTNum.Text.ToString()))
                {
                    messageShow.singlemsgtext("GSTIN number should not be empty");
                    TxtSGSTNum.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(TxtArSAddrOne.Text.ToString()))
                {
                    messageShow.singlemsgtext("Address should not be empty");
                    TxtArSAddrOne.Focus();
                    return;
                }
                var supplier_master = new SupplierMaster
                {
                    SupplierCode = SelectedSupplierCode,
                    SupplierName = TxtSName.Text.ToString(),
                    MobileNumber = Convert.ToInt64(TxtSMobNum.Text.ToString()),
                    EmailId = TxtSEmailId.Text.ToString(),
                    GSTINNumber = TxtSGSTNum.Text.ToString(),
                    Address1 = TxtArSAddrOne.Text.ToString(),
                    Address2 = TxtArSAddrTwo.Text.ToString(),
                    OperationType = SelectedSupplierCode == 0 ? 1 : 2
                };
                int id = _instanceRepository.InsertUpdateDeleteSupplierLegder(supplier_master);
                supplier_master.SupplierName = "";
                ResetControllers();
            }
            catch (Exception _exception)
            {
                CmC.InsertException(_exception);
                messageShow.singlemsgtext(CmC.ExceptionErrorMessage);
            }
        }

        private void DataGridDetails_MouseClick(object sender, MouseEventArgs e)
        {
            if (DataGridDetails.Rows.Count > 0)
            {
                int ColumnIndex = DataGridDetails.CurrentCell.ColumnIndex;
                string text = DataGridDetails.Columns[ColumnIndex].HeaderText;
                int RowIndex = DataGridDetails.CurrentCell.RowIndex;
                SelectedSupplierCode = Convert.ToInt32(DataGridDetails.Rows[RowIndex].Cells[0].Value.ToString());
                if (text.Equals("Action"))
                {
                    string result = messageShow.show("Delete!", "Do you want to supplier the product permanently?");
                    if (result == "1")
                    {
                        DeleteItemMaster();
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    AppendEditDetails(SelectedSupplierCode);
                }
            }
        }
        private void ResetControllers()
        {
            GetSupplierLedgerList("", 0);
            TxtSName.Focus();
            TxtSName.Text = "";
            TxtSMobNum.Text = "";
            TxtSEmailId.Text = "";
            TxtSGSTNum.Text = "";
            TxtArSAddrOne.Text = "";
            TxtArSAddrTwo.Text = "";
            TxtSearchItem._TextBox.Text = "";
        }
        public void AppendEditDetails(int SelectedSupplierCode)
        {
           DataTable dt_single_list = CmC.GetSupplierList("", SelectedSupplierCode);
            TxtSName.Text = dt_single_list.Rows[0]["supplier_name"].ToString();
            TxtSMobNum.Text = dt_single_list.Rows[0]["mobile_number"].ToString();
            TxtSEmailId.Text = dt_single_list.Rows[0]["email_id"].ToString();
            TxtSGSTNum.Text = dt_single_list.Rows[0]["gstin_number"].ToString();
            TxtArSAddrOne.Text = dt_single_list.Rows[0]["address1"].ToString();
            TxtArSAddrTwo.Text = dt_single_list.Rows[0]["address2"].ToString();
        }
        public void DeleteItemMaster()
        {
            try
            {
                var supplier_master = new SupplierMaster
                {
                    SupplierCode = SelectedSupplierCode,
                    SupplierName = "",
                    MobileNumber = 0,
                    EmailId = "",
                    GSTINNumber = "",
                    Address1 = "",
                    Address2 = "",
                    OperationType = 3
                };
                int DeleteStatus = _instanceRepository.InsertUpdateDeleteSupplierLegder(supplier_master);
                if (DeleteStatus >= 1)
                    messageShow.singlemsgtext("Deleted Successfully");
                else
                    messageShow.singlemsgtext("Unable to Delete");
                GetSupplierLedgerList("", 0);
                ResetControllers();
            }
            catch (Exception _exception)
            {
                CmC.InsertException(_exception);
                messageShow.singlemsgtext(CmC.ExceptionErrorMessage);
            }
        }

        private void TxtSMobNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CmC.CheckNumberOnlyText(e);
        }

        private void BtnRefresgList_Click(object sender, EventArgs e)
        {
            ResetControllers();
        }
    }
}
