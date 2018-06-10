using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.Data.SqlClient;

namespace BusinessLogicLayer
{
    public class BLLsales
    {
        public DataTable ShowAllSales()
        {
            string sql = "select * from tblSales";
            return DAO.getTable(sql, null);
        }

        public int AddNewSalesItem(string invoice_No, int categoryId, int productId, string productName, int quantity, Decimal total, Decimal exciseDuty,Decimal discount, Decimal vat, Decimal grandTotal, string soldBy, string soldDate, string customerName)
        {
            string sql = "insert into tblSales values(@a,@b,@c,@d,@e,@f,@g,@h,@i,@j,@k,@l,@m)";
            SqlParameter[] param = new SqlParameter[]{
                new SqlParameter("@a",invoice_No),
                new SqlParameter("@b",categoryId),
                new SqlParameter("@c",productId),
                new SqlParameter("@d",productName),
                new SqlParameter("@e",quantity),
                new SqlParameter("@f",total),
                new SqlParameter("@g",exciseDuty),
                new SqlParameter("@h",discount),
                new SqlParameter("@i",vat),
                new SqlParameter("@j",grandTotal),
                new SqlParameter("@k",soldBy),
                new SqlParameter("@l",soldDate),
                new SqlParameter("@m",customerName)
            
            };

            return DAO.IUD(sql, param);
        }
    }
}
