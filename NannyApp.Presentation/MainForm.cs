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
            MainController.InitializeLists(this);
            NannyOffersList.FullRowSelect = true;
            ParentOffersList.FullRowSelect = true;


        }

        public void ShowLoginButton()
        {
            loginButton.Show();
        }

        private void ShowMyProfile(object sender, EventArgs e)
        {
            MainController.ShowMyProfile();
        }
        private void ShowMyCooperations(object sender, EventArgs e)
        {
            MainController.ShowMyCooperations();
        }
        private void Logout(object sender, EventArgs e)
        {
            MainController.Logout(this);
        }

        
        private void ShowNannyOffer(object sender, EventArgs e)
        {
            ListViewItem firstSelectedItem = NannyOffersList.SelectedItems[0];
            int Id = Int32.Parse(firstSelectedItem.SubItems[0].Text.ToString());
            MainController.ShowOfferForm(Id, this);
        }
        private void ShowParentOffer(object sender, EventArgs e)
        {
            ListViewItem firstSelectedItem = ParentOffersList.SelectedItems[0];
            int Id = Int32.Parse(firstSelectedItem.SubItems[0].Text.ToString());
            MainController.ShowOfferForm(Id, this);
        }

        public void ShowLoginForm(object sender, EventArgs e)
        {
             MainController.ShowLoginForm(this);
        }

        public void ShowOfferForm(object sender, EventArgs e)
        {
            MainController.ShowOfferForm();
        }
        public void Close(object sender, EventArgs e)
        {
            Application.Exit();
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

        public void DisableMenu()
        {
            menu.Enabled = false;
        }

        public List<NannyOffer> NannyOffers
        {
            get
            {
                return null;
            }
            set
            {
                foreach(var o in value){
                    NannyOffersList.Items.Add(new ListViewItem(new[] {o.Id.ToString(), o.Nanny.Username, o.City, o.Price.ToString(), o.Deadline.ToShortDateString() }));

                }

                
            }
        }

        public List<ParentOffer> ParentOffers
        {
            get
            {
                return null;
            }
            set
            {
                foreach (var o in value)
                {
                    ParentOffersList.Items.Add(new ListViewItem(new[] {o.Id.ToString(), o.Parent.Username, o.City, o.Price.ToString(), o.Deadline.ToShortDateString() }));

                }
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }
    }
}
