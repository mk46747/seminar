using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NannyApp.Model.Repositories;
using NannyApp.BaseLib;
using NannyApp.Model;
using NannyApp.DAL.Repositories;
using NannyApp.Presentation;
using System.Windows.Forms;

namespace NannyApp.Controllers
{
    public class LoginController
    {

        public static void Login(IUserRepository UserRepository, ILoginView LoginView, IMainFormController MainController)
        {
            string Username = LoginView.GetUsername();
            string Password = LoginView.GetPassword();
            if (Username.Length == 0 || Password.Length == 0)
            {
                MessageBox.Show("Please fill all the fields");
                return;
            }
            Admin Admin = UserRepository.GetAdmin(Username, Password);
            if (Admin != null)
            {
              //  MainController admin view
            }
            Nanny Nanny = UserRepository.GetNanny(Username, Password);
            if (Nanny != null)
            {
                //  MainController nanny view
            }
            Parent Parent = UserRepository.GetParent(Username, Password);

            if (Parent != null)
            {
                //  MainController nanny view
            }

        }
    }
}
