using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NannyApp.Model
{
    class ParrentOffer : Offer
    {
        private int _numberOfChildren;
        private int _childrenAge;
        private string _period;
        private string _dl;

        public virtual int NumberOfChildren
        {
            get { return _numberOfChildren; }
            set { _numberOfChildren = value; }
        }
        public virtual int ChildrenAge
        {
            get { return _childrenAge; }
            set { _childrenAge = value; }
        }
        public virtual string Period
        {
            get { return _period; }
            set { _period = value; }
        }
        public virtual string DL
        {
            get { return _dl; }
            set { _dl = value; }
        }
    }
}
