using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel;
using DomainModel.Mater;

namespace BusinessLayer.Repository.AdminMaster
{
    public class AdminMasterIRepository : BasicConext
    {
        /// <summary>
        /// Add parameters while adding the item  
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public IDbDataParameter[] AddParametersItemMasterInsertUpdateDelete(ItemMaster item_master)
        {
            parameters.Clear();
            parameters.Add(dbManager.CreateParameter("@ItemCode", 7, item_master.ItemCode, DbType.Int32));
            parameters.Add(dbManager.CreateParameter("@ItemName", 50, item_master.ItemName, DbType.String));
            parameters.Add(dbManager.CreateParameter("@OperationType", 2, item_master.OperationType, DbType.Int16));
            return parameters.ToArray();
        }
        /// <summary>
        /// Add parameters while fetch or search items
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public IDbDataParameter[] AddParametersItemMasterGet(ItemMaster item_master)
        {
            parameters.Clear();
            parameters.Add(dbManager.CreateParameter("@ItemCode", 50, item_master.ItemCode, DbType.Int32));
            parameters.Add(dbManager.CreateParameter("@ItemName", 50, item_master.ItemName, DbType.String));
            return parameters.ToArray();
        }
        /// <summary>
        /// Add parameters while fetch or product search items
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public IDbDataParameter[] AddParametersProductMasterGet(ProductMaster product_master)
        {
            parameters.Clear();
            parameters.Add(dbManager.CreateParameter("@ProductName", 150, product_master.ProductName, DbType.String));
            return parameters.ToArray();
        }
        /// <summary>
        /// Add parameters while fetch or brand search items
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public IDbDataParameter[] AddParametersGetBrandMaster(BrandMaster brand_master)
        {
            parameters.Clear();
            parameters.Add(dbManager.CreateParameter("@BrandName", 150, brand_master.BrandName, DbType.String));
            return parameters.ToArray();
        }
        /// <summary>
        /// Add parameters while fetch or supplier search items
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public IDbDataParameter[] AddParametersGetSupplierMaster(SupplierMaster supplier_master)
        {
            parameters.Clear();
            parameters.Add(dbManager.CreateParameter("@SupplierName", 150, supplier_master.SupplierName, DbType.String));
            parameters.Add(dbManager.CreateParameter("@SupplierCode", 50, supplier_master.SupplierCode, DbType.Int32));
            return parameters.ToArray();
        }
        /// <summary>
        /// Add parameters while fetch all master drop down list
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public IDbDataParameter[] AddParamsGetProductMaster(GetMasterNamesAndCodes master_details)
        {
            parameters.Clear();
            parameters.Add(dbManager.CreateParameter("@SearchText", 150, master_details.SearchText, DbType.String));
            parameters.Add(dbManager.CreateParameter("@MasterCode", 2, master_details.MasterCode, DbType.Int32));
            parameters.Add(dbManager.CreateParameter("@OperationType", 2, master_details.OperationType, DbType.Int16));
            return parameters.ToArray();
        }
        /// <summary>
        /// Add parameters while fetch all color master
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public IDbDataParameter[] AddParamsGetColorMaster(ColorMaster ColorMaster)
        {
            parameters.Clear();
            parameters.Add(dbManager.CreateParameter("@ColorName", 50, ColorMaster.ColorName, DbType.String));
            return parameters.ToArray();
        }
        /// <summary>
        /// Add parameters while adding the product details  
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public IDbDataParameter[] AddParametersProductMasterInsertUpdateDelete(ProductMaster product_master)
        {
            parameters.Clear(); 
            parameters.Add(dbManager.CreateParameter("@ProductName", 50, product_master.ProductName, DbType.String));
            parameters.Add(dbManager.CreateParameter("@ItemCode", 7, product_master.ItemCode, DbType.Int32));
            parameters.Add(dbManager.CreateParameter("@ProductCode", 7, product_master.ProductCode, DbType.Int32));
            parameters.Add(dbManager.CreateParameter("@MinimumStockNotification", 7, product_master.MinimumStockNotification, DbType.Int32));
            parameters.Add(dbManager.CreateParameter("@OperationType", 2, product_master.OperationType, DbType.Int16));
            return parameters.ToArray();
        }
        /// <summary>
        /// Add parameters while adding the product details  
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public IDbDataParameter[] AddParametersBrandMaster(BrandMaster brand_master)
        {
            parameters.Clear();
            parameters.Add(dbManager.CreateParameter("@BrandName", 150, brand_master.BrandName, DbType.String));
            parameters.Add(dbManager.CreateParameter("@ProductCode", 8, brand_master.ProductCode, DbType.Int32));
            parameters.Add(dbManager.CreateParameter("@BrandCode", 8, brand_master.BrandCode, DbType.Int32));
            parameters.Add(dbManager.CreateParameter("@OperationType", 2, brand_master.OperationType, DbType.Int16));
            return parameters.ToArray();
        }
        /// <summary>
        /// Add parameters while adding the product details  
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public IDbDataParameter[] AddParametersSupplierLedger(SupplierMaster supplier_master)
        {
            parameters.Clear();
            parameters.Add(dbManager.CreateParameter("@SupplierCode", 50, supplier_master.SupplierCode, DbType.Int32));
            parameters.Add(dbManager.CreateParameter("@SupplierName", 150, supplier_master.SupplierName, DbType.String));
            parameters.Add(dbManager.CreateParameter("@MobileNumber", 18, supplier_master.MobileNumber, DbType.Int64));
            parameters.Add(dbManager.CreateParameter("@EmailId", 30, supplier_master.EmailId, DbType.String));
            parameters.Add(dbManager.CreateParameter("@GSTINNumber", 30, supplier_master.GSTINNumber, DbType.String));
            parameters.Add(dbManager.CreateParameter("@Address1", 150, supplier_master.Address1, DbType.String));
            parameters.Add(dbManager.CreateParameter("@Address2", 150, supplier_master.Address2, DbType.String));
            parameters.Add(dbManager.CreateParameter("@OperationType", 2, supplier_master.OperationType, DbType.Int16));
            return parameters.ToArray();
        }
        /// <summary>
        /// Add parameters while adding the product details  
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public IDbDataParameter[] AddParametersTax(TaxMaster tax_master)
        {
            parameters.Clear();
            parameters.Add(dbManager.CreateParameter("@CGST", 50, tax_master.CGST, DbType.Decimal));
            parameters.Add(dbManager.CreateParameter("@SGST", 50, tax_master.SGST, DbType.Decimal));
            parameters.Add(dbManager.CreateParameter("@IGST", 50, tax_master.IGST, DbType.Decimal));
            parameters.Add(dbManager.CreateParameter("@IsActive", 2, tax_master.IsActive, DbType.Int16));
            parameters.Add(dbManager.CreateParameter("@OperationType", 2, tax_master.OperationType, DbType.Int16));
            return parameters.ToArray();
        }
        /// <summary>
        /// Add parameters while adding the product details  
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public IDbDataParameter[] AddParametersColorMasterInsert(ColorMaster ColorMaster)
        {
            parameters.Clear();
            parameters.Add(dbManager.CreateParameter("@ColorName", 50, ColorMaster.ColorName, DbType.String));
            parameters.Add(dbManager.CreateParameter("@ColorCode", 7, ColorMaster.ColorCode, DbType.Int32));
            parameters.Add(dbManager.CreateParameter("@OperationType", 2, ColorMaster.OperationType, DbType.Int16));
            return parameters.ToArray();
        }
    }
}
