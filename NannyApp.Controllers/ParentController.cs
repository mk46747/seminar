using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NannyApp.BaseLib;
using System.Windows.Forms;
using NannyApp.Model.Repositories;
using NannyApp.Model;
using NannyApp.Model.Factories;

namespace NannyApp.Controllers
{
    class ParentController
    {
        public void ShowParentForm(IParentView ParentView)
        {
            var form = (Form)ParentView;
            form.Show();
        }

        public User CreateParent(IParentView ParentView, IUserRepository UserRepository)
        {
            string Username = ParentView.Username;
            string Password = ParentView.Password;
            string Name = ParentView.Name;
            string Surname = ParentView.Surname;
            string Contact = ParentView.Contact;
            Gender Gender = ParentView.Gender;

            if (Username.Length == 0 || Password.Length == 0 || Name.Length == 0 || Surname.Length == 0
                || Contact.Length == 0)
            {
                MessageBox.Show("Please fill all the fields.");
                return null;
            }

            Parent Parent = UserRepository.GetParent(Username, Password);
            if (Parent != null)
            {
                MessageBox.Show("User with inserted username and password already exists. Please choose another one.");
                return null;
            }

            Parent = (Parent)UserFactory.CreateParent(Username, Password, Name, Surname, Gender, Contact, UserType.PARENT);
            if (UserRepository.AddUser(Parent) == false)
            {
                MessageBox.Show("Error creating account, please try again");
                return null;
            }
            return Parent;
        }
    }
}