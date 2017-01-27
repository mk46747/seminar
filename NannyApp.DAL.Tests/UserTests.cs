using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NannyApp.Model;
using NannyApp.Model.Factories;
using NannyApp.DAL.Repositories;
using System.Diagnostics;

namespace NannyApp.DAL.Tests
{
    [TestClass]
    public class UserTests
    {
        [TestMethod]
        public void Parent_CreateInstance()
        {
            User newParent = UserFactory.CreateParent("IIvic", "12321", "Ivan", "Ivić", Gender.MALE, "060 723 555");
            UserRepository repository = new UserRepository();
            repository.AddUser(newParent);

            Parent p = repository.GetParent("IIvic", "12321");
            Debug.Assert(p == newParent);
        }

        [TestMethod]
        public void Parent_RemoveInstance()
        {
            UserRepository repository = new UserRepository();
            repository.AddUser(UserFactory.CreateParent("JJovic", "qwewq", "Jelena", "Jović", Gender.FEMALE, "092 092 092"));
            Parent p = repository.GetParent("JJovic", "qwewq");
            repository.DeleteUser(p);
        }

        [TestMethod]
        public void Nanny_CreateInstance()
        {
            //User newNanny = UserFactory.CreateNanny()
            //UserRepository repository = new UserRepository();

        }
    }
}
