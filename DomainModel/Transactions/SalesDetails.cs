using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Transactions
{
    public class SalesDetails
    {
        public long SalesId { get; set; }

        public int BrandCode { get; set; }

        public int ColorCode { get; set; }

        public int PurchaseId { get; set; }

        public int PurchaseLineId { get; set; }

        public string PurchaseInvoiceNo { get; set; }

        public string CustomerName { get; set; }

        public double CustomerMobileNo { get; set; }

        public double GrossAmount { get; set; }

        public double DiscountPer { get; set; }

        public double DiscountAmount { get; set; }

        public double NetAmount { get; set; }

        public int PaymentType { get; set; }

        public double PaidAmount { get; set; }

        public double DuesAmount { get; set; }

        public int OperationType { get; set; }

        public DataTable DtSalesDetails { get; set; }
    }
}
