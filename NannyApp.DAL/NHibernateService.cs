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
            ISessionFactory sessionFactory = null;
            try
            {
               AppDomain.CurrentDomain.SetData("DataDirectory", "c:/");
                Object datadir = AppDomain.CurrentDomain.GetData("DataDirectory");

                var nhConfig = Fluently.Configure()
                    .Database(SQLiteConfiguration.Standard
                          .ConnectionString("data source=|DataDirectory|test.db;")
                     //   .ConnectionString("data source=c:/(localdb)baza.db;")
                        .AdoNetBatchSize(100))
                    .Mappings(mappings => mappings.FluentMappings.AddFromAssemblyOf<UserMap>())
                    .BuildConfiguration();
                
                sessionFactory = nhConfig.BuildSessionFactory();
                var schemaExport = new SchemaUpdate(nhConfig);
                //var schemaExport = new SchemaExport(nhConfig);
                schemaExport.Execute(true, true);
                //schemaExport.Create(false, true); 

            }
            catch(Exception e)
            {
                Logger.Log(e);
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }

            return sessionFactory;
            
        }
    }
}
