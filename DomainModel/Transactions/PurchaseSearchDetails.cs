using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Transactions
{
    public class PurchaseSearchDetails
    {
        public int? PurchaseId { get; set; }

        public int? PurchaseLineId { get; set; }

        public string PurchaseInvoiceNo { get; set; }

        public DateTime? FromDate { get; set; }

        public DateTime? ToDate { get; set; }

        public string SupplierName { get; set; }

        public double? SupplierMobileNo { get; set; }

        public int? BrandCode { get; set; }

        public string BrandName { get; set; }

        public int OperationType { get; set; }
    }
}
