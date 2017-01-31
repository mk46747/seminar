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
        public string GetUsername(){
            return UserNameTextBox.Text;
        }

        public void SetUsername(string Username)
        {
            UserNameTextBox.Text = Username;
        }
    }
}
