using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NannyApp.Model
{
    public class NannyOffer : Offer
    {
        public virtual Nanny Nanny { get; set; }

        public NannyOffer()
            : base()
        {

        }
        public NannyOffer( double Price, string Experience, BabySittingPlace BabySittingPlace, string Notice,
        DateTime StartTime,  DateTime EndTime, string City, string Address, int ChildrenNumber,
         int MinChildrenAge,  int MaxChildrenAge, DateTime Deadline, Nanny Nanny)   
            :base( Price,  Experience,  BabySittingPlace,  Notice, StartTime,   EndTime,
            City,  Address,  ChildrenNumber, MinChildrenAge,   MaxChildrenAge,  Deadline){
                this.Nanny = Nanny;
            }
    }
}
