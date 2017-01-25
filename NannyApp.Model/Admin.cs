using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NannyApp.Model
{
   public class Admin : User
    {
               
       public Admin()
            : base()
        {
            

        }
       public Admin(string Username, string Password,
             string Name, string Surname, Gender Gender, string Contact)
           : base(Username, Password, Name, Surname, Gender, Contact)
       {

       }

    }
}
