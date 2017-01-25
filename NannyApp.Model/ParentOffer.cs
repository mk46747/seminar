using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NannyApp.Model
{
    public class ParentOffer : Offer
    {
        public virtual Parent Parent { get; set; }
        public ParentOffer(int Id)
            : base(Id)
        {
        }
            public ParentOffer()
            : base()
        {

    }


}
}
