using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NannyApp.Model
{
    public class NannyOffer : Offer
    {
        public virtual Nanny Nanny { get; set; }

        public NannyOffer()
            : base()
        {

        }
        public NannyOffer(int Id)
            : base(Id)
        {

        }
    }
}
