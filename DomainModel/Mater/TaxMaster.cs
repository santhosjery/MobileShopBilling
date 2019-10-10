using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Mater
{
    public class TaxMaster
    {
        public Nullable<decimal> CGST { get; set; }

        public Nullable<decimal> SGST { get; set; }

        public Nullable<decimal> IGST { get; set; }

        public Nullable<int> IsActive { get; set; }

        public Nullable<int> OperationType { get; set; }

    }
}
