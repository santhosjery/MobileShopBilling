using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using BusinessLayer.Repository.ExceptionRepositoryHandler;
using BusinessLayer.Repository.PurchaseAndSales;
using MobileShopBilling.Admin.CommonClasses;

namespace MobileShopBilling.Admin.Details
{
    public partial class AvailableStockReport : Form
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
        string BrandName = null;
        int BrandCode = 0, ColorCode = 0;
        public AvailableStockReport()
        {
            InitializeComponent();
        }

        private void AvailableStockReport_Load(object sender, EventArgs e)
        {
            ResetControlles();
        }
        private void ResetControlles()
        {
            LblHeaderText.BackColor = Color.FromName(CmC.LblBackColor);
            LblHeaderText.Font = new Font(CmC.LblFontStyle, CmC.LblFontSize); //, 17pt, style=Bold
            LblHeaderText.Font = new Font(LblHeaderText.Font, FontStyle.Bold);
            LblHeaderText.ForeColor = Color.FromName(CmC.LblFontColor);

            datagriddesign();
            BrandCode = 0;
            ColorCode = 0;
            GetStockList(0, 0, "", 1);
            GetBrandList(0, 0, "", 2);
            GetColorList(0, 0, "", 3);
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
            this.DataGridDetails.DefaultCellStyle.Font = new Font("Cambria", 11);
        }
        public void GetBrandList(int BrandCode, int ColorCode, string BrandName, int OperationType)
        {
            try
            {
                DtBrandList.Clear();
                DcItemList.Clear();
                DropDownBrandName.Refresh();
                DtBrandList = CmC.GetStockReport(BrandCode, ColorCode, BrandName, OperationType);
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
        public void GetColorList(int BrandCode, int ColorCode, string BrandName, int OperationType)
        {
            try
            {
                DtBrandList.Clear();
                DcItemList.Clear();
                DropDownColorName.Refresh();
                DtBrandList = CmC.GetStockReport(BrandCode, ColorCode, BrandName, OperationType);
                if (DtBrandList.Rows.Count > 0)
                {
                    DcItemList.Add("0", CmC.FirstElementInSelect);
                    foreach (DataRow DtCol in DtBrandList.Rows)
                    {
                        DcItemList.Add(DtCol[0].ToString(), DtCol[1].ToString());
                    }
                    DropDownColorName.DataSource = new BindingSource(DcItemList, null);
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
        private void GetStockList(int BrandCode, int ColorCode, string BrandName, int OperationType)
        {
            try
            {
                DtStockList.Clear();
                DataGridDetails.Refresh();
                DtStockList = CmC.GetStockReport(BrandCode, ColorCode, BrandName, OperationType);
                SBind.DataSource = DtStockList;
                datagriddesign();
                DataGridDetails.DataSource = SBind;
                DataGridDetails.ClearSelection();
            }
            catch (Exception _exception)
            {
                CmC.InsertException(_exception);
                messageShow.singlemsgtext(CmC.ExceptionErrorMessage);
            }
        }

        private void DataGridDetails_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            ChangeColorForCell();
        }
        private void ChangeColorForCell()
        {
            if (DataGridDetails.Rows.Count > 0)
            {
                for (int i = 0; i < DataGridDetails.Rows.Count; i++)
                {
                    Color AvailableQuantity = Color.FromName(DataGridDetails.Rows[i].Cells["color_to_show"].Value.ToString());

                    DataGridDetails.Rows[i].Cells[0].Style.BackColor = AvailableQuantity;
                }
                DataGridDetails.FirstDisplayedCell.Selected = false;
            }
        }

        private void TxtSearchItem_OnTextChange(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtSearchItem.text.ToString()))
            {
                BrandName = TxtSearchItem.text.ToString();
                GetStockList(BrandCode, ColorCode, BrandName, 1);
            }
            else
            {
                BrandName = null;
                GetStockList(BrandCode, ColorCode, "", 1);
            }
        }
        private void DropDownBrandName_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtSearchItem.text = "";
            BrandCode = Convert.ToInt32(((KeyValuePair<string, string>)DropDownBrandName.SelectedItem).Key.ToString());
            GetStockList(BrandCode, ColorCode, "", 1);
        }

        private void DropDownColorName_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtSearchItem.text = "";
            ColorCode = Convert.ToInt32(((KeyValuePair<string, string>)DropDownColorName.SelectedItem).Key.ToString());
            GetStockList(BrandCode, ColorCode, "", 1);
        }

        private void BtnRefresgList_Click(object sender, EventArgs e)
        {
            ResetControlles();
        }
    }
}
