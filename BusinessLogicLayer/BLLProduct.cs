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
    public class BLLProduct
    {
        public DataTable GetAllProduct()
        {
            string sql = "SELECT tblProduct.categoryId,tblCategory.CategoryName, tblProduct.productId, tblProduct.ProductName, tblProduct.ProductPrice FROM tblCategory INNER JOIN tblProduct ON tblCategory.categoryId = tblProduct.categoryId";
            return DAO.getTable(sql,null);
        }

        public int AddProduct(int categoryid, string productName, decimal productPrice)
        {
            string sql = "insert into tblProduct values(@a,@b,@c)";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@a",categoryid),
                new SqlParameter("@b",productName),
                new SqlParameter("@c",productPrice)
            };

            return DAO.IUD(sql,param);
        }
        public DataTable getProductbyProductId(int ProductId)
        {
            string sql = "select *from tblProduct where productId=@a";
            SqlParameter[] param = new SqlParameter[] { 
                new SqlParameter("@a",ProductId)
            };
            return DAO.getTable(sql,param);
        }

        public DataTable getProductbyCategoryId(int CategoryId)
        {
            string sql = "select *from tblProduct where categoryId=@a";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@a",CategoryId)
            };

            return DAO.getTable(sql,param);
        }

        public int UpdateProduct(int categoryid, string productName, decimal productPrice, int productId)
        {
            string sql = "update tblProduct set categoryId=@a,productName=@b,productPrice=@c where productId=@d";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@a",categoryid),
                new SqlParameter("@b",productName),
                new SqlParameter("@c",productPrice),
                new SqlParameter("@d",productId)
            };

            return DAO.IUD(sql,param);
        }

        public int DeleteProduct(int ProductId)
        {
            
                string sql = "delete from tblProduct where productId=@a";
                SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@a",ProductId)
            };
                return DAO.IUD(sql, param);
            
        }

        public DataTable getAllProduct()
        {
            string sql = "select * from tblProduct";
            return DAO.getTable(sql, null);
        }
    }
}
