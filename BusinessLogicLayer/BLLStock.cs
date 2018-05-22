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
    public class BLLStock
    {
        public DataTable getAllStock()
        {
            string sql = "select *from tblStock";
            return DAO.getTable(sql,null);
        }

        public DataTable getQuantityByProductId(int productId)
        {
            string sql = "select *from tblStock where productId=@a";
            SqlParameter[] param = new SqlParameter[]
            {
            new SqlParameter("@a",productId)
            };

            return DAO.getTable(sql, param);
        }

        public int UpdateQuantityByProductId(int productId, int quantity)
        {
            string sql = "update tblStock set quantity=@quantity where productId=@productId";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@quantity",quantity),
                new SqlParameter("@productId",productId)
            };

            return DAO.IUD(sql, param);
        }

        public int insertIntoTblStock(int ProductId, int Quantity)
        {
            string sql = "insert into tblStock values(@a,@b)";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@a",ProductId),
                new SqlParameter("@b",Quantity)
            };

            return DAO.IUD(sql, param);
        }

        public DataTable getAllStockWithName()
        {
            string sql = "SELECT tblStock.stockId, tblStock.ProductId,tblProduct.productName, tblStock.Quantity FROM tblProduct INNER JOIN tblStock ON tblProduct.productId = tblStock.ProductId";
            DataTable dt = DAO.getTable(sql, null);
            return dt;
        }



        
    }
}
