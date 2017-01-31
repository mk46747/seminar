using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NannyApp.Model.Factories
{
    public class OfferFactory
    {
        public static Offer CreateNannyOffer( double Price, string Experience, BabySittingPlace BabySittingPlace, string Notice,
        DateTime StartTime,  DateTime EndTime, string City, string Address, int ChildrenNumber,
         int MinChildrenAge, int MaxChildrenAge, DateTime Deadline, bool Opened, Nanny Nanny)
        {
            return new NannyOffer( Price,  Experience,  BabySittingPlace,  Notice, StartTime,   EndTime,
            City, Address, ChildrenNumber, MinChildrenAge, MaxChildrenAge, Deadline, Opened, Nanny);
        }

        public static Offer CreateParentOffer( double Price, string Experience, BabySittingPlace BabySittingPlace, string Notice,
        DateTime StartTime,  DateTime EndTime, string City, string Address, int ChildrenNumber,
         int MinChildrenAge,  int MaxChildrenAge, DateTime Deadline, bool Opened, Parent Parent)  { 
            return new ParentOffer( Price,  Experience,  BabySittingPlace,  Notice, StartTime,   EndTime,
            City, Address, ChildrenNumber, MinChildrenAge, MaxChildrenAge, Deadline, Opened, Parent);
        }
    }
}
