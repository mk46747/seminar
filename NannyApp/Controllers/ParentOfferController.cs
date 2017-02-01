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
            OfferRepository offers = new OfferRepository();
            IList<ParentOffer> parentOffers = offers.GetAllParentOffers();

            return View(parentOffers);
        }

        public ActionResult Details(int IdOffer)
        {
            OfferRepository offer = new OfferRepository();
            ParentOffer ParentOffer = new ParentOffer();
            ParentOffer = offer.GetParentOffer(IdOffer);

            return View(ParentOffer);
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
                int id = Convert.ToInt32(Session["Id"]);
                parent = UserRepository.GetParent(id);

                BabySittingPlace place = BabySittingPlace.NANNYS_PLACE;
                if (offer.BabySittingPlace.Equals(BabySittingPlace.NANNYS_PLACE))
                {
                    place = BabySittingPlace.NANNYS_PLACE;
                }
                else if (offer.BabySittingPlace.Equals(BabySittingPlace.PARENTS_PLACE))
                {
                    place = BabySittingPlace.PARENTS_PLACE;
                }
                ParentOffer newOffer = (ParentOffer)OfferFactory.CreateParentOffer(offer.Price, offer.Experience, place, offer.Notice, offer.StartTime, offer.EndTime, offer.City, offer.Address, offer.ChildrenNumber, offer.MinChildrenAge, offer.MaxChildrenAge, offer.Deadline, offer.Opened, parent);
                parent.AddOffer(newOffer);
                UserRepository.UpdateUser(parent);

                return RedirectToAction("Details", new { IdOffer = newOffer.Id});
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int IdOffer)
        {
            OfferRepository OfferRepository = new OfferRepository();
            ParentOffer ParentOffer = new ParentOffer();
            ParentOffer = OfferRepository.GetParentOffer(IdOffer);
            if (ParentOffer == null)
            {
                return HttpNotFound();
            }

            return View(ParentOffer);
        }

        [HttpPost]
        public ActionResult Edit(int IdOffer, ParentOffer offer)
        {
            if (ModelState.IsValid)
            {
                UserRepository UserRepository = new UserRepository();
                int IdParent = Convert.ToInt32(Session["Id"]);
                Parent parent = UserRepository.GetParent(IdParent);
                ParentOffer ParentOffer = GetParentOffer(parent.Offers, offer.Id);

                ParentOffer.Address = offer.Address;
                ParentOffer.BabySittingPlace = offer.BabySittingPlace;
                ParentOffer.ChildrenNumber = offer.ChildrenNumber;
                ParentOffer.City = offer.City;
                ParentOffer.Deadline = offer.Deadline;
                ParentOffer.EndTime = offer.EndTime;
                ParentOffer.Experience = offer.Experience;
                ParentOffer.Id = offer.Id;
                ParentOffer.MaxChildrenAge = offer.MaxChildrenAge;
                ParentOffer.MinChildrenAge = offer.MinChildrenAge;
                ParentOffer.Parent = parent;
                ParentOffer.Notice = offer.Notice;
                ParentOffer.Opened = offer.Opened;
                ParentOffer.Price = offer.Price;
                ParentOffer.StartTime = offer.StartTime;

                UserRepository.UpdateUser(parent);

                return RedirectToAction("Details", new { IdOffer = offer.Id });
            }
            return View(offer);
        }

        private ParentOffer GetParentOffer(IList<ParentOffer> Offers, int id)
        {
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
            ParentOffer ParentOffer = new ParentOffer();
            ParentOffer = OfferRepository.GetParentOffer(IdOffer);
            if (ParentOffer == null)
            {
                return HttpNotFound();
            }

            return View(ParentOffer);
        }

        [HttpPost]
        public ActionResult Delete(int IdOffer, ParentOffer offer)
        {
            if (ModelState.IsValid)
            {
                Parent parent = new Parent();
                UserRepository UserRepository = new UserRepository();
                int id = Convert.ToInt32(Session["Id"]);
                parent = UserRepository.GetParent(id);
                ParentOffer ParentOffer = GetParentOffer(parent.Offers, offer.Id);
                parent.RemoveOffer(ParentOffer);

                UserRepository.UpdateUser(parent);

                return RedirectToAction("MyOffers");
            }
            return View(offer);
        }

        public ActionResult MyOffers()
        {
            UserRepository UserRepository = new UserRepository();
            if (Session["Id"] != null)
            {
                int IdParent = Convert.ToInt32(Session["Id"]);
                Parent Parent = UserRepository.GetParent(IdParent);
                return View(Parent.Offers);
            }
            else
            {
                return RedirectToAction("Login", "User");
            }
        }
    }
}
