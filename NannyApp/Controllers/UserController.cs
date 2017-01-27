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

namespace NannyApp.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            return View();
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
                 if(user.Gender.Equals(Gender.FEMALE)){
                     gender = Gender.FEMALE;
                } else if(user.Gender.Equals(Gender.MALE)){
                     gender = Gender.MALE;
                }
                Nanny newNanny = (Nanny)UserFactory.CreateNanny(user.Username, user.Password, user.Name, user.Surname, gender, user.Contact, UserType.NANNY, user.Education, user.Smoking, user.Pets, user.Car, user.ExtraServices, user.ExtraQualification);
                UserRepository.AddUser(newNanny);

                return RedirectToAction("Home/Index");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult CreateParent()
        {
            return View();

        }

        [HttpPost]
        public ActionResult CreateParent(Parent user)
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
                Parent newParent = (Parent)UserFactory.CreateParent(user.Username, user.Password, user.Name, user.Surname, gender, user.Contact, UserType.PARENT);
                UserRepository.AddUser(newParent);

                return RedirectToAction("Home/Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: User/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: User/Delete/5
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
