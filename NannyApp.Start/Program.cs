using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NannyApp.BaseLib;
using NannyApp.DAL.Repositories;
using NannyApp.Controllers;
using NannyApp.Presentation;
using System.Windows.Forms;


namespace NannyApp.Start
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            IWindowFormsFactory WindowsFormsFactory = new WindowFormsFactory();

            // umjesto Singleton patterna, imati ćemo samo jednu instancu repozitorija unutar glavnog programa
            UserRepository UserRepository = new UserRepository();
            OfferRepository OfferRepository = new OfferRepository();
            CooperationRepository CooperationRepository = new CooperationRepository();
           

            // a za Account repozitorij koristimo Singleton
            MainFormController mainController = new MainFormController(WindowsFormsFactory, UserRepository, OfferRepository, CooperationRepository);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new NannyApp.Presentation.LoginForm(mainController));
        }
    }
}



