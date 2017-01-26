using NannyApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NannyApp.DAL
{
   public static class Program
    {
        private static void Main(string[] args)
        {
            CreateReviewAndSaveToDatabase();
            CreateAndFetchParent();
        }

        private static void CreateAndFetchParent()
        {
            ParentOffer offer = new ParentOffer(200, "doslovno bilo tko", BabySittingPlace.PARENTS_PLACE, "This is a notice?", new DateTime(), new DateTime(), "Varaždin", "Unska 2.4", 1, 8, 8, new DateTime(), null);
            User parent = new Parent("ZZZ", "1234", "Živadin", "Krempitić", Gender.MALE, "Unska 2.4", new List<Offer>() { offer }, null);
            offer.Parent = (Parent) parent;
            object id = 0;
            using(var session = NHibernateService.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    id = session.Save(parent);
                    transaction.Commit();
                }
                Console.WriteLine("parent (and offer?) saved");
                session.Clear();
            }

            using(var session = NHibernateService.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    Parent fetchedParent = session.Get<Parent>(id);
                    Console.WriteLine(fetchedParent.Name);
                    transaction.Commit();
                }
            }

            Console.ReadLine();
        }

        private static void CreateReviewAndSaveToDatabase()
        {
            var review = new Review();

            review.Grade = 7;
            review.ReviewText = "marko mrzljak";

            using (var session = NHibernateService.OpenSession())
            {
               using (var transaction = session.BeginTransaction())
                {
                    session.Save(review);
                    transaction.Commit();
                }
                Console.WriteLine("Saved review to the database");
            }
        }
    }
}
