using ChoDoLuong.Web.Areas.Manage.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChoDoLuong.Web.Areas.Manage.Controllers
{
    public class HomeController : Controller
    {
        // GET: Manage/Home
        public ActionResult Index()
        {
           if(SessionHelper.GetSession().Username != null)
            {
                return View();
            }
            else
            {
                return Redirect("/Manage/Login");
            }
            
        }
    }
}