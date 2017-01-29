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
                offersList.Add(new OffersViewModel
                {
                    NannyOffer = nannyOffer
                });
            }
            foreach (var parentOffer in parentOffers)
            {
                offersList.Add(new OffersViewModel
                {
                    ParentOffer = parentOffer
                });
            }
            return View(offersList.OrderByDescending(o => o.ParentOffer.Deadline).OrderByDescending(o => o.NannyOffer.Deadline));
            //return View();
        }


    }
}