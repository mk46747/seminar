using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NannyApp.Model.Repositories
{
    public interface IUserRepository
    {
        bool AddUser(User User);
        bool DeleteUser(User User);
        bool DeleteUser(int Id);
        bool DeleteUser(string Username, string Password);
        Admin GetAdmin(int Id);

        Nanny GetNanny(int Id);
        Parent GetParent(int Id);

        Admin GetAdmin(string Username, string Password);
        Nanny GetNanny(string Username, string Password);
        Parent GetParent(string Username, string Password);
        IList<Nanny> GetAllNannies();
        IList<Parent> GetAllParents();
        bool UpdateUser(User User);



    }
}
