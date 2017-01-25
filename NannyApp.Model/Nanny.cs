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

        public Nanny(int Id, string Username, string Password)
            : base(Id, Username, Password)
        {

        }

        public Nanny(int Id, string Username, string Password, String Education, bool Smoking,
            bool Pets, bool Car)
            :base(Id, Username, Password)
        {
            this.Education = Education;
            this.Smoking = Smoking;
            this.Pets = Pets;
            this.Car = Car;
           
        }
        public Nanny()
            : base()
        {
            

        }


    }
}
