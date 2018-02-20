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
    public class BllCategory
    {
        public DataTable gellAllCategory()
        {
            string sql = "select *from tblCategory";
            return DAO.getTable(sql,null);
        }

        public int AddCategory(string category)
        {
            string sql = "insert into tblCategory values(@a)";
            SqlParameter[] param=new SqlParameter[]
            {
                new SqlParameter("@a",category)
        };

            return DAO.IUD(sql,param);
        }

        public DataTable getCategorybyCategoryId(int CategoryId)
        {
            string sql = "select categoryName from tblCategory where categoryId=@a";
            SqlParameter[] param = new SqlParameter[] { 
                new SqlParameter("@a",CategoryId)
            };

            return DAO.getTable(sql,param);
        }

        public int UpdateCategory(string category, int categoryId)
        {
            string sql = "update tblCategory set category=@category where categoryId=@categoryId";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@category",category),
                new SqlParameter("categoryId",categoryId)
            };
            return DAO.IUD(sql,param);
        }
        public int DeleteCategory(int categoryId)
        {
            string sql = "delete from tblCategory where categoryId=@categoryId";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@categoryId",categoryId)
            };

            return DAO.IUD(sql,param);
        }
    }
}
