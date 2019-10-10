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
    public partial class ColorDetails : Form
    {
        AdminMasterRepository _instanceRepository = new AdminMasterRepository();
        MsgBoxMessages messageShow = new MsgBoxMessages();
        DataGridViewLinkColumn lm = new DataGridViewLinkColumn();
        DataTable dt = new DataTable();
        BindingSource SBind = new BindingSource();
        CommonModel CmC = new CommonModel();
        int ColorCode = 0;
        public ColorDetails()
        {
            InitializeComponent();
        }

        private void ColorDetails_Load(object sender, EventArgs e)
        {
            LblHeaderText.BackColor = Color.FromName(CmC.LblBackColor);
            LblHeaderText.Font = new Font(CmC.LblFontStyle, CmC.LblFontSize); //, 17pt, style=Bold
            LblHeaderText.Font = new Font(LblHeaderText.Font, FontStyle.Bold);
            LblHeaderText.ForeColor = Color.FromName(CmC.LblFontColor);

            TxtColorName.Focus();
            DataGridColorMaster.AutoGenerateColumns = false;
            this.AcceptButton = BtnInsertUpdate;
            GetColorMasterList("");
        }
        private void GetColorMasterList(string SearchText)
        {
            try
            {
                var ColorMaster = new ColorMaster
                {
                    ColorName = SearchText,
                    OperationType = 1
                };
                dt.Clear();
                DataGridColorMaster.Refresh();
                dt = CmC.GetColorMasterList(SearchText);
                SBind.DataSource = dt;
                datagriddesign();
                DataGridColorMaster.DataSource = SBind;
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
            DataGridColorMaster.RowTemplate.Height = 37;
            DataGridColorMaster.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            DataGridColorMaster.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            DataGridColorMaster.DefaultCellStyle.SelectionBackColor = Color.FromArgb(36, 129, 77);
            DataGridColorMaster.DefaultCellStyle.SelectionForeColor = Color.White;
            DataGridColorMaster.DefaultCellStyle.ForeColor = Color.Black;
            this.DataGridColorMaster.DefaultCellStyle.Font = new Font("Cambria", 14);
        }

        private void BtnInsertUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(TxtColorName.Text.ToString()))
                {
                    messageShow.singlemsgtext("Color Name should not be empty.");
                    TxtColorName.Focus();
                    return;
                }
                var ColorMaster = new ColorMaster
                {
                    ColorName = TxtColorName.Text.ToString(),
                    ColorCode = ColorCode,
                    OperationType = BtnInsertUpdate.Text.ToString() == "Save" ? 1 : 2
                };
                int id = _instanceRepository.InsertUpdateDeleteColorMaster(ColorMaster);
                if (id >= 1)
                {
                    messageShow.singlemsgtext(ColorMaster.OperationType == 1 ? "New Color added successfully" : "Color updated successfully");
                    ColorMaster.ColorName = "";
                    ResetControlles();
                }
                else if (id == -1)
                {
                    messageShow.singlemsgtext("The color name already exists, please try another name!");
                }
                else
                {
                    messageShow.singlemsgtext("Error in color insert/update");
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
            GetColorMasterList("");
            TxtColorName.Text = "";
            TxtSearchItem._TextBox.Text = "";
        }

        private void DataGridColorMaster_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridColorMaster.Rows.Count > 0)
            {
                int ColumnIndex = DataGridColorMaster.CurrentCell.ColumnIndex;
                string text = DataGridColorMaster.Columns[ColumnIndex].HeaderText;
                if (text.Equals("Delete"))
                {
                    string result = messageShow.show("Delete!", "Do you want to delete the color   permanently?");
                    if (result == "1")
                    {
                        int RowIndex = DataGridColorMaster.CurrentCell.RowIndex;
                        ColorCode = Convert.ToInt32(DataGridColorMaster.Rows[RowIndex].Cells["color_code"].Value.ToString());
                        string ItemName = DataGridColorMaster.Rows[RowIndex].Cells[1].Value.ToString();
                        DeleteItemMaster(ItemName);
                    }
                    else
                    {
                        return;
                    }
                }
                if (text.Equals("Edit"))
                {
                    int RowIndex = DataGridColorMaster.CurrentCell.RowIndex;
                    ColorCode = Convert.ToInt32(DataGridColorMaster.Rows[RowIndex].Cells["color_code"].Value.ToString());
                    TxtColorName.Text = DataGridColorMaster.Rows[RowIndex].Cells["color_name"].Value.ToString();
                    BtnInsertUpdate.Text = "Update";
                }
            }
        }
        public void DeleteItemMaster(string ColorName)
        {
            try
            {
                var ColorMaster = new ColorMaster
                {
                    ColorCode = ColorCode,
                    ColorName = ColorName,
                    OperationType = 3
                };
                int DeleteStatus = _instanceRepository.InsertUpdateDeleteColorMaster(ColorMaster);
                if (DeleteStatus >= 1)
                    messageShow.singlemsgtext("Deleted Successfully");
                else if (DeleteStatus == -1)
                    messageShow.singlemsgtext("Can not delete the color, because the color has transactions!");
                else
                    messageShow.singlemsgtext("Unable to Delete");
                ResetControlles();
                GetColorMasterList("");
            }
            catch (Exception _exception)
            {
                CmC.InsertException(_exception);
                messageShow.singlemsgtext(CmC.ExceptionErrorMessage);
            }
        }

        private void TxtSearchItem_OnTextChange(object sender, EventArgs e)
        {
            GetColorMasterList(TxtSearchItem._TextBox.Text.ToString());
        }

        private void BtnRefresgList_Click(object sender, EventArgs e)
        {
            ResetControlles();
        }

    }
}
