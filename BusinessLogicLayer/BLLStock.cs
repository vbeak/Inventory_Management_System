using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class BLLStock
    {
        public DataTable getAllStock()
        {
            string sql = "select *from tblStock";
            return DAO.getTable(sql,null);
        }

        
    }
}
