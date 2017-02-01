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

                return RedirectToAction("Details", new { IdOffer = newOffer.Id });
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int IdOffer)
        {
            OfferRepository OfferRepository = new OfferRepository();
            NannyOffer NannyOffer = new NannyOffer();
            NannyOffer = OfferRepository.GetNannyOffer(IdOffer);
            if (NannyOffer == null)
            {
                return HttpNotFound();
            }

            return View(NannyOffer);
        }

        [HttpPost]
        public ActionResult Edit(int IdOffer, NannyOffer offer)
        {
            if (ModelState.IsValid)
            {
                UserRepository UserRepository = new UserRepository();
                int IdNanny = Convert.ToInt32(Session["Id"]);
                Nanny nanny = UserRepository.GetNanny(IdNanny);
                NannyOffer NannyOffer = GetNannyOffer(nanny.Offers, offer.Id);

                NannyOffer.Address = offer.Address;
                NannyOffer.BabySittingPlace = offer.BabySittingPlace;
                NannyOffer.ChildrenNumber = offer.ChildrenNumber;
                NannyOffer.City = offer.City;
                NannyOffer.Deadline = offer.Deadline;
                NannyOffer.EndTime = offer.EndTime;
                NannyOffer.Experience = offer.Experience;
                NannyOffer.Id = offer.Id;
                NannyOffer.MaxChildrenAge = offer.MaxChildrenAge;
                NannyOffer.MinChildrenAge = offer.MinChildrenAge;
                NannyOffer.Nanny = nanny;
                NannyOffer.Notice = offer.Notice;
                NannyOffer.Opened = offer.Opened;
                NannyOffer.Price = offer.Price;
                NannyOffer.StartTime = offer.StartTime;
                
                UserRepository.UpdateUser(nanny);

                return RedirectToAction("Index");
            }
            return View(offer);
        }
        private NannyOffer GetNannyOffer(IList<NannyOffer> Offers, int id){
            foreach (var o in Offers)
            {
                if (o.Id.Equals(id))
                {
                    return o;
                }
            }
            return null;
        }
        public ActionResult Delete(int IdOffer)
        {
            OfferRepository OfferRepository = new OfferRepository();
            NannyOffer NannyOffer = new NannyOffer();
            NannyOffer = OfferRepository.GetNannyOffer(IdOffer);
            if (NannyOffer == null)
            {
                return HttpNotFound();
            }

            return View(NannyOffer);
        }

        [HttpPost]
        public ActionResult Delete(int IdOffer, NannyOffer offer)
        {
            if (ModelState.IsValid)
            {
                Nanny nanny = new Nanny();
                UserRepository UserRepository = new UserRepository();
                int id = Convert.ToInt32(Session["Id"]);
                nanny = UserRepository.GetNanny(id);
                NannyOffer NannyOffer = GetNannyOffer(nanny.Offers, offer.Id);
                nanny.RemoveOffer(NannyOffer);

                UserRepository.UpdateUser(nanny);

                return RedirectToAction("MyOffers");
            }
            return View(offer);
        }

        public ActionResult MyOffers()
        {
            UserRepository UserRepository = new UserRepository();
            if (Session["Id"] != null) { 
                int IdNanny = Convert.ToInt32(Session["Id"]);
                Nanny nanny = UserRepository.GetNanny(IdNanny);
                return View(nanny.Offers);
            }
            else
            {
                return RedirectToAction("Login", "User");
            }  
        }
    }
}
