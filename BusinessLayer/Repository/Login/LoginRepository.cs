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
    public class LoginRepository : BasicConext
    {
        LoginIRepository _instanceRepository = new LoginIRepository();
        /// <summary>
        /// Insert the new employee details..
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public int InsertEmployee(Users users)
        {
            int LastId = 0;
            var DbManager = new DBManager("DBConnection");
            DbManager.Insert(_StoredProcedures.InsertUpdateDeleteEmployee_SP, CommandType.StoredProcedure, _instanceRepository.AddParametersRegister(users), out LastId);
            return LastId;
        }
        /// <summary>
        /// To Check the users to login and get the details to use in another page..
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public DataTable LoginUser(Users users)
        {
            var DbManager = new DBManager("DBConnection");
            return DbManager.GetDataTable(_StoredProcedures.AppUserLogin_SP, CommandType.StoredProcedure, _instanceRepository.AddParametersLogin(users));
        }
        /// <summary>
        /// To get the user details..
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public DataTable GetUserDetails(Users users)
        {
            var DbManager = new DBManager("DBConnection");
            return DbManager.GetDataTable(_StoredProcedures.GetUserDetails_SP, CommandType.StoredProcedure, _instanceRepository.AddParametersGetUsers(users));
        }
        /// <summary>
        /// To check and update the password..
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public DataTable ChangePassword(ChangePasswordModel ChangePasswordModel)
        {
            var DbManager = new DBManager("DBConnection");
            return DbManager.GetDataTable(_StoredProcedures.UpdateUserPassword_SP, CommandType.StoredProcedure, _instanceRepository.AddParasUpdatePassword(ChangePasswordModel));
        }

    }
}
