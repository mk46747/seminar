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
    public partial class ParentForm : Form, IParentView
    {
        IMainFormController MainController;
        public ParentForm(IMainFormController MainController)
        {
            this.MainController = MainController;
            InitializeComponent();
        }

        private void CreateParent(object sender, EventArgs e)
        {
            MainController.CreateParent(this);
        }
        
        public string Username
        {
            get
            {
                return UserNameTextBox.Text;
            }

            set
            {
                UserNameTextBox.Text = value;
            }
        }

        public string Password
        {
            get
            {
                return PasswordTextBox.Text;
            }

            set
            {
                PasswordTextBox.Text = value;
            }
        }

        public string Name
        {
            get
            {
                return NameTextBox.Text;
            }

            set
            {
                NameTextBox.Text = value;
            }
        }

        public string Surname
        {
            get
            {
                return SurnameTextBox.Text;
            }

            set
            {
                SurnameTextBox.Text = value;
            }
        }

        public Gender Gender
        {
            get
            {
                var checkedButton = panel1.Controls.OfType<RadioButton>()
                                    .FirstOrDefault(r => r.Checked);
                if (checkedButton.Name == "MaleRadio")
                {
                    return Gender.MALE;
                }

                else //if (checkedButton.Name == "FemaleRadio")
                {
                    return Gender.FEMALE;
                }
            }

            set
            {
                if (value == Gender.MALE)
                {
                    MaleRadio.Checked = true;
                    FemaleRadio.Checked = false; 
                }

                else if (value == Gender.FEMALE)
                {
                    MaleRadio.Checked = false;
                    FemaleRadio.Checked = true;
                }
            }
        }

        public string Contact
        {
            get
            {
                return ContactTextBox.Text;
            }

            set
            {
                ContactTextBox.Text = value;
            }
        }


        public void AdjustCreateView()
        {
            UpdateParentButton.Hide();
         }

        public void AdjustEditView()
        {
            CreateParentButton.Hide();
        }

        public void AdjustOuterView()
        {
            UpdateParentButton.Hide();
            CreateParentButton.Hide();

        }
    }
}
