using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class ExceptionHandler
    {
        public Nullable<int> ErrorNumber { get; set; }

        public Nullable<int> ErrorState { get; set; }

        public Nullable<int> ErrorLine { get; set; }

        public Nullable<int> ErrorFrom { get; set; }

        public string ErrorMethod { get; set; }

        public string ErrorMessage { get; set; }

        public string ErrorRemarks { get; set; }

        public ExceptionHandler()
        {
            this.ErrorFrom = 1; //Set as default one.. one for error occured from c# code 2 for SQL.
        }
    }
}