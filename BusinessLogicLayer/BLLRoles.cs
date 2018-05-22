using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class BLLRoles
    {
        public DataTable getAllRoles()
        {
            string sql = "select *from tblRoles";
            return DAO.getTable(sql,null);
        }

        public DataTable getRolebyId(int id)
        {
            string sql = "select Role from tblRoles where RoleId=@roleId";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@roleId",id)
            };
            return DAO.getTable(sql,param);
        }
    }
}
