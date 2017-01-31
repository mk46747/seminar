
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NannyApp.Model;

namespace NannyApp.BaseLib
{
   public interface IMainView
    {
        //User User { get; set; }

       void HideLoginButton();
       void SetWelcomeLabel(string text);

       void EnableMenu();

    }
}
