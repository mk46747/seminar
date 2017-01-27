using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NannyApp.Model.Factories
{
    public class CooperationFactory
    {
        public static Cooperation CreateCooperation(User CooperationInitiator, User CooperationAcceptee, Offer Offer){
            return new Cooperation(CooperationInitiator, CooperationAcceptee, Offer);
        }
    }
}
