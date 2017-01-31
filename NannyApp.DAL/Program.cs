using NannyApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NannyApp.Model.Repositories;
using NannyApp.DAL.Repositories;


namespace NannyApp.DAL
{
   public static class Program
    {
        private static void Main(string[] args)
        {
            CreateReviewAndSaveToDatabase();
            CreateAndFetchParent();
            Console.ReadLine();
        }

        private static void CreateAndFetchParent()
        {
            ParentOffer offer = new ParentOffer(200, "doslovno bilo tko", BabySittingPlace.PARENTS_PLACE, "This is a notice?", new DateTime(), new DateTime(), "Varaždin", "Unska 2.4", 1, 8, 8, new DateTime(), false, null);
            Parent parent = new Parent("ZZZ", "1234", "Živadin", "Krempitić", Gender.MALE, "Unska 2.4", UserType.ADMIN, new List<ParentOffer>(), null);
            offer.Parent = (Parent) parent;
            parent.AddOffer(offer);
            object id = 0;
            using(var session = NHibernateService.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    id = session.Save(parent);
                    transaction.Commit();
                }
                session.Clear();
               // session.c;
            }
            /*
            UserRepository UserRepository = new UserRepository();
            OfferRepository OfferRepository = new OfferRepository();
            Parent p = UserRepository.GetParent((int)id);
            Console.WriteLine(p.Name);

            Parent p2 = UserRepository.GetParent("ZZZ", "1234");
            Console.WriteLine(p2.Name);

            IList<Parent> parents = UserRepository.GetAllParents();
            Console.WriteLine(parents.ElementAt(0).Name);

            IList<ParentOffer> parentOffers = OfferRepository.GetAllParentOffers();
            Console.WriteLine(parentOffers.ElementAt(0).Experience);
            Exception e = new Exception();
            
            Logger.Log("marko beba mrzljak");


            Console.ReadLine();
            */

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
