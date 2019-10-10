using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessHandler;
using DomainModel;

namespace BusinessLayer.Repository.ExceptionRepositoryHandler
{
    public class ExceptionRepository : BasicConext
    {
        ExceptionIRepository _ExceptionIRepository = new ExceptionIRepository();
        /// <summary>
        /// Insert the exception details..
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public int InsertExceptionDetails(Exception ex, string ErrorFunction)
        {
            var exception_master = new ExceptionHandler
            {
                ErrorNumber = 0,
                ErrorState = 0,
                ErrorLine = LineNumber(ex),
                ErrorMethod = ErrorFunction,
                ErrorMessage = ex.ToString(),
                ErrorRemarks = ""
            };
            int LastId = 0;
            var DbManager = new DBManager("DBConnection");
            DbManager.Insert(_StoredProcedures.InsertExceptionDetails_SP, CommandType.StoredProcedure, _ExceptionIRepository.AddParasExceptionInsert(exception_master), out LastId);
            return LastId;
        }
        private int LineNumber(Exception e)
        {

            int linenum = 0;
            try
            {
                //linenum = Convert.ToInt32(e.StackTrace.Substring(e.StackTrace.LastIndexOf(":line") + 5));

                //For Localized Visual Studio ... In other languages stack trace  doesn't end with ":Line 12"
                linenum = Convert.ToInt32(e.StackTrace.Substring(e.StackTrace.LastIndexOf(' ')));

            }
            catch
            {
                //Stack trace is not available!
            }
            return linenum;
        }
    }
}
