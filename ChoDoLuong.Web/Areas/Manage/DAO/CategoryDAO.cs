using ChoDoLuong.Admin.Models.DTO;
using ChoDoLuong.Web.Areas.Manage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChoDoLuong.Web.Areas.Manage.DAO
{
    public class CategoryDAO
    {
        chodoluongdbEntities data = new chodoluongdbEntities();
        public List<CategoryDTO> GetListCSKHByCondition(int Start, int pageSize, string Orderby, string orderbyType,out int Total)
        {
            Total = (int)PreQuerySearchCSKH(Start, pageSize, Orderby, orderbyType, "count");
            return (List<CategoryDTO>)PreQuerySearchCSKH(Start, pageSize, Orderby, orderbyType, "search");
        }
        public object PreQuerySearchCSKH(int start, int pageSize, string Orderby, string orderbyType,string mode)
        {
            string sql = "sp_GetAllCategory ";
            sql = sql + string.Format("'{0}', ", Orderby);
            sql = sql + string.Format("'{0}', ", orderbyType);
            sql = sql + string.Format("'{0}', ", mode);
            sql = sql + string.Format("'{0}', ", start);
            sql = sql + string.Format("'{0}'", start + pageSize);
            try
            {
                if (mode == "search")
                {
                    return data.Database.SqlQuery<CategoryDTO>(sql).ToList();
                }
                if (mode == "count")
                {
                    return data.Database.SqlQuery<int>(sql).ToList().FirstOrDefault();
                }
            }
            catch (Exception ex)
            {

                throw new Exception(sql, ex);
            }

            return null;

        }
    }
}