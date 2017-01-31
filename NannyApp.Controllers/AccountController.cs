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
    public class AccountController
    {
        IMainView MainView;
        
        public  User Login(IUserRepository UserRepository, ILoginView LoginView, IMainFormController MainController
            )
        {
            string Username = LoginView.GetUsername();
            string Password = LoginView.GetPassword();

            if (Username.Length == 0 || Password.Length == 0)
            {

                MessageBox.Show("Please fill all the fields");
                return null;
            }
            var frm = (Form)LoginView;
            Admin Admin = UserRepository.GetAdmin(Username, Password);
            if (Admin != null)
            {
                return Admin;
              //  MainController.ShowAdminView()
            }
            Nanny Nanny = UserRepository.GetNanny(Username, Password);
            if (Nanny != null)
            {
                frm.Hide();
                frm.ShowInTaskbar = false;
                return Nanny;
            }
            
            Parent Parent = UserRepository.GetParent(Username, Password);

            if (Parent != null)
            {
                frm.Hide();
                frm.ShowInTaskbar = false;
                return Parent;
            }

            MessageBox.Show("Invalid username or password, please try again.");
            return null;


        }

        public void ShowLoginForm(ILoginView LoginView)
        {
            var form = (Form)LoginView;
            form.Show();
        }

    }
}
