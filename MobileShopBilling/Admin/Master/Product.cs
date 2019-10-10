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
    public partial class Product : Form
    {
        AdminMasterRepository _instanceRepository = new AdminMasterRepository();
        CommonModel CmC = new CommonModel();
        DataTable DtItemList = new DataTable();
        MsgBoxMessages messageShow = new MsgBoxMessages();
        Dictionary<string, string> DcItemList = new Dictionary<string, string>();
        DataGridViewLinkColumn lm = new DataGridViewLinkColumn();
        DataTable dt = new DataTable();
        BindingSource SBind = new BindingSource();
        int ProductCode = 0;
        public Product()
        {
            InitializeComponent();
        }

        private void Product_Load(object sender, EventArgs e)
        {
            LblHeaderText.BackColor = Color.FromName(CmC.LblBackColor);
            LblHeaderText.Font = new Font(CmC.LblFontStyle, CmC.LblFontSize); //, 17pt, style=Bold
            LblHeaderText.Font = new Font(LblHeaderText.Font, FontStyle.Bold);
            LblHeaderText.ForeColor = Color.FromName(CmC.LblFontColor);

            DropDownItemName.Focus();
            this.AcceptButton = BtnInsertUpdate;
            GetItemListDropDown();
            GetProductMasterList("");
        }
        private void GetItemListDropDown()
        {
            try
            {
                DropDownItemName.Refresh();
                DcItemList.Clear();
                DtItemList = CmC.GetMasterNamesAndCodes("", 0, 1);
                if (DtItemList.Rows.Count > 0)
                {
                    DcItemList.Add("0", CmC.FirstElementInSelect);
                    foreach (DataRow DtCol in DtItemList.Rows)
                    {
                        DcItemList.Add(DtCol[0].ToString(), DtCol[1].ToString());
                    }
                    DropDownItemName.DataSource = new BindingSource(DcItemList, null);
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
        private void ResetControlles()
        {
            BtnInsertUpdate.Text = "Save";
            GetProductMasterList("");
            TxtProductName.Text = "";
            TxtSearchItem._TextBox.Text = "";
            GetItemListDropDown();
            DropDownItemName.Focus();
        }
        private void BtnInsertUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (DropDownItemName.SelectedIndex <= 0)
                {
                    messageShow.singlemsgtext("Please select the Item Name");
                    DropDownItemName.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(TxtProductName.Text.ToString()))
                {
                    messageShow.singlemsgtext("Product name should not be empty");
                    TxtProductName.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(TxtMinimumStockNotify.Text.ToString()))
                {
                    messageShow.singlemsgtext("Minimum stock notification should not be empty");
                    TxtMinimumStockNotify.Focus();
                    return;
                }
                else
                {
                    if (Convert.ToInt32(TxtMinimumStockNotify.Text.ToString()) < 0)
                    {
                        messageShow.singlemsgtext("Minimum stock notification should be greater than zero");
                        TxtMinimumStockNotify.Focus();
                        return;
                    }
                }
                var product_master = new ProductMaster
                {
                    ProductName = TxtProductName.Text.ToString(),
                    MinimumStockNotification = Convert.ToInt32(TxtMinimumStockNotify.Text.ToString()),
                    ItemCode = Convert.ToInt32(((KeyValuePair<string, string>)DropDownItemName.SelectedItem).Key.ToString()),
                    ProductCode = ProductCode,
                    OperationType = BtnInsertUpdate.Text.ToString() == "Save" ? 1 : 2
                };
                int id = _instanceRepository.InsertUpdateDeleteProductMaster(product_master);
                if (id >= 1)
                {
                    messageShow.singlemsgtext(product_master.OperationType == 1 ? "New Product added successfully" : "Product updated successfully");
                    product_master.ProductName = "";
                    ResetControlles();
                }
                else if (id == -1)
                {
                    messageShow.singlemsgtext("The product name already exists, please try another name!");
                }
                else
                {
                    messageShow.singlemsgtext("Error in Product insert/update");
                }
            }
            catch (Exception _exception)
            {
                CmC.InsertException(_exception);
                messageShow.singlemsgtext(CmC.ExceptionErrorMessage);
            }
        }
        private void GetProductMasterList(string SearchText)
        {
            try
            {
                dt.Clear();
                DataGridItemMaster.Refresh();
                dt = CmC.GetProductMasterList(SearchText);
                SBind.DataSource = dt;
                datagriddesign();
                DataGridItemMaster.DataSource = SBind;
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
            DataGridItemMaster.RowTemplate.Height = 37;
            DataGridItemMaster.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            DataGridItemMaster.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            DataGridItemMaster.DefaultCellStyle.SelectionBackColor = Color.FromArgb(36, 129, 77);
            DataGridItemMaster.DefaultCellStyle.SelectionForeColor = Color.White;
            DataGridItemMaster.DefaultCellStyle.ForeColor = Color.Black;
            this.DataGridItemMaster.DefaultCellStyle.Font = new Font("Cambria", 14);
        }

        private void TxtSearchItem_OnTextChange(object sender, EventArgs e)
        {
            GetProductMasterList(TxtSearchItem._TextBox.Text.ToString());
        }

        private void DataGridItemMaster_MouseClick(object sender, MouseEventArgs e)
        {
            if (DataGridItemMaster.Rows.Count > 0)
            {
                int ColumnIndex = DataGridItemMaster.CurrentCell.ColumnIndex;
                string text = DataGridItemMaster.Columns[ColumnIndex].HeaderText;
                if (text.Equals("Delete"))
                {
                    string result = messageShow.show("Delete!", "Do you want to delete the product permanently?");
                    if (result == "1")
                    {
                        int RowIndex = DataGridItemMaster.CurrentCell.RowIndex;
                        ProductCode = Convert.ToInt32(DataGridItemMaster.Rows[RowIndex].Cells["product_code"].Value.ToString());
                        string ItemName = DataGridItemMaster.Rows[RowIndex].Cells[1].Value.ToString();
                        DeleteItemMaster(ItemName);
                        ResetControlles();
                    }
                    else
                    {
                        return;
                    }
                }
                if (text.Equals("Edit"))
                {
                        int RowIndex = DataGridItemMaster.CurrentCell.RowIndex;
                        ProductCode = Convert.ToInt32(DataGridItemMaster.Rows[RowIndex].Cells["product_code"].Value.ToString());
                        SetTextToDropDownItem(DataGridItemMaster.Rows[RowIndex].Cells["item_code"].Value.ToString(), DataGridItemMaster.Rows[RowIndex].Cells["item_name"].Value.ToString());
                        TxtProductName.Text = DataGridItemMaster.Rows[RowIndex].Cells["product_name"].Value.ToString();
                        TxtMinimumStockNotify.Text = DataGridItemMaster.Rows[RowIndex].Cells["min_stock_notify"].Value.ToString();
                        BtnInsertUpdate.Text = "Update";
                }
            }
        }
        private void SetTextToDropDownItem(string name, string value)
        {
            DropDownItemName.DataSource = new BindingSource(CmC.ConvertStringToDictionary(name, value), null);
            DropDownItemName.DisplayMember = "Value";
            DropDownItemName.ValueMember = "Key";
            DropDownItemName.SelectedIndex = 1;
        }
        public void DeleteItemMaster(string ItemName)
        {
            try
            {
                var product_master = new ProductMaster
                {
                    MinimumStockNotification = 0,
                    ProductName = ItemName,
                    ProductCode = ProductCode,
                    ItemCode = 0,
                    OperationType = 3
                };
                int DeleteStatus = _instanceRepository.InsertUpdateDeleteProductMaster(product_master);
                if (DeleteStatus >= 1)
                    messageShow.singlemsgtext("Deleted Successfully");
                else if (DeleteStatus == -1)
                    messageShow.singlemsgtext("Can not delete the product, because the product has transactions!");
                else
                    messageShow.singlemsgtext("Unable to Delete");
                GetProductMasterList("");
            }
            catch (Exception _exception)
            {
                CmC.InsertException(_exception);
                messageShow.singlemsgtext(CmC.ExceptionErrorMessage);
            }
        }

        private void BtnRefresgList_Click(object sender, EventArgs e)
        {
            ResetControlles();
        }

        private void bunifuCustomTextbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CmC.CheckNumberOnlyText(e);
        }

        private void DropDownItemName_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtMinimumStockNotify.Text = "2";
        }
    }
}
