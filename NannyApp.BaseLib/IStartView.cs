using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NannyApp.Model;

namespace NannyApp.BaseLib
{
    public interface IStartView
    {
        List<NannyOffer> GetNannyOffers();
        List<ParentOffer> GetParentOffers();

    }
}
