using ChoDoLuong.Web.Areas.Manage.Code;
using ChoDoLuong.Web.Areas.Manage.DAO;
using ChoDoLuong.Web.Areas.Manage.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChoDoLuong.Web.Areas.Manage.Controllers
{
    public class LoginController : Controller
    {
        // GET: Manage/Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(LoginDTO model)
        {
            var result = new CustomerDAO().Login(model.Username, model.Password);
            if(result && ModelState.IsValid)
            {
                SessionHelper.SetSession(new UserSession() { Username = model.Username });
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "Tên đăng nhập hoặc mật khẩu không đúng");
            }
            return View(model);
        }
        public ActionResult Logout()
        {
            SessionHelper.SetSession(new UserSession() { Username = null });
            return Redirect("/Manage/Login");
        }
    }
}