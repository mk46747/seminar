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
            var newFrm = new MainForm2(MainFormController);

            return newFrm;
        }

        public INannyView CreateNannyView(IMainFormController MainFormController)
        {
            return new NannyForm(MainFormController);
        }
		
    }
}
