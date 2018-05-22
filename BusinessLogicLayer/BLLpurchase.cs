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
    public class BLLpurchase
    {
        public int AddPurchase(int categoryId,int productId,int quantity,decimal total,string date)
        {
            string sql = "insert into tblPurchase values(@b,@c,@d,@e,@f)";
            SqlParameter[] param = new SqlParameter[]{
            
            new SqlParameter("@b",categoryId),
            new SqlParameter("@c",productId),
            new SqlParameter("@d",quantity),
            new SqlParameter("@e",total),
            new SqlParameter("@f",date)
            };

            return DAO.IUD(sql,param);
        }

        public DataTable SelectAllPurchasedItems()
        {
            string sql = "select * from tblPurchase";
            DataTable dt = DAO.getTable(sql, null);
            return dt;

            
                
        }
    }
}
