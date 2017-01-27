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

        // GET: User/Create
        public ActionResult Create()
        {
            return View();

        }
        // POST: User/Create
        [HttpPost]
        public ActionResult Create(User user)
        {
            try
            {
                UserRepository UserRepository = new UserRepository();

                if (user.UserType.Equals(UserType.PARENT))
                {
                    User newUser = UserFactory.CreateParent(user.Username, user.Password, user.Name, user.Surname, user.Gender, user.Contact, UserType.PARENT);
                    UserRepository.AddUser(newUser);
                }
                else if (user.UserType.Equals(UserType.NANNY))
                {
                    //User newUser = UserFactory.CreateNanny(user.Username, user.Password, user.Name, user.Surname, user.Gender, user.Contact, UserType.NANNY);
                    //UserRepository.AddUser(newUser);
                }
                //User newUser = UserFactory.CreateAccount(Name, AccType, Balance);

                //userRepository.AddUser(newUser);

                return RedirectToAction("Index");
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
