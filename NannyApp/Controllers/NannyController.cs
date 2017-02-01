using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NannyApp.Model;
using NannyApp.Model.Repositories;
using NannyApp.Model.Factories;
using NannyApp.DAL;
using NannyApp.DAL.Repositories;
using NHibernate;
using System.Net;

namespace NannyApp.Controllers
{
    public class NannyController : Controller
    {
        public ActionResult Index()
        {
            UserRepository nannies = new UserRepository();
            return View(nannies.GetAllNannies());
        }

        public ActionResult Details(int id)
        {
            UserRepository UserRepository = new UserRepository();
            Nanny Nanny = new Nanny();
            Nanny = UserRepository.GetNanny(id);

            return View(Nanny);
        }

        public ActionResult CreateNanny()
        {
            return View();

        }

        [HttpPost]
        public ActionResult CreateNanny(Nanny user)
        {
            try
            {

                Gender gender = Gender.MALE;
                UserRepository UserRepository = new UserRepository();
                if (user.Gender.Equals(Gender.FEMALE))
                {
                    gender = Gender.FEMALE;
                }
                else if (user.Gender.Equals(Gender.MALE))
                {
                    gender = Gender.MALE;
                }
                Nanny newNanny = (Nanny)UserFactory.CreateNanny(user.Username, user.Password, user.Name, user.Surname, gender, user.Contact, UserType.NANNY, user.Education, user.Smoking, user.Pets, user.Car, user.ExtraServices, user.ExtraQualification);
                UserRepository.AddUser(newNanny);

                return RedirectToAction("Login", "User");
            }
            catch
            {
                return View();
            }
        }

        // GET: Nanny/Edit/5
        public ActionResult Edit(int id)
        {
            UserRepository UserRepository = new UserRepository();
            Nanny nanny = new Nanny();
            nanny = UserRepository.GetNanny(id);
            if (nanny == null)
            {
                return HttpNotFound();
            }
            
            return View(nanny);
        }

        // POST: Nanny/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Nanny nanny)
        {
            if (ModelState.IsValid)
            {
                //UserRepository UserRepository = new UserRepository();
                //UserRepository.UpdateUser(nanny);
                //return RedirectToAction("Index");
            }
            
            return View(nanny);
        }

        // GET: Nanny/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Nanny/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
