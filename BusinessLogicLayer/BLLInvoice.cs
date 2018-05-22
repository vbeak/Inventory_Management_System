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
    public class BLLInvoice
    {
        public DataTable getInvoice()
        {
            string sql = "select top 1 *from tblInvoice order by invoice_No desc";

            return DAO.getTable(sql, null);
        }

        public int CreateInvoice(string invoiceno, DateTime invoicedate, string customerName, decimal grandtotal)
        {
            string sql = "insert into tblInvoice values(@a,@b,@c,@d)";
            SqlParameter[] param = new SqlParameter[]{
            
            new SqlParameter("@a",invoiceno),
            new SqlParameter("@b",invoicedate),
            new SqlParameter("@c",customerName),
            new SqlParameter("@d",grandtotal)
            };

            return DAO.IUD(sql, param);
        }
    }
}
