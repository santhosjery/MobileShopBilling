using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessHandler;
using DomainModel;
using DomainModel.Users;

namespace BusinessLayer.Repository.Login
{
    public class LoginIRepository : BasicConext
    {
        /// <summary>
        /// Add parameters while login
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public IDbDataParameter[] AddParametersLogin(Users users)
        {
            parameters.Clear();
            parameters.Add(dbManager.CreateParameter("@UserName", 50, users.UserName, DbType.String));
            parameters.Add(dbManager.CreateParameter("@Password", 50, users.Password, DbType.String));
            return parameters.ToArray();
        }
        /// <summary>
        /// Add parameters while get user details
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public IDbDataParameter[] AddParametersGetUsers(Users users)
        {
            parameters.Clear();
            parameters.Add(dbManager.CreateParameter("@UserId", 7, users.UserId, DbType.Int32));
            parameters.Add(dbManager.CreateParameter("@UserName", 50, users.UserName, DbType.String));
            return parameters.ToArray();
        }
        /// <summary>
        /// To add the parameters for insert employee details
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public IDbDataParameter[] AddParametersRegister(Users users)
        {
            parameters.Clear();
            parameters.Add(dbManager.CreateParameter("@UserId", 2, users.UserId, DbType.Int32));
            parameters.Add(dbManager.CreateParameter("@UserRole", 2, users.UserRole, DbType.Int32));
            parameters.Add(dbManager.CreateParameter("@UserName", 50,users.UserName, DbType.String));
            parameters.Add(dbManager.CreateParameter("@Password", 50, users.Password, DbType.String));
            parameters.Add(dbManager.CreateParameter("@EmailId", 50, users.EmailId, DbType.String));
            parameters.Add(dbManager.CreateParameter("@MobileNumber", 15, users.MobileNumber, DbType.Int64));
            parameters.Add(dbManager.CreateParameter("@Address1", 50, users.Address1, DbType.String));
            parameters.Add(dbManager.CreateParameter("@Address2", 50, users.Address2, DbType.String));
            parameters.Add(dbManager.CreateParameter("@OperationType", 2, users.OperationType, DbType.Int32));
            return parameters.ToArray();
        }
        /// <summary>
        /// Add parameters while login
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public IDbDataParameter[] AddParasUpdatePassword(ChangePasswordModel ChangePasswordModel)
        {
            parameters.Clear();
            parameters.Add(dbManager.CreateParameter("@OldPassword", 50, ChangePasswordModel.OldPassword, DbType.String));
            parameters.Add(dbManager.CreateParameter("@NewPassword", 50, ChangePasswordModel.NewPassword, DbType.String));
            parameters.Add(dbManager.CreateParameter("@OperationType", 2, ChangePasswordModel.OperationType, DbType.Int32));
            return parameters.ToArray();
        }
    }
}
