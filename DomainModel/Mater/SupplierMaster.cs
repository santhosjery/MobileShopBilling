using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Mater
{
    public class SupplierMaster
    {
        public Nullable<int> SupplierCode { get; set; }

        public string SupplierName { get; set; }

        public Nullable<long> MobileNumber { get; set; }

        public string EmailId { get; set; }

        public string GSTINNumber { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public Nullable<int> OperationType { get; set; }
    }
}
