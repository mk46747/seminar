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

       string GetUsername();
         string GetPassword();
         string GetName();
         string GetSurname();
         string GetContact();
         string GetEducation();
        
        string GetExtraServices();
         string GetExtraQualification();
         Gender GetGender();
         bool GetSmoking();
         bool GetPets();
         bool GetSickChildren();
         bool GetDriversLicence();
        


    }
}
