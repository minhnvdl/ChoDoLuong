using ChoDoLuong.Web.Areas.Manage.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ChoDoLuong.Web.Areas.Manage.DAO
{
    public class CustomerDAO
    {
        private chodoluongdbEntities context = new chodoluongdbEntities();
        public bool Login(string username, string password)
        {
            object[] sqlParams =
            {
                new SqlParameter("username",username),
                new SqlParameter("password",password)
            };
            var res = context.Database.SqlQuery<bool>("sp_Login @username, @password", sqlParams).SingleOrDefault();
            return res;
        }
    }
}