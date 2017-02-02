using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NannyApp.BaseLib
{
    public interface IWindowFormsFactory
    {
        ILoginView CreateLoginView(IMainFormController MainFormController);
        INannyView CreateNannyView(IMainFormController MainFormController);
        IMainView CreateMainView(IMainFormController MainFormController);
        IParentView CreateParentView(IMainFormController MainFormController);
        IOfferView CreateOfferView(IMainFormController MainFormController);
        IReviewView CreateReviewView(IMainFormController MainFormController);
        IReviewsView CreateReviewsView(IMainFormController MainFormController);
        ICooperationView CreateCooperationView(IMainFormController MainFormController);
        ICooperationsView CreateCooperationsView(IMainFormController MainFormController);
        
    }
}
