﻿using System;
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

        public ICreateNannyView CreateNannyView(IMainFormController MainFormController)
        {
            return new CreateNannyForm(MainFormController);
        }
		
    }
}
