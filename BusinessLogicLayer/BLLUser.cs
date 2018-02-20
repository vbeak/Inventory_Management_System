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
    public class BLLUser
    {
        public DataTable getAllUser()
        {
            string sql = "SELECT tblUser.UserId, tblUser.Username, tblUser.Password,tblRoles.RoleId, tblRoles.Role,tblUser.FullName, tblUser.Address, tblUser.PhoneNo FROM tblRoles INNER JOIN tblUser ON tblRoles.RoleId = tblUser.RoleId";
            return DAO.getTable(sql,null);
        }

        public int AddUser(string username, string password, int usertype, string FullName, string Address, string phoneNo)
        {
            string sql = "insert into tblUser values(@a,@b,@c,@d,@e,@f)";
            SqlParameter[] param = new SqlParameter[] { 
                new SqlParameter("@a",username),
                new SqlParameter("@b",password),
                new SqlParameter("@c",usertype),
                new SqlParameter("@d",FullName),
                new SqlParameter("@e",Address),
                new SqlParameter("@f",phoneNo)
            };

            int i = DAO.IUD(sql,param);
            return i;

        }
        public int UpdateUser(string username, string password, int usertype, string FullName, string Address, string phoneNo, int userId)
        {
            string sql = "Update tblUser set username=@a,password=@b,usertype=@c,fullname=@d,Address=@e,phoneNo=@f where UserId=@g";
            SqlParameter[] param = new SqlParameter[] { 
                new SqlParameter("@a",username),
                new SqlParameter("@b",password),
                new SqlParameter("@c",usertype),
                new SqlParameter("@d",FullName),
                new SqlParameter("@e",Address),
                new SqlParameter("@f",phoneNo),
                new SqlParameter("@g",userId)
            };

            int i = DAO.IUD(sql, param);
            return i;
        }

        public int DeleteUser(int UserId)
        {
            string sql = "delete from tblUser where userId=@a";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@a",UserId)
            };
            return DAO.IUD(sql,param);
        }
    }
}
