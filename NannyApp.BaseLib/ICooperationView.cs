using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NannyApp.Model;

namespace NannyApp.BaseLib
{
    public interface ICooperationView
    {
        void HideReviewButton();
        CooperationStatus Status { get; set; }
        int CooperationId { get; set; }
        string NannyUserName { set; }
        string ParentUserName { set; }
        string NannyContact { set; }
        string ParentContact { set; }
        DateTime StartDate { set; }
        DateTime EndDate { set; }
        double Price { set; }
    }
}
