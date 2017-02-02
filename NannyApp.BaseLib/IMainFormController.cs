using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NannyApp.Model;
using System.Windows.Forms;

namespace NannyApp.BaseLib
{
    public interface IMainFormController
    {
        void ShowNannyForm(Form LoginView);
        void CreateNanny(INannyView NannyView);
        void ShowLoginForm(IMainView MainView);
        void LoginUser(ILoginView LoginView);
        void ShowMainForm();
        void ShowMyCooperations();
        void ShowParentForm(Form LoginView);
        void CreateParent(IParentView ParentView);
        void ShowOfferForm();
        void ShowMyProfile();
        void CreateOffer(IOfferView OfferView);
        void ShowOfferForm(int Id, IMainView MinView);
        void ShowCooperation(int Id);
        void UpdateCooperation(ICooperationView CooperationView);
        void ShowReview(int CooperationId);
        void SaveReview(IReviewView ReviewView);
        void ShowReviews(int NannyId);
        void ShowOwner(IOfferView OfferView);
        void Logout(IMainView MainView);
        void ApplyToOffer(int Id);

        void InitializeLists(IMainView MainView);

        


    }
}
