using NannyApp.BaseLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NannyApp.Presentation
{
    public partial class ReviewForm : Form, IReviewView
    {
       private IMainFormController MainFormController;
        public ReviewForm(IMainFormController MainFormController)
        {
            this.MainFormController = MainFormController;
            InitializeComponent();
        }
        private void SaveReview(object sender, EventArgs e)
        {
            MainFormController.SaveReview(this);
        }
       
        public int ReviewScore
        {
            get
            {
                return (int)ReviewScoreNumeric.Value;
            }
            set
            {
                ReviewScoreNumeric.Value = (decimal)value;
            }
        }
        public int CooperationId
        {
            get
            {
                return Int32.Parse(cooperationId.Text);
            }
            set
            {
                cooperationId.Text = value.ToString();
            }
        }

        public string Comment
        {
            get
            {
                return ReviewCommentTextBox.Text;
            }

            set
            {
                ReviewCommentTextBox.Text = value;
            }
        }
    }
}
