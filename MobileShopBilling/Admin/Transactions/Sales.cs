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

namespace MobileShopBilling.Admin.Transactions
{
    public partial class Sales : Form
    {
        PurchaseRepository _PurchaseRepository = new PurchaseRepository();
        SalesRepository _SalesRepository = new SalesRepository();
        ExceptionRepository _exceptionRepository = new ExceptionRepository();
        CommonModel CmC = new CommonModel();
        DataTable DtItemList = new DataTable();
        MsgBoxMessages messageShow = new MsgBoxMessages();
        Dictionary<string, string> DcItemList = new Dictionary<string, string>();
        DataGridViewLinkColumn lm = new DataGridViewLinkColumn();
        BindingSource SBind = new BindingSource();
        private long SalesId_Sales = 0;
        bool IsAllowTextChange = true;
        int PurchaseIdSale = 0, PurchaseLineIdSale = 0, SelectedRowIndex = 0;
        int SelectedItemCode = 0, SelectedProductCode = 0, SelectedBrandCode = 0, SalesLineId = 0;
        int CurrentAvailableItems = 0;
        int GridAutoIncrement = 0, NoOfItemsSignle = 0,SelectedColorCode = 0;
        double SingleCgstAmount = 0, SingleSgstAmount = 0, NetAmount = 0, SingleCgstPer = 0;
        double SingleSgstPer = 0, SinglePrice = 0, SingleTotalAmount = 0, GrossAmount = 0, DiscountAmountHeader = 0;
        double PaidAmount = 0;
        public Sales()
        {
            InitializeComponent();
        }

        public Sales(int SalesId) //To open the edit form while calling this from sales details..
        {
            this.SalesId_Sales = SalesId;
            InitializeComponent();
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            if (UserInfo.UserRole == 1)
            {
                PanelIsEmployee.Hide();
            }
            else
            {
                PanelIsEmployee.Show();
            }
            LblWelcome.Text = "Welcome: "+ UserInfo.UserName;
            LblHeaderText.BackColor = Color.FromName(CmC.LblBackColor);
            LblHeaderText.Font = new Font(CmC.LblFontStyle, CmC.LblFontSize); //, 17pt, style=Bold
            LblHeaderText.Font = new Font(LblHeaderText.Font, FontStyle.Bold);
            LblHeaderText.ForeColor = Color.FromName(CmC.LblFontColor);

            Grouppurchase.Update();
            datagriddesign();
            if (SalesId_Sales != 0)
            {
                IsAllowTextChange = false;
                LblInvoiceNumber.Show();
                TxtNoOfItems.Enabled = false;
                LblAvaiableItems.Hide();
                LoadInsertedData();
                IsAllowTextChange = true;
            }
            else
            {
                LblInvoiceNumber.Hide();
                GetItemList();
                GetUnitAndPaymentTypeDropDown();
            }
        }
        private void LoadInsertedData()
        {
            var SalesDetails = new SalesDetails
            {
                SalesId = SalesId_Sales
            };
            DataTable DtSalesDetails = _SalesRepository.GetLastSalesDetailsBySalesId(SalesDetails);

            LblInvoiceNumber.Text = "Invoice Number :" + DtSalesDetails.Rows[0]["invoice_number"].ToString();
            TxtCustomerName.Text = DtSalesDetails.Rows[0]["customer_name"].ToString();
            TxtCustomerMobileNo.Text = DtSalesDetails.Rows[0]["customer_mobile_no"].ToString();

            TxtGrossAmount.Text = Convert.ToDouble(DtSalesDetails.Rows[0]["sigle_total_amount"].ToString()).ToString();
            TxtPaidAmount.Text = Convert.ToDouble(DtSalesDetails.Rows[0]["paid_amount"].ToString()).ToString();
            TxtDuesAmount.Text = Convert.ToDouble(DtSalesDetails.Rows[0]["dues_amount"].ToString()).ToString();
            TxtNetAmount.Text = Convert.ToDouble(DtSalesDetails.Rows[0]["sigle_total_amount"].ToString()).ToString();
            TxtDiscountAmt.Text = Convert.ToDouble(DtSalesDetails.Rows[0]["discount"].ToString()).ToString();
            TxtDiscountPer.Text = Convert.ToDouble(DtSalesDetails.Rows[0]["discount_percentage"].ToString()).ToString();

            SBind.DataSource = DtSalesDetails;
            DataGridDetails.DataSource = SBind;
            BtnInsertUpdatePurchase.Text = "Update";
            EmptyBtnaddListcontrols();
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
            this.DataGridDetails.DefaultCellStyle.Font = new Font("Cambria", 9);
        }
        public void GetItemList()
        {
            try
            {
                DtItemList.Clear();
                DcItemList.Clear();
                DropDownItemName.Refresh();
                DtItemList = CmC.GetMasterNamesAndCodes("", 0, 1);
                if (DtItemList.Rows.Count > 0)
                {
                    DropDownItemName.DataSource = new BindingSource(CmC.ConvertDataTableToDictionary(DtItemList), null);
                    DropDownItemName.DisplayMember = "Value";
                    DropDownItemName.ValueMember = "Key";
                }
            }
            catch (Exception _exception)
            {
                CmC.InsertException(_exception);
                messageShow.singlemsgtext(CmC.ExceptionErrorMessage);
            }
        }
        private void GetUnitAndPaymentTypeDropDown()
        {
            DcItemList.Clear();
            DcItemList.Add("0", "--Select--");
            DcItemList.Add("1", "Cash");
            DcItemList.Add("2", "Card");
            DropDownPaymentType.DataSource = new BindingSource(DcItemList, null);
            DropDownPaymentType.DisplayMember = "Value";
            DropDownPaymentType.ValueMember = "Key";
            DropDownPaymentType.SelectedIndex = 1;
        }

        private void DropDownItemName_Leave(object sender, EventArgs e)
        {
            if (DropDownItemName.SelectedIndex < 0)
            {
                messageShow.singlemsgtext("Invalid Item Nmae, Must select the Item");
            }
        }

        private void DropDownItemName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownItemName.SelectedIndex > 0 && IsAllowTextChange)
            {
                SelectedItemCode = Convert.ToInt32(((KeyValuePair<string, string>)DropDownItemName.SelectedItem).Key.ToString());
                if (SelectedItemCode != 0)
                {
                    EmptyProductListDropDown();
                    EmptyBrandListDropDown();
                    GetProductList(SelectedItemCode);
                }
            }
        }
        public void GetProductList(int ItemCode)
        {
            try
            {
                DtItemList.Clear();
                DcItemList.Clear();
                DtItemList = CmC.GetMasterNamesAndCodes("", ItemCode, 4);
                if (DtItemList.Rows.Count > 0)
                {
                    DropDownProductName.DataSource = new BindingSource(CmC.ConvertDataTableToDictionary(DtItemList), null);
                    DropDownProductName.DisplayMember = "Value";
                    DropDownProductName.ValueMember = "Key";
                }
            }
            catch (Exception _exception)
            {
                CmC.InsertException(_exception);
                messageShow.singlemsgtext(CmC.ExceptionErrorMessage);
            }
        }
        private void EmptyProductListDropDown()
        {
            DropDownProductName.DataSource = null;
            DropDownProductName.Items.Clear();
            DropDownProductName.Items.Add(DBNull.Value);
            DropDownProductName.Items.Clear();

        }
        private void EmptyItemListDropDown()
        {
            DropDownItemName.DataSource = null;
            DropDownItemName.Items.Clear();
            DropDownItemName.Items.Add(DBNull.Value);
            DropDownItemName.Items.Clear();
        }
        private void EmptyBrandListDropDown()
        {
            DropDownBrandName.DataSource = null;
            DropDownBrandName.Items.Clear();
            DropDownBrandName.Items.Add(DBNull.Value);
            DropDownBrandName.Items.Clear();
        }
        private void EmptyColorListDropDown()
        {
            DropDownColorName.DataSource = null;
            DropDownColorName.Items.Clear();
            DropDownColorName.Items.Add(DBNull.Value);
            DropDownColorName.Items.Clear();
        }

        private void DropDownProductName_Leave(object sender, EventArgs e)
        {
            if (DropDownProductName.SelectedIndex < 0)
            {
                messageShow.singlemsgtext("Invalid product Nmae, Must select the product");
            }
        }

        private void DropDownProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownProductName.SelectedIndex > 0 && IsAllowTextChange)
            {
                SelectedProductCode = Convert.ToInt32(((KeyValuePair<string, string>)DropDownProductName.SelectedItem).Key.ToString());
                if (SelectedProductCode != 0)
                {
                    EmptyBrandListDropDown();
                    GetBrandList(SelectedProductCode);
                }
            }
        }
        public void GetBrandList(int SelectedProductCode)
        {
            try
            {
                DtItemList.Clear();
                DcItemList.Clear();
                DtItemList = CmC.GetMasterNamesAndCodes("", SelectedProductCode, 5);
                if (DtItemList.Rows.Count > 0)
                {
                    DropDownBrandName.DataSource = new BindingSource(CmC.ConvertDataTableToDictionary(DtItemList), null);
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

        private void DropDownBrandName_Leave(object sender, EventArgs e)
        {
            if (DropDownBrandName.SelectedIndex < 0)
            {
                messageShow.singlemsgtext("Invalid Brand Nmae, Must select the Brand Name");
            }
        }

        private void DropDownBrandName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownBrandName.SelectedIndex > 0 && IsAllowTextChange)
            {
                SelectedBrandCode = Convert.ToInt32(((KeyValuePair<string, string>)DropDownBrandName.SelectedItem).Key.ToString());
                GetColorNameDetailsByBrandCode();
            }
        }
        private void GetColorNameDetailsByBrandCode()
        {
            try
            {
                DtItemList.Clear();
                DcItemList.Clear();
                DtItemList = CmC.GetMasterNamesAndCodes("", SelectedBrandCode, 9);
                if (DtItemList.Rows.Count > 0)
                {
                    DropDownColorName.DataSource = new BindingSource(CmC.ConvertDataTableToDictionary(DtItemList), null);
                    DropDownColorName.DisplayMember = "Value";
                    DropDownColorName.ValueMember = "Key";
                }
            }
            catch (Exception _exception)
            {
                CmC.InsertException(_exception);
                messageShow.singlemsgtext(CmC.ExceptionErrorMessage);
            }
        }
        public void GetBrandListById(int SelectedBrandCode, int SelectedColorCode, int PurchaseId, int PurchaseLineId)
        {
            try
            {
                DtItemList.Clear();
                DtItemList = CmC.GetPurchaseListById(SelectedBrandCode, SelectedColorCode, PurchaseId, PurchaseLineId, 1);
                if (DtItemList.Rows.Count <= 0)
                {
                    messageShow.singlemsgtext("There is no stock details available for this item.");
                }
                else if (DtItemList.Rows.Count > 1)
                {
                    ShowDataGridPop(DtItemList);
                }
                else
                {
                    ApplyProductDetails(DtItemList);
                }
            }
            catch (Exception _exception)
            {
                CmC.InsertException(_exception);
                messageShow.singlemsgtext(CmC.ExceptionErrorMessage);
            }
        }
        public void ApplyProductDetails(DataTable DtproductList)
        {
            ClearPurchaseDetailsGroup();
            LblAvaiableItems.Show();
            NoOfItemsSignle = 1;
            CurrentAvailableItems = 0;
            IsAllowTextChange = false;
            DiscountAmountHeader = 0;
            PurchaseIdSale = Convert.ToInt32(DtproductList.Rows[0]["purchase_id"].ToString());
            PurchaseLineIdSale = Convert.ToInt32(DtproductList.Rows[0]["purchase_line_id"].ToString());
            SinglePrice = Convert.ToDouble(DtproductList.Rows[0]["selling_price"].ToString());
            SingleCgstPer = Convert.ToDouble(DtproductList.Rows[0]["cgst_per"].ToString());
            SingleSgstPer = Convert.ToDouble(DtproductList.Rows[0]["sgst_per"].ToString());
            TxtDiscountHeader.Text = DiscountAmountHeader.ToString();
            TxtHSNCode.Text = DtproductList.Rows[0]["hsn_code"].ToString();
            TxtArDescription.Text = DtproductList.Rows[0]["description"].ToString();
            CurrentAvailableItems = Convert.ToInt32(DtproductList.Rows[0]["number_of_items_available"].ToString());
            LblAvaiableItems.Text = "(" + DtproductList.Rows[0]["number_of_items_available"].ToString() + ")";
            SetAllCalculationsTextBox();

            //messageShow.singlemsgtext("Have to work on here");

        }
        private void SetAllCalculationsTextBox()
        {
            SingleCgstAmount = NoOfItemsSignle * SinglePrice / 100 * SingleCgstPer;
            SingleSgstAmount = NoOfItemsSignle * SinglePrice / 100 * SingleSgstPer;
            SingleTotalAmount = NoOfItemsSignle * SinglePrice + SingleCgstAmount + SingleSgstAmount;
            TxtRate.Text = SinglePrice.ToString();
            TxtNoOfItems.Text = NoOfItemsSignle.ToString();
            TxtCgstPer.Text = SingleCgstPer.ToString();
            TxtCgstRs.Text = SingleCgstAmount.ToString();
            TxtSgstPer.Text = SingleSgstPer.ToString();
            TxtSgstRs.Text = SingleSgstAmount.ToString();
            TxtTotaltaxHeader.Text = (SingleCgstAmount + SingleSgstAmount).ToString();
            TxtSingleTotal.Text = SingleTotalAmount.ToString();
            IsAllowTextChange = true; //To allow the text box change event
        }
        private void TxtNoOfItems_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtNoOfItems.Text.ToString()) && IsAllowTextChange)
            {
                if (Convert.ToInt32(TxtNoOfItems.Text) > CurrentAvailableItems)
                {
                    IsAllowTextChange = false;
                    messageShow.singlemsgtext("Entered quantity not available.");
                    TxtNoOfItems.Text = TxtNoOfItems.Text.Substring(0, (TxtNoOfItems.TextLength - 1));
                    IsAllowTextChange = true;
                    TxtNoOfItems.SelectAll();
                    TxtNoOfItems.Focus();
                    return;
                }
                NoOfItemsSignle = Convert.ToInt32(TxtNoOfItems.Text.ToString());
                SinglePrice = Convert.ToDouble(TxtRate.Text.ToString());
                SingleCgstAmount = Convert.ToDouble(TxtCgstRs.Text.ToString());
                SingleSgstAmount = Convert.ToDouble(TxtSgstRs.Text.ToString());
                SingleCgstPer = Convert.ToDouble(TxtCgstPer.Text.ToString());
                SingleSgstPer = Convert.ToDouble(TxtSgstPer.Text.ToString());
                DiscountAmountHeader = Convert.ToDouble(TxtDiscountHeader.Text.ToString());

                SingleCgstAmount = NoOfItemsSignle * SinglePrice / 100 * SingleCgstPer;
                SingleSgstAmount = NoOfItemsSignle * SinglePrice / 100 * SingleSgstPer;
                SingleTotalAmount = NoOfItemsSignle * SinglePrice + SingleCgstAmount + SingleSgstAmount;
                TxtCgstPer.Text = SingleCgstPer.ToString();
                TxtCgstRs.Text = SingleCgstAmount.ToString();
                TxtSgstPer.Text = SingleSgstPer.ToString();
                TxtSgstRs.Text = SingleSgstAmount.ToString();
                TxtTotaltaxHeader.Text = (SingleCgstAmount + SingleSgstAmount).ToString();
                TxtSingleTotal.Text = (SingleTotalAmount - DiscountAmountHeader).ToString();
            }
        }
        private void TxtRate_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtRate.Text.ToString()) && IsAllowTextChange)
            {
                NoOfItemsSignle = Convert.ToInt32(TxtNoOfItems.Text.ToString());
                SinglePrice = Convert.ToDouble(TxtRate.Text.ToString());
                SingleCgstAmount = Convert.ToDouble(TxtCgstRs.Text.ToString());
                SingleSgstAmount = Convert.ToDouble(TxtSgstRs.Text.ToString());
                SingleCgstPer = Convert.ToDouble(TxtCgstPer.Text.ToString());
                SingleSgstPer = Convert.ToDouble(TxtSgstPer.Text.ToString());

                SingleCgstAmount = NoOfItemsSignle * SinglePrice / 100 * SingleCgstPer;
                SingleSgstAmount = NoOfItemsSignle * SinglePrice / 100 * SingleSgstPer;
                SingleTotalAmount = NoOfItemsSignle * SinglePrice + SingleCgstAmount + SingleSgstAmount;
                TxtCgstPer.Text = SingleCgstPer.ToString();
                TxtCgstRs.Text = SingleCgstAmount.ToString();
                TxtSgstPer.Text = SingleSgstPer.ToString();
                TxtSgstRs.Text = SingleSgstAmount.ToString();
                TxtSingleTotal.Text = SingleTotalAmount.ToString();
            }
        }
        private void ClearPurchaseDetailsGroup()
        {
            PurchaseIdSale = 0;
            PurchaseLineIdSale = 0;
            TxtHSNCode.Text = "";
            TxtArDescription.Text = "";
            TxtCgstPer.Text = "";
            TxtCgstRs.Text = "";
            TxtSgstPer.Text = "";
            TxtSgstRs.Text = "";
            TxtRate.Text = "";
            TxtSingleTotal.Text = "";
        }
        public void ShowDataGridPop(DataTable DtItemList_d)
        {
            try
            {
                DataGridPopUp pop = new DataGridPopUp();
                pop.DisplayDataGridPopUp(DtItemList_d);
                DialogResult DialogResult = pop.DialogResult;
                if (DialogResult == DialogResult.OK)
                {
                    GetBrandListById(0, 0, pop.PurchaseId, pop.PurchaseLineId);
                }
                if (DialogResult == DialogResult.Cancel)
                {
                    messageShow.singlemsgtext("You must select atleast one item in this list.");
                }
                pop.Dispose();
            }
            catch (Exception _exception)
            {
                CmC.InsertException(_exception);
                messageShow.singlemsgtext(CmC.ExceptionErrorMessage);
            }       
        }

        private void BtnInsertUpdateGrid_Click(object sender, EventArgs e)
        {
            AddValuesToDataGrid();
        }
        private void AddValuesToDataGrid()
        {
            try
            {
                string ResultMessage = ValidateLineControlles();
                if (!string.IsNullOrEmpty(ResultMessage))
                {
                    messageShow.singlemsgtext(ResultMessage);
                    return;
                }
                GridAutoIncrement = 0;
                string ProductName = ((KeyValuePair<string, string>)DropDownProductName.SelectedItem).Value.ToString();
                int ProductCode = Convert.ToInt32(((KeyValuePair<string, string>)DropDownProductName.SelectedItem).Key.ToString());
                string ItemName = ((KeyValuePair<string, string>)DropDownItemName.SelectedItem).Value.ToString();
                int ItemCode = Convert.ToInt32(((KeyValuePair<string, string>)DropDownItemName.SelectedItem).Key.ToString());
                string BrandName = ((KeyValuePair<string, string>)DropDownBrandName.SelectedItem).Value.ToString();
                int BrandCode = Convert.ToInt32(((KeyValuePair<string, string>)DropDownBrandName.SelectedItem).Key.ToString());
                string ColorName = ((KeyValuePair<string, string>)DropDownColorName.SelectedItem).Value.ToString();
                int ColorCode = Convert.ToInt32(((KeyValuePair<string, string>)DropDownColorName.SelectedItem).Key.ToString());
                string Description = TxtArDescription.Text.ToString();
                string HSNCode = TxtHSNCode.Text.ToString();
                int Quantity = Convert.ToInt32(TxtNoOfItems.Text.ToString());
                double Price = Convert.ToDouble(TxtRate.Text.ToString());
                double SingleTotal = Convert.ToDouble(TxtSingleTotal.Text.ToString());
                double CgstPer = Convert.ToDouble(TxtCgstPer.Text.ToString());
                double SgstPer = Convert.ToDouble(TxtSgstPer.Text.ToString());
                double CgstAmount = Convert.ToDouble(TxtCgstRs.Text.ToString());
                double SgstAmount = Convert.ToDouble(TxtSgstRs.Text.ToString());
                double DiscountAmount = Convert.ToDouble(TxtDiscountHeader.Text.ToString());
                double TaxableAmount = (Quantity * Price) - DiscountAmount;

                ResultMessage = ValidateDuplicateGrid(ProductCode, ItemCode, BrandCode, ColorCode); //To prevent the duplicate entry in the grid
                if (!string.IsNullOrEmpty(ResultMessage))
                {
                    messageShow.singlemsgtext(ResultMessage);
                    return;
                }

                string[] row = { PurchaseIdSale.ToString(), PurchaseLineIdSale.ToString(), SalesId_Sales.ToString(), 
                                SalesLineId.ToString(),
                                GridAutoIncrement.ToString(), ItemCode.ToString(), ItemName.ToString(), 
                                BrandCode.ToString(), BrandName,
                                ProductCode.ToString(), ProductName,
                                ColorCode.ToString(), ColorName,
                                Description, HSNCode, 
                                Quantity.ToString(), Price.ToString(), 
                                (Quantity * Price).ToString(), DiscountAmount.ToString(),
                                TaxableAmount.ToString(),
                                CgstPer.ToString(), CgstAmount.ToString(), SgstPer.ToString(), SgstAmount.ToString(),
                                TxtSingleTotal.Text.ToString(), "Edit", "Delete", CurrentAvailableItems.ToString()};
                if (BtnInsertUpdateGrid.Text.ToString() == "Add")
                {
                    DataGridDetails.Rows.Add(row);
                    UpdateSerialNumberToGrid();
                }
                else if (BtnInsertUpdateGrid.Text.ToString() == "Save")
                {
                    DataGridDetails.Rows[DataGridDetails.CurrentCell.RowIndex].SetValues(row);
                    UpdateSerialNumberToGrid();
                }
                else
                {
                    messageShow.singlemsgtext("Invalid button text");
                }
                EmptyBtnaddListcontrols();
            }
            catch (Exception _exception)
            {
                CmC.InsertException(_exception);
                messageShow.singlemsgtext(CmC.ExceptionErrorMessage);
            }
        }
        private string ValidateDuplicateGrid(int ProductCode, int ItemCode, int BrandCode, int ColorCode)
        {
            for (int i = 0; i < DataGridDetails.Rows.Count; i++)
            {
                if(Convert.ToInt32(DataGridDetails.Rows[i].Cells["item_code"].Value.ToString()) == ItemCode &&
                    Convert.ToInt32(DataGridDetails.Rows[i].Cells["brand_code"].Value.ToString()) == BrandCode &&
                    Convert.ToInt32(DataGridDetails.Rows[i].Cells["product_code"].Value.ToString()) == ProductCode &&
                    Convert.ToInt32(DataGridDetails.Rows[i].Cells["color_code"].Value.ToString()) == ColorCode &&
                    BtnInsertUpdateGrid.Text.ToString() == "Add")
                    //Convert.ToInt32(DataGridDetails.Rows[i].Cells["purchase_line_id"].Value.ToString()) == PurchaseLineIdSale)
                {
                    return "This product already added in the sales list, please select edit and update the quantity.";
                }
            }
            return string.Empty;
        }
        private string ValidateLineControlles()
        {
            string ValidateMessage = string.Empty;
            if (DropDownItemName.SelectedIndex <= 0)
            {
                DropDownItemName.Focus();
                return "Please select the Item Name.";
            }
            if (DropDownProductName.SelectedIndex <= 0)
            {
                DropDownProductName.Focus();
                return "Please select the Product Name.";
            }
            if (DropDownBrandName.SelectedIndex <= 0)
            {
                DropDownBrandName.Focus();
                return "Please select the Brand Name.";
            }
            if (DropDownColorName.SelectedIndex <= 0)
            {
                DropDownColorName.Focus();
                return "Please select the Color";
            }
            if (string.IsNullOrEmpty(TxtNoOfItems.Text.ToString()))
            {
                TxtNoOfItems.Focus();
                return "Please enter the number of Items";
            }
            if (string.IsNullOrEmpty(TxtDiscountHeader.Text.ToString()))
            {
                TxtDiscountHeader.Focus();
                return "Please enter the discount price";
            }
            return ValidateMessage;
        }
        private void EmptyBtnaddListcontrols()
        {
            LblAvaiableItems.Hide();
            EmptyProductListDropDown();
            EmptyBrandListDropDown();
            EmptyItemListDropDown();
            EmptyColorListDropDown();
            foreach (Control ctr in Grouppurchase.Controls)
            {
                if (ctr is TextBox)
                {
                    ctr.Text = "";
                }
                if (ctr is RichTextBox)
                {
                    ctr.Text = "";
                }
            }
            GetItemList();
            if (DataGridDetails.Rows.Count > 0)
            {
                GetGrossAmountTotal();
            }
            GetUnitAndPaymentTypeDropDown();
            BtnInsertUpdateGrid.Text = "Add";
        }
        private void GetGrossAmountTotal()
        {
            GrossAmount = 0;
            double TotDiscount = 0;
            GrossAmount = DataGridDetails.Rows.Cast<DataGridViewRow>()
                                                .Sum(s => (Convert.ToDouble(s.Cells["sigle_total_amount"].Value)));
            TotDiscount = DataGridDetails.Rows.Cast<DataGridViewRow>()
                                                .Sum(s => (Convert.ToDouble(s.Cells["discount_header"].Value)));
            TxtGrossAmount.Text = (GrossAmount + TotDiscount).ToString();
            TxtDiscountAmt.Text = TotDiscount.ToString();
            TxtNetAmount.Text = (Convert.ToDouble(TxtGrossAmount.Text) - TotDiscount).ToString();
            TxtPaidAmount.Text = Convert.ToDouble(TxtNetAmount.Text).ToString();
            TotDiscount = 0;
            TxtDiscountPer.Text = TotDiscount.ToString();
        }

        private void TxtPaidAmount_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtPaidAmount.Text.ToString()) && IsAllowTextChange)
            {
                PaidAmount = Convert.ToDouble(TxtPaidAmount.Text.ToString());
                NetAmount = Convert.ToDouble(TxtNetAmount.Text.ToString());
                TxtDuesAmount.Text = (NetAmount - PaidAmount).ToString();
            }
        }
        private void TxtDiscountPer_TextChanged(object sender, EventArgs e)
        {
            /*if (!string.IsNullOrEmpty(TxtDiscountPer.Text.ToString()) && IsChangeDiscount == 1)
            {
                MultipleDiscountPer = Convert.ToDouble(TxtDiscountPer.Text.ToString());
                GrossAmount = Convert.ToDouble(TxtGrossAmount.Text.ToString());
                MultipleDiscountAmt = (GrossAmount / 100) * MultipleDiscountPer;
                TxtDiscountAmt.Text = MultipleDiscountAmt.ToString();
                NetAmount = GrossAmount - MultipleDiscountAmt;
                TxtNetAmount.Text = NetAmount.ToString();
            }*/
        }
        private void TxtDiscountAmt_TextChanged(object sender, EventArgs e)
        {
            /*if (!string.IsNullOrEmpty(TxtDiscountAmt.Text.ToString()))
            {
                MultipleDiscountAmt = Convert.ToDouble(TxtDiscountAmt.Text.ToString());
                MultipleDiscountPer = Math.Round((MultipleDiscountAmt / GrossAmount) * 100, 2);
                UpdateDiscountPercentage();
            }*/
        }

        private void TxtDiscountPer_Leave(object sender, EventArgs e)
        {
        }

        private void TxtDiscountAmt_Leave(object sender, EventArgs e)
        {
        }

        private void BtnInsertUpdatePurchase_Click(object sender, EventArgs e)
        {
            try
            {
                string ResultMessage = ValidateHeaderControlles();
                if (!string.IsNullOrEmpty(ResultMessage))
                {
                    messageShow.singlemsgtext(ResultMessage);
                    return;
                }
                var SalesDetails = new SalesDetails
                {
                    SalesId = SalesId_Sales,
                    CustomerName = TxtCustomerName.Text.ToString(),
                    CustomerMobileNo = Convert.ToDouble(TxtCustomerMobileNo.Text.ToString()),
                    GrossAmount = Convert.ToDouble(TxtGrossAmount.Text.ToString()),
                    DiscountPer = Convert.ToDouble(TxtDiscountPer.Text.ToString()),
                    DiscountAmount = Convert.ToDouble(TxtDiscountAmt.Text.ToString()),
                    NetAmount = Convert.ToDouble(TxtNetAmount.Text.ToString()),
                    PaymentType = Convert.ToInt32(((KeyValuePair<string, string>)DropDownPaymentType.SelectedItem).Key.ToString()),
                    PaidAmount = Convert.ToDouble(TxtPaidAmount.Text.ToString()),
                    DuesAmount = Convert.ToDouble(TxtDuesAmount.Text.ToString()),
                    DtSalesDetails = DataGridViewToDataTable(),
                    OperationType = BtnInsertUpdatePurchase.Text == "Update" ? 2 : 1
                };
                long SalesId = _SalesRepository.InsertUpdateSalesDetails(SalesDetails);
                if (SalesId > 0 && SalesId_Sales == 0)
                {
                    new SalesBillingReport(SalesId).ShowDialog();
                    EmptyDataGridAndHeader();
                }
                else if (SalesId > 0 && SalesId_Sales != 0)
                {
                    new SalesBillingReport(SalesId).ShowDialog();
                }
                else
                {
                    messageShow.singlemsgtext("Error occured in sales the product.");
                }
            }
            catch (Exception _exception)
            {
                CmC.InsertException(_exception);
                messageShow.singlemsgtext(CmC.ExceptionErrorMessage);
            }
        }
        private string ValidateHeaderControlles()
        {
            string ValidateMessage = string.Empty;
            if (DataGridDetails.Rows.Count <= 0)
            {
                return "Please add atleast one product to sale";
            }
            if (DropDownPaymentType.SelectedIndex <= 0)
            {
                DropDownPaymentType.Focus();
                return "Please select the Payment Type.";
            }
            if (string.IsNullOrEmpty(TxtCustomerName.Text.ToString()))
            {
                TxtCustomerName.Focus();
                return "Please enter the Customer Name";
            }
            if (string.IsNullOrEmpty(TxtCustomerMobileNo.Text.ToString()))
            {
                TxtCustomerMobileNo.Focus();
                return "Please enter the Customer Mobile Number";
            }
            if (string.IsNullOrEmpty(TxtPaidAmount.Text.ToString()))
            {
                TxtPaidAmount.Focus();
                return "Please enter the Paid amount";
            }
            return ValidateMessage;
        }
        private void EmptyDataGridAndHeader()
        {
            DataGridDetails.Rows.Clear();
            DataGridDetails.Refresh();
            TxtPaidAmount.Text = "";
            TxtDuesAmount.Text = "";
            TxtNetAmount.Text = "";
            TxtCustomerName.Text = "";
            TxtCustomerMobileNo.Text="";
            TxtGrossAmount.Text = "";
            TxtDiscountPer.Text = "";
            TxtDiscountAmt.Text = "";
            EmptyBtnaddListcontrols();
        }
        private DataTable DataGridViewToDataTable()
        {
            //DtSalesDetails = new DataTable();
            DataTable DtConvertedTable = new DataTable();
            DtConvertedTable.Clear();
            foreach (DataGridViewColumn col in DataGridDetails.Columns)
            {
                DtConvertedTable.Columns.Add(col.Name);
            }

            foreach (DataGridViewRow row in DataGridDetails.Rows)
            {
                DataRow dRow = DtConvertedTable.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dRow[cell.ColumnIndex] = cell.Value;
                }
                DtConvertedTable.Rows.Add(dRow);
            }
            DtConvertedTable.Columns.Remove("srno");
            DtConvertedTable.Columns.Remove("brand_name");
            DtConvertedTable.Columns.Remove("item_code");
            DtConvertedTable.Columns.Remove("item_name");
            DtConvertedTable.Columns.Remove("product_code");
            DtConvertedTable.Columns.Remove("product_name");
            DtConvertedTable.Columns.Remove("hsn_code");
            DtConvertedTable.Columns.Remove("total_amount_s");
            DtConvertedTable.Columns.Remove("color_code");
            DtConvertedTable.Columns.Remove("color_name");
            DtConvertedTable.Columns.Remove("taxable_amount");
            DtConvertedTable.Columns.Remove("edit");
            DtConvertedTable.Columns.Remove("delete");
            DtConvertedTable.Columns.Remove("number_of_items_available");
            return DtConvertedTable;
        }

        private void TxtCustomerMobileNo_TextChanged(object sender, EventArgs e)
        {
        }

        private void TxtCustomerMobileNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CmC.CheckNumberOnlyText(e);
        }

        private void TxtNoOfItems_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CmC.CheckNumberOnlyText(e);
        }

        private void TxtRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CmC.CheckNumberWithDecimalText(e);
        }

        private void TxtCgstPer_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CmC.CheckNumberWithDecimalText(e);
        }

        private void TxtCgstRs_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CmC.CheckNumberWithDecimalText(e);
        }

        private void TxtSgstPer_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CmC.CheckNumberWithDecimalText(e);
        }

        private void TxtSgstRs_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CmC.CheckNumberWithDecimalText(e);
        }

        private void TxtSingleTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CmC.CheckNumberWithDecimalText(e);
        }

        private void TxtGrossAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CmC.CheckNumberWithDecimalText(e);
        }

        private void TxtDiscountPer_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CmC.CheckNumberWithDecimalText(e);
        }

        private void TxtDiscountAmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CmC.CheckNumberWithDecimalText(e);
        }

        private void TxtNetAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CmC.CheckNumberWithDecimalText(e);
        }

        private void TxtPaidAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CmC.CheckNumberWithDecimalText(e);
        }

        private void TxtDuesAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CmC.CheckNumberWithDecimalText(e);
        }
        private void ChangeButtonText(string gridSave, string dbUpdate)
        {
            BtnInsertUpdateGrid.Text = gridSave;
            BtnInsertUpdatePurchase.Text = dbUpdate;
        }

        private void DataGridDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //IsUpdateToGrid
            if (DataGridDetails.Rows.Count > 0)
            {
                int RowIndex = DataGridDetails.CurrentCell.RowIndex;
                int ColumnIndex = DataGridDetails.CurrentCell.ColumnIndex;
                string text = DataGridDetails.Columns[ColumnIndex].HeaderText;
                if (text.Equals("Edit"))
                {
                    IsAllowTextChange = false;
                    BtnInsertUpdateGrid.Text = "Save";
                    SelectedRowIndex = Convert.ToInt32(DataGridDetails.Rows[RowIndex].Cells[4].Value.ToString());
                    BindGridDataToheader(RowIndex);
                    IsAllowTextChange = true;
                }
                if (text.Equals("Delete"))
                {
                    string result = messageShow.show("Delete!", "Do you want to delete the item permanently?");
                    if (result == "1")
                    {
                        IsAllowTextChange = false;
                        if (DataGridDetails.Rows.Count > 0)
                        {
                            DataGridDetails.Rows.RemoveAt(RowIndex);
                            GetGrossAmountTotal();
                            UpdateSerialNumberToGrid();
                        }
                        IsAllowTextChange = true;
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }
        private void UpdateSerialNumberToGrid()
        {
            for (int i = 0; i < DataGridDetails.Rows.Count; i++)
            {
                DataGridDetails.Rows[i].Cells["srno"].Value = (i+1).ToString(); 
            }
        }
        private void BindGridDataToheader(int RowIndex)
        {
            CurrentAvailableItems = 0;
            SetTextToDropDownItem(DataGridDetails.Rows[RowIndex].Cells["item_code"].Value.ToString(), DataGridDetails.Rows[RowIndex].Cells["item_name"].Value.ToString());
            SetTextToDropDownBrand(DataGridDetails.Rows[RowIndex].Cells["brand_code"].Value.ToString(), DataGridDetails.Rows[RowIndex].Cells["brand_name"].Value.ToString());
            SetTextToDropDownProduct(DataGridDetails.Rows[RowIndex].Cells["product_code"].Value.ToString(), DataGridDetails.Rows[RowIndex].Cells["product_name"].Value.ToString());
            SetTextToDropDownColor(DataGridDetails.Rows[RowIndex].Cells["color_code"].Value.ToString(), DataGridDetails.Rows[RowIndex].Cells["color_name"].Value.ToString());
            TxtHSNCode.Text = DataGridDetails.Rows[RowIndex].Cells["hsn_code"].Value.ToString();
            TxtArDescription.Text = DataGridDetails.Rows[RowIndex].Cells["description"].Value.ToString();
            TxtNoOfItems.Text = DataGridDetails.Rows[RowIndex].Cells["quantity"].Value.ToString();
            TxtRate.Text = DataGridDetails.Rows[RowIndex].Cells["rate"].Value.ToString();
            TxtCgstPer.Text = DataGridDetails.Rows[RowIndex].Cells["cgst_per"].Value.ToString();
            TxtCgstRs.Text = DataGridDetails.Rows[RowIndex].Cells["cgst_amount"].Value.ToString();
            TxtSgstPer.Text = DataGridDetails.Rows[RowIndex].Cells["sgst_per"].Value.ToString();
            TxtSgstRs.Text = DataGridDetails.Rows[RowIndex].Cells["sgst_amount"].Value.ToString();
            TxtSingleTotal.Text = DataGridDetails.Rows[RowIndex].Cells["sigle_total_amount"].Value.ToString();
            SalesLineId = Convert.ToInt32(DataGridDetails.Rows[RowIndex].Cells["sales_line_id"].Value.ToString());
            PurchaseIdSale = Convert.ToInt32(DataGridDetails.Rows[RowIndex].Cells["purchase_id"].Value.ToString());
            PurchaseLineIdSale = Convert.ToInt32(DataGridDetails.Rows[RowIndex].Cells["purchase_line_id"].Value.ToString());
            TxtDiscountHeader.Text = DataGridDetails.Rows[RowIndex].Cells["discount_header"].Value.ToString();
            TxtTotaltaxHeader.Text = (Convert.ToDouble(DataGridDetails.Rows[RowIndex].Cells["cgst_amount"].Value) +
                                       Convert.ToDouble(DataGridDetails.Rows[RowIndex].Cells["sgst_amount"].Value)).ToString();
            CurrentAvailableItems = Convert.ToInt32(DataGridDetails.Rows[RowIndex].Cells["number_of_items_available"].Value.ToString());
            LblAvaiableItems.Text = "(" + CurrentAvailableItems.ToString() + ")";
            
            LblAvaiableItems.Show();
        }
        private void SetTextToDropDownItem(string name, string value)
        {
            DropDownItemName.DataSource = new BindingSource(CmC.ConvertStringToDictionary(name, value), null);
            DropDownItemName.DisplayMember = "Value";
            DropDownItemName.ValueMember = "Key";
            DropDownItemName.SelectedIndex = 1;
        }
        private void SetTextToDropDownBrand(string name, string value)
        {
            DropDownBrandName.DataSource = new BindingSource(CmC.ConvertStringToDictionary(name, value), null);
            DropDownBrandName.DisplayMember = "Value";
            DropDownBrandName.ValueMember = "Key";
            DropDownBrandName.SelectedIndex = 1;
        }
        private void SetTextToDropDownProduct(string name, string value)
        {
            DropDownProductName.DataSource = new BindingSource(CmC.ConvertStringToDictionary(name, value), null);
            DropDownProductName.DisplayMember = "Value";
            DropDownProductName.ValueMember = "Key";
            DropDownProductName.SelectedIndex = 1;
        }
        private void SetTextToDropDownColor(string name, string value)
        {
            DropDownColorName.DataSource = new BindingSource(CmC.ConvertStringToDictionary(name, value), null);
            DropDownColorName.DisplayMember = "Value";
            DropDownColorName.ValueMember = "Key";
            DropDownColorName.SelectedIndex = 1;
        }

        private void DropDownColorName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownColorName.SelectedIndex > 0 && IsAllowTextChange)
            {
                IsAllowTextChange = false;
                SelectedColorCode = Convert.ToInt32(((KeyValuePair<string, string>)DropDownColorName.SelectedItem).Key.ToString());
                GetBrandListById(SelectedBrandCode,SelectedColorCode, 0,0);
                IsAllowTextChange = true;
            }
        }

        private void TxtDiscountHeader_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CmC.CheckNumberWithDecimalText(e);
        }

        private void TxtDiscountHeader_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtDiscountHeader.Text.ToString()) && IsAllowTextChange)
            {
                NoOfItemsSignle = Convert.ToInt32(TxtNoOfItems.Text.ToString());
                SinglePrice = Convert.ToDouble(TxtRate.Text.ToString());
                SingleCgstAmount = Convert.ToDouble(TxtCgstRs.Text.ToString());
                SingleSgstAmount = Convert.ToDouble(TxtSgstRs.Text.ToString());
                SingleCgstPer = Convert.ToDouble(TxtCgstPer.Text.ToString());
                SingleSgstPer = Convert.ToDouble(TxtSgstPer.Text.ToString());
                DiscountAmountHeader = Convert.ToDouble(TxtDiscountHeader.Text.ToString());

                SingleCgstAmount = NoOfItemsSignle * SinglePrice / 100 * SingleCgstPer;
                SingleSgstAmount = NoOfItemsSignle * SinglePrice / 100 * SingleSgstPer;
                SingleTotalAmount = NoOfItemsSignle * SinglePrice + SingleCgstAmount + SingleSgstAmount;
                TxtCgstPer.Text = SingleCgstPer.ToString();
                TxtCgstRs.Text = SingleCgstAmount.ToString();
                TxtSgstPer.Text = SingleSgstPer.ToString();
                TxtSgstRs.Text = SingleSgstAmount.ToString();
                TxtSingleTotal.Text = (SingleTotalAmount - DiscountAmountHeader).ToString();
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            EmptyBtnaddListcontrols();
        }

        private void BtnRefreshHeader_Click(object sender, EventArgs e)
        {
            EmptyDataGridAndHeader();
        }

        private void BtnExit_Click(object sender, EventArgs e)
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

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            LoginHome lm = new LoginHome();
            this.Hide();
            lm.Show();
        }
    }
}
