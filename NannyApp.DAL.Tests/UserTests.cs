using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NannyApp.Model;
using NannyApp.Model.Factories;
using NannyApp.DAL.Repositories;

namespace NannyApp.DAL.Tests
{
    [TestClass]
    public class UserTests
    {
        [TestMethod]
        public void Parent_CreateInstance()
        {
            User newParent = UserFactory.CreateParent("IIvic", "12321", "Ivan", "Ivić", Gender.MALE, "060 723 555");
            object id = 0;

            using (var session = NHibernateService.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    id = session.Save(newParent);
                    transaction.Commit();
                }
                session.Clear();
            }

            UserRepository repository = new UserRepository();
            Parent p = repository.GetParent((int)id);

        }
    }
}
