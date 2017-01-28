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
    public class ParentOfferController : Controller
    {
        // GET: ParentOffer
        public ActionResult Index()
        {
            return View();
        }

        // GET: ParentOffer/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ParentOffer/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(ParentOffer offer)
        {
            try
            {
                Parent parent = new Parent();
                UserRepository UserRepository = new UserRepository();
                //parent = UserRepository.GetParent(Session['Id']);

                BabySittingPlace place = BabySittingPlace.NANNYS_PLACE;
                if (offer.BabySittingPlace.Equals(BabySittingPlace.NANNYS_PLACE))
                {
                    place = BabySittingPlace.NANNYS_PLACE;
                }
                else if (offer.BabySittingPlace.Equals(BabySittingPlace.PARENTS_PLACE))
                {
                    place = BabySittingPlace.PARENTS_PLACE;
                }
                ParentOffer newOffer = (ParentOffer)OfferFactory.CreateParentOffer(offer.Price, offer.Experience, place, offer.Notice, offer.StartTime, offer.EndTime, offer.City, offer.Address, offer.ChildrenNumber, offer.MinChildrenAge, offer.MaxChildrenAge, offer.Deadline, offer.Parent);
                parent.AddOffer(newOffer);
                UserRepository.UpdateUser(parent);

                return RedirectToAction("Index", "Parent");
            }
            catch
            {
                return View();
            }
        }

        // GET: ParentOffer/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ParentOffer/Edit/5
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

        // GET: ParentOffer/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ParentOffer/Delete/5
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
