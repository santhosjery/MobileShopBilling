using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DomainModel.Transactions;
using MobileShopBilling.Admin.CommonClasses;

namespace MobileShopBilling.Admin.Transactions
{
    public partial class DataGridPopUp : Form
    {
        CommonModel CmC = new CommonModel();
        Sales SaS = new Sales();
        MsgBoxMessages messageShow = new MsgBoxMessages(); 
        public int PurchaseId = 0, PurchaseLineId = 0;
        public DataGridPopUp()
        {
            InitializeComponent();
        }

        private void DataGridDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void DataGridPopUp_Load(object sender, EventArgs e)
        {
            LblHeaderText.BackColor = Color.FromName(CmC.LblBackColor);
            LblHeaderText.Font = new Font(CmC.LblFontStyle, CmC.LblFontSize); //, 17pt, style=Bold
            LblHeaderText.Font = new Font(LblHeaderText.Font, FontStyle.Bold);
            LblHeaderText.ForeColor = Color.FromName(CmC.LblFontColor);
        }
        public void DisplayDataGridPopUp(DataTable DtItemList)
        {
            DataGridDetails.Rows.Clear();
            DataGridDetails.Refresh();
            datagriddesign();
            DataGridDetails.DataSource = DtItemList;
            this.ShowDialog();
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void DataGridDetails_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (DataGridDetails.Rows.Count > 0)
                {
                    int RowIndex = DataGridDetails.CurrentCell.RowIndex;
                    PurchaseId = Convert.ToInt32(DataGridDetails.Rows[RowIndex].Cells[0].Value.ToString());
                    PurchaseLineId = Convert.ToInt32(DataGridDetails.Rows[RowIndex].Cells[1].Value.ToString());
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception _exception)
            {
                CmC.InsertException(_exception);
                messageShow.singlemsgtext(CmC.ExceptionErrorMessage);
            }
        }
    }
}