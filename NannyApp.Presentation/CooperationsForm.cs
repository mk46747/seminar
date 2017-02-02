using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NannyApp.Model;

using NannyApp.BaseLib;
namespace NannyApp.Presentation
{
    public partial class CooperationsForm : Form, ICooperationsView
    {
         private IMainFormController MainFormController;
        public CooperationsForm(IMainFormController MainFormController)
        {
            this.MainFormController = MainFormController;
            InitializeComponent();
            CooperationsListView.FullRowSelect = true;

        }

        private void ShowCooperation(object sender, EventArgs e)
        {
            ListViewItem firstSelectedItem = CooperationsListView.SelectedItems[0];
            int Id = Int32.Parse(firstSelectedItem.SubItems[0].Text.ToString());
            MainFormController.ShowCooperation(Id);
        }

        public IList<Cooperation> Cooperations
        {
            get
            {
                return null;
            }
            set
            {
                foreach (var c in value)
                {
                    CooperationsListView.Items.Add(new ListViewItem(new[] {c.Id.ToString(), c.CooperationInitiator.Username, c.Status.ToString() }));

                }


            }
        }
    }
}
