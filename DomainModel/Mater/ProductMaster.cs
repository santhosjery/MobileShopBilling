using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Mater
{
    public class ProductMaster
    {
        public Nullable<int> ItemCode { get; set; }

        public string ItemName { get; set; }

        public int? MinimumStockNotification { get; set; }

        public Nullable<int> ProductCode { get; set; }

        public string ProductName { get; set; }

        public Nullable<int> OperationType { get; set; }
    }
}
