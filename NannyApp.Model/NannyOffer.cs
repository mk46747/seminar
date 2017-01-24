using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NannyApp.Model
{
    class NannyOffer : Offer
    {
        private string _childrenAgeExp; // ovo bi mozda trebala biti lista int brojeva koji bi predstavljali godine djece
        private string _availybility;

        public virtual string ChildrenAgeExp
        {
            get { return _childrenAgeExp; }
            set { _childrenAgeExp = value; }
        }
        public virtual string Availybility
        {
            get { return _availybility; }
            set { _availybility = value; }
        }
    }
}
