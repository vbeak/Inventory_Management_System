using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
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
    }
}
