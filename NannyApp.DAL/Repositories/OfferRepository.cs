using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NannyApp.Model.Repositories;
using NannyApp.Model;

namespace NannyApp.DAL.Repositories
{
    public class OfferRepository : IOfferRepository
    {
        private IList<T> getAllOffers<T>() where T : Offer
        {
            IList<T> Offers = null;
            using (var session = NHibernateService.OpenSession())
            {
                try
                {
                    using (var transaction = session.BeginTransaction())
                    {
                        Offers = session.QueryOver<T>().List();
                        transaction.Commit();
                    }
                    session.Clear();
                    // session.Close();

                }
                catch (Exception e)
                {
                    Logger.Log(e);
                    return null;
                }
            }
           // return Offers.OrderBy(o => o.Id).ToList();

            return Offers;

        }
       public IList<NannyOffer> GetAllNannyOffers()
        {
            return getAllOffers<NannyOffer>();
        }

       public IList<ParentOffer> GetAllParentOffers()
       {
           return getAllOffers<ParentOffer>();

       }
    

        public NannyOffer GetNannyOffer(int Id)
        {
            return GetOffer<NannyOffer>(Id);
        }
        public ParentOffer GetParentOffer(int Id)
        {
            return GetOffer<ParentOffer>(Id);
        }
        private T GetOffer<T>(int Id) where T : Offer
        {
            T Offer = default(T);
            using (var session = NHibernateService.OpenSession())
            {
                try
                {
                    using (var transaction = session.BeginTransaction())
                    {
                       // User = session.QueryOver<User>().Where(c => c.Id == Id)
                        //    .And(c => c is T).SingleOrDefault();
                        Offer = (T) session.Get(typeof(T), Id);
                        transaction.Commit();
                    }
                    session.Clear();
                    //session.Close();

               }
                catch (Exception e)
                {
                    Logger.Log(e);
                    return Offer;
                }
            }
            return  Offer;
        }
    }
}
