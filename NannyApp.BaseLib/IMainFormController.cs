using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NannyApp.Model;

namespace NannyApp.BaseLib
{
    public interface IMainFormController
    {
        void ShowCreateNannyForm();
        void CreateNanny(ICreateNannyView CreateNannyView);
        void ShowLoginForm(IStartView StartView);
        void LoginUser(ILoginView LoginView);
        void ShowMainForm(User User);
        void ShowCreateParentForm();
        void CreateParent(ICreatParentView CreateParentView);
        void ShowCreateNannyOfferForm();
        void CreateNannyOffer(ICreateNannyOfferView CreateNannyOfferView);
        void ShowCreateParentOfferForm();
        void CreateParentOffer(ICreateParentOfferView CreateParentOfferView);
        void ShowOffersForm();
        void ShowOfferForm();
        void ShowCooperationsForm();
        void ShowNannyForm();
        void ShowParentForm();
        void ShowCooperationsForm();
        void ShowCooperationForm();

       
    }
}
