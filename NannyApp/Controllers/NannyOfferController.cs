﻿using System;
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
    public class NannyOfferController : Controller
    {
        // GET: Offer
        public ActionResult Index()
        {
            return View();
        }

        // GET: Offer/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(NannyOffer offer)
        {
            try
            {
                Nanny nanny = new Nanny();
                UserRepository UserRepository = new UserRepository();
                //nanny = UserRepository.GetNanny(Session['Id']);

                BabySittingPlace place = BabySittingPlace.NANNYS_PLACE;
                if (offer.BabySittingPlace.Equals(BabySittingPlace.NANNYS_PLACE))
                {
                    place = BabySittingPlace.NANNYS_PLACE;
                }
                else if (offer.BabySittingPlace.Equals(BabySittingPlace.PARENTS_PLACE))
                {
                    place = BabySittingPlace.PARENTS_PLACE;
                }
                NannyOffer newOffer = (NannyOffer)OfferFactory.CreateNannyOffer(offer.Price, offer.Experience, place, offer.Notice, offer.StartTime, offer.EndTime, offer.City, offer.Address, offer.ChildrenNumber, offer.MinChildrenAge, offer.MaxChildrenAge, offer.Deadline, offer.Nanny);
                nanny.AddOffer(newOffer);
                UserRepository.UpdateUser(nanny);

                return RedirectToAction("Index", "Nanny");
            }
            catch
            {
                return View();
            }
        }

        // GET: Offer/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Offer/Edit/5
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

        // GET: Offer/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Offer/Delete/5
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