using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NannyApp.Model.Repositories
{
    public interface IOfferRepository
    {
        IList<NannyOffer> GetAllNannyOffers();

        IList<ParentOffer> GetAllParentOffers();

        NannyOffer GetNannyOffer(int Id);
        ParentOffer GetParentOffer(int Id);
    }
}
