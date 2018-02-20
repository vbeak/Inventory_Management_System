using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
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
    }
}
