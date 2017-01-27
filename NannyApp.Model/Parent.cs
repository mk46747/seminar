using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NannyApp.Model
{
    public class Parent : User
    {
        public virtual IList<ParentOffer> Offers {get; set;}
        public virtual IList<Cooperation> Cooperations {get; set;}

        public Parent()
            : base()
        {
            

        }
       public Parent(string Username, string Password, 
             string Name, string Surname, Gender Gender, string Contact, UserType UserType, IList<ParentOffer> Offers, IList<Cooperation> Cooperations)
            : base(Username, Password, Name, Surname, Gender, Contact, UserType)
        {
            this.Offers = Offers;
            this.Cooperations = Cooperations;
            
        }

       public virtual void AddOffer(ParentOffer Offer)
       {
           Offers.Add(Offer);
       }
       public virtual void AddCooperation(Cooperation Cooperation)
       {
           Cooperations.Add(Cooperation);
       }
       public virtual void RemoveOffer(ParentOffer Offer)
       {
           Offers.Remove(Offer);
       }
       public virtual void RemoveCooperation(Cooperation Cooperation)
       {
           Cooperations.Remove(Cooperation);
       }
        
    }
}
