using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileShopBilling.Admin.CommonClasses
{
    public interface ExceptionILogger
    {
        void ILogger(Exception _exception);
    }
}
