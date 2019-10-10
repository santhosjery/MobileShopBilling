using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Mater
{
    public class BrandMaster
    {
        public Nullable<int> BrandCode { get; set; }

        public string BrandName { get; set; }

        public Nullable<int> ProductCode { get; set; }

        public string ProductName { get; set; }

        public Nullable<int> OperationType { get; set; }
    }
}
