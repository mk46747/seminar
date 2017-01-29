using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NannyApp.BaseLib
{
    public interface IWindowFormsFactory
    {
     //   IAddNannyView CreateNannyView();
        ILoginView CreateLoginView(IMainFormController MainFormController);
        ICreateNannyView CreateNannyView(IMainFormController MainFormController);

        /*
        IAddNewAccountView CreateAddNewAccountView(List<string> inAccType);
        IEditAccountView CreateEditAccountView();
        IShowAccountsListView CreateShowAccountsListView();
         */
    }
}
