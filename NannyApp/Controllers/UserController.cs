using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using NannyApp.Model;
using NannyApp.Model.Repositories;
using NannyApp.Model.Factories;using NannyApp.DAL;
using NannyApp.DAL.Repositories;
using NHibernate;

namespace NannyApp.Controllers
{
    public class UserController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Parent u)
        {
            if (ModelState.IsValid) // this is check validity
            {
                Nanny checkNanny = new Nanny();
                Parent checkParrent = new Parent();
                Admin checkAdmin = new Admin();
                UserRepository UserRepository = new UserRepository();
                checkNanny = UserRepository.GetNanny(u.Username, u.Password);
                checkParrent = UserRepository.GetParent(u.Username, u.Password);
                checkAdmin = UserRepository.GetAdmin(u.Username, u.Password);

                if (checkNanny != null)
                {
                    Session["Id"] = checkNanny.Id;
                    Session["Username"] = checkNanny.Username;
                    Session["UserType"] = UserType.NANNY;

                    return RedirectToAction("Index", "Home");
                }
                else if (checkParrent != null)
                {
                    Session["Id"] = checkParrent.Id;
                    Session["Username"] = checkParrent.Username;
                    Session["UserType"] = UserType.PARENT;

                    return RedirectToAction("Index", "Home");
                }
                else if (checkAdmin != null)
                {
                    Session["Id"] = checkAdmin.Id;
                    Session["Username"] = checkAdmin.Username;
                    Session["UserType"] = UserType.ADMIN;

                    return RedirectToAction("Index", "Home");
                }
            }
            return View(u);
        }

        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}
