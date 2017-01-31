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
                throw new NotImplementedException();
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
                throw new NotImplementedException();
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
                throw new NotImplementedException();
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
                throw new NotImplementedException();
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
                throw new NotImplementedException();
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
                throw new NotImplementedException();
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
                throw new NotImplementedException();
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
                throw new NotImplementedException();
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
                throw new NotImplementedException();
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
                throw new NotImplementedException();
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
                throw new NotImplementedException();
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
                throw new NotImplementedException();
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
                throw new NotImplementedException();
            }
        }
    }
}
