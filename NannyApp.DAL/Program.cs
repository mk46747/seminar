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

        }

        private static void CreateReviewAndSaveToDatabase()
        {
            var review = new Review();

            review.Grade = 4;
            review.ReviewText = "tdsdstt";

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
