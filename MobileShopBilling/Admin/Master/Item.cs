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
using BusinessLayer.Repository.Login;
using DomainModel.Mater;
using MobileShopBilling.Admin.CommonClasses;

namespace MobileShopBilling.Admin.Master
{
    public partial class Item : Form
    {
        AdminMasterRepository _instanceRepository = new AdminMasterRepository();
        MsgBoxMessages messageShow = new MsgBoxMessages();
        DataGridViewLinkColumn lm = new DataGridViewLinkColumn();
        DataTable dt = new DataTable();
        BindingSource SBind = new BindingSource();
        CommonModel CmC = new CommonModel();
        int ItemCode = 0;
        public Item()
        {
            InitializeComponent();
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

        private void Item_Load(object sender, EventArgs e)
        {
            LblHeaderText.BackColor = Color.FromName(CmC.LblBackColor);
            LblHeaderText.Font = new Font(CmC.LblFontStyle, CmC.LblFontSize); //, 17pt, style=Bold
            LblHeaderText.Font = new Font(LblHeaderText.Font, FontStyle.Bold);
            LblHeaderText.ForeColor = Color.FromName(CmC.LblFontColor);

            TxtItemName.Focus();
            DataGridItemMaster.AutoGenerateColumns = false;
            this.AcceptButton = BtnInsertUpdate;
            GetItemMasterList(0, "");
        }
        private void ResetControlles()
        {
            BtnInsertUpdate.Text = "Save";
            TxtItemName.Text = "";
            TxtSearchItem._TextBox.Text = "";
            GetItemMasterList(0,"");
        }
        private void BtnInsertUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(TxtItemName.Text.ToString()))
                {
                    messageShow.singlemsgtext("Item name should not be empty");
                    TxtItemName.Focus();
                    return;
                }
                var item_master = new ItemMaster
                {
                    ItemCode = ItemCode,
                    ItemName = TxtItemName.Text.ToString(),
                    OperationType = BtnInsertUpdate.Text.ToString() == "Save" ? 1 : 2
                };
                int id = _instanceRepository.InsertUpdateDeleteItemMaster(item_master);
                if (id >= 1)
                {
                    messageShow.singlemsgtext(item_master.OperationType == 1 ? "New Item added successfully" : "Item updated successfully");
                    item_master.ItemName = "";
                    ResetControlles();
                }
                else if (id == -1)
                {
                    messageShow.singlemsgtext("The item name already exists, please try another name!");
                }
                else
                {
                    messageShow.singlemsgtext("Error in item insert/update");
                }
            }
            catch (Exception _exception)
            {
                CmC.InsertException(_exception);
                messageShow.singlemsgtext(CmC.ExceptionErrorMessage);
            }
        }
        private void GetItemMasterList(int ItemCode, string SearchText)
        {
            try
            {
                dt.Clear();
                DataGridItemMaster.Refresh();
                dt = CmC.GetItemMasterList(ItemCode, SearchText);
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

        private void DataGridItemMaster_MouseClick(object sender, MouseEventArgs e)
        {
            if (DataGridItemMaster.Rows.Count > 0)
            {
                int ColumnIndex = DataGridItemMaster.CurrentCell.ColumnIndex;
                string text = DataGridItemMaster.Columns[ColumnIndex].HeaderText;
                if (text.Equals("Delete"))
                {
                    string result = messageShow.show("Delete!", "Do you want to delete the item    permanently?");
                    if (result == "1")
                    {
                        int RowIndex = DataGridItemMaster.CurrentCell.RowIndex;
                        ItemCode = Convert.ToInt32(DataGridItemMaster.Rows[RowIndex].Cells["item_code"].Value.ToString());
                        string ItemName = DataGridItemMaster.Rows[RowIndex].Cells[1].Value.ToString();
                        DeleteItemMaster(ItemName);
                    }
                    else
                    {
                        return;
                    }
                }
                if (text.Equals("Edit"))
                {
                        int RowIndex = DataGridItemMaster.CurrentCell.RowIndex;
                        ItemCode = Convert.ToInt32(DataGridItemMaster.Rows[RowIndex].Cells["item_code"].Value.ToString());
                        TxtItemName.Text = DataGridItemMaster.Rows[RowIndex].Cells["item_name"].Value.ToString();
                        BtnInsertUpdate.Text = "Update";
                }
            }
        }
        public void UpdateItemMaster()
        {
            try
            {
                var item_master = new ItemMaster
                {
                    ItemCode = ItemCode,
                    ItemName = TxtItemName.Text.ToString(),
                    OperationType = 2
                };
                int UpdateStatus = _instanceRepository.InsertUpdateDeleteItemMaster(item_master);
                if (UpdateStatus >= 1)
                    messageShow.singlemsgtext("Item Updated Successfully");
                else
                    messageShow.singlemsgtext("Unable to Update");
                ResetControlles();
                GetItemMasterList(0, "");
            }
            catch (Exception _exception)
            {
                CmC.InsertException(_exception);
                messageShow.singlemsgtext(CmC.ExceptionErrorMessage);
            }
        }
        public void DeleteItemMaster(string ItemName)
        {
            try
            {
                var item_master = new ItemMaster
                {
                    ItemCode = ItemCode,
                    ItemName = ItemName,
                    OperationType = 3
                };
                int DeleteStatus = _instanceRepository.InsertUpdateDeleteItemMaster(item_master);
                if (DeleteStatus >= 1)
                    messageShow.singlemsgtext("Deleted Successfully");
                else if(DeleteStatus == -1)
                    messageShow.singlemsgtext("Can not delete the item, because the item has transactions!");
                else
                    messageShow.singlemsgtext("Unable to Delete");
                ResetControlles();
                GetItemMasterList(0, "");
            }
            catch (Exception _exception)
            {
                CmC.InsertException(_exception);
                messageShow.singlemsgtext(CmC.ExceptionErrorMessage);
            }
        }

        private void TxtSearchItem_OnTextChange(object sender, EventArgs e)
        {
             GetItemMasterList(0, TxtSearchItem._TextBox.Text.ToString());
        }

        private void BtnRefresgList_Click(object sender, EventArgs e)
        {
            ResetControlles();
        }
    }
}