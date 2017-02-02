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
        public ActionResult CreateForParentOffer(int IdNanny, ParentOffer ParentOffer)
        {
            if (ModelState.IsValid)
            {
                //UserRepository UserRepository = new UserRepository();
                //Nanny nanny = UserRepository.GetNanny(IdNanny);
                //Parent parent = UserRepository.GetParent(ParentOffer.Parent.Id);

                //Cooperation newCooperation = new Cooperation();

                //newCooperation.CooperationInitiator = nanny; 
                //newCooperation.CooperationAcceptee = parent;
                //newCooperation.Offer = ParentOffer;
                //newCooperation.Status = CooperationStatus.PENDING;
                //parent.Cooperations = newCooperation;

                //UserRepository.UpdateUser(parent);

                //return RedirectToAction("Create");
            }
            return View();   
        }

        [HttpPost]
        public ActionResult CreateForNannyOffer(int IdParent, NannyOffer NannyOffer)
        {
            if (ModelState.IsValid)
            {
                UserRepository UserRepository = new UserRepository();
                Nanny nanny = UserRepository.GetNanny(NannyOffer.Nanny.Id);
                Parent parent = UserRepository.GetParent(IdParent);

                Cooperation newCooperation = new Cooperation();

                newCooperation.CooperationInitiator = parent; //tko se prijavljuje
                newCooperation.CooperationAcceptee = nanny;

                UserRepository.UpdateUser(nanny);

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
