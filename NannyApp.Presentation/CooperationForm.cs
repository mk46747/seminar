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
    public partial class CooperationForm : Form, ICooperationView
    {
        public CooperationForm()
        {
            InitializeComponent();
        }

        public string NannyUserName
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                NannyNameTextBox.Text = NannyUserName;
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
                ParentNameTextBox.Text = ParentUserName;
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
                NannyContactTextBox.Text = NannyContact;
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
                ParentContactTextBox.Text = ParentContact;
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
                StartDateDateTime.Value = StartDate;
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
                EndDateDateTime.Value = EndDate;
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
                PriceTextBox.Text = Price.ToString();
            }
        }
    }
}
