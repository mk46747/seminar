using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NannyApp.BaseLib;
using NannyApp.Model;

namespace NannyApp.Presentation
{
    public partial class NannyForm : Form, INannyView
    {
        IMainFormController MainFormController;
        public NannyForm()
        {
            InitializeComponent();
        }
        /*
        public string GetUsername()
        {
            return usernameTextbox.Text;
        }
        public string GetPassword()
        {
            return passwordTextbox.Text;
        }
        public string GetName()
        {
            return nameTextbox.Text;
        }
        public string GetSurname()
        {
            return surnameTextbox.Text;
        }
        public string GetContact()
        {
            return contactTextbox.Text;
        }
        public string GetEducation()
        {
            return educationTextbox.Text;
        }
       
        public string GetExtraServices()
        {
            return extraServicesTextbox.Text;
        }
        public string GetExtraQualification()
        {
            return extraQualificationTextbox.Text;
        }

        public Gender GetGender()
        {
            var checkedButton = genderPanel.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);
            if (checkedButton.Name.Equals("Male"))
            {
                return Gender.MALE;
            }
            return Gender.FEMALE;
        }
        public bool GetSmoking()
        {
            var checkedButton = smokingPanel.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);
            if (checkedButton.Name.Equals("Yes"))
            {
                return true;
            }
            return false;
        }
        public bool GetPets()
        {
            var checkedButton = petsPanel.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);
            if (checkedButton.Name.Equals("Yes"))
            {
                return true;
            }
            return false;
        }

        public bool GetSickChildren()
        {
            var checkedButton = sickChildrenPanel.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);
            if (checkedButton.Name.Equals("Yes"))
            {
                return true;
            }
            return false;
        }

        public bool GetDriversLicence()
        {
            var checkedButton = driversLicencePanel.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);
            if (checkedButton.Name.Equals("Yes"))
            {
                return true;
            }
            return false;
        }*/
        public NannyForm(IMainFormController MainFormController)
        {
            this.MainFormController = MainFormController;
            InitializeComponent();
        }

        private void CreateNanny(object sender, EventArgs e)
        {
            MainFormController.CreateNanny(this);
        }
         


        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }



        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        public string Username
        {
            get
            {
                return usernameTextbox.Text;
            }
            set
            {
                usernameTextbox.Text = Username ;
            }
        }

        public string Password
        {
            get
            {
                return passwordTextbox.Text;
            }
            set
            {
                passwordTextbox.Text = Password;
            }
        }

        public string Surname
        {
            get
            {
                return surnameTextbox.Text;
            }
            set
            {
                surnameTextbox.Text = Surname;
            }
        }

        public string Contact
        {
            get
            {
                return contactTextbox.Text;
            }
            set
            {
                contactTextbox.Text = Contact;
            }
        }

        public string Education
        {
            get
            {
                return educationTextbox.Text;
            }
            set
            {
                educationTextbox.Text = Education;
            }
        }

        public string ExtraQualification
        {
            get
            {
                return extraQualificationTextbox.Text;
            }
            set
            {
                extraQualificationTextbox.Text = ExtraQualification ;
            }
        }

        public string ExtraServices
        {
            get
            {
                return extraServicesTextbox.Text;
            }
            set
            {
                extraServicesTextbox.Text = ExtraServices;
            }
        }

        public bool Smoking
        {
            get
            {
                var checkedButton = smokingPanel.Controls.OfType<RadioButton>()
                                                     .FirstOrDefault(r => r.Checked);
                if (checkedButton.Name.Equals("Yes"))
                {
                    return true;
                }
                return false;
            }
            set
            {
                if (Smoking == true)
                {
                    smokingYes.Checked = true;
                    smokingNo.Checked = false;
                }
                else
                {
                    smokingYes.Checked = false;
                    smokingNo.Checked = true;

                }
            }
        }

        public bool Pets
        {
            get
            {
                var checkedButton = petsPanel.Controls.OfType<RadioButton>()
                                                     .FirstOrDefault(r => r.Checked);
                if (checkedButton.Name.Equals("Yes"))
                {
                    return true;
                }
                return false;
            }
            set
            {
                if (Pets == true)
                {
                    petsYes.Checked = true;
                    petsNo.Checked = false;
                }
                else
                {
                    petsYes.Checked = false;
                    petsNo.Checked = true;

                }
            }
        }

        public bool SickChildren
        {
            get
            {
                var checkedButton = sickChildrenPanel.Controls.OfType<RadioButton>()
                                                     .FirstOrDefault(r => r.Checked);
                if (checkedButton.Name.Equals("Yes"))
                {
                    return true;
                }
                return false;
            }
            set
            {
                if (SickChildren == true)
                {
                    illChildrenYes.Checked = true;
                    illChildrenNo.Checked = false;
                }
                else
                {
                    illChildrenYes.Checked = false;
                    illChildrenNo.Checked = true;

                }
            }
        }

        public bool DriversLicence
        {
            get
            {
                var checkedButton = driversLicencePanel.Controls.OfType<RadioButton>()
                                                     .FirstOrDefault(r => r.Checked);
                if (checkedButton.Name.Equals("Yes"))
                {
                    return true;
                }
                return false;
            }
            set
            {
                if (DriversLicence == true)
                {
                    driversLicenceYes.Checked = true;
                    driversLicenceNo.Checked = false;
                }
                else
                {
                    driversLicenceYes.Checked = false;
                    driversLicenceNo.Checked = true;

                }
            }
        }


        public string NannyName
        {
            get
            {
                return nameTextbox.Text;

            }
            set
            {
                nameTextbox.Text = Name;
            }
        }


        public Gender Gender
        {
            get
            {
                var checkedButton = genderPanel.Controls.OfType<RadioButton>()
                                                      .FirstOrDefault(r => r.Checked);
                if (checkedButton.Name.Equals("Male"))
                {
                    return Gender.MALE;
                }
                return Gender.FEMALE;
            }
            set
            {
                if (Gender == Gender.MALE)
                {
                    genderMale.Checked = true;
                    genderFemale.Checked = false;
                }
                else
                {
                    genderMale.Checked = false;
                    genderFemale.Checked = true; 

                }
            }
        }

        public void HideUpdateButton()
        {
            UpdateAccountButton.Hide();
        }

        public void HideViewReviewsButton()
        {
            ReviewsButton.Hide();
         }
    }
}
