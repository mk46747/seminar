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
        public ActionResult Index()
        {
            UserRepository parents = new UserRepository();
            return View(parents.GetAllParents());
        }

        public ActionResult Details(int id)
        {
            UserRepository UserRepository = new UserRepository();
            Parent Parent = new Parent();
            Parent = UserRepository.GetParent(id);

            return View(Parent);
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

                return RedirectToAction("Login", "User");
            }
            catch
            {
                return View();
            }
        }


        // GET: Parent/Edit/5
        public ActionResult Edit(int id)
        {
            UserRepository UserRepository = new UserRepository();
            Parent parent = new Parent();
            parent = UserRepository.GetParent(id);
            if (parent == null)
            {
                return HttpNotFound();
            }

            return View(parent);
        }

        // POST: Parent/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Parent parent)
        {
            if (ModelState.IsValid)
            {
                UserRepository UserRepository = new UserRepository();
                UserRepository.UpdateUser(parent);
                return RedirectToAction("Index");
            }

            return View(parent);
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
