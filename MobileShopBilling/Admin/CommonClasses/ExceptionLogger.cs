using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Repository.ExceptionRepositoryHandler;

namespace MobileShopBilling.Admin.CommonClasses
{
    public enum LogSeverity
    {
        DataBase,
        FileSystem,
        FileSystemAndDataBase
    };
    public class ExceptionLogger
    {
        public static ExceptionILogger GetLoggerType(LogSeverity _severity)
        {
            ExceptionILogger _exceptionILogger;
            if (_severity == LogSeverity.FileSystemAndDataBase)
            {
                _exceptionILogger = new FileSystemAndDataBase();
            }
            else if (_severity == LogSeverity.DataBase)
            {
                _exceptionILogger = new DatabaseLogger();
            }
            else
            {
                _exceptionILogger = new FileSystemLogger();
            }
            return _exceptionILogger;
        }
    }
    public class DatabaseLogger : ExceptionILogger
    {
        public void ILogger(Exception _exception)
        {
            //Db log handler..
        }
    }
    public class FileSystemLogger : ExceptionILogger
    {
        public void ILogger(Exception _exception)
        {
            //File log handler..
        }
    }
    public class FileSystemAndDataBase : ExceptionILogger
    {
        ExceptionRepository _exceptionRepository = new ExceptionRepository();
        public void ILogger(Exception _exception)
        {
            _exceptionRepository.InsertExceptionDetails(_exception, "NotGetting");
            //File log handler..
        }
    }
}
