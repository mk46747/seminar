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
    public class ParentController : Controller
    {
        // GET: Parent
        public ActionResult Index()
        {
            return View();
        }

        // GET: Parent/Details/5
        public ActionResult Details(int id)
        {
            return View();
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
                UserType type = UserType.PARENT;
                UserRepository UserRepository = new UserRepository();
                if (user.Gender.Equals(Gender.FEMALE))
                {
                    gender = Gender.FEMALE;
                }
                else if (user.Gender.Equals(Gender.MALE))
                {
                    gender = Gender.MALE;
                }
                Parent newParent = (Parent)UserFactory.CreateParent(user.Username, user.Password, user.Name, user.Surname, gender, user.Contact, type);
                UserRepository.AddUser(newParent);

                return RedirectToAction("Index", "Home");
            }
            catch
            {
                return View();
            }
        }


        // GET: Parent/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Parent/Edit/5
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

        // GET: Parent/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Parent/Delete/5
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
