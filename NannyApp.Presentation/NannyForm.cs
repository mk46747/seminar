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
        public void AdjustCreateView()
        {
            UpdateAccountButton.Hide();
            ReviewsButton.Hide();
        }
        public void AdjustEditView()
        {
            CreateAccountButton.Hide();
        }
        public void AdjustOuterView()
        {
            UpdateAccountButton.Hide();
            //ReviewsButton.Hide();
            CreateAccountButton.Hide();

        }

        
        public NannyForm(IMainFormController MainFormController)
        {
            this.MainFormController = MainFormController;
            InitializeComponent();
        }

        private void CreateNanny(object sender, EventArgs e)
        {
            MainFormController.CreateNanny(this);
        }
        private void ShowReviews(object sender, EventArgs e)
        {
            MainFormController.ShowReviews(this.NannyId);
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
                usernameTextbox.Text = value ;
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
                passwordTextbox.Text = value;
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
                surnameTextbox.Text = value;
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
                contactTextbox.Text = value;
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
                educationTextbox.Text = value;
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
                extraQualificationTextbox.Text = value;
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
                extraServicesTextbox.Text = value;
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
                if (value == true)
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
                if (value == true)
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
                if (value == true)
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
                if (value == true)
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
                nameTextbox.Text = value;
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
                if (value == Gender.MALE)
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

        public int NannyId
        {
            get
            {
                return (int)Int32.Parse(nannyId.Text);
            }

            set
            {
                nannyId.Text = value.ToString();
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
