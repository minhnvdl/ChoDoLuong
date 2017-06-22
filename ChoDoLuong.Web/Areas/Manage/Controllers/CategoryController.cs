using ChoDoLuong.Admin.Models.DTO;
using ChoDoLuong.Web.Areas.Manage.DAO;
using ChoDoLuong.Web.Areas.Manage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChoDoLuong.Web.Areas.Manage.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Manage/Category
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult GetAllCategory()
        {
                int Start = int.Parse(Request["start"]);
                int Length = int.Parse(Request["length"]);
                int draw = int.Parse(Request["draw"]);
                var ordercolum = int.Parse(Request["order[0][column]"]);
                var orderasc = Request["order[0][dir]"].ToString();
                dynamic orderby = Request["columns[" + ordercolum + "][data]"].ToString();

                int Total = 0;

                CategoryDAO dao = new CategoryDAO();

                List<CategoryDTO> lst = dao.GetListCSKHByCondition(Start, Length, orderby, orderasc, out Total);
                return Json(new { draw = draw, recordsTotal = Total, recordsFiltered = Total, data = lst });
        }
    }
}