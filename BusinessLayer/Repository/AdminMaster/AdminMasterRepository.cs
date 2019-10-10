using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessHandler;
using DomainModel.Mater;

namespace BusinessLayer.Repository.AdminMaster
{
    public class AdminMasterRepository : BasicConext
    {
        AdminMasterIRepository _AdminMasterIRepository = new AdminMasterIRepository();
        /// <summary>
        /// Insert the new Item code details..
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public int InsertUpdateDeleteItemMaster(ItemMaster item_master)
        {
            int LastId = 0;
            var DbManager = new DBManager("DBConnection");
            DbManager.Insert(_StoredProcedures.InsertUpdateDeleteItemMaster_SP, CommandType.StoredProcedure, _AdminMasterIRepository.AddParametersItemMasterInsertUpdateDelete(item_master), out LastId);
            return LastId;
        }
        /// <summary>
        /// To get the item master list..
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public DataTable GetItemMaster(ItemMaster item_master)
        {
            var DbManager = new DBManager("DBConnection");
            return DbManager.GetDataTable(_StoredProcedures.GetItemMaster_SP, CommandType.StoredProcedure, _AdminMasterIRepository.AddParametersItemMasterGet(item_master));
        }
        /// <summary>
        /// Insert the new product code details..
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public int InsertUpdateDeleteProductMaster(ProductMaster product_master)
        {
            int LastId = 0;
            var DbManager = new DBManager("DBConnection");
            DbManager.Insert(_StoredProcedures.InsertUpdateDeleteProductMaster_SP, CommandType.StoredProcedure, _AdminMasterIRepository.AddParametersProductMasterInsertUpdateDelete(product_master), out LastId);
            return LastId;
        }
        /// <summary>
        /// Insert the new brand details..
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public int InsertUpdateDeleteBrandMaster(BrandMaster brand_master)
        {
            int LastId = 0;
            var DbManager = new DBManager("DBConnection");
            DbManager.Insert(_StoredProcedures.InsertUpdateDeleteBrandMaster_SP, CommandType.StoredProcedure, _AdminMasterIRepository.AddParametersBrandMaster(brand_master), out LastId);
            return LastId;
        }
        /// <summary>
        /// Insert/update/delete the new supplier details..
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public int InsertUpdateDeleteSupplierLegder(SupplierMaster supplier_master)
        {
            int LastId = 0;
            var DbManager = new DBManager("DBConnection");
            DbManager.Insert(_StoredProcedures.InsertUpdateDeleteSupplierLedger_SP, CommandType.StoredProcedure, _AdminMasterIRepository.AddParametersSupplierLedger(supplier_master), out LastId);
            return LastId;
        }
        /// <summary>
        /// Insert/update/delete the new tax details..
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public int InsertUpdateDeleteTaxMaster(TaxMaster tax_master)
        {
            int LastId = 0;
            var DbManager = new DBManager("DBConnection");
            DbManager.Insert(_StoredProcedures.InsertUpdateDeleteTaxMaster_SP, CommandType.StoredProcedure, _AdminMasterIRepository.AddParametersTax(tax_master), out LastId);
            return LastId;
        }
        /// <summary>
        /// To get the product master list..
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public DataTable GetProductMaster(ProductMaster product_master)
        {
            var DbManager = new DBManager("DBConnection");
            return DbManager.GetDataTable(_StoredProcedures.GetProductMaster_SP, CommandType.StoredProcedure, _AdminMasterIRepository.AddParametersProductMasterGet(product_master));
        }
        /// <summary>
        /// To get the brand master list..
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public DataTable GetBrandMaster(BrandMaster brand_master)
        {
            var DbManager = new DBManager("DBConnection");
            return DbManager.GetDataTable(_StoredProcedures.GetBrandMaster_SP, CommandType.StoredProcedure, _AdminMasterIRepository.AddParametersGetBrandMaster(brand_master));
        }
        /// <summary>
        /// To get the supplier ledger list..
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public DataTable GetSupplierLedger(SupplierMaster supplier_master)
        {
            var DbManager = new DBManager("DBConnection");
            return DbManager.GetDataTable(_StoredProcedures.GetSupplierLedger_SP, CommandType.StoredProcedure, _AdminMasterIRepository.AddParametersGetSupplierMaster(supplier_master));
        }
        /// <summary>
        /// To get the supplier ledger list..
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public DataTable GetTaxList()
        {
            var DbManager = new DBManager("DBConnection");
            return DbManager.GetDataTable(_StoredProcedures.GetTaxMaster_SP, CommandType.StoredProcedure, null);
        }
        /// <summary>
        /// To get the all master list..
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public DataTable GetProductMaster(GetMasterNamesAndCodes master_details)
        {
            var DbManager = new DBManager("DBConnection");
            return DbManager.GetDataTable(_StoredProcedures.GetMasterNameAndCodes_SP, CommandType.StoredProcedure, _AdminMasterIRepository.AddParamsGetProductMaster(master_details));
        }
        /// <summary>
        /// To get the color master list..
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public DataTable GetColorMaster(ColorMaster ColorMaster)
        {
            var DbManager = new DBManager("DBConnection");
            return DbManager.GetDataTable(_StoredProcedures.GetColorMaster_SP, CommandType.StoredProcedure, _AdminMasterIRepository.AddParamsGetColorMaster(ColorMaster));
        }
        /// <summary>
        /// Insert/update/delete the color master details..
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public int InsertUpdateDeleteColorMaster(ColorMaster ColorMaster)
        {
            int LastId = 0;
            var DbManager = new DBManager("DBConnection");
            DbManager.Insert(_StoredProcedures.InsertUpdateDeleteColorMaster_SP, CommandType.StoredProcedure, _AdminMasterIRepository.AddParametersColorMasterInsert(ColorMaster), out LastId);
            return LastId;
        }
    }
}
