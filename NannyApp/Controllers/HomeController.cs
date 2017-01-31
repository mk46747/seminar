using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NannyApp.Model;
using NannyApp.Models;
using NannyApp.Model.Repositories;
using NannyApp.Model.Factories;
using NannyApp.DAL;
using NannyApp.DAL.Repositories;
using NHibernate;

namespace NannyApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            OfferRepository offers = new OfferRepository();
            List<OffersViewModel> offersList = new List<OffersViewModel>();
            IList<NannyOffer> nannyOffers = offers.GetAllNannyOffers();
            IList<ParentOffer> parentOffers = offers.GetAllParentOffers();

            foreach (var nannyOffer in nannyOffers)
            {
                if(nannyOffer.Opened.Equals("true")){
                offersList.Add(new OffersViewModel
                {
                    IdOffer = nannyOffer.Id,
                    Nanny = nannyOffer.Nanny,
                    Price = nannyOffer.Price,
                    City = nannyOffer.City,
                    Deadline = nannyOffer.Deadline
                });
            }
            }

            foreach (var parentOffer in parentOffers)
            {
                if (parentOffer.Opened.Equals("true"))
                { 
                offersList.Add(new OffersViewModel
                {
                    IdOffer = parentOffer.Id,
                    Parent = parentOffer.Parent,
                    Price = parentOffer.Price,
                    City = parentOffer.City,
                    Deadline = parentOffer.Deadline
                });
                }
            }

            return View(offersList);
            //return View();
        }


    }
}