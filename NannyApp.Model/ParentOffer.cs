using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NannyApp.Model
{
    public class ParentOffer : Offer
    {
        public virtual Parent Parent { get; set; }
        public ParentOffer( double Price, string Experience, BabySittingPlace BabySittingPlace, string Notice,
        DateTime StartTime,  DateTime EndTime, string City, string Address, int ChildrenNumber,
         int MinChildrenAge,  int MaxChildrenAge, DateTime Deadline, bool Opened, Parent Parent)   
            :base( Price,  Experience,  BabySittingPlace,  Notice, StartTime,   EndTime,
            City, Address, ChildrenNumber, MinChildrenAge, MaxChildrenAge, Deadline, Opened)
        {
                this.Parent = Parent;
            }
            public ParentOffer()
            : base()
        {
            //commit comment

    }


}
}
