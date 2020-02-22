using OnlineLeaveManagement.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineLeaveManagementSystem.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Login login)
        {
            if (string.IsNullOrEmpty(login.UserName))
            {
                ModelState.AddModelError("userName", "UserName is required");
            }
            if (string.IsNullOrEmpty(login.Password))
            {
                ModelState.AddModelError("password", "Password is required");
            }
            if (ModelState.IsValid)
            {
                return RedirectToAction("AddEmployee");
            }
            return View(login);
        }
    }
}