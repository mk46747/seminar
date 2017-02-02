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
    public class CooperationController : Controller
    {
        public ActionResult Index(int id)
        {
            CooperationRepository CooperationRepository = new CooperationRepository();
            IList<Cooperation> AllCooperations = CooperationRepository.GetAllCooperations();
            List<Cooperation> list = new List<Cooperation>();

            foreach(var c in AllCooperations){
                if (c.CooperationAcceptee.Id.Equals(id) || c.CooperationInitiator.Id.Equals(id))
                {
                    list.Add(c);
                }
            }
            return View(list);
        }


        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateForParentOffer(int IdParentOffer)
        {
            int IdNanny = Convert.ToInt32(Session["Id"]);
            if (ModelState.IsValid)
            {
                UserRepository UserRepository = new UserRepository();
                OfferRepository OfferRepository = new OfferRepository();

                Nanny Initiator = UserRepository.GetNanny(IdNanny);
                ParentOffer ParentOffer = OfferRepository.GetParentOffer(IdParentOffer);
                Parent Aceptee = UserRepository.GetParent(ParentOffer.Parent.Id);

                Cooperation Cooperation = CooperationFactory.CreateCooperation(Initiator, Aceptee, ParentOffer);
                Initiator.AddCooperation(Cooperation);
                Aceptee.AddCooperation(Cooperation);

                UserRepository.UpdateUser(Aceptee);
                UserRepository.UpdateUser(Initiator);

                return RedirectToAction("Create");
            }
            return View();   
        }

        [HttpPost]
        public ActionResult CreateForNannyOffer(int IdParent, NannyOffer NannyOffer)
        {
            if (ModelState.IsValid)
            {
                UserRepository UserRepository = new UserRepository();
                Nanny Aceptee = UserRepository.GetNanny(NannyOffer.Nanny.Id);
                Parent Initiator = UserRepository.GetParent(IdParent);

                Cooperation Cooperation = CooperationFactory.CreateCooperation(Initiator, Aceptee, NannyOffer);
                Initiator.AddCooperation(Cooperation);
                Aceptee.AddCooperation(Cooperation);

                UserRepository.UpdateUser(Aceptee);
                UserRepository.UpdateUser(Initiator);

                return RedirectToAction("Create");
            }
            return View();
        }
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Cooperation/Edit/5
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

        // GET: Cooperation/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Cooperation/Delete/5
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
