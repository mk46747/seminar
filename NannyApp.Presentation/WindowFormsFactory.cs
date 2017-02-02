using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NannyApp.BaseLib;

namespace NannyApp.Presentation
{
    public class WindowFormsFactory: IWindowFormsFactory
	{
		public ILoginView CreateLoginView(IMainFormController MainFormController ) {
			var newFrm = new LoginForm(MainFormController);

			return newFrm;
		}
        public IMainView CreateMainView(IMainFormController MainFormController)
        {
            var newFrm = new MainForm(MainFormController);

            return newFrm;
        }
        public IReviewsView CreateReviewsView(IMainFormController MainFormController)
        {
            var newFrm = new ReviewsForm(MainFormController);

            return newFrm;
        }
        public IReviewView CreateReviewView(IMainFormController MainFormController)
        {
            var newFrm = new ReviewForm(MainFormController);

            return newFrm;
        }
        public ICooperationView CreateCooperationView(IMainFormController MainFormController)
        {
            var newFrm = new CooperationForm(MainFormController);

            return newFrm;
        }
        public ICooperationsView CreateCooperationsView(IMainFormController MainFormController)
        {
            var newFrm = new CooperationsForm(MainFormController);

            return newFrm;
        }

        public INannyView CreateNannyView(IMainFormController MainFormController)
        {
            return new NannyForm(MainFormController);
        }

        public IParentView CreateParentView(IMainFormController MainFormController)
        {
            return new ParentForm(MainFormController);
        }

        //public IOfferView CreateParentView(IMainFormController MainFormController)
        public IOfferView CreateOfferView(IMainFormController MainFormController)
        {
            return new OfferForm(MainFormController);
        }
		
    }
}
