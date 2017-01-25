using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NannyApp.Model
{
   public class Admin : User
    {
       public Admin(int Id, string Username, string Password)
           : base(Id, Username, Password)
       {

       }

    }
}
