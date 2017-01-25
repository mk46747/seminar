using NannyApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NannyApp.DAL
{
    class TestProgram
    {
        private static void Main(string[] args)
        {
            CreateNannyAndSaveToDatabase();
            //UpdateTobinAndAssignPierreAsManager();
            //LoadEmployeesFromDatabase();
        }

        private static void CreateNannyAndSaveToDatabase()
        {
            var nanny = new Nanny(0, "nanny", "nanny");
            nanny.Name = "Tobin Harris";

            using (var session = NHibernateService.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.Save(nanny);
                    transaction.Commit();
                }
                Console.WriteLine("Saved Nanny to the database");
            }
        }

        private static void LoadEmployeesFromDatabase()
        {
            using (var session = NHibernateService.OpenSession())
            {
                var query = session.CreateQuery(
                    "from Employee as emp order by emp.Name asc");

                var foundNannys = query.List<Nanny>();

                Console.WriteLine("\n{0} employees found:", foundNannys.Count);

                foreach (var nanny in foundNannys)
                {
                    Console.WriteLine(nanny.Name);
                }
            }
        }
/*
        private static void UpdateTobinAndAssignPierreAsManager()
        {
            using (var session = OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var q = session.CreateQuery("from Employee where Name = 'Tobin Harris'");

                    var tobin = q.List<Employee>()[0];
                    tobin.Name = "Tobin David Harris";

                    var pierre = new Employee();
                    pierre.Name = "Pierre Henri Kuate";

                    tobin.Manager = pierre;
                    session.Save(pierre);

                    transaction.Commit();

                    Console.WriteLine("Updated Tobin and added Pierre");
                }
            }
        }*/
    }
}
