using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NannyApp.Model;
using NannyApp.Model.Repositories;
using NannyApp.DAL.Repositories;
using System.Diagnostics;
using System.Collections.Generic;

namespace NannyApp.DAL.Tests
{
    [TestClass]
    public class OfferTests
    {
        [TestMethod]
        public void Offer_CreateInstance()
        {
            Parent parent = new Parent("AAljic", "aaaaa", "Ana", "Aljić", Gender.FEMALE, "095 274 8356", UserType.PARENT, 
                new List<ParentOffer>(), new List<Cooperation>());
            Offer parentOffer = new ParentOffer(200, "viša stručna sprema", BabySittingPlace.PARENTS_PLACE, "notice", 
                new DateTime(2017, 2, 1, 10, 0, 0), new DateTime(2017, 2, 1, 18, 0, 0), "Zagreb", "Mihanovićeva 7", 2, 8, 10, 
                new DateTime(2017, 1, 30), false, parent);
            parent.AddOffer((ParentOffer)parentOffer);

            UserRepository repository = new UserRepository();
            repository.AddUser(parent);
            OfferRepository offerRepository = new OfferRepository();
            ParentOffer fetchedParentOffer = offerRepository.GetAllParentOffers()[0];
            Debug.Assert(parentOffer == fetchedParentOffer);  
        }

        [TestMethod]
        public void Offer_DeleteInstance()
        {
            Nanny nanny = new Nanny("IMandic", "55555", "Ivana", "Mandić", Gender.FEMALE, "091 626 409", UserType.NANNY,
                "Bachelor of philosophy", true, false, true, null, null, new List<NannyOffer>(), new List<Cooperation>());
            Offer nannyOffer = new NannyOffer(50, "2 years of caregiving", BabySittingPlace.NANNYS_PLACE, null, 
                new DateTime(2017, 2, 1, 8, 0, 0), new DateTime(2017, 2, 1, 20, 0, 0), "Zagreb", null, 3, 6, 11,
                new DateTime(2017, 1, 30), false, nanny);
            nanny.AddOffer((NannyOffer)nannyOffer);

            UserRepository repository = new UserRepository();
            repository.AddUser(nanny);
            nanny.RemoveOffer((NannyOffer)nannyOffer);
            repository.UpdateUser(nanny);
            OfferRepository offerRepository = new OfferRepository();
            List<NannyOffer> fetchedNannyOffers = (List<NannyOffer>)offerRepository.GetAllNannyOffers();
            Debug.Assert(fetchedNannyOffers == null);
        }
    }
}
