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
using NannyApp.Model;

namespace NannyApp.Presentation
{
    public partial class CooperationForm : Form, ICooperationView
    {
        private IMainFormController MainFormController;
        public CooperationForm(IMainFormController MainFormController)
        {
            this.MainFormController = MainFormController;
            InitializeComponent();
        }

        private void ShowReview(object sender, EventArgs e)
        {
            MainFormController.ShowReview(this.CooperationId);

        }
        public void HideReviewButton()
        {
            ReviewButton.Hide();

        }


        private void UpdateCooperation(object sender, EventArgs e)
        {
            MainFormController.UpdateCooperation(this);
        }


        public string NannyUserName
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                NannyNameTextBox.Text = value;
            }
        }

        public string ParentUserName
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                ParentNameTextBox.Text = value;
            }
        }

        public string NannyContact
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                NannyContactTextBox.Text = value;
            }
        }

        public string ParentContact
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                ParentContactTextBox.Text = value;
            }
        }

        public DateTime StartDate
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                StartDateDateTime.Value = value;
            }
        }

        public DateTime EndDate
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                EndDateDateTime.Value = value;
            }
        }

        public double Price
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                PriceTextBox.Text = value.ToString();
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
        public CooperationStatus Status
        {
            get
            {
                if (acceptRadio.Checked == true)
                {
                    return CooperationStatus.ACCEPTED;
                }
                if (rejectRadio.Checked == true)
                {
                    return CooperationStatus.DECLINED;
                } if (pendingRadio.Checked == true)
                {
                    return CooperationStatus.PENDING;
                }
                return CooperationStatus.PENDING;
                
            }
            set
            {
                if (value == CooperationStatus.ACCEPTED)
                {
                    acceptRadio.Checked = true;
                }
                else if (value == CooperationStatus.DECLINED)
                {
                    rejectRadio.Checked = true;


                }
                else if (value == CooperationStatus.PENDING)
                {
                    pendingRadio.Checked = true;


                }
            }
        }
    }
}
