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

        private void CreateOffer(object sender, EventArgs e)
        {
            MainFormController.CreateOffer(this);
        }

        public double Price
        {
            get
            {
                return (double) priceNumeric.Value;
            }

            set
            {
                priceNumeric.Value = (decimal)Price;
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
                if (BabySittingPlace == BabySittingPlace.NANNYS_PLACE)
                {
                    NannysPlaceRadio.Checked = true;
                    ParentsPlaceRadio.Checked = false;
                }

                else if (BabySittingPlace == BabySittingPlace.PARENTS_PLACE)
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
                experienceTextBox.Text = Experience;
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
                NoticeTextBox.Text = Notice;
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
                StartingTimeDateTime.Value = StartTime;
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
                EndTimeDateTimePicker.Value = EndTime;
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
                if (CooperationStatus == CooperationStatus.PENDING)
                {
                    PendingRadio.Checked = true;
                    AcceptedRadio.Checked = false;
                    DeclinedRadio.Checked = false;
                }

                else if (CooperationStatus == CooperationStatus.ACCEPTED)
                {
                    PendingRadio.Checked = false;
                    AcceptedRadio.Checked = true;
                    DeclinedRadio.Checked = false;
                }

                else if (CooperationStatus == CooperationStatus.DECLINED)
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
                CityTextBox.Text = City;
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
                AddressTextBox.Text = Address;
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
                NumChildrenNumeric.Value = (decimal)ChildrenNumber;
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
                MinAgeNumeric.Value = (decimal)MinChildrenAge;
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
                MaxAgeNumeric.Value = (decimal)MaxChildrenAge;
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
                DeadLineDateTime.Value = DeadLine;
            }
        }
    }
}
