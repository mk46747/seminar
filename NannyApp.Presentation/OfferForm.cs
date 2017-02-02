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
    public partial class OfferForm : Form, IOfferView
    {
        IMainFormController MainFormController;
        public OfferForm(IMainFormController MainFormController)
        {
            this.MainFormController = MainFormController;
            InitializeComponent();
        }

        public OfferForm()
        {
            InitializeComponent();
        }
        private void ShowOwner(object sender, EventArgs e)
        {
            MainFormController.ShowOwner(this);
        }
        private void CreateOffer(object sender, EventArgs e)
        {
            MainFormController.CreateOffer(this);
        }
        private void UpdateOffer(object sender, EventArgs e)
        {
           // MainFormController.CreateOffer(this);
        }
        private void ApplyToOffer(object sender, EventArgs e)
        {
            MainFormController.ApplyToOffer(this.OfferId);
            this.Hide();
        }

        

        public double Price
        {
            get
            {
                return (double) priceNumeric.Value;
            }

            set
            {
                priceNumeric.Value = (decimal)value;
            }
        }

        public BabySittingPlace BabySittingPlace
        {
            get
            {
                var checkedButton = panel1.Controls.OfType<RadioButton>()
                                    .FirstOrDefault(r => r.Checked);
                if (checkedButton.Name.Equals("NannysPlaceRadio"))
                {
                    return BabySittingPlace.NANNYS_PLACE;
                }
                else //if (checkedButton.Name.Equals("ParentsPlaceRadio"))
                {
                    return BabySittingPlace.PARENTS_PLACE;
                }

            }
            set
            {
                if (value == BabySittingPlace.NANNYS_PLACE)
                {
                    NannysPlaceRadio.Checked = true;
                    ParentsPlaceRadio.Checked = false;
                }

                else if (value == BabySittingPlace.PARENTS_PLACE)
                {
                    NannysPlaceRadio.Checked = false;
                    ParentsPlaceRadio.Checked = true;
                }
            }
        }

        public string Experience
        {
            get
            {
                return experienceTextBox.Text;
            }

            set
            {
                experienceTextBox.Text = value;
            }
        }

        public string Notice
        {
            get
            {
                return NoticeTextBox.Text;
            }

            set
            {
                NoticeTextBox.Text = value;
            }
        }

        public DateTime StartTime
        {
            get
            {
                return StartingTimeDateTime.Value;
            }

            set
            {
                StartingTimeDateTime.Value = value;
            }
        }

        public DateTime EndTime
        {
            get
            {
                return EndTimeDateTimePicker.Value;
            }

            set
            {
                EndTimeDateTimePicker.Value = value;
            }
        }

        public CooperationStatus CooperationStatus
        {
            get
            {
                var checkedButton = AnchorStatusPanel.Controls.OfType<RadioButton>()
                                    .FirstOrDefault(r => r.Checked);
                if (checkedButton.Name.Equals("PendingRadio"))
                {
                    return CooperationStatus.PENDING;
                }

                else if (checkedButton.Name.Equals("AcceptedRadio"))
                {
                    return CooperationStatus.ACCEPTED;
                }

                else //if (checkedButton.Name.Equals("DeclinedRadio"))
                {
                    return CooperationStatus.DECLINED;
                }
            }

            set
            {
                if (value == CooperationStatus.PENDING)
                {
                    PendingRadio.Checked = true;
                    AcceptedRadio.Checked = false;
                    DeclinedRadio.Checked = false;
                }

                else if (value == CooperationStatus.ACCEPTED)
                {
                    PendingRadio.Checked = false;
                    AcceptedRadio.Checked = true;
                    DeclinedRadio.Checked = false;
                }

                else if (value == CooperationStatus.DECLINED)
                {
                    PendingRadio.Checked = false;
                    AcceptedRadio.Checked = false;
                    DeclinedRadio.Checked = true;
                }
            }
        }

        public string City
        {
            get
            {
                return CityTextBox.Text;
            }

            set
            {
                CityTextBox.Text = value;
            }
        }

        public string Address
        {
            get
            {
                return AddressTextBox.Text;
            }

            set
            {
                AddressTextBox.Text = value;
            }
        }

        public int ChildrenNumber
        {
            get
            {
                return (int)NumChildrenNumeric.Value;
            }

            set
            {
                NumChildrenNumeric.Value = (decimal)value;
            }
        }

        public int MinChildrenAge
        {
            get
            {
                return (int)MinAgeNumeric.Value;
            }

            set
            {
                MinAgeNumeric.Value = (decimal)value;
            }
        }

        public int MaxChildrenAge
        {
            get
            {
                return (int)MaxAgeNumeric.Value;
            }

            set
            {
                MaxAgeNumeric.Value = (decimal)value;
            }
        }

        public DateTime DeadLine
        {
            get
            {
                return DeadLineDateTime.Value;
            }

            set
            {
                DeadLineDateTime.Value = value;
            }
        }

        public int OfferId
        {
            get
            {
                return (int)Int32.Parse(offerId.Text);
            }

            set
            {
                offerId.Text = value.ToString();
            }
        }

        public void AdjustCreateView()
        {
            ApplyToOfferButton.Hide();
            ViewOwnerDetailsButton.Hide();
            UpdateOfferButton.Hide();
         }

        public void AdjustEditView()
        {
            ApplyToOfferButton.Hide();
            CreateOfferButton.Hide();
        }

        public void AdjustApplyYesView()
        {
            CreateOfferButton.Hide();
            UpdateOfferButton.Hide();

        }

        public void AdjustApplyNoView()
        {
            CreateOfferButton.Hide();
            UpdateOfferButton.Hide();
            ApplyToOfferButton.Hide();
        }
    }
}
