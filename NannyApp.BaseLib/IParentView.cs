using NannyApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NannyApp.BaseLib
{
    public interface IParentView
    {
        string Username { get; set; }
        string Password { get; set; }
        string Name { get; set; }
        string Surname { get; set; }
        Gender Gender { get; set; }
        string Contact { get; set; }
    }
}
