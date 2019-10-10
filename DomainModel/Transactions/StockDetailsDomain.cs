using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Transactions
{
    public class StockDetailsDomain
    {
        public int? StockId { get; set; }

        public int? BrandCode { get; set; }

        public int? ColorCode { get; set; }

        public string BrandName { get; set; }

        public DateTime? FromDate { get; set; }

        public DateTime? ToDate { get; set; }

        public int OperationType { get; set; }
    }
}