using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Mater
{
    public class GetMasterNamesAndCodes
    {
        public string SearchText { get; set; }

        public Nullable<int> MasterCode { get; set; }

        public Nullable<int> OperationType { get; set; }
    }
}
