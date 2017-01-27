using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NannyApp.Model.Repositories;
using NannyApp.Model;
using NHibernate;

namespace NannyApp.DAL.Repositories
{
    public class UserRepository : IUserRepository
    {
        public UserRepository()
        {

        }
        public bool AddUser(User User)
        {
            using (var session = NHibernateService.OpenSession())
            {
                try
                {
                    using (var transaction = session.BeginTransaction())
                    {

                        session.Save(User);
                        transaction.Commit();
                    }
                    session.Clear();
                    //session.Close();
                }
                catch (Exception e)
                {
                    Logger.Log(e);
                    return false;
                }

            }
            return true;
        }
        public bool DeleteUser(User User)
        {
            using (var session = NHibernateService.OpenSession())
            {
                try
                {
                    using (var transaction = session.BeginTransaction())
                    {

                        session.Delete(User);
                        transaction.Commit();
                    }
                    session.Clear();
                    //session.Close();

                }
                catch (Exception e)
                {
                    Logger.Log(e);
                    return false;
                }

            }
            return true;
        }
        public bool DeleteUser(int Id)
        {
            using (var session = NHibernateService.OpenSession())
            {
                try
                {
                    using (var transaction = session.BeginTransaction())
                    {
                        User user = session.Get<User>(Id);
                        session.Delete(user);

                        transaction.Commit();
                    }
                    session.Clear();
                   // session.Close();

                }
                catch (Exception e)
                {
                    Logger.Log(e);
                    return false;
                }

            }
            return true;

        }

        public bool DeleteUser(string Username, string Password)
        {
            User User = GetUser<User>(Username, Password);
            return DeleteUser(User);

        }
        public Admin GetAdmin(int Id)
        {
            return GetUser<Admin>(Id);
        }
        public Nanny GetNanny(int Id)
        {
            return GetUser<Nanny>(Id);
        }
        public Parent GetParent(int Id)
        {
            return GetUser<Parent>(Id);
        }
        private T GetUser<T>(int Id) where T : User
        {
            T User = default(T);
            using (var session = NHibernateService.OpenSession())
            {
                try
                {
                    using (var transaction = session.BeginTransaction())
                    {
                       // User = session.QueryOver<User>().Where(c => c.Id == Id)
                        //    .And(c => c is T).SingleOrDefault();
                        User = (T) session.Get(typeof(T), Id);
                        transaction.Commit();
                    }
                    session.Clear();
                    //session.Close();

               }
                catch (Exception e)
                {
                    Logger.Log(e);
                    return User;
                }
            }
            return  User;
        }
        public Admin GetAdmin(string Username, string Password)
        {
            return (Admin)GetUser<Admin>(Username, Password);
        }
        public Nanny GetNanny(string Username, string Password)
        {
            return (Nanny)GetUser<Nanny>(Username, Password);
        }
        public Parent GetParent(string Username, string Password)
        {
            return (Parent)GetUser<Parent>(Username, Password);
        }

        private T GetUser<T>(string Username, string Password) where T :  User

        {
            T User = default(T);
            using (var session = NHibernateService.OpenSession())
            {
                try
                {
                    using (var transaction = session.BeginTransaction())
                    {
                        

                        User = session.QueryOver<T>().Where(c => c.Username == Username)
                            .And(c => c.Password == Password)
                            .SingleOrDefault();
                        transaction.Commit();
                    }
                    session.Clear();
                    //session.Close();

                }
                catch (Exception e)
                {
                    Logger.Log(e);
                    return null;
                }
            }
            return User;
        }

        private IList<T> GetAllUsers<T>() where T : User
        {
            IList<T> Users = null;
            using (var session = NHibernateService.OpenSession())
            {
                try
                {
                    using (var transaction = session.BeginTransaction())
                    {
                        Users = session.QueryOver<T>().List();
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
            return Users;

        }
        public IList<Parent> GetAllParents()
        {
            return GetAllUsers<Parent>();
        }
        public IList<Nanny> GetAllNannies()
        {
            return GetAllUsers<Nanny>();
        }
        public bool UpdateUser(User User)
        {
            using (var session = NHibernateService.OpenSession())
            {
                try
                {
                    using (var transaction = session.BeginTransaction())
                    {

                        session.Update(User);
                        transaction.Commit();
                    }
                    session.Clear();
                    //session.Close();

                }
                catch (Exception e)
                {
                    Logger.Log(e);
                    return false;
                }

            }
            return true;


        }
    }
}
