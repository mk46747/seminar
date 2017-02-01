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
        public void ShowNannyForm(INannyView NannyView)
        {
            var form =  (Form) NannyView;
            form.Show();
           
        }

        public User  CreateNanny(INannyView NannyView, IUserRepository UserRepository)
        {
            string Username = NannyView.Username;
            string Password = NannyView.Password;
            string Name = NannyView.NannyName;
            string Surname = NannyView.Surname;
            string Contact = NannyView.Contact;
            string Education = NannyView.Education;
            Gender Gender = NannyView.Gender;
            bool Smoking = NannyView.Smoking;
            bool Pets = NannyView.Pets;
            bool SickChildren = NannyView.SickChildren;
            bool DriversLicence = NannyView.DriversLicence;
            string ExtraServices = NannyView.ExtraServices;
            string ExtraQualification = NannyView.ExtraQualification;

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
