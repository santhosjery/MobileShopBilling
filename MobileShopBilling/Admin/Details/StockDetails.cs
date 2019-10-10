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

namespace MobileShopBilling.Admin.Details
{
    public partial class StockDetails : Form
    {
        SalesRepository _SalesRepository = new SalesRepository();
        ExceptionRepository _exceptionRepository = new ExceptionRepository();
        CommonModel CmC = new CommonModel();
        DataTable DtStockList = new DataTable();
        DataTable DtBrandList = new DataTable();
        MsgBoxMessages messageShow = new MsgBoxMessages();
        Dictionary<string, string> DcItemList = new Dictionary<string, string>();
        DataGridViewLinkColumn lm = new DataGridViewLinkColumn();
        BindingSource SBind = new BindingSource();
        DateTime? FromDate = null, ToDate = null;
        string BrandName = null;
        int BrandCode = 0;
        public StockDetails()
        {
            InitializeComponent();
        }

        private void StockDetails_Load(object sender, EventArgs e)
        {
            ResetControlles();
        }
        private void ResetControlles()
        {
            LblHeaderText.BackColor = Color.FromName(CmC.LblBackColor);
            LblHeaderText.Font = new Font(CmC.LblFontStyle, CmC.LblFontSize); //, 17pt, style=Bold
            LblHeaderText.Font = new Font(LblHeaderText.Font, FontStyle.Bold);
            LblHeaderText.ForeColor = Color.FromName(CmC.LblFontColor);

            DatePickerFrom.Value = DateTime.Now;
            DatePickerTo.Value = DateTime.Now;
            datagriddesign();
            GetStockList(0, "", 1);
            GetBrandList(0, "", 2);
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
        public void GetBrandList(int StockId, string BrandName, int OperationType)
        {
            try
            {
                DtBrandList.Clear();
                DcItemList.Clear();
                DropDownBrandName.Refresh();
                DtBrandList = CmC.GetStockDetails(StockId, BrandName, OperationType, FromDate, ToDate);
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
        private void GetStockList(int StockId, string BrandName, int OperationType)
        {
            try
            {
                if (DatePickerFrom.Text != " ")
                {
                    FromDate = Convert.ToDateTime(DatePickerFrom.Value.ToString("yyyy-MM-dd"));
                }
                if (DatePickerTo.Text != " ")
                {
                    ToDate = Convert.ToDateTime(DatePickerTo.Value.ToString("yyyy-MM-dd"));
                }
                DtStockList.Clear();
                DataGridDetails.Refresh();
                DtStockList = CmC.GetStockDetails(StockId, BrandName, OperationType, FromDate, ToDate);
                SBind.DataSource = DtStockList;
                datagriddesign();
                DataGridDetails.DataSource = SBind;
            }
            catch (Exception _exception)
            {
                CmC.InsertException(_exception);
                messageShow.singlemsgtext(CmC.ExceptionErrorMessage);
            }
        }
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (DatePickerFrom.Text != " ")
            {
                FromDate = Convert.ToDateTime(DatePickerFrom.Value.ToString("yyyy-MM-dd"));
            }
            if (DatePickerTo.Text != " ")
            {
                ToDate = Convert.ToDateTime(DatePickerTo.Value.ToString("yyyy-MM-dd"));
            }
            GetStockList(0, "", 1);
        }

        private void TxtSearchItem_OnTextChange(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtSearchItem.text.ToString()))
            {
                BrandName = TxtSearchItem.text.ToString();
                GetStockList(0, BrandName, 1);
            }
            else
            {
                BrandName = null;
                GetStockList(0, "", 1);
            }
        }

        private void DropDownBrandName_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtSearchItem.text = "";
            BrandCode = Convert.ToInt32(((KeyValuePair<string, string>)DropDownBrandName.SelectedItem).Key.ToString());
            GetStockList(BrandCode, "", 1);
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

        private void BtnRefresgList_Click(object sender, EventArgs e)
        {
            ResetControlles();
        }
    }
}
