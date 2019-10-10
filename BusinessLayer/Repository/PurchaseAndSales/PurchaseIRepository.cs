using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.Transactions;

namespace BusinessLayer.Repository.PurchaseAndSales
{
    public class PurchaseIRepository : BasicConext
    {
        /// <summary>
        /// Add parameters while adding the purchase details  
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public IDbDataParameter[] AddParmsPurchaseDetails(PurchaseDetails purchase_details)
        {
            parameters.Clear();
            parameters.Add(dbManager.CreateParameter("@PurchaseId_Purchase", 7, purchase_details.PurchaseId, DbType.Int32));
            parameters.Add(dbManager.CreateParameter("@PurchaseInvoiceNo", 50, purchase_details.PurchaseInvoiceNo, DbType.String));
            parameters.Add(dbManager.CreateParameter("@SupplierCode", 2, purchase_details.SupplierCode, DbType.Int32));
            parameters.Add(dbManager.CreateParameter("@NetAmount", purchase_details.NetAmount, DbType.Double));
            parameters.Add(dbManager.CreateParameter("@PaymentType", 2, purchase_details.PaymentType, DbType.Int16));
            parameters.Add(dbManager.CreateParameter("@PaidAmount", purchase_details.PaidAmount, DbType.Double));
            parameters.Add(dbManager.CreateParameter("@DuesAmount", purchase_details.DuesAmount, DbType.Double));
            parameters.Add(dbManager.CreateParameter("@DtPurchaseDetailsType", "dbo.DtPurchaseDetailsType", purchase_details.DtPurchaseDetails, SqlDbType.Structured));
            parameters.Add(dbManager.CreateParameter("@OperationType", 2, purchase_details.OperationType, DbType.Int16));
            return parameters.ToArray();
        }
        /// <summary>
        /// Add parameters while getting the stock details  
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public IDbDataParameter[] AddParamsGetPurchaseDetails(PurchaseSearchDetails PurchaseSearchDetails)
        {
            parameters.Clear();
            parameters.Add(dbManager.CreateParameter("@PurchaseId", 9, PurchaseSearchDetails.PurchaseId, DbType.Int32));
            parameters.Add(dbManager.CreateParameter("@PurchaseLineId", 9, PurchaseSearchDetails.PurchaseLineId, DbType.Int32));
            parameters.Add(dbManager.CreateParameter("@PurchaseInvoiceNo", 100, PurchaseSearchDetails.PurchaseInvoiceNo, DbType.String));
            parameters.Add(dbManager.CreateParameter("@FromDate", PurchaseSearchDetails.FromDate, DbType.Date));
            parameters.Add(dbManager.CreateParameter("@ToDate", PurchaseSearchDetails.ToDate, DbType.Date));
            parameters.Add(dbManager.CreateParameter("@CustomerName", 100, PurchaseSearchDetails.SupplierName, DbType.String));
            parameters.Add(dbManager.CreateParameter("@CustomerMobileNo", 14, PurchaseSearchDetails.SupplierMobileNo, DbType.Double));
            parameters.Add(dbManager.CreateParameter("@BrandCode", 9, PurchaseSearchDetails.BrandCode, DbType.Int32));
            parameters.Add(dbManager.CreateParameter("@BrandName", 200, PurchaseSearchDetails.BrandName, DbType.String));
            parameters.Add(dbManager.CreateParameter("@OperationType", 2, PurchaseSearchDetails.OperationType, DbType.Int16));
            return parameters.ToArray();
        }
    }
}
