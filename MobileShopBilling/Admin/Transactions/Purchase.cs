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
using BusinessLayer.Repository.ExceptionRepositoryHandler;
using BusinessLayer.Repository.PurchaseAndSales;
using DomainModel.Transactions;
using MobileShopBilling.Admin.CommonClasses;

namespace MobileShopBilling.Admin.Transactions
{
    public partial class Purchase : Form
    {
        PurchaseRepository _PurchaseRepository = new PurchaseRepository();
        ExceptionRepository _exceptionRepository = new ExceptionRepository();
        CommonModel CmC = new CommonModel();
        DataTable DtItemList = new DataTable();
        MsgBoxMessages messageShow = new MsgBoxMessages();
        Dictionary<string, string> DcItemList = new Dictionary<string, string>();
        DataGridViewLinkColumn lm = new DataGridViewLinkColumn();
        BindingSource SBind = new BindingSource();
        int SelectedItemCode = 0, SelectedProductCode = 0, SelectedBrandCode = 0, SelectedSupplierCode = 0, SelectedColorCode = 0;
        int GridAutoIncrement = 0, SelectedRowIndex = 0;
        bool IsAllowTextChange = true;
        double SingleTotalPricePurchase = 0, SingleCgstAmountPurchase = 0, SingleSgstAmountPurchase = 0, NetAmountPurchase = 0;
        double SingleTotalPriceSales = 0, SingleCgstAmountSales = 0, SingleSgstAmountSales = 0, NetAmountSales = 0;
        string SelectedSupplierName = "";
        public Purchase()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Purchase_Load(object sender, EventArgs e)
        {
            LblHeaderText.BackColor = Color.FromName(CmC.LblBackColor);
            LblHeaderText.Font = new Font(CmC.LblFontStyle, CmC.LblFontSize); //, 17pt, style=Bold
            LblHeaderText.Font = new Font(LblHeaderText.Font, FontStyle.Bold);
            LblHeaderText.ForeColor = Color.FromName(CmC.LblFontColor);

            DropDownItemName.Focus();
            datagriddesign();
            GetItemList();
            GetSupplierNameList();
            GetUnitAndPaymentTypeDropDown();
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
        public void GetSupplierNameList()
        {
            try
            {
                DtItemList.Clear();
                DcItemList.Clear();
                DropDownSupplierName.Refresh();
                DtItemList = CmC.GetMasterNamesAndCodes("", 0, 6);
                if (DtItemList.Rows.Count > 0)
                {
                    DropDownSupplierName.DataSource = new BindingSource(CmC.ConvertDataTableToDictionary(DtItemList), null);
                    DropDownSupplierName.DisplayMember = "Value";
                    DropDownSupplierName.ValueMember = "Key";
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
            DcItemList.Add("1" , "Cash");
            DcItemList.Add("2", "Card");
            DropDownPaymentType.DataSource = new BindingSource(DcItemList, null);
            DropDownPaymentType.DisplayMember = "Value";
            DropDownPaymentType.ValueMember = "Key";
            DropDownPaymentType.SelectedIndex = 1;

            DcItemList.Clear();
            DcItemList.Add("0", "--Select--");
            DcItemList.Add("1", "Pcs");
            DropDownUnit.DataSource = new BindingSource(DcItemList, null);
            DropDownUnit.DisplayMember = "Value";
            DropDownUnit.ValueMember = "Key";
            DropDownUnit.SelectedIndex = 1;
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

        private void DropDownItemName_Leave(object sender, EventArgs e)
        {
            if (DropDownItemName.SelectedIndex < 0)
            {
                messageShow.singlemsgtext("Invalid Item Nmae, Must select the Item");
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
        private void EmptyColorListDropDown()
        {
            DropDownColorName.DataSource = null;
            DropDownColorName.Items.Clear();
            DropDownColorName.Items.Add(DBNull.Value);
            DropDownColorName.Items.Clear();
        }
        private void EmptyUnitDropDown()
        {
            DropDownUnit.DataSource = null;
            DropDownUnit.Items.Clear();
            DropDownUnit.Items.Add(DBNull.Value);
            DropDownUnit.Items.Clear();
        }
        private void EmptySupplierNameDropDown()
        {
            DropDownSupplierName.DataSource = null;
            DropDownSupplierName.Items.Clear();
            DropDownSupplierName.Items.Add(DBNull.Value);
            DropDownSupplierName.Items.Clear();
        }
        private void EmptySupplierMobileNoDropDown()
        {
            DropDownSupplierMobNo.DataSource = null;
            DropDownSupplierMobNo.Items.Clear();
            DropDownSupplierMobNo.Items.Add(DBNull.Value);
            DropDownSupplierMobNo.Items.Clear();
        }

        private void EmptyBtnaddListcontrols()
        {
            EmptyProductListDropDown();
            EmptyBrandListDropDown();
            EmptyItemListDropDown();
            EmptyUnitDropDown();
            EmptyColorListDropDown();
            IsAllowTextChange = false;
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
            GetNetAmountTotalPurchase();
            GetNetAmountTotalSales();
            GetUnitAndPaymentTypeDropDown();
            IsAllowTextChange = true;
            BtnInsertUpdateGrid.Text = "Add";
        }
        private void RoundValues()
        {
            TxtPurchasePrice.Text = TxtSingleTotalPurchase.ToString();
            TxtNoItems.Text = TxtSingleTotalPurchase.ToString();
            TxtCgstPer.Text = TxtSingleTotalPurchase.ToString();
            TxtSgstPer.Text = TxtSingleTotalPurchase.ToString();
            TxtSingleTotalPurchase.Text = TxtSingleTotalPurchase.ToString();
        }

        private void DropDownProductName_Leave(object sender, EventArgs e)
        {
            if (DropDownProductName.SelectedIndex < 0)
            {
                messageShow.singlemsgtext("Invalid product Nmae, Must select the product");
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
        private void EmptyBrandListDropDown()
        {
            DropDownBrandName.DataSource = null;
            DropDownBrandName.Items.Clear();
            DropDownBrandName.Items.Add(DBNull.Value);
            DropDownBrandName.Items.Clear();
        }

        private void DropDownBrandName_Leave(object sender, EventArgs e)
        {
            if (DropDownBrandName.SelectedIndex < 0)
            {
                messageShow.singlemsgtext("Invalid Brand Nmae, Must select the Brand Name");
            }
        }

        private void DropDownSupplierName_Leave(object sender, EventArgs e)
        {
            if (DropDownSupplierName.SelectedIndex < 0)
            {
                messageShow.singlemsgtext("Invalid Supplier Nmae, Must select the Supplier Name");
            }
        }
        public void GetSupplierMobileNumberList(string SelectedSupplierName)
        {
            try
            {
                DtItemList.Clear();
                DcItemList.Clear();
                DtItemList = CmC.GetMasterNamesAndCodes(SelectedSupplierName, 0, 7);
                if (DtItemList.Rows.Count > 0)
                {
                    DropDownSupplierMobNo.DataSource = new BindingSource(CmC.ConvertDataTableToDictionary(DtItemList), null);
                    DropDownSupplierMobNo.DisplayMember = "Value";
                    DropDownSupplierMobNo.ValueMember = "Key";
                }
            }
            catch (Exception _exception)
            {
                CmC.InsertException(_exception);
                messageShow.singlemsgtext(CmC.ExceptionErrorMessage);
            }
        }

        private void DropDownSupplierMobNo_Leave(object sender, EventArgs e)
        {
            
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

        private void DropDownBrandName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownBrandName.SelectedIndex > 0 && IsAllowTextChange)
            {
                SelectedBrandCode = Convert.ToInt32(((KeyValuePair<string, string>)DropDownBrandName.SelectedItem).Key.ToString());
                LoadColorDetails();
            }
        }
        private void LoadColorDetails()
        {
            try
            {
                DtItemList.Clear();
                DcItemList.Clear();
                DtItemList = CmC.GetMasterNamesAndCodes(SelectedSupplierName, 0, 8);
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

        private void DropDownSupplierName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownSupplierName.SelectedIndex > 0)
            {
                SelectedSupplierName = ((KeyValuePair<string, string>)DropDownSupplierName.SelectedItem).Key.ToString();
                if (SelectedSupplierName != "")
                {
                    EmptySupplierMobileNoDropDown();
                    GetSupplierMobileNumberList(SelectedSupplierName);
                }
            }
        }

        private void DropDownSupplierMobNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownSupplierMobNo.SelectedIndex > 0)
            {
                SelectedSupplierCode = Convert.ToInt32(((KeyValuePair<string, string>)DropDownSupplierMobNo.SelectedItem).Key.ToString());
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
                int BrandCode = Convert.ToInt32(((KeyValuePair<string, string>)DropDownBrandName.SelectedItem).Key.ToString());
                string BrandName = ((KeyValuePair<string, string>)DropDownBrandName.SelectedItem).Value.ToString();
                int ProductCode = Convert.ToInt32(((KeyValuePair<string, string>)DropDownProductName.SelectedItem).Key.ToString());
                string ProductName = ((KeyValuePair<string, string>)DropDownProductName.SelectedItem).Value.ToString();
                int ItemCode = Convert.ToInt32(((KeyValuePair<string, string>)DropDownItemName.SelectedItem).Key.ToString());
                string ItemName = ((KeyValuePair<string, string>)DropDownItemName.SelectedItem).Value.ToString();
                int ColorCode = Convert.ToInt32(((KeyValuePair<string, string>)DropDownColorName.SelectedItem).Key.ToString());
                string ColorName = ((KeyValuePair<string, string>)DropDownColorName.SelectedItem).Value.ToString();
                string Description = TxtArDescription.Text.ToString();
                string HSNCode = TxtHSNCode.Text.ToString();
                int Quantity = Convert.ToInt32(TxtNoItems.Text.ToString());
                string UnitName = ((KeyValuePair<string, string>)DropDownUnit.SelectedItem).Value.ToString();
                int UnitId = Convert.ToInt32(((KeyValuePair<string, string>)DropDownUnit.SelectedItem).Key.ToString());
                double PurchasePrice = Convert.ToDouble(TxtPurchasePrice.Text.ToString());
                double SalesPrice = Convert.ToDouble(TxtSalesPrice.Text.ToString());
                
                double GrossPurchasePrice = PurchasePrice * Quantity;
                double GrossSalesPrice = SalesPrice * Quantity; //TxtSingleTotalPurchase
                double CgstPer = Convert.ToDouble(TxtCgstPer.Text.ToString());
                double CgstAmountPurchase = GrossPurchasePrice / 100 * CgstPer;
                double SgstPer = Convert.ToDouble(TxtSgstPer.Text.ToString());
                double SgstAmountPurchase = GrossPurchasePrice / 100 * SgstPer;
                double CgstAmountSales = GrossSalesPrice / 100 * CgstPer; //No need to show
                double SgstAmountSales = GrossSalesPrice / 100 * SgstPer; //No need to show
                double GrandTotalPurchase = GrossPurchasePrice + CgstAmountPurchase + SgstAmountPurchase;
                double GrandTotalSales = GrossSalesPrice + CgstAmountSales + SgstAmountSales;

                ResultMessage = ValidateDuplicateGrid(ProductCode, ItemCode, BrandCode, ColorCode); //To prevent the duplicate entry in the grid
                if (!string.IsNullOrEmpty(ResultMessage))
                {
                    messageShow.singlemsgtext(ResultMessage);
                    return;
                }
                string[] row = {GridAutoIncrement.ToString() , BrandCode.ToString(), BrandName, 
                                ProductCode.ToString(), 
                                ProductName, ItemCode.ToString(), ItemName,
                                ColorCode.ToString(), ColorName, Description, HSNCode, Quantity.ToString(), UnitName,
                                UnitId.ToString(),
                                PurchasePrice.ToString(), SalesPrice.ToString(), 
                                GrossPurchasePrice.ToString(), GrossSalesPrice.ToString(), CgstPer.ToString(),
                                CgstAmountPurchase.ToString(), SgstPer.ToString(), SgstAmountPurchase.ToString(),
                                GrandTotalPurchase.ToString(), GrandTotalSales.ToString(),
                                "Edit", "Delete"};
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
                if (Convert.ToInt32(DataGridDetails.Rows[i].Cells["item_code"].Value.ToString()) == ItemCode &&
                    Convert.ToInt32(DataGridDetails.Rows[i].Cells["brand_code"].Value.ToString()) == BrandCode &&
                    Convert.ToInt32(DataGridDetails.Rows[i].Cells["product_code"].Value.ToString()) == ProductCode &&
                    Convert.ToInt32(DataGridDetails.Rows[i].Cells["color_code"].Value.ToString()) == ColorCode &&
                    BtnInsertUpdateGrid.Text.ToString() == "Add")
                //Convert.ToInt32(DataGridDetails.Rows[i].Cells["purchase_line_id"].Value.ToString()) == PurchaseLineIdSale)
                {
                    return "This product already added in the purchase list, please select edit and update the quantity.";
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
            if (string.IsNullOrEmpty(TxtNoItems.Text.ToString()))
            {
                TxtNoItems.Focus();
                return "Please enter the number of Items";
            }
            if (DropDownUnit.SelectedIndex <= 0)
            {
                DropDownUnit.Focus();
                return "Please select the Unit.";
            }
            if (string.IsNullOrEmpty(TxtPurchasePrice.Text.ToString()))
            {
                TxtPurchasePrice.Focus();
                return "Please enter the purchase price";
            }
            if (string.IsNullOrEmpty(TxtSalesPrice.Text.ToString()))
            {
                TxtSalesPrice.Focus();
                return "Please enter the sales price";
            }
            if (string.IsNullOrEmpty(TxtCgstPer.Text.ToString()))
            {
                TxtCgstPer.Focus();
                return "Please enter the Cgst percentage";
            }
            if (string.IsNullOrEmpty(TxtSgstPer.Text.ToString()))
            {
                TxtSgstPer.Focus();
                return "Please enter the Sgst percentage";
            }
            return ValidateMessage;
        }
        private void GetNetAmountTotalPurchase()
        {
            NetAmountPurchase = 0;
            NetAmountPurchase = DataGridDetails.Rows.Cast<DataGridViewRow>()
                                                .Sum(s => Convert.ToDouble(s.Cells["grand_total_purchase"].Value));
            TxtNetAmountPurchase.Text = NetAmountPurchase.ToString();
        }
        private void GetNetAmountTotalSales()
        {
            NetAmountSales = 0;
            NetAmountSales = DataGridDetails.Rows.Cast<DataGridViewRow>()
                                                .Sum(s => Convert.ToDouble(s.Cells["grand_total_sales"].Value));
            TxtNetAmountSales.Text = NetAmountSales.ToString();
        }
        private void TxtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CmC.CheckNumberWithDecimalText(e);
        }

        private void TxtCgstPer_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CmC.CheckNumberWithDecimalText(e);
        }

        private void TxtCgstPer_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtCgstPer.Text.ToString()) && IsAllowTextChange)
            {
                ApplyProductCalculations();
            }
        }

        private void TxtPrice_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtPurchasePrice.Text.ToString()) && IsAllowTextChange)
            {
                ApplyProductCalculations();
            }
        }

        private void TxtSgstPer_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtSgstPer.Text.ToString()) && IsAllowTextChange)
            {
                ApplyProductCalculations();
            }
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
                var purchase_details = new PurchaseDetails
                {
                    PurchaseId = 0,
                    PurchaseInvoiceNo = TxtInvoiceNo.Text.ToString(),
                    SupplierCode = Convert.ToInt32(((KeyValuePair<string, string>)DropDownSupplierMobNo.SelectedItem).Key.ToString()),
                    NetAmount = Convert.ToDouble(TxtNetAmountPurchase.Text.ToString()),
                    PaymentType = Convert.ToInt32(((KeyValuePair<string, string>)DropDownPaymentType.SelectedItem).Key.ToString()),
                    PaidAmount = Convert.ToDouble(TxtPaidAmount.Text.ToString()),
                    DuesAmount = Convert.ToDouble(TxtDuesAmount.Text.ToString()),
                    DtPurchaseDetails = DataGridViewToDataTable(),
                    OperationType = 1
                };
                int id = _PurchaseRepository.InsertUpdatePurchaseDetails(purchase_details);
                if (id > 0)
                {
                    messageShow.singlemsgtext("Sccessfully purchased the product.");
                    EmptyDataGridAndHeader();
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
                return "Please add atleast one product to purchase";
            }
            if (DropDownSupplierName.SelectedIndex <= 0)
            {
                DropDownSupplierName.Focus();
                return "Please select the Supplier Name";
            }
            if (DropDownSupplierMobNo.SelectedIndex <= 0)
            {
                DropDownSupplierMobNo.Focus();
                return "Please select the Supplier Mobile Number";
            }
            if (DropDownPaymentType.SelectedIndex <= 0)
            {
                DropDownPaymentType.Focus();
                return "Please select the Payment Type.";
            }
            
            if (string.IsNullOrEmpty(TxtPaidAmount.Text.ToString()))
            {
                TxtPaidAmount.Focus();
                return "Please enter the Paid Amount";
            }
            return ValidateMessage;
        }
        private void EmptyDataGridAndHeader()
        {
            DataGridDetails.Rows.Clear();
            DataGridDetails.Refresh();
            TxtInvoiceNo.Text = "";
            TxtPaidAmount.Text = "";
            TxtDuesAmount.Text = "";
            TxtNetAmountPurchase.Text = "";
            EmptySupplierNameDropDown();
            EmptySupplierMobileNoDropDown();
            EmptyBtnaddListcontrols();

            GetSupplierNameList();
        }
        private DataTable DataGridViewToDataTable()
        {
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
            DtConvertedTable.Columns.Remove("product_code");
            DtConvertedTable.Columns.Remove("product_name");
            DtConvertedTable.Columns.Remove("item_code");
            DtConvertedTable.Columns.Remove("item_name");
            DtConvertedTable.Columns.Remove("color_name");
            DtConvertedTable.Columns.Remove("gross_amnt_purchase");
            DtConvertedTable.Columns.Remove("unit_code");
            DtConvertedTable.Columns.Remove("gross_amnt_sales");
            DtConvertedTable.Columns.Remove("edit");
            DtConvertedTable.Columns.Remove("delete");
            return DtConvertedTable;
        }
        private void TxtPaidAmount_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtPaidAmount.Text.ToString()) && !string.IsNullOrEmpty(TxtNetAmountPurchase.Text.ToString()))
            {
                NetAmountPurchase = 0;
                NetAmountPurchase = Convert.ToDouble(TxtNetAmountPurchase.Text.ToString());
                TxtDuesAmount.Text = (NetAmountPurchase - Convert.ToDouble(TxtPaidAmount.Text.ToString())).ToString();
            }
        }

        private void DropDownSupplierMobNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CmC.CheckNumberOnlyText(e);
        }

        private void TxtNoItems_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CmC.CheckNumberOnlyText(e);
        }

        private void TxtSgstPer_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CmC.CheckNumberWithDecimalText(e);
        }

        private void TxtSingleTotal_KeyPress(object sender, KeyPressEventArgs e)
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DropDownColorName_Leave(object sender, EventArgs e)
        {
            if (DropDownColorName.SelectedIndex < 0)
            {
                messageShow.singlemsgtext("Invalid Color Nmae, Must select the Color Name");
            }
        }

        private void DropDownColorName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownBrandName.SelectedIndex > 0 && IsAllowTextChange)
            {
                SelectedColorCode = Convert.ToInt32(((KeyValuePair<string, string>)DropDownBrandName.SelectedItem).Key.ToString());
            }
        }

        private void TxtSalesPrice_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtPurchasePrice.Text.ToString()) && IsAllowTextChange)
            {
                ApplyProductCalculations();
            }
        }

        private void TxtSalesPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CmC.CheckNumberWithDecimalText(e);
        }

        private void BtnRefresgList_Click(object sender, EventArgs e)
        {
            EmptyBtnaddListcontrols();
        }

        private void BtnRefreshHeader_Click(object sender, EventArgs e)
        {
            EmptyDataGridAndHeader();
        }

        private void DataGridDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                    SelectedRowIndex = Convert.ToInt32(DataGridDetails.Rows[RowIndex].Cells["srno"].Value.ToString());
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
                            GetNetAmountTotalPurchase();
                            GetNetAmountTotalSales();
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
        private void BindGridDataToheader(int RowIndex)
        {
            SetTextToDropDownItem(DataGridDetails.Rows[RowIndex].Cells["item_code"].Value.ToString(), DataGridDetails.Rows[RowIndex].Cells["item_name"].Value.ToString());
            SetTextToDropDownBrand(DataGridDetails.Rows[RowIndex].Cells["brand_code"].Value.ToString(), DataGridDetails.Rows[RowIndex].Cells["brand_name"].Value.ToString());
            SetTextToDropDownProduct(DataGridDetails.Rows[RowIndex].Cells["product_code"].Value.ToString(), DataGridDetails.Rows[RowIndex].Cells["product_name"].Value.ToString());
            SetTextToDropDownColor(DataGridDetails.Rows[RowIndex].Cells["color_code"].Value.ToString(), DataGridDetails.Rows[RowIndex].Cells["color_name"].Value.ToString());
            SetTextToDropDownUnit(DataGridDetails.Rows[RowIndex].Cells["unit_code"].Value.ToString(), DataGridDetails.Rows[RowIndex].Cells["unit"].Value.ToString());
            TxtHSNCode.Text = DataGridDetails.Rows[RowIndex].Cells["hsn_code"].Value.ToString();
            TxtArDescription.Text = DataGridDetails.Rows[RowIndex].Cells["description"].Value.ToString();
            TxtNoItems.Text = DataGridDetails.Rows[RowIndex].Cells["quantity"].Value.ToString();
            TxtPurchasePrice.Text = DataGridDetails.Rows[RowIndex].Cells["purchase_price"].Value.ToString();
            TxtSalesPrice.Text = DataGridDetails.Rows[RowIndex].Cells["sales_price"].Value.ToString();
            TxtCgstPer.Text = DataGridDetails.Rows[RowIndex].Cells["cgst_per"].Value.ToString();
            SingleCgstAmountPurchase = Convert.ToDouble(DataGridDetails.Rows[RowIndex].Cells["cgst_amnt"].Value.ToString());
            TxtSgstPer.Text = DataGridDetails.Rows[RowIndex].Cells["sgst_per"].Value.ToString();
            SingleSgstAmountPurchase = Convert.ToDouble(DataGridDetails.Rows[RowIndex].Cells["cgst_amnt"].Value.ToString());
            TxtSingleTotalPurchase.Text = DataGridDetails.Rows[RowIndex].Cells["grand_total_purchase"].Value.ToString();
            TxtSingleTotalSales.Text = DataGridDetails.Rows[RowIndex].Cells["grand_total_sales"].Value.ToString();
            /*SalesLineId = Convert.ToInt32(DataGridDetails.Rows[RowIndex].Cells["sales_line_id"].Value.ToString());
            PurchaseIdSale = Convert.ToInt32(DataGridDetails.Rows[RowIndex].Cells["purchase_id"].Value.ToString());
            PurchaseLineIdSale = Convert.ToInt32(DataGridDetails.Rows[RowIndex].Cells["purchase_line_id"].Value.ToString());
            TxtDiscountHeader.Text = DataGridDetails.Rows[RowIndex].Cells["discount_header"].Value.ToString();
            TxtTotaltaxHeader.Text = (Convert.ToDouble(DataGridDetails.Rows[RowIndex].Cells["cgst_amount"].Value) +
                                       Convert.ToDouble(DataGridDetails.Rows[RowIndex].Cells["sgst_amount"].Value)).ToString();
            CurrentAvailableItems = Convert.ToInt32(DataGridDetails.Rows[RowIndex].Cells["number_of_items_available"].Value.ToString());

            LblAvaiableItems.Show();*/
        }
        private void UpdateSerialNumberToGrid()
        {
            for (int i = 0; i < DataGridDetails.Rows.Count; i++)
            {
                DataGridDetails.Rows[i].Cells["srno"].Value = (i + 1).ToString();
            }
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
        private void SetTextToDropDownUnit(string name, string value)
        {
            DropDownUnit.DataSource = new BindingSource(CmC.ConvertStringToDictionary(name, value), null);
            DropDownUnit.DisplayMember = "Value";
            DropDownUnit.ValueMember = "Key";
            DropDownUnit.SelectedIndex = 1;
        }

        private void TxtNoItems_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtNoItems.Text.ToString()) && IsAllowTextChange)
            {
                ApplyProductCalculations();
            }
        }
        private void ApplyProductCalculations()
        {
            IsAllowTextChange = false;
            SingleTotalPricePurchase = 0;
            SingleTotalPriceSales = 0;
            SingleCgstAmountPurchase = 0;
            SingleSgstAmountPurchase = 0;
            SingleCgstAmountSales = 0;
            SingleSgstAmountSales = 0;

            SingleTotalPricePurchase = ((string.IsNullOrEmpty(TxtPurchasePrice.Text.ToString()) ? 0 :
                                       Convert.ToDouble(TxtPurchasePrice.Text.ToString())) *
                                       (string.IsNullOrEmpty(TxtNoItems.Text.ToString()) ? 0 :
                                        Convert.ToDouble(TxtNoItems.Text)));
            SingleCgstAmountPurchase = (SingleTotalPricePurchase / 100 *
                                        (string.IsNullOrEmpty(TxtCgstPer.Text.ToString()) ? 0 :
                                       Convert.ToDouble(TxtCgstPer.Text.ToString())));
            SingleSgstAmountPurchase = (SingleTotalPricePurchase / 100 *
                                       (string.IsNullOrEmpty(TxtSgstPer.Text.ToString()) ? 0 :
                                        Convert.ToDouble(TxtSgstPer.Text)));
            SingleTotalPriceSales = (string.IsNullOrEmpty(TxtSalesPrice.Text.ToString()) ? 0 :
                                       Convert.ToDouble(TxtSalesPrice.Text.ToString())) *
                                       (string.IsNullOrEmpty(TxtNoItems.Text.ToString()) ? 0 :
                                        Convert.ToDouble(TxtNoItems.Text));
            SingleCgstAmountSales = (SingleTotalPriceSales / 100 *
                                        (string.IsNullOrEmpty(TxtCgstPer.Text.ToString()) ? 0 :
                                       Convert.ToDouble(TxtCgstPer.Text.ToString())));
            SingleSgstAmountSales = (SingleTotalPriceSales / 100 *
                                       (string.IsNullOrEmpty(TxtSgstPer.Text.ToString()) ? 0 :
                                        Convert.ToDouble(TxtSgstPer.Text)));
            TxtSingleTotalPurchase.Text = (SingleTotalPricePurchase + SingleCgstAmountPurchase + SingleSgstAmountPurchase).ToString();
            TxtSingleTotalSales.Text = (SingleTotalPriceSales + SingleCgstAmountSales + SingleSgstAmountSales).ToString();
            
            IsAllowTextChange = true;
        }

    }
}
