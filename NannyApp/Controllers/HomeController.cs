using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using NannyApp.Model;
using NannyApp.Model.Repositories;
using NannyApp.DAL;

namespace NannyApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        //public ActionResult Test()
        //{
        //    Review review = new Review();
        //    review.Id = 1;
        //    review.Grade = 4;
        //    review.ReviewText = "dadasda";

        //    return View(review);
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Login(User u)
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