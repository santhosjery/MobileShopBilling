using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Repository.PurchaseAndSales;
using DataAccessHandler;
using DomainModel.Transactions;

namespace BusinessLayer.Repository.PurchaseAndSales
{
    public class PurchaseRepository : BasicConext
    {
        PurchaseIRepository _PurchaseIRepository = new PurchaseIRepository();
        /// <summary>
        /// Insert and update the purchase details..
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public int InsertUpdatePurchaseDetails(PurchaseDetails purchase_details)
        {
            int LastId = 0;
            var DbManager = new DBManager("DBConnection");
            DbManager.Insert(_StoredProcedures.InsertUpdatePurchaseDetails_SP, CommandType.StoredProcedure, _PurchaseIRepository.AddParmsPurchaseDetails(purchase_details), out LastId);
            return LastId;
        }
        /// <summary>
        /// To get the purchase list for header and line..
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public DataTable GetPurchaseDetails(PurchaseSearchDetails PurchaseSearchDetails)
        {
            var DbManager = new DBManager("DBConnection");
            return DbManager.GetDataTable(_StoredProcedures.GetPurchaseDetails_SP, CommandType.StoredProcedure, _PurchaseIRepository.AddParamsGetPurchaseDetails(PurchaseSearchDetails));
        }
    }
}
