using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NannyApp.Model.Repositories
{
    public interface ICooperationRepository
    {
        IList<Cooperation> GetAllCooperations();
        bool AddCooperation(Cooperation Cooperation);
    }
}
