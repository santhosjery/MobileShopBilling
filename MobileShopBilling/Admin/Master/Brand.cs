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
    public partial class Brand : Form
    {
        AdminMasterRepository _instanceRepository = new AdminMasterRepository();
        CommonModel CmC = new CommonModel();
        DataTable DtItemList = new DataTable();
        MsgBoxMessages messageShow = new MsgBoxMessages();
        Dictionary<string, string> DcItemList = new Dictionary<string, string>();
        DataGridViewLinkColumn lm = new DataGridViewLinkColumn();
        DataTable dt = new DataTable();
        BindingSource SBind = new BindingSource();
        int SelectedItemCode = 0, BrandCode = 0;
        int SelectedProductCode = 0;
        public Brand()
        {
            InitializeComponent();
        }

        private void Brand_Load(object sender, EventArgs e)
        {
            LblHeaderText.BackColor = Color.FromName(CmC.LblBackColor);
            LblHeaderText.Font = new Font(CmC.LblFontStyle, CmC.LblFontSize); //, 17pt, style=Bold
            LblHeaderText.Font = new Font(LblHeaderText.Font, FontStyle.Bold);
            LblHeaderText.ForeColor = Color.FromName(CmC.LblFontColor);

            DropDownItemName.Focus();
            this.AcceptButton = BtnInsertUpdate;
            GetItemList();
            GetBrandMasterList("");
        }
        private void GetBrandMasterList(string SearchText)
        {
            try
            {
                dt.Clear();
                DataGridItemMaster.Refresh();
                dt = CmC.GetBrandMasterList(SearchText);
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
        public void GetProductList(int ItemCode)
        {
            try
            {
                DtItemList.Clear();
                DcItemList.Clear();
                DtItemList = CmC.GetMasterNamesAndCodes("", ItemCode, 4);
                if (DtItemList.Rows.Count > 0)
                {
                    DcItemList.Add("0", CmC.FirstElementInSelect);
                    foreach (DataRow DtCol in DtItemList.Rows)
                    {
                        DcItemList.Add(DtCol[0].ToString(), DtCol[1].ToString());
                    }
                    DropDownProductName.DataSource = new BindingSource(DcItemList, null);
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

        private void DropDownItemName_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedItemCode = Convert.ToInt32(((KeyValuePair<string, string>)DropDownItemName.SelectedItem).Key.ToString());
            if (SelectedItemCode != 0)
            {
                EmptyItemListDropDown();
                GetProductList(SelectedItemCode);
            }            
        }

        private void BtnInsertUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (DropDownItemName.SelectedIndex <= 0)
                {
                    messageShow.singlemsgtext("Please select the Item Name.");
                    DropDownItemName.Focus();
                    return;
                }
                if (DropDownProductName.SelectedIndex <= 0)
                {
                    messageShow.singlemsgtext("Please select the Product Name.");
                    DropDownProductName.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(TxtBrandName.Text.ToString()))
                {
                    messageShow.singlemsgtext("Brand name should not be empty");
                    TxtBrandName.Focus();
                    return;
                }
                SelectedProductCode = Convert.ToInt32(((KeyValuePair<string, string>)DropDownProductName.SelectedItem).Key.ToString());
                var brand_master = new BrandMaster
                {
                    BrandName = TxtBrandName.Text.ToString(),
                    ProductCode = SelectedProductCode,
                    BrandCode = BrandCode,
                    OperationType = BtnInsertUpdate.Text.ToString() == "Save" ? 1 : 2
                };
                int id = _instanceRepository.InsertUpdateDeleteBrandMaster(brand_master);
                if (id >= 1)
                {
                    messageShow.singlemsgtext(brand_master.OperationType == 1 ? "New Brand added successfully" : "Brand updated successfully");
                    brand_master.BrandName = "";
                    ResetAllControls();
                }
                else if (id == -1)
                {
                    messageShow.singlemsgtext("The brand name already exists, please try another name!");
                }
                else
                {
                    messageShow.singlemsgtext("Error in Brand insert/update");
                }
                
            }
            catch (Exception _exception)
            {
                CmC.InsertException(_exception);
                messageShow.singlemsgtext(CmC.ExceptionErrorMessage);
            }
        }

        private void DataGridItemMaster_MouseClick(object sender, MouseEventArgs e)
        {
            if (DataGridItemMaster.Rows.Count > 0)
            {
                int ColumnIndex = DataGridItemMaster.CurrentCell.ColumnIndex;
                string text = DataGridItemMaster.Columns[ColumnIndex].HeaderText;
                if (text.Equals("Delete"))
                {
                    string result = messageShow.show("Delete!", "Do you want to delete the brand permanently?");
                    if (result == "1")
                    {
                        int RowIndex = DataGridItemMaster.CurrentCell.RowIndex;
                        BrandCode = Convert.ToInt32(DataGridItemMaster.Rows[RowIndex].Cells["brand_code"].Value.ToString());
                        string BrandName = DataGridItemMaster.Rows[RowIndex].Cells[1].Value.ToString();
                        DeleteItemMaster(BrandName);
                        ResetAllControls();
                    }
                    else
                    {
                        return;
                    }
                }
                if (text.Equals("Edit"))
                {
                    int RowIndex = DataGridItemMaster.CurrentCell.RowIndex;
                    BrandCode = Convert.ToInt32(DataGridItemMaster.Rows[RowIndex].Cells["brand_code"].Value.ToString());
                    SetTextToDropDownItem(DataGridItemMaster.Rows[RowIndex].Cells["item_code"].Value.ToString(), DataGridItemMaster.Rows[RowIndex].Cells["item_name"].Value.ToString());
                    SetTextToDropDownProduct(DataGridItemMaster.Rows[RowIndex].Cells["product_code"].Value.ToString(), DataGridItemMaster.Rows[RowIndex].Cells["product_name"].Value.ToString());
                    TxtBrandName.Text = DataGridItemMaster.Rows[RowIndex].Cells["brand_name"].Value.ToString();
                    BtnInsertUpdate.Text = "Update";
                }
            }
        }
        private void SetTextToDropDownProduct(string name, string value)
        {
            DropDownProductName.DataSource = new BindingSource(CmC.ConvertStringToDictionary(name, value), null);
            DropDownProductName.DisplayMember = "Value";
            DropDownProductName.ValueMember = "Key";
            DropDownProductName.SelectedIndex = 1;
        }
        private void SetTextToDropDownItem(string name, string value)
        {
            DropDownItemName.DataSource = new BindingSource(CmC.ConvertStringToDictionary(name, value), null);
            DropDownItemName.DisplayMember = "Value";
            DropDownItemName.ValueMember = "Key";
            DropDownItemName.SelectedIndex = 1;
        }
        public void DeleteItemMaster(string BrandName)
        {
            try
            {
                var brand_master = new BrandMaster
                {
                    BrandName = BrandName,
                    BrandCode = BrandCode,
                    ProductCode = 0,
                    OperationType = 3
                };
                int DeleteStatus = _instanceRepository.InsertUpdateDeleteBrandMaster(brand_master);
                if (DeleteStatus >= 1)
                    messageShow.singlemsgtext("Deleted Successfully");
                else if (DeleteStatus == -1)
                    messageShow.singlemsgtext("Can not delete the brand, because the      brand has transactions!");
                else
                    messageShow.singlemsgtext("Unable to Delete");
                GetBrandMasterList("");
            }
            catch (Exception _exception)
            {
                CmC.InsertException(_exception);
                messageShow.singlemsgtext(CmC.ExceptionErrorMessage);
            }
        }

        private void TxtSearchItem_OnTextChange(object sender, EventArgs e)
        {
            GetBrandMasterList(TxtSearchItem._TextBox.Text.ToString());
        }
        private void ResetAllControls()
        {
            BtnInsertUpdate.Text = "Save";
            GetBrandMasterList("");
            TxtBrandName.Text = "";
            TxtSearchItem._TextBox.Text = "";
            EmptyItemListDropDown();
            GetItemList();
            DropDownItemName.Focus();
        }
        private void EmptyItemListDropDown()
        {
            DropDownProductName.DataSource = null;
            DropDownProductName.Items.Clear();
            DropDownProductName.Items.Add(DBNull.Value);
            DropDownProductName.Items.Clear();
        }

        private void BtnRefresgList_Click(object sender, EventArgs e)
        {
            GetBrandMasterList("");
            ResetAllControls();
        }
    }
}