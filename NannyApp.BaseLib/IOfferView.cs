using NannyApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NannyApp.BaseLib
{
    public interface IOfferView
    {
        void AdjustCreateView();
        void AdjustEditView();
        void AdjustApplyYesView();
        void AdjustApplyNoView();
        
        double Price { get; set; }
        string Experience { get; set; }
        BabySittingPlace BabySittingPlace { get; set; }
        string Notice { get; set; }
        DateTime StartTime { get; set; }
        DateTime EndTime { get; set; }
        CooperationStatus CooperationStatus { get; set; }
        string City { get; set; }
        string Address { get; set; }
        int ChildrenNumber { get; set; }
        int MinChildrenAge { get; set; }
        int MaxChildrenAge { get; set; }
        DateTime DeadLine { get; set; }

        int OfferId { get; set; }
    }
}
