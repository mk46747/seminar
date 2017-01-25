using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NannyApp.Model
{
    public enum CooperationStatus {PENDING, ACCEPTED, DECLINED}
    public class Cooperation
    {
        public virtual int Id { get; set; }
        public virtual User CooperationInitiator { get; set; }
        public virtual User CooperationAcceptee { get; set; }
        public virtual Offer Offer { get; set; }
        public virtual CooperationStatus Status { get; set; }
        public virtual Review Review { get; set; }

    }
}
