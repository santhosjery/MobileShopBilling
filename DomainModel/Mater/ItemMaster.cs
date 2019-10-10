using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Mater
{
    public class ItemMaster
    {
        public Nullable<int> ItemCode { get; set; }

        public string ItemName { get; set; }

        public Nullable<int> OperationType { get; set; }
    }
}