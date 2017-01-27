using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NannyApp.Model
{
    public class Nanny : User
    {
       // public IList<ExtraServiceType> ExtraServices {get; set;}
       // public IList<Education> Education {get; set;}

        public virtual IList<NannyOffer> Offers { get; set; }
        public virtual IList<Cooperation> Cooperations { get; set; }
        public virtual string Education { get; set; }
        public virtual bool Smoking { get; set; }
        public virtual bool Pets { get; set; }
        public virtual bool SickChildern { get; set; }
        public virtual bool Car { get; set; }
        //mozda nece bit obavezni?
        public virtual string ExtraServices { get; set; }
        public virtual string ExtraQualification { get; set; }



        public Nanny(string Username, string Password, 
             string Name, string Surname, Gender Gender, string Contact, string Education, bool Smoking,
            bool Pets, bool Car, string ExtraServices, string ExtraQualification,
            IList<NannyOffer> Offers, IList<Cooperation> Cooperations)
            : base(Username, Password, Name, Surname, Gender, Contact)
        {
            this.Education = Education;
            this.Smoking = Smoking;
            this.Pets = Pets;
            this.Car = Car;
            this.ExtraServices = ExtraServices;
            this.ExtraQualification = ExtraQualification;
            this.Offers = Offers;
            this.Cooperations = Cooperations;
           
        }
        public Nanny()
            : base()
        {
            

        }
        public virtual void AddCooperation(Cooperation Cooperation)
        {
            Cooperations.Add(Cooperation);
        }

        public virtual void AddOffer(NannyOffer Offer)
        {
            Offers.Add(Offer);
        }
        public virtual void RemoveOffer(NannyOffer Offer)
        {
            Offers.Remove(Offer);
        }
        public virtual void RemoveCooperation(Cooperation Cooperation)
        {
            Cooperations.Remove(Cooperation);
        }


    }
}
