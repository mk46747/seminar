using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NannyApp.BaseLib
{
    public interface IMainController
    {
        void AddNanny();
        void AddParent();
        void AddNannyOffer();
        void AddParentOffer();

       // void EditAccount(string accountName);
    }
}
