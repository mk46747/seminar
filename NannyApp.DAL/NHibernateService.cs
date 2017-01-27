using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NannyApp.DAL.Mappings;

using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;

namespace NannyApp.DAL
{

    using global::NHibernate;
    using global::NHibernate.Cfg;
    using global::NHibernate.Tool.hbm2ddl;
    public static class NHibernateService
    {
        private static ISessionFactory sessionFactory;

        public static ISession OpenSession()
        {
            //try
            {
                if (sessionFactory == null)
                {
                    sessionFactory = OpenSessionFactory();
                }
                ISession session = sessionFactory.OpenSession();
                return session;
            }
            //catch (Exception e)
            //{
            //    throw e.InnerException ?? e;
            //}
        }

        private static ISessionFactory OpenSessionFactory()
        {
            var nhConfig = Fluently.Configure()
                .Database(SQLiteConfiguration.Standard
                    .ConnectionString("Data Source=NannyAppDB.db;Version=3")
                    .AdoNetBatchSize(100))
                .Mappings(mappings => mappings.FluentMappings.AddFromAssemblyOf<UserMap>())
                .BuildConfiguration();

            var sessionFactory = nhConfig.BuildSessionFactory();
            var schemaExport = new SchemaUpdate(nhConfig);
            //var schemaExport = new SchemaExport(nhConfig);
            schemaExport.Execute(true, true); 
            //schemaExport.Create(false, true); 
            return sessionFactory;
        }
    }
}
