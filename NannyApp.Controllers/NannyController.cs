using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NannyApp.Model.Repositories;
using NannyApp.BaseLib;
using NannyApp.Model;
using NannyApp.Model.Factories;
using System.Windows.Forms;

namespace NannyApp.Controllers
{
    class NannyController
    {
        public void ShowCreateNannyForm(INannyView CreateNannyView)
        {
            var form =  (Form) CreateNannyView;
            form.Show();
           
        }

        public User  CreateNanny(INannyView CreateNannyView, IUserRepository UserRepository)
        {
            string Username = CreateNannyView.Username;
            string Password = CreateNannyView.Password;
            string Name = CreateNannyView.NannyName;
            string Surname = CreateNannyView.Surname;
            string Contact = CreateNannyView.Contact;
            string Education = CreateNannyView.Education;
            Gender Gender = CreateNannyView.Gender;
            bool Smoking = CreateNannyView.Smoking;
            bool Pets = CreateNannyView.Pets;
            bool SickChildren = CreateNannyView.SickChildren;
            bool DriversLicence = CreateNannyView.DriversLicence;
            string ExtraServices = CreateNannyView.ExtraServices;
            string ExtraQualification = CreateNannyView.ExtraQualification;

            if(Username.Length == 0 || Password.Length == 0 || Name.Length == 0 || Surname.Length == 0
                || Contact.Length == 0 || Education.Length == 0)
            {
                MessageBox.Show("Please fill all the fields.");
                return null;
            }
            Nanny Nanny = UserRepository.GetNanny(Username, Password);
            if (Nanny != null)
            {
                MessageBox.Show("User with inserted username and password already exists. Please choose another one.");
                return null;
            }

            Nanny = (Nanny) UserFactory.CreateNanny(Username, Password, Name, Surname, Gender, 
                Contact, UserType.NANNY, Education, Smoking, Pets, DriversLicence,
                ExtraServices, ExtraQualification);

            if (UserRepository.AddUser(Nanny) == false)
            {
                MessageBox.Show("Error creating account, please try again");
                return null;
            }
            return Nanny;

        }
    
    }
}
