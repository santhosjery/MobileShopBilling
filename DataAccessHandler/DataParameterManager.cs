using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessHandler
{
    public class DataParameterManager
    {
        public static IDbDataParameter CreateParameter(string name, object value, DbType dbType, ParameterDirection direction = ParameterDirection.Input)
        {
            return CreateSqlParameter(name, value, dbType, direction);
        }

        public static IDbDataParameter CreateParameter(string name, int size, object value, DbType dbType, ParameterDirection direction = ParameterDirection.Input)
        {
            return CreateSqlParameter(name, size, value, dbType, direction);
        }

        public static IDbDataParameter CreateParameter(string name, string typeName, object value, SqlDbType sqldbType, ParameterDirection direction = ParameterDirection.Input)
        {
            return CreateSqlParameter(name, typeName, value, sqldbType, direction);
        }

        private static IDbDataParameter CreateSqlParameter(string name, object value, DbType dbType, ParameterDirection direction)
        {
            return new SqlParameter
            {
                DbType = dbType,
                ParameterName = name,
                Direction = direction,
                Value = value
            };
        }

        private static IDbDataParameter CreateSqlParameter(string name, int size, object value, DbType dbType, ParameterDirection direction)
        {
            return new SqlParameter
            {
                DbType = dbType,
                Size = size,
                ParameterName = name,
                Direction = direction,
                Value = value
            };
        }
        private static IDbDataParameter CreateSqlParameter(string name, string typeName, object value, SqlDbType sqldbType, ParameterDirection direction)
        {
            return new SqlParameter
            {
                ParameterName = name,
                SqlDbType = sqldbType,
                TypeName = typeName,
                Direction = direction,
                Value = value                
            };
        }
    }
}
