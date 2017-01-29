using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NannyApp.Model.Repositories;
using NannyApp.Model;

namespace NannyApp.DAL.Repositories
{
    public class CooperationRepository : ICooperationRepository
    {
        public IList<Cooperation> GetAllCooperations()
        {
            IList<Cooperation> Cooperations = null;
            using (var session = NHibernateService.OpenSession())
            {
                try
                {
                    using (var transaction = session.BeginTransaction())
                    {
                        Cooperations = session.QueryOver<Cooperation>().List();
                        transaction.Commit();
                    }
                    session.Clear();
                    // session.Close();

                }
                catch (Exception e)
                {
                    Logger.Log(e);
                    return null;
                }
            }
            return Cooperations;

        }

    }
}
