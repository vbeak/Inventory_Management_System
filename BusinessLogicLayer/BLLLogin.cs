using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLogicLayer
{
    public class BLLLogin
    {
        public DataTable LoginUser(string username,string password,int roleId)
        {
            string sql = "SELECT UserId, Username, Password,RoleId FROM tblUser where Username=@a and Password=@b and RoleId=@c";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@a",username),
                new SqlParameter("@b",password),
                new SqlParameter("@c",roleId)
            };
            
            
            DataTable dt = DAO.getTable(sql,param);
            return dt;

        }
    }
}
