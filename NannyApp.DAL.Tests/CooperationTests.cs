using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NannyApp.Model;
using System.Collections.Generic;
using NannyApp.Model.Factories;
using NannyApp.DAL.Repositories;
using System.Diagnostics;

namespace NannyApp.DAL.Tests
{
    [TestClass]
    public class CooperationTests
    {
        [TestMethod]
        public void Cooperation_CreateInstance()
        {
            Parent parent = new Parent("DSeric", "6768", "Dario", "Šerić", Gender.MALE, "01 624 580", UserType.PARENT,
                new List<ParentOffer>(), new List<Cooperation>());
            Nanny nanny = new Nanny("IJovic", "09876", "Ivana", "Jović", Gender.FEMALE, "091 542 106",
                UserType.NANNY, "Bachelor of english", false, false, true, "", "",
                new List<NannyOffer>(), new List<Cooperation>());
            //the parent offers a job
            Offer parentOffer = new ParentOffer(100, "bachelor or higher", BabySittingPlace.PARENTS_PLACE, "smth", 
                new DateTime(2017, 2, 5, 9, 0, 0), new DateTime(2017, 2, 5, 17, 0, 0), "Zagreb", "Branimirova 18",
                2, 7, 9, new DateTime(2017, 1, 31), false, parent);
            parent.AddOffer((ParentOffer)parentOffer);
            //the nanny applies for the job, thus creating a cooperation
            Cooperation cooperation = CooperationFactory.CreateCooperation(nanny, parent, parentOffer);
            //the parent accepts
            cooperation.Status = CooperationStatus.ACCEPTED;
            parent.AddCooperation(cooperation);
            nanny.AddCooperation(cooperation);
            
            UserRepository repository = new UserRepository();
            repository.AddUser(parent);
            repository.AddUser(nanny);

            CooperationRepository coopRepository = new CooperationRepository();
            //coopRepository.AddCooperation(cooperation);

            Cooperation fetchedCooperation = coopRepository.GetAllCooperations()[0];
            Debug.Assert(fetchedCooperation == cooperation);//*/
        }
    }
}
