using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NannyApp.Model
{
    public class Parent : User
    {
        public virtual IList<Offer> Offers {get; set;}
        public virtual IList<Cooperation> Cooperations {get; set;}

        public Parent()
            : base()
        {
            

        }
       public Parent(string Username, string Password, 
             string Name, string Surname, Gender Gender, string Contact, IList<Offer> Offers, IList<Cooperation> Cooperations)
            : base(Username, Password, Name, Surname, Gender, Contact)
        {
            this.Offers = Offers;
            this.Cooperations = Cooperations;
            
        }

       public virtual void AddOffer(Offer Offer)
       {
           Offers.Add(Offer);
       }
       public virtual void AddCooperation(Cooperation Cooperation)
       {
           Cooperations.Add(Cooperation);
       }
       public virtual void RemoveOffer(Offer Offer)
       {
           Offers.Remove(Offer);
       }
       public virtual void RemoveCooperation(Cooperation Cooperation)
       {
           Cooperations.Remove(Cooperation);
       }
        
    }
}
