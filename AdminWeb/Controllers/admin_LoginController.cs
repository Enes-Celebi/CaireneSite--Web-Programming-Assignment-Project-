using System;
using AdminWeb.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminWeb.Controllers
{
    public class admin_LoginController : Controller
    {
        DBEntities db = new DBEntities();
        // GET: admin_Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Admin login)
        {
            if (ModelState.IsValid)
            {
                var model = (from m in db.Admins
                             where m.UserName == login.UserName && m.Password == login.Password
                             select m).Any();
                if (model)
                {
                    var loginInfo = db.Admins.Where(x => x.UserName == login.UserName && x.Password == login.Password).FirstOrDefault();

                    Session["username"] = loginInfo.UserName;
                    TemData.AdminID = loginInfo.AdminID;
                    return RedirectToAction("Index", "Dashboard");
                }
            }
            return View("Index");
        }
        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Index", "admin_Login");
        }
    }
}