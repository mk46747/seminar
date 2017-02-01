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
    public class NannyOfferController : Controller
    {
        public ActionResult Index()
        {
            OfferRepository offers = new OfferRepository();
            IList<NannyOffer> nannyOffers = offers.GetAllNannyOffers();

            return View(nannyOffers);
        }

        public ActionResult Details(int IdOffer)
        {
            OfferRepository offer = new OfferRepository();
            NannyOffer NannyOffer = new NannyOffer();
            NannyOffer = offer.GetNannyOffer(IdOffer);

            return View(NannyOffer);
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
                int id = Convert.ToInt32(Session["Id"]);
                nanny = UserRepository.GetNanny(id);

                BabySittingPlace place = BabySittingPlace.NANNYS_PLACE;
                if (offer.BabySittingPlace.Equals(BabySittingPlace.NANNYS_PLACE))
                {
                    place = BabySittingPlace.NANNYS_PLACE;
                }
                else if (offer.BabySittingPlace.Equals(BabySittingPlace.PARENTS_PLACE))
                {
                    place = BabySittingPlace.PARENTS_PLACE;
                }
                NannyOffer newOffer = (NannyOffer)OfferFactory.CreateNannyOffer(offer.Price, offer.Experience, place, offer.Notice, offer.StartTime, offer.EndTime, offer.City, offer.Address, offer.ChildrenNumber, offer.MinChildrenAge, offer.MaxChildrenAge, offer.Deadline, offer.Opened, nanny);
                nanny.AddOffer(newOffer);
                UserRepository.UpdateUser(nanny);

                return RedirectToAction("Index", "Nanny");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            OfferRepository OfferRepository = new OfferRepository();
            NannyOffer NannyOffer = new NannyOffer();
            NannyOffer = OfferRepository.GetNannyOffer(id);
            if (NannyOffer == null)
            {
                return HttpNotFound();
            }

            return View(NannyOffer);
        }

        [HttpPost]
        public ActionResult Edit(int id, NannyOffer offer)
        {
            //if (ModelState.IsValid)
            //{
            //    OfferRepository OfferRepository = new OfferRepository();
            //    OfferRepository.UpdateNannyOffer(offer);
            //    return RedirectToAction("Index");
            //}
            //ovo izgleda ne radi, ne update-a nanny?
            return View(offer);
        }

        public ActionResult Delete(int id)
        {
            OfferRepository OfferRepository = new OfferRepository();
            NannyOffer NannyOffer = new NannyOffer();
            NannyOffer = OfferRepository.GetNannyOffer(id);
            if (NannyOffer == null)
            {
                return HttpNotFound();
            }

            return View(NannyOffer);
        }

        [HttpPost]
        public ActionResult Delete(int id, NannyOffer NannyOffer)
        {
            Nanny nanny = new Nanny();
            UserRepository UserRepository = new UserRepository();
            nanny = UserRepository.GetNanny(NannyOffer.Nanny.Id);

            nanny.AddOffer(NannyOffer);
            UserRepository.UpdateUser(nanny);

            return RedirectToAction("Index", "Nanny");
        }
    }
}
