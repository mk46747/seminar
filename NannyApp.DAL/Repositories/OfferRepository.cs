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
    }
}
