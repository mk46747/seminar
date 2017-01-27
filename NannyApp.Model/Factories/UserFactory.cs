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
             string Name, string Surname, Gender Gender, string Contact, UserType UserType)
       {
           return new Admin(Username, Password, Name, Surname, Gender, Contact, UserType);
       }

       public static User CreateNanny(string Username, string Password,
             string Name, string Surname, Gender Gender, string Contact, UserType UserType, string Education, bool Smoking,
            bool Pets, bool Car, string ExtraServices, string ExtraQualification)
       {
           return new Nanny(Username, Password, Name, Surname, Gender, Contact,UserType,
               Education, Smoking, Pets, Car, ExtraServices, ExtraQualification,
               new List<NannyOffer>(), new List<Cooperation>());
       }

       public static User CreateParent(string Username, string Password,
             string Name, string Surname, Gender Gender, string Contact, UserType UserType)
       {
           return new Parent(Username, Password, Name, Surname, Gender, Contact, UserType,
               new List<ParentOffer>(), new List<Cooperation>());
       }
    }
}
