using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer.Repository.ExceptionRepositoryHandler;
using BusinessLayer.Repository.PurchaseAndSales;
using DomainModel.Transactions;
using MobileShopBilling.Admin.CommonClasses;
using MobileShopBilling.Admin.ReportForm;
using MobileShopBilling.Admin.Transactions;

namespace MobileShopBilling.Admin.Details
{
    public partial class SalesDetails : Form
    {
        SalesRepository _SalesRepository = new SalesRepository();
        ExceptionRepository _exceptionRepository = new ExceptionRepository();
        CommonModel CmC = new CommonModel();
        DataTable DtGridList = new DataTable();
        DataTable DtGridHeader = new DataTable();
        DataTable DtBrandList = new DataTable();
        MsgBoxMessages messageShow = new MsgBoxMessages();
        Dictionary<string, string> DcItemList = new Dictionary<string, string>();
        DataGridViewLinkColumn lm = new DataGridViewLinkColumn();
        BindingSource SBindHeader = new BindingSource();
        BindingSource SBindList = new BindingSource();
        string SalesInvoiceNo = null, BrandName = null, CustomerName = null;
        DateTime? FromDate = null, ToDate = null;
        double? CustomerMobileNo = null;
        int SalesId = 0, SalesLineId = 0, OperationType = 0, BrandCode = 0;
        public SalesDetails()
        {
            InitializeComponent();
        }

        private void SalesDetails_Load(object sender, EventArgs e)
        {
            LblHeaderText.BackColor = Color.FromName(CmC.LblBackColor);
            LblHeaderText.Font = new Font(CmC.LblFontStyle, CmC.LblFontSize); //, 17pt, style=Bold
            LblHeaderText.Font = new Font(LblHeaderText.Font, FontStyle.Bold);
            LblHeaderText.ForeColor = Color.FromName(CmC.LblFontColor);

            ResetControlles();
        }
        private void ResetControlles()
        {
            DropDownCustomerName.Text = "";
            DropDownCustomerMobile.Text = "";
            DatePickerFrom.Format = DateTimePickerFormat.Custom;
            DatePickerFrom.CustomFormat = " ";
            DatePickerTo.Format = DateTimePickerFormat.Custom;
            DatePickerTo.CustomFormat = " ";
            GetBrandList(0, DropDownBrandName.Text.ToString(), 3);
            OperationType = 1;
            GetDataGridDetails();
        }
        public void GetBrandList(int MasterCode, string BrandName, int OperationType)
        {
            try
            {
                DtBrandList.Clear();
                DcItemList.Clear();
                DropDownBrandName.Refresh();
                DtBrandList = CmC.GetMasterNamesAndCodes(BrandName, MasterCode, OperationType); ;
                if (DtBrandList.Rows.Count > 0)
                {
                    DcItemList.Add("0", CmC.FirstElementInSelect);
                    foreach (DataRow DtCol in DtBrandList.Rows)
                    {
                        DcItemList.Add(DtCol[0].ToString(), DtCol[1].ToString());
                    }
                    DropDownBrandName.DataSource = new BindingSource(DcItemList, null);
                    DropDownBrandName.DisplayMember = "Value";
                    DropDownBrandName.ValueMember = "Key";
                }
            }
            catch (Exception _exception)
            {
                CmC.InsertException(_exception);
                messageShow.singlemsgtext(CmC.ExceptionErrorMessage);
            }
        }
        public void datagriddesign_header()
        {
            /*This Method for Allow datagrid to perform some Operations */
            DataGridHeaderDetails.AllowUserToAddRows = false;
            DataGridHeaderDetails.AutoGenerateColumns = false;
            DataGridHeaderDetails.RowTemplate.Height = 37;
            DataGridHeaderDetails.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            DataGridHeaderDetails.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            DataGridHeaderDetails.DefaultCellStyle.SelectionBackColor = Color.FromArgb(36, 129, 77);
            DataGridHeaderDetails.DefaultCellStyle.SelectionForeColor = Color.White;
            DataGridHeaderDetails.DefaultCellStyle.ForeColor = Color.Black;
            this.DataGridHeaderDetails.DefaultCellStyle.Font = new Font("Cambria", 9);
        }
        public void datagriddesign_line()
        {
            /*This Method for Allow datagrid to perform some Operations */
            DataGridLineDetails.AllowUserToAddRows = false;
            DataGridLineDetails.AutoGenerateColumns = false;
            DataGridLineDetails.RowTemplate.Height = 37;
            DataGridLineDetails.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            DataGridLineDetails.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            DataGridLineDetails.DefaultCellStyle.SelectionBackColor = Color.FromArgb(36, 129, 77);
            DataGridLineDetails.DefaultCellStyle.SelectionForeColor = Color.White;
            DataGridLineDetails.DefaultCellStyle.ForeColor = Color.Black;
            this.DataGridLineDetails.DefaultCellStyle.Font = new Font("Cambria", 9);
        }

        private void SwitchAdvanceSearch_OnValueChange(object sender, EventArgs e)
        {
            ClearAdvanceSearchControls();
            if (SwitchAdvanceSearch.Value == true)
            {
                PanelAdvanceSearch.Show();
            }
            else
            {
                PanelAdvanceSearch.Hide();
            }
        }

        private void DropDownBrandName_TextChanged(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void GetDataGridDetails()
        {
            try
            {
                var SalesSearchDetails = new SalesSearchDetails
                {
                    SalesInvoiceNo = SalesInvoiceNo,
                    BrandName = BrandName,
                    BrandCode = BrandCode,
                    FromDate = FromDate,
                    ToDate = ToDate,
                    CustomerName = CustomerName,
                    CustomerMobileNo = CustomerMobileNo,
                    SalesId = SalesId,
                    SalesLineId = SalesLineId,
                    OperationType = OperationType
                };
                if (OperationType != 3)
                {
                    DtGridHeader.Clear();
                    DtGridHeader = _SalesRepository.GetSalesDetails(SalesSearchDetails);
                    LoadDataToHeaderGrid();
                }
                else
                {
                    DtGridList.Clear();
                    DtGridList = _SalesRepository.GetSalesDetails(SalesSearchDetails);
                    LoadDataToListGrid();
                }
            }
            catch (Exception _exception)
            {
                CmC.InsertException(_exception);
                messageShow.singlemsgtext(CmC.ExceptionErrorMessage);
            }
        }
        private void LoadDataToHeaderGrid()
        {
            LblInvoiceNo.Hide();
            ClearDataGridList();
            datagriddesign_header();
            SBindHeader.DataSource = DtGridHeader;
            DataGridHeaderDetails.DataSource = SBindHeader;
        }
        private void ClearDataGridList()
        {
            DataGridLineDetails.DataSource = null;
            DataGridLineDetails.Rows.Clear();
            DataGridLineDetails.Refresh();
        }
        private void LoadDataToListGrid()
        {
            LblInvoiceNo.Show();
            datagriddesign_line();
            SBindList.DataSource = DtGridList;
            DataGridLineDetails.DataSource = SBindList;
        }
        private void AssignValesToVariables()
        {
            SalesInvoiceNo = null;
            BrandName = null;
            BrandCode = 0;
            CustomerName = null;
            FromDate = null;
            ToDate = null;
            SalesId = 0;
            SalesLineId = 0;
            OperationType = 0;
        }
        private void ResetVariables()
        {
            SalesInvoiceNo = null;
            BrandName = null;
            CustomerName = null;
            FromDate = null;
            ToDate = null;
            SalesId = 0;
            SalesLineId = 0;
            BrandCode = 0;
            OperationType = 0;
        }

        private void DropDownBrandName_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetVariables();
            ClearAdvanceSearchControls();
            BrandCode = Convert.ToInt32(((KeyValuePair<string, string>)DropDownBrandName.SelectedItem).Key.ToString());
            if (BrandCode != 0)
            {
                OperationType = 2;
                GetDataGridDetails();
            }   
        }

        private void DropDownBrandName_Leave(object sender, EventArgs e)
        {
            if (DropDownBrandName.SelectedIndex < 0)
            {
                messageShow.singlemsgtext("Invalid brand name, you can try again");
            }
        }

        private void DropDownInvoiceNumber_TextChanged(object sender, EventArgs e)
        {
            OperationType = 2;
            BrandCode = 0;
            if(!string.IsNullOrEmpty(DropDownInvoiceNumber.Text.ToString()))
            {
                SalesInvoiceNo = DropDownInvoiceNumber.Text.ToString();
            }
            else
            {
                SalesInvoiceNo = null;
            }
            GetDataGridDetails();
        }

        private void DataGridHeaderDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DataGridHeaderDetails.Rows.Count > 0)
                {
                    int RowIndex = DataGridHeaderDetails.CurrentCell.RowIndex;
                    SalesId = Convert.ToInt32(DataGridHeaderDetails.Rows[RowIndex].Cells[0].Value.ToString());
                    int ColumnIndex = DataGridHeaderDetails.CurrentCell.ColumnIndex;
                    string text = DataGridHeaderDetails.Columns[ColumnIndex].HeaderText;
                    if (text.Equals("Edit"))
                    {
                        if (SalesId != 0)
                        {
                            new Sales(SalesId).ShowDialog();
                        }
                        else
                        {
                            messageShow.singlemsgtext("Only invoice number search allowed to edit");
                        }
                    }
                    else if (text.Equals("Delete"))
                    {
                        string result = messageShow.show("Delete!", "Do you want to delete the bill permanently?");
                        if (result == "1")
                        {
                            var SalesDetails = new DomainModel.Transactions.SalesDetails
                            {
                                SalesId = Convert.ToInt32(DataGridHeaderDetails.Rows[DataGridHeaderDetails.CurrentCell.RowIndex].Cells["sales_id"].Value.ToString()),
                                CustomerName = "",
                                CustomerMobileNo = 0,
                                GrossAmount = 0,
                                DiscountPer = 0,
                                DiscountAmount = 0,
                                NetAmount = 0,
                                PaymentType = 1,
                                PaidAmount = 0,
                                DuesAmount = 0,
                                DtSalesDetails = null,
                                OperationType = 3
                            };
                            long DeletedId = _SalesRepository.InsertUpdateSalesDetails(SalesDetails);
                            if (DeletedId > 0)
                            {
                                messageShow.singlemsgtext("Successfully deleted the bill.");
                                GetBrandList(0, DropDownBrandName.Text.ToString(), 3);
                                OperationType = 1;
                                GetDataGridDetails();
                            }
                            else
                            {
                                messageShow.singlemsgtext("Error occured while deleting the bill.");
                            }
                        }
                        else
                        {
                            return;
                        }
                    }
                    else
                    {
                        if (BrandCode != 0)
                        {
                            LblInvoiceNo.Text = "Brand Code : " + BrandCode.ToString();
                        }
                        else
                        {
                            LblInvoiceNo.Text = "Invoice Number : " + DataGridHeaderDetails.Rows[RowIndex].Cells[2].Value.ToString();
                        }
                        OperationType = 3;
                        GetDataGridDetails();
                    }
                }
            }
            catch (Exception _exception)
            {
                CmC.InsertException(_exception);
                messageShow.singlemsgtext(CmC.ExceptionErrorMessage);
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            CustomerName = null;
            CustomerMobileNo = null;
            if (!string.IsNullOrEmpty(DropDownCustomerName.Text.ToString()))
            {
                CustomerName = DropDownCustomerName.Text.ToString();
            }
            if (!string.IsNullOrEmpty(DropDownCustomerMobile.Text.ToString()))
            {
                CustomerMobileNo = Convert.ToDouble(DropDownCustomerMobile.Text.ToString());
            }
            if (DatePickerFrom.Text != " ")
            {
                FromDate = Convert.ToDateTime(DatePickerFrom.Value.ToString("yyyy-MM-dd"));
            }
            if (DatePickerTo.Text != " ")
            {
                ToDate = Convert.ToDateTime(DatePickerTo.Value.ToString("yyyy-MM-dd"));
            }
            OperationType = 2;
            GetDataGridDetails();
        }
        private void ClearAdvanceSearchControls()
        {
            DatePickerFrom.Value = DateTimePicker.MinimumDateTime;
            DatePickerTo.Value = DateTimePicker.MinimumDateTime;
            DatePickerFrom.CustomFormat = " ";
            DatePickerTo.CustomFormat = " ";
            
            DropDownCustomerMobile.Text = "";
            DropDownCustomerName.Text = "";
            CustomerName = null;
            CustomerMobileNo = null;
        }

        private void DatePickerFrom_ValueChanged(object sender, EventArgs e)
        {
            if (DatePickerFrom.Value == DateTimePicker.MinimumDateTime)
            {
                DatePickerFrom.Value = DateTime.Now; // This is required in order to show current month/year when user reopens the date popup.
                DatePickerFrom.Format = DateTimePickerFormat.Custom;
                DatePickerFrom.CustomFormat = " ";
            }
            else
            {
                DatePickerFrom.Format = DateTimePickerFormat.Short;
            }
        }

        private void DatePickerTo_ValueChanged(object sender, EventArgs e)
        {
            if (DatePickerTo.Value == DateTimePicker.MinimumDateTime)
            {
                DatePickerTo.Value = DateTime.Now; // This is required in order to show current month/year when user reopens the date popup.
                DatePickerTo.Format = DateTimePickerFormat.Custom;
                DatePickerTo.CustomFormat = " ";
            }
            else
            {
                DatePickerTo.Format = DateTimePickerFormat.Short;
            }
        }

        private void DataGridHeaderDetails_DoubleClick(object sender, EventArgs e)
        {
            if (SalesId != 0)
            {
                new SalesBillingReport(SalesId).ShowDialog();                
            }
            else
            {
                messageShow.singlemsgtext("Only invoice search allowed to take report.");
            }
        }

        private void BtnRefresgList_Click(object sender, EventArgs e)
        {
            ResetControlles();
        }

        private void DropDownCustomerMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CmC.CheckNumberOnlyText(e);
        }
    }
}
