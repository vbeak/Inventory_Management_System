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
        public DataTable LoginUser()
        {
            string sql = "SELECT tblUser.Username, tblUser.Password,tblRoles.Role FROM  tblRoles INNER JOIN tblUser ON tblRoles.RoleId = tblUser.RoleId";
            //SqlParameter[] param = new SqlParameter[]
            //{
            //    new SqlParameter("@a",username)
            //};
            
            
            DataTable dt = DAO.getTable(sql,null);
            return dt;

        }
    }
}
