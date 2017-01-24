using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NannyApp.Model
{
    public abstract class Offer
    {
        private int _idOffer;
        private double _price;
        private string _experience;
        private string _babysittingPlace;
        private string _notice;

        public virtual int IdOffer
        {
            get { return _idOffer; }
            set { _idOffer = value; }
        }
        public virtual double Price
        {
            get { return _price; }
            set { _price = value; }
        }
        public virtual string Experience
        {
            get { return _experience; }
            set { _experience = value; }
        }
        public virtual string BabysittingPlace
        {
            get { return _babysittingPlace; }
            set { _babysittingPlace = value; }
        }
        public virtual string Notice
        {
            get { return _notice; }
            set { _notice = value; }
        }      
    }
}
