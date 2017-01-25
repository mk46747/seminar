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
        public Parent(int Id, string Username, string Password)
            :base(Id, Username, Password)
        {
            
        }
        
    }
}
