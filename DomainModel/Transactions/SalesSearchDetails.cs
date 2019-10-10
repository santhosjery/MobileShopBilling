using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Transactions
{
    public class SalesSearchDetails
    {
        public int? SalesId { get; set; }

        public int? SalesLineId { get; set; }

        public string SalesInvoiceNo { get; set; }

        public DateTime? FromDate { get; set; }

        public DateTime? ToDate { get; set; }

        public string CustomerName { get; set; }

        public double? CustomerMobileNo { get; set; }

        public int? BrandCode { get; set; }

        public string BrandName { get; set; }

        public int OperationType { get; set; }
    }
}
