using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CustomLogin.Models;

namespace CustomLogin.Controllers
{

    public class HomeController : Controller
    {
        private WebDevTestEntities db = new WebDevTestEntities();

        // GET: Home
        public ActionResult Index()
        {

            ViewBag.roleId = new SelectList(db.dogie_Role_tbl, "roleId", "roleName");
            return View();
        }

        // POST: Home/Register
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        [HttpPost]
        public ActionResult Register([Bind(Include = "username,password,email,roleId")]Dogie_user_tbl dogie_user)
        {
            if (ModelState.IsValid)
            {
                dogie_user.createdBy = DateTime.Now;
                db.Dogie_user_tbl.Add(dogie_user);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.roleId = new SelectList(db.dogie_Role_tbl, "roleId", "roleName");
            return View(dogie_user);
        }

        // GET: Role
        public ActionResult Role()
        {
            return View();
        }

        
    }
}