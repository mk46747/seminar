using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NannyApp.BaseLib
{
    public interface IParentView
    {
        

         string GetUsername();
         void SetUsername(string Username);
    }
}
