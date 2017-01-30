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
    public partial class StartForm : Form, IStartView
    {
        private IMainFormController MainController;

        public StartForm(IMainFormController MainController)
        {
            this.MainController = MainController;
            InitializeComponent();
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


      
    }
}
