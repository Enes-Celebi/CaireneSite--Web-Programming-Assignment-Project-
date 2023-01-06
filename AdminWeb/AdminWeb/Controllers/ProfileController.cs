using System;
using AdminWeb.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;

namespace AdminWeb.Controllers
{
    public class ProfileController : Controller
    {
        DBEntities db = new DBEntities();
        // GET: Profile
        public ActionResult Index()
        {
            return View(db.Admins.Find(TemData.AdminID));

        }

        public ActionResult Edit(int id)
        {
            Admin emp = db.Admins.Find(id);
            if (emp == null)
            {
                return HttpNotFound();
            }
            return View(emp);
        }

        [HttpPost]
        public ActionResult Edit(Admin emp)
        {
            if (ModelState.IsValid)
            {
                db.Entry(emp).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}