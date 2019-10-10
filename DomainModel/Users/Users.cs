using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Users
{
    public class Users
    {
        public Nullable<int> UserId { get; set; }

        public int UserRole { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string EmailId { get; set; }

        public UInt64 MobileNumber { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public int? OperationType { get; set; }
    }
}
