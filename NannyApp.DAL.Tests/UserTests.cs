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
            User newParent = UserFactory.CreateParent("IIvic", "12321", "Ivan", "Ivić", Gender.MALE, "060 723 555", UserType.PARENT);
            UserRepository repository = new UserRepository();
            repository.AddUser(newParent);
            Parent p = repository.GetParent("IIvic", "12321");
            Debug.Assert(p == newParent);
        }

        [TestMethod]
        public void Parent_RemoveInstance()
        {
            User newParent = UserFactory.CreateParent("JJovic", "qwewq", "Jelena", "Jović", Gender.FEMALE, "092 092 092", UserType.PARENT);
            UserRepository repository = new UserRepository();
            repository.AddUser(newParent);
            repository.DeleteUser(newParent);
            Debug.Assert(repository.GetParent("JJovic", "jolejecar") == null);
        }

        [TestMethod]
        public void Nanny_CreateInstance()
        {
            User newNanny = UserFactory.CreateNanny("AHorvat", "ghjkl", "Ana", "Horvat", Gender.FEMALE, "+385 98 125 678", UserType.NANNY, "Psychology bachelor", false, true, true, null, null);
            UserRepository repository = new UserRepository();
            repository.AddUser(newNanny);
            Nanny n = repository.GetNanny("AHorvat", "ghjkl");
            Debug.Assert(n == newNanny);
        }

        [TestMethod]
        public void Nanny_RemoveInstance()
        {
            User newNanny = UserFactory.CreateNanny("JHorvat", "jolejecar", "Josip", "Horvat", Gender.MALE, "trg kralja petra krešimira 4. 3b", UserType.NANNY, "Pedagogy major", true, false, false, null, null);
            UserRepository repository = new UserRepository();
            repository.AddUser(newNanny);
            repository.DeleteUser(newNanny);
            Debug.Assert(repository.GetNanny("JHorvat", "jolejecar") == null);
        }

        [TestMethod]
        public void Admin_CreateInstance()
        {
            User newAdmin = UserFactory.CreateAdmin("IMesic", "474811", "Ivana", "Mesić", Gender.FEMALE, "060 722 722", UserType.ADMIN);
            UserRepository repository = new UserRepository();
            repository.AddUser(newAdmin);
            Admin a = repository.GetAdmin("IMesic", "474811");
            Debug.Assert(a == newAdmin);
        }

        [TestMethod]
        public void Admin_RemoveInstance()
        {
            User newAdmin = UserFactory.CreateAdmin("JPajic", "abc123", "Juraj", "Pajić", Gender.MALE, "098 886 432", UserType.ADMIN);
            UserRepository repository = new UserRepository();
            repository.AddUser(newAdmin);
            repository.DeleteUser(newAdmin);
            Debug.Assert(repository.GetAdmin("JPajic", "abc123") == null);
        }

        [TestMethod]
        public void User_UpdateInstance()
        {
            User newUser = UserFactory.CreateAdmin("MCesarec", "bmwbmw", "Marija", "Cesarec", Gender.MALE, "091 285, 3470", UserType.ADMIN);
            UserRepository repository = new UserRepository();
            repository.AddUser(newUser);
            newUser.Contact = "091 295, 3470";
            repository.UpdateUser(newUser);
        }
    }
}