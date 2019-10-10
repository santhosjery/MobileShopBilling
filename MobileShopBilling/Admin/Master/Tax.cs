using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer.Repository.AdminMaster;
using DomainModel.Mater;
using MobileShopBilling.Admin.CommonClasses;

namespace MobileShopBilling.Admin.Master
{
    public partial class Tax : Form
    {
        AdminMasterRepository _instanceRepository = new AdminMasterRepository();
        CommonModel CmC = new CommonModel();
        DataTable DtItemList = new DataTable();
        MsgBoxMessages messageShow = new MsgBoxMessages();
        Dictionary<string, string> DcItemList = new Dictionary<string, string>();
        DataGridViewLinkColumn lm = new DataGridViewLinkColumn();
        DataTable dt = new DataTable();
        BindingSource SBind = new BindingSource();
        int SelectedTaxCode = 0;
        public Tax()
        {
            InitializeComponent();
        }

        private void Tax_Load(object sender, EventArgs e)
        {
            TxtCGST.Focus();
            this.AcceptButton = BtnInsertUpdate;
            GetTaxLedgerList();
        }
        private void GetTaxLedgerList()
        {
            try
            {
                ResetControls();
                SelectedTaxCode = 0;
                dt.Clear();
                DataGridDetails.Refresh();
                dt = CmC.GetTaxList();
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

        private void BtnInsertUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(TxtCGST.Text.ToString()))
                {
                    messageShow.singlemsgtext("CGST should not be empty");
                    TxtCGST.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(TxtSGST.Text.ToString()))
                {
                    messageShow.singlemsgtext("SGST should not be empty");
                    TxtSGST.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(TxtIGST.Text.ToString()))
                {
                    messageShow.singlemsgtext("IGST should not be empty");
                    TxtIGST.Focus();
                    return;
                }
                var tax_master = new TaxMaster
                {
                    CGST = Convert.ToDecimal(TxtCGST.Text.ToString()),
                    SGST = Convert.ToDecimal(TxtSGST.Text.ToString()),
                    IGST = Convert.ToDecimal(TxtIGST.Text.ToString()),
                    IsActive = ChkBoxIsActive.Checked ? 1 : 0,
                    OperationType = SelectedTaxCode == 0 ? 1 : 2
                };
                int id = _instanceRepository.InsertUpdateDeleteTaxMaster(tax_master);
                if (id <= 0)
                {
                    messageShow.singlemsgtext("Can't add one or more tax details");
                }
                GetTaxLedgerList();
                TxtCGST.Focus();
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
                SelectedTaxCode = Convert.ToInt32(DataGridDetails.Rows[RowIndex].Cells[0].Value.ToString());
                if (text.Equals("Action"))
                {
                    string result = messageShow.show("Delete!", "Do you want to tax the product permanently?");
                    if (result == "1")
                    {
                        DeleteTaxMaster();
                        ResetControls();
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    AppendEditDetails();
                }
            }
        }
        public void AppendEditDetails()
        {
            DataTable dt_single_list = CmC.GetTaxList();
            TxtCGST.Text = dt_single_list.Rows[0]["cgst"].ToString();
            TxtSGST.Text = dt_single_list.Rows[0]["sgst"].ToString();
            TxtIGST.Text = dt_single_list.Rows[0]["igst"].ToString();
            ChkBoxIsActive.Checked = Convert.ToInt32(dt_single_list.Rows[0]["is_active"]) == 1 ? true : false;
        }
        public void ResetControls()
        {
            TxtCGST.Text = "";
            TxtSGST.Text = "";
            TxtIGST.Text = "";
            ChkBoxIsActive.Checked = false;
        }
        public void DeleteTaxMaster()
        {
            try
            {
                var tax_master = new TaxMaster
                {
                    CGST = 0,
                    SGST = 0,
                    IGST = 0,
                    IsActive = 0,
                    OperationType = 3
                };
                int DeleteStatus = _instanceRepository.InsertUpdateDeleteTaxMaster(tax_master);
                if (DeleteStatus >= 1)
                    messageShow.singlemsgtext("Deleted Successfully");
                else
                    messageShow.singlemsgtext("Unable to Delete");
                GetTaxLedgerList();
            }
            catch (Exception _exception)
            {
                CmC.InsertException(_exception);
                messageShow.singlemsgtext(CmC.ExceptionErrorMessage);
            }
        }

        private void TxtCGST_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CmC.CheckNumberWithDecimalText(e);
        }

        private void TxtSGST_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CmC.CheckNumberWithDecimalText(e);
        }

        private void TxtIGST_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CmC.CheckNumberWithDecimalText(e);
        }

        private void BtnRefresgList_Click(object sender, EventArgs e)
        {
            GetTaxLedgerList();
        }
    }
}
