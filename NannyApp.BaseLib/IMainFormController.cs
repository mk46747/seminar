using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NannyApp.BaseLib
{
    public interface IMainFormController
    {
        void LoginUser(ILoginView LoginView);

        void CreateNanny(ICreateNannyView CreateNannyForm);

        void ShowCreateNannyForm();

        void CreateParent();
        /*
        void AddNanny();
        void AddParent();
        void AddNannyOffer();
        void AddParentOffer();
        void ShowNannyOffers();
        void ShowParentOffers();
         * */

       // void AddParentOffer();

       // void EditAccount(string accountName);
    }
}
