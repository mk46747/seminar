using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NannyApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Login(korisnik u)
        //{
        //    // this action is for handle post (login)
        //    if (ModelState.IsValid) // this is check validity
        //    {
        //        using (Entities dc = new Entities())
        //        {
        //            var v = dc.korisnik.Where(a => a.email.Equals(u.email) && a.lozinka.Equals(u.lozinka)).FirstOrDefault();
        //            if (v != null)
        //            {
        //                Session["LogedUserID"] = v.idKorisnik.ToString();
        //                Session["LogedUserFullname"] = v.korisnickoIme.ToString();
        //                Session["User"] = v.vrstaKorisnik.ToString();

        //                return RedirectToAction("Index", "Korisnik");
        //            }
        //        }
        //    }
        //    return View(u);
        //}

        //public ActionResult Logout()
        //{
        //    Session.Clear();
        //    return RedirectToAction("Index", "Home");
        //}
    }
}