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
    public partial class MainForm : Form, IMainView
    {
        private IMainFormController MainController;

        public MainForm(IMainFormController MainController)
        {
            this.MainController = MainController;
            InitializeComponent();
            this.menu.Enabled = false;

        }

        public List<NannyOffer> GetNannyOffers()
        {
            return null;
        }
        public List<ParentOffer> GetParentOffers()
        {
            return null;
        }

        public void ShowLoginForm(object sender, EventArgs e)
        {
             MainController.ShowLoginForm(this);
        }




        public void HideLoginButton()
        {
            this.loginButton.Hide();
        }

    

        public void SetWelcomeLabel(string text)
        {
            welcomeLabel.Text = text;
        }


        public void EnableMenu()
        {
            menu.Enabled = true;
        }
    }
}
