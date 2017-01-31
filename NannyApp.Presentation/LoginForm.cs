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
using NannyApp.BaseLib;
namespace NannyApp.Presentation
{
    public partial class LoginForm : Form, ILoginView
    {

     private IMainFormController controller;
     public string GetUsername()
     {
         return usernameTextbox.Text;
     }
     public string GetPassword()
     {
         return passwordTextbox.Text;
     }


     public LoginForm(IMainFormController MainFormController)
        {
            this.controller = MainFormController;
            InitializeComponent();
        }

        public void Login(object sender, EventArgs e)
        {
            controller.LoginUser(this);
        }
        public void CreateNanny(object sender, EventArgs e)
        {
            controller.ShowCreateNannyForm();
            this.Hide();
        }
        public void CreateParent(object sender, EventArgs e)
        {
         //   controller.CreateParent();
        }
    }
}
