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
{//
    public partial class ReviewsForm : Form, IReviewsView
    {//
        private IMainFormController MainFormController;
        public ReviewsForm(IMainFormController MainFormController)
        {
            this.MainFormController = MainFormController;
            InitializeComponent();
        }

        public List<Review> Reviews
        {
            get
            {
                return null;
            }
            set
            {
                if (value.Count > 0)
                {
                foreach (var r in value)
                {
                    if(r != null)
                        ReviewsListView.Items.Add(new ListViewItem(new[] { r.Grade.ToString(), r.ReviewText }));
                    }

                }


            }
        }
    }
}
