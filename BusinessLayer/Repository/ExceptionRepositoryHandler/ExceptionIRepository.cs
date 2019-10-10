using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel;

namespace BusinessLayer.Repository.ExceptionRepositoryHandler
{
    public class ExceptionIRepository : BasicConext
    {
        /// <summary>
        /// Add parameters inserting the exception
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public IDbDataParameter[] AddParasExceptionInsert(ExceptionHandler exception_master)
        {
            parameters.Clear();
            parameters.Add(dbManager.CreateParameter("@ErrorNumber", 2, exception_master.ErrorNumber, DbType.Int16));
            parameters.Add(dbManager.CreateParameter("@ErrorState", 7, exception_master.ErrorState, DbType.Int32));
            parameters.Add(dbManager.CreateParameter("@ErrorLine", 7, exception_master.ErrorLine, DbType.Int32));
            parameters.Add(dbManager.CreateParameter("@ErrorFrom", 2, exception_master.ErrorFrom, DbType.Int16));
            parameters.Add(dbManager.CreateParameter("@ErrorMethod", 150, exception_master.ErrorMethod, DbType.String));
            parameters.Add(dbManager.CreateParameter("@ErrorMessage", 3000, exception_master.ErrorMessage, DbType.String));
            parameters.Add(dbManager.CreateParameter("@ErrorRemarks", 500 , exception_master.ErrorRemarks, DbType.String));
            return parameters.ToArray();
        }
    }
}
