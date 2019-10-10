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

namespace MobileShopBilling.Admin.ReportForm
{
    public partial class SalesBillingReport : Form
    {
        private long SalesId = 0;
        private DataTable DtSalesDetails= new DataTable("SalesBillingReport");
        SalesRepository _SalesRepository = new SalesRepository();
        ExceptionRepository _exceptionRepository = new ExceptionRepository();
        CommonModel CmC = new CommonModel();
        MsgBoxMessages messageShow = new MsgBoxMessages();
        public SalesBillingReport()
        {
            InitializeComponent();
        }
        public SalesBillingReport(long SalesId)
        {
            this.SalesId = SalesId;
            InitializeComponent();
        }
        private void SalesBillingReport_Load(object sender, EventArgs e)
        {
            try
            {
                var SalesDetails = new SalesDetails
                {
                    SalesId = SalesId
                };
                DtSalesDetails = _SalesRepository.GetLastSalesDetailsBySalesId(SalesDetails);
                SalesBillingDataSet SBDS = new SalesBillingDataSet();
                DtSalesDetails.TableName = "SalesBillingReport";
                SBDS.Merge(DtSalesDetails);
                SalesBillingCrystalRpt SBCR = new SalesBillingCrystalRpt();
                SBCR.SetDataSource(SBDS.Tables["SalesBillingReport"]);
                CrystalReportViewerSales.ReportSource = SBCR;
                CrystalReportViewerSales.Refresh();
                //MessageBox.Show(SBDS.Tables.Count.ToString());
            }
            catch (Exception _exception)
            {
                CmC.InsertException(_exception);
                messageShow.singlemsgtext(CmC.ExceptionErrorMessage);
            }
            
        }
    }
}
