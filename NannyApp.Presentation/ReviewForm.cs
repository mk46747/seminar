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
        public ReviewForm()
        {
            InitializeComponent();
        }

        public double ReviewScore
        {
            get
            {
                return (double)ReviewScoreNumeric.Value;
            }
            set
            {
                ReviewScoreNumeric.Value = (decimal)ReviewScore;
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
                ReviewCommentTextBox.Text = Comment;
            }
        }
    }
}
