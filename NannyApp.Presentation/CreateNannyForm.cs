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
    public partial class CreateNannyForm : Form, ICreateNannyView
    {
        IMainFormController MainFormController;
        public CreateNannyForm()
        {
            InitializeComponent();
        }
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
        }
        public CreateNannyForm(IMainFormController MainFormController)
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
    }
}
