using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessHandler;
using DomainModel.Transactions;

namespace BusinessLayer.Repository.PurchaseAndSales
{
    public class SalesRepository : BasicConext
    {
        SalesIRepository _SalesIRepository = new SalesIRepository();
        /// <summary>
        /// To get the brand master list..
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public DataTable GetPurchaseListById(SalesDetails SalesDetails)
        {
            var DbManager = new DBManager("DBConnection");
            return DbManager.GetDataTable(_StoredProcedures.GetPurchaseListById_SP, CommandType.StoredProcedure, _SalesIRepository.AddParamsGetBrandMaster(SalesDetails));
        }
        /// <summary>
        /// Insert and update the sales details..
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public long InsertUpdateSalesDetails(SalesDetails SalesDetails)
        {
            long LastId = 0;
            var DbManager = new DBManager("DBConnection");
            DbManager.Insert(_StoredProcedures.InsertUpdateSalesDetails_SP, CommandType.StoredProcedure, _SalesIRepository.AddParmsSalesDetails(SalesDetails), out LastId);
            return LastId;
        }
        /// <summary>
        /// Get the last sales details by salesid..
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public DataTable GetLastSalesDetailsBySalesId(SalesDetails SalesDetails)
        {
            var DbManager = new DBManager("DBConnection");
            return DbManager.GetDataTable(_StoredProcedures.GetSalesDetailsBySalesId_SP, CommandType.StoredProcedure, _SalesIRepository.AddParmsGetLastSalesDetailsBySalesId(SalesDetails));
        }
        /// <summary>
        /// To get the stock list list..
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public DataTable StockDetailsDomain(StockDetailsDomain StockDetailsDomain)
        {
            var DbManager = new DBManager("DBConnection");
            return DbManager.GetDataTable(_StoredProcedures.GetStockDetails_SP, CommandType.StoredProcedure, _SalesIRepository.AddParamsGetStockDetailsDomain(StockDetailsDomain));
        }
        /// <summary>
        /// To get the stock report list..
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public DataTable StockReportDomain(StockDetailsDomain StockDetailsDomain)
        {
            var DbManager = new DBManager("DBConnection");
            return DbManager.GetDataTable(_StoredProcedures.GetStockReport_SP, CommandType.StoredProcedure, _SalesIRepository.AddParamsGetStockReportDomain(StockDetailsDomain));
        }
        /// <summary>
        /// To get the sales list for header and line..
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public DataTable GetSalesDetails(SalesSearchDetails SalesSearchDetails)
        {
            var DbManager = new DBManager("DBConnection");
            return DbManager.GetDataTable(_StoredProcedures.GetSalesDetails_SP, CommandType.StoredProcedure, _SalesIRepository.AddParamsGetSalesDetails(SalesSearchDetails));
        }
    }
}
