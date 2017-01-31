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
        
        public string Username
        {
            get
            {
                return UserNameTextBox.Text;
            }

            set
            {
                UserNameTextBox.Text = Username;
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
                PasswordTextBox.Text = Password;
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
                NameTextBox.Text = Name;
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
                SurnameTextBox.Text = Surname;
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
                if (Gender == Gender.MALE)
                {
                    MaleRadio.Checked = true;
                    FemaleRadio.Checked = false; 
                }

                else if (Gender == Gender.FEMALE)
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
                ContactTextBox.Text = Contact;
            }
        }
    }
}
