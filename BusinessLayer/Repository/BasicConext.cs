using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessHandler;

namespace BusinessLayer.Repository
{
    public class BasicConext
    {
        public StoredProcedures _StoredProcedures = new StoredProcedures();
        public List<IDbDataParameter> parameters = new List<IDbDataParameter>();
        public DBManager dbManager = new DBManager();
    }
}
