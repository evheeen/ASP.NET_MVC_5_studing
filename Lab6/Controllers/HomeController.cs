using Lab6.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Lab6.Controllers
{
    public class HomeController : Controller
    {
        DB_Content dB_Content = new DB_Content();
        public ActionResult Index()
        {
            IEnumerable<DB_Users> dB_Users = dB_Content.DB_Users;
            ViewBag.DB_Users = dB_Users;

            IEnumerable<DB_Roles> dB_Roles = dB_Content.DB_Roles;
            ViewBag.DB_Roles = dB_Roles;

            IEnumerable<DB_Intermediate> dB_Intermediate = dB_Content.DB_Intermediates;
            ViewBag.DB_Intermediate = dB_Intermediate;
            return View();
        }

        public ActionResult AddUser()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddUser([Bind(Include = "UserID, Name, Surname, Login, Password, Email")] DB_Users dB_Users)
        {
            if (ModelState.IsValid)
            {
                dB_Content.DB_Users.Add(dB_Users);
                dB_Content.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dB_Users);
        }
    }
}