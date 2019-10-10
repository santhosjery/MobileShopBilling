using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer.Repository.AdminMaster;
using BusinessLayer.Repository.Login;
using BusinessLayer.Repository.PurchaseAndSales;
using DomainModel.Mater;
using DomainModel.Transactions;
using DomainModel.Users;

namespace MobileShopBilling.Admin.CommonClasses
{
    public class CommonModel 
    {
        ExceptionLogger _exceptionLogger = new ExceptionLogger();
        AdminMasterRepository _instanceRepository = new AdminMasterRepository();
        LoginRepository _instanceLoginRepository = new LoginRepository();
        SalesRepository _instanceSalesRepository = new SalesRepository();
        public string FirstElementInSelect = "--Select--";
        public string DisplayErrorMessage = "Sorry, something went wrong with input, Please clear and try again..";
        public string ExceptionErrorMessage = "Server error occured, please contact the developer";
        public int PurchaseIdPopUp = 0;
        Dictionary<string, string> ConvertedToDictionary = new Dictionary<string, string>();
        public string LblBackColor = "ControlLight";
        public string LblFontColor = "Blue";
        public string LblFontStyle = "Segoe UI";
        public int LblFontSize = 17;
        //Get grid list for Item Master
        public DataTable GetItemMasterList(int ItemCode, string SearchText)
        {
            var item_master = new ItemMaster
            {
                ItemCode = ItemCode,
                ItemName = SearchText,
                OperationType = 1
            };
            return _instanceRepository.GetItemMaster(item_master);
        }
        //Get grid list for Product Master
        public DataTable GetProductMasterList(string SearchText)
        {
            var product_master = new ProductMaster
            {
                ProductName = SearchText,
                OperationType = 1
            };
            return _instanceRepository.GetProductMaster(product_master);
        }
        //Get grid list for Brand Master
        public DataTable GetBrandMasterList(string SearchText)
        {
            var brand_master = new BrandMaster
            {
                BrandName = SearchText,
                OperationType = 1
            };
            return _instanceRepository.GetBrandMaster(brand_master);
        }
        //Get purchase details beaded on brand code and brand code
        public DataTable GetPurchaseListById(int SelectedBrandCode, int SelectedColorCode, int PurchaseId, int PurchaseLineId, int OperationType)
        {
            var SalesDetails = new SalesDetails
            {
                BrandCode = SelectedBrandCode,
                ColorCode = SelectedColorCode,
                PurchaseId = PurchaseId,
                PurchaseLineId = PurchaseLineId,
                OperationType = OperationType
            };
            return _instanceSalesRepository.GetPurchaseListById(SalesDetails);
        }
        //Get grid list for Supplier Ledger
        public DataTable GetSupplierList(string SearchText, int SupplierCode)
        {
            var supplier_master = new SupplierMaster
            {
                SupplierName = SearchText,
                SupplierCode = SupplierCode,
                OperationType = 1
            };
            return _instanceRepository.GetSupplierLedger(supplier_master);
        }
        //Get grid list for Tax Ledger
        public DataTable GetTaxList()
        {
            return _instanceRepository.GetTaxList();
        }
        //Get grid list for Color Master
        public DataTable GetColorMasterList(string SearchText)
        {
            var ColorMaster = new ColorMaster
            {
                ColorName = SearchText,
                OperationType = 1
            };
            return _instanceRepository.GetColorMaster(ColorMaster);
        }
        //Get grid list for stock details
        public DataTable GetStockDetails(int StockId, string BrandName, int OperationType, DateTime? FromDate, DateTime? ToDate)
        {
            var StockDetailsDomain = new StockDetailsDomain
            {
                StockId = StockId,
                FromDate = FromDate,
                ToDate = ToDate,
                BrandName = BrandName,
                OperationType = OperationType
            };
            return _instanceSalesRepository.StockDetailsDomain(StockDetailsDomain);
        }
        //Get grid list for stock report
        public DataTable GetStockReport(int BrandCode, int ColorCode, string BrandName, int OperationType)
        {
            var StockDetailsDomain = new StockDetailsDomain
            {
                BrandCode = BrandCode,
                BrandName = BrandName,
                ColorCode = ColorCode,
                OperationType = OperationType
            };
            return _instanceSalesRepository.StockReportDomain(StockDetailsDomain);
        }
        //Get grid list for user deatils
        public DataTable GetUserDetails(int UserId, string UserName)
        {
            var Users = new Users
            {
                UserId = UserId,
                UserName = UserName
            };
            return _instanceLoginRepository.GetUserDetails(Users);
        }
        /// <summary>
        /// To get the drop down list details for all master
        /// </summary>
        /// <param name="SearchText"> for fetch all the text </param>
        /// <param name="OperationType"></param>
        /// <returns></returns>
        public DataTable GetMasterNamesAndCodes(string SearchText, int MasterCode, int OperationType)
        {
            var master_details = new GetMasterNamesAndCodes
            {
                SearchText = SearchText,
                MasterCode = MasterCode,
                OperationType = OperationType
            };
            return _instanceRepository.GetProductMaster(master_details);
        }
        public Dictionary<string, string> ConvertDataTableToDictionary(DataTable DtList)
        {
            ConvertedToDictionary.Clear();
            ConvertedToDictionary.Add("0", this.FirstElementInSelect);
            foreach (DataRow DtCol in DtList.Rows)
            {
                ConvertedToDictionary.Add(DtCol[0].ToString(), DtCol[1].ToString());
            }
            return ConvertedToDictionary;
        }
        public Dictionary<string, string> ConvertStringToDictionary(string name, string value)
        {
            ConvertedToDictionary.Clear();
            ConvertedToDictionary.Add("0", FirstElementInSelect);
            ConvertedToDictionary.Add(name.ToString(), value.ToString());
            return ConvertedToDictionary;
        }
        public Boolean CheckNumberOnlyText(KeyPressEventArgs e)
        {
            return !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        public Boolean CheckNumberWithDecimalText(KeyPressEventArgs e)
        {
            return !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.';
        }
        public void InsertException(Exception _exception)
        {
            var LoggerCreator = ExceptionLogger.GetLoggerType(LogSeverity.FileSystemAndDataBase);
            LoggerCreator.ILogger(_exception);
        }
    }
}
