﻿using System;
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

        public bool AddCooperation(Cooperation Cooperation)
        {
            using (var session = NHibernateService.OpenSession())
            {
                try
                {
                    using (var transaction = session.BeginTransaction())
                    {
                        session.Save(Cooperation);
                        transaction.Commit();
                        session.Clear();
                    }
                }

                catch (Exception e)
                {
                    Logger.Log(e);
                    return false;
                }
            }
            return true;
        }
        public Cooperation GetCooperation(int Id)
        {
            Cooperation Cooperation = null;
            using (var session = NHibernateService.OpenSession())
            {
                try
                {
                    using (var transaction = session.BeginTransaction())
                    {
                        Cooperation = session.Get<Cooperation>(Id);
                        transaction.Commit();
                    }
                }

                catch (Exception e)
                {
                    Logger.Log(e);
                    return null;
                }
            }
            return Cooperation;
        }

    }
}
