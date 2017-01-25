using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NannyApp.Model.Factories
{
   public class UserFactory
    {
       public static User CreateAdmin(string Username, string Password,
             string Name, string Surname, Gender Gender, string Contact)
       {
           return new Admin(Username, Password, Name, Surname, Gender, Contact);
       }

       public static User CreateNanny(string Username, string Password,
             string Name, string Surname, Gender Gender, string Contact, string Education, bool Smoking,
            bool Pets, bool Car, string ExtraServices, string ExtraQualification)
       {
           return new Nanny(Username, Password, Name, Surname, Gender, Contact,
               Education, Smoking, Pets, Car, ExtraServices, ExtraQualification,
               new List<Offer>(), new List<Cooperation>());
       }

       public static User CreateParent(string Username, string Password,
             string Name, string Surname, Gender Gender, string Contact)
       {
           return new Parent(Username, Password, Name, Surname, Gender, Contact,
               new List<Offer>(), new List<Cooperation>());
       }
    }
}
