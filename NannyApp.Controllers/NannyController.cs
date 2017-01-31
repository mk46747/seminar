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

        public void CreateNanny(INannyView CreateNannyView, IUserRepository UserRepository)
        {
            string Username = CreateNannyView.GetUsername();
            string Password = CreateNannyView.GetPassword();
            string Name = CreateNannyView.GetName();
            string Surname = CreateNannyView.GetSurname();
            string Contact = CreateNannyView.GetContact();
            string Education = CreateNannyView.GetEducation();
            Gender Gender = CreateNannyView.GetGender();
            bool Smoking = CreateNannyView.GetSmoking();
            bool Pets = CreateNannyView.GetPets();
            bool SickChildren = CreateNannyView.GetSickChildren();
            bool DriversLicence = CreateNannyView.GetDriversLicence();
            string ExtraServices = CreateNannyView.GetExtraServices();
            string ExtraQualification = CreateNannyView.GetExtraQualification();
            if(Username.Length == 0 || Password.Length == 0 || Name.Length == 0 || Surname.Length == 0
                || Contact.Length == 0 || Education.Length == 0)
            {
                MessageBox.Show("Please fill all the fields.");
                return;
            }
            Nanny Nanny = UserRepository.GetNanny(Username, Password);
            if (Nanny != null)
            {
                MessageBox.Show("User with inserted username and password already exists. Please choose another one.");
                return;
            }

            Nanny = (Nanny) UserFactory.CreateNanny(Username, Password, Name, Surname, Gender, 
                Contact, UserType.NANNY, Education, Smoking, Pets, DriversLicence,
                ExtraServices, ExtraQualification);

            if (UserRepository.AddUser(Nanny) == false)
            {
                MessageBox.Show("Error creating account, please try again");
                return;
            }

        }
    
    }
}
