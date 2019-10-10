using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.Transactions;

namespace BusinessLayer.Repository.PurchaseAndSales
{
    public class SalesIRepository : BasicConext
    {
        /// <summary>
        /// Add parameters while adding the purchase details  
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public IDbDataParameter[] AddParamsGetBrandMaster(SalesDetails SalesDetails)
        {
            parameters.Clear();
            parameters.Add(dbManager.CreateParameter("@BrandCode", 2, SalesDetails.BrandCode, DbType.Int32));
            parameters.Add(dbManager.CreateParameter("@ColorCode", 2, SalesDetails.ColorCode, DbType.Int32));
            parameters.Add(dbManager.CreateParameter("@PurchaseId", 2, SalesDetails.PurchaseId, DbType.Int32));
            parameters.Add(dbManager.CreateParameter("@PurchaseLineId", 2, SalesDetails.PurchaseLineId, DbType.Int32));
            parameters.Add(dbManager.CreateParameter("@OperationType", 2, SalesDetails.OperationType, DbType.Int16));
            return parameters.ToArray();
        }
        /// <summary>
        /// Add parameters while adding the sales details  
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public IDbDataParameter[] AddParmsSalesDetails(SalesDetails SalesDetails)
        {
            parameters.Clear();
            parameters.Add(dbManager.CreateParameter("@SalesId_Sales", 300, SalesDetails.SalesId, DbType.Int64));
            parameters.Add(dbManager.CreateParameter("@CustomerName", 300, SalesDetails.CustomerName, DbType.String));
            parameters.Add(dbManager.CreateParameter("@CustomerMobileNo", SalesDetails.CustomerMobileNo, DbType.Double));
            parameters.Add(dbManager.CreateParameter("@GrossAmount", SalesDetails.GrossAmount, DbType.Double));
            parameters.Add(dbManager.CreateParameter("@DiscountPer", SalesDetails.DiscountPer, DbType.Double));
            parameters.Add(dbManager.CreateParameter("@DiscountAmount", SalesDetails.DiscountAmount, DbType.Double));
            parameters.Add(dbManager.CreateParameter("@NetAmount", SalesDetails.NetAmount, DbType.Double));
            parameters.Add(dbManager.CreateParameter("@PaymentType", SalesDetails.PaymentType, DbType.Int16));
            parameters.Add(dbManager.CreateParameter("@PaidAmount", SalesDetails.PaidAmount, DbType.Double));
            parameters.Add(dbManager.CreateParameter("@DuesAmount", SalesDetails.DuesAmount, DbType.Double));
            parameters.Add(dbManager.CreateParameter("@DtPurchaseSalesType", "dbo.DtSalesDetailsType", SalesDetails.DtSalesDetails, SqlDbType.Structured));
            parameters.Add(dbManager.CreateParameter("@OperationType", 2, SalesDetails.OperationType, DbType.Int16));
            return parameters.ToArray();
        }
        /// <summary>
        /// Add parameters while adding the sales details  
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public IDbDataParameter[] AddParmsGetLastSalesDetailsBySalesId(SalesDetails SalesDetails)
        {
            parameters.Clear();
            parameters.Add(dbManager.CreateParameter("@SalesId", 9, SalesDetails.SalesId, DbType.Int64));
            return parameters.ToArray();
        }
        /// <summary>
        /// Add parameters while getting the stock details  
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public IDbDataParameter[] AddParamsGetStockDetailsDomain(StockDetailsDomain StockDetailsDomain)
        {
            parameters.Clear();
            parameters.Add(dbManager.CreateParameter("@StockId", 9, StockDetailsDomain.StockId, DbType.Int32));
            parameters.Add(dbManager.CreateParameter("@FromDate", StockDetailsDomain.FromDate, DbType.Date));
            parameters.Add(dbManager.CreateParameter("@ToDate", StockDetailsDomain.ToDate, DbType.Date));
            parameters.Add(dbManager.CreateParameter("@BrandName", 100, StockDetailsDomain.BrandName, DbType.String));
            parameters.Add(dbManager.CreateParameter("@OperationType", 2, StockDetailsDomain.OperationType, DbType.Int16));
            return parameters.ToArray();
        }
        /// <summary>
        /// Add parameters while getting the stock report  
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public IDbDataParameter[] AddParamsGetStockReportDomain(StockDetailsDomain StockDetailsDomain)
        {
            parameters.Clear();
            parameters.Add(dbManager.CreateParameter("@BrandCode", 9, StockDetailsDomain.BrandCode, DbType.Int32));
            parameters.Add(dbManager.CreateParameter("@BrandName", 100, StockDetailsDomain.BrandName, DbType.String));
            parameters.Add(dbManager.CreateParameter("@ColorCode", 9, StockDetailsDomain.ColorCode, DbType.Int32));
            parameters.Add(dbManager.CreateParameter("@OperationType", 2, StockDetailsDomain.OperationType, DbType.Int16));
            return parameters.ToArray();
        }
        /// <summary>
        /// Add parameters while getting the stock details  
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public IDbDataParameter[] AddParamsGetSalesDetails(SalesSearchDetails SalesSearchDetails)
        {
            parameters.Clear();
            parameters.Add(dbManager.CreateParameter("@SalesId", 9, SalesSearchDetails.SalesId, DbType.Int32));
            parameters.Add(dbManager.CreateParameter("@SalesLineId", 9, SalesSearchDetails.SalesLineId, DbType.Int32));
            parameters.Add(dbManager.CreateParameter("@SalesInvoiceNo", 100, SalesSearchDetails.SalesInvoiceNo, DbType.String));
            parameters.Add(dbManager.CreateParameter("@FromDate", SalesSearchDetails.FromDate, DbType.Date));
            parameters.Add(dbManager.CreateParameter("@ToDate", SalesSearchDetails.ToDate, DbType.Date));
            parameters.Add(dbManager.CreateParameter("@CustomerName", 100, SalesSearchDetails.CustomerName, DbType.String));
            parameters.Add(dbManager.CreateParameter("@CustomerMobileNo", 14, SalesSearchDetails.CustomerMobileNo, DbType.Double));
            parameters.Add(dbManager.CreateParameter("@BrandCode", 9, SalesSearchDetails.BrandCode, DbType.Int32));
            parameters.Add(dbManager.CreateParameter("@BrandName", 200, SalesSearchDetails.BrandName, DbType.String));
            parameters.Add(dbManager.CreateParameter("@OperationType", 2, SalesSearchDetails.OperationType, DbType.Int16));
            return parameters.ToArray();
        }
    }
}
