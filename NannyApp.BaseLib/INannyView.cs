using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NannyApp.Model;

namespace NannyApp.BaseLib
{
    public interface INannyView
    {
       
        int NannyId {get; set;}
        void AdjustCreateView();
        void AdjustEditView();
        void AdjustOuterView();

        void HideUpdateButton();
        void HideViewReviewsButton();

        string Username { get; set; }
        string Password { get; set; }
        string NannyName { get; set; }
        string Surname { get; set; }
        string Contact { get; set; }
        string Education { get; set; }
        string ExtraQualification { get; set; }
        string ExtraServices { get; set; }
        Gender Gender { get; set; }
        bool Smoking { get; set; }
        bool Pets { get; set; }
        bool SickChildren { get; set; }
        bool DriversLicence { get; set; }




        


    }
}
