using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Transactions
{
    public class PurchaseDetails
    {
        public int PurchaseId { get; set; }

        public string PurchaseInvoiceNo { get; set; }

        public int SupplierCode { get; set; }

        public double NetAmount { get; set; }

        public int PaymentType { get; set; }

        public double PaidAmount { get; set; }

        public double DuesAmount { get; set; }

        public int OperationType { get; set; }

        public DataTable DtPurchaseDetails { get; set; }
    }
}