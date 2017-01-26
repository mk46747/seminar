using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NannyApp.Model

{
    public enum BabySittingPlace { NANNYS_PLACE, PARENTS_PLACE}
    public abstract class Offer : EntityBase<int>
    {
        public virtual double Price { get; set; }
        public virtual string Experience { get; set; }
        public virtual BabySittingPlace BabySittingPlace { get; set; }
        public virtual string Notice { get; set; }
        public virtual DateTime StartTime { get; set; }
        public virtual DateTime EndTime{ get; set; }
        public virtual string City { get; set; }
        public virtual string Address { get; set; }
        public virtual int ChildrenNumber { get; set; }
        public virtual int MinChildrenAge { get; set; }
        public virtual int MaxChildrenAge { get; set; }
        public virtual DateTime Deadline { get; set; }

        public virtual bool Opened {get; set;}

        public Offer( double Price, string Experience, BabySittingPlace BabySittingPlace, string Notice,
        DateTime StartTime,  DateTime EndTime, string City, string Address, int ChildrenNumber,
         int MinChildrenAge,  int MaxChildrenAge, DateTime Deadline)
        {
            this.Price = Price;
            this.Experience = Experience;
            this.BabySittingPlace = BabySittingPlace;
            this.Notice = Notice;
            this.StartTime = StartTime;
            this.EndTime = EndTime;
            this.City = City;
            this.Address = Address;
            this.ChildrenNumber = ChildrenNumber;
            this.MinChildrenAge = this.MinChildrenAge;
            this.MaxChildrenAge = MaxChildrenAge;
            this.Deadline = Deadline;
        }

        public Offer()
            :base()
        {
        }

    }
}
