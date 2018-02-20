using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class BLLpurchase
    {
        public int AddPurchase(string invoiceNo,int categoryId,int productId,int quantity,decimal total,string date)
        {
            string sql = "insert into tblPurchase values(@a,@b,@c,@d,@e,@f)";
            SqlParameter[] param = new SqlParameter[]{
            new SqlParameter("@a",invoiceNo),
            new SqlParameter("@b",categoryId),
            new SqlParameter("@c",productId),
            new SqlParameter("@d",quantity),
            new SqlParameter("@e",total),
            new SqlParameter("@f",date)
            };

            return DAO.IUD(sql,param);
        }
    }
}
