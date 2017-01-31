using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NannyApp.BaseLib;
using NannyApp.DAL;
using NannyApp.Model.Repositories;
using NannyApp.Presentation;
using NannyApp.Model;
using System.Windows.Forms;


namespace NannyApp.Controllers
{
    public class MainFormController : IMainFormController
    {
        private bool DefaultModelLoaded = false;

        private readonly IWindowFormsFactory WindowFormsFactory = null;
        private readonly IUserRepository UserRepository = null;
        private readonly IOfferRepository OfferRepository = null;
        private readonly ICooperationRepository CooperationRepository = null;

        public MainFormController(IWindowFormsFactory WindowsFormsFactory, IUserRepository UserRepository
            , IOfferRepository OfferRepository, ICooperationRepository CooperationRepository)
        {
            this.WindowFormsFactory = WindowsFormsFactory;
            this.UserRepository = UserRepository;
            this.OfferRepository = OfferRepository;
            this.CooperationRepository = CooperationRepository;
        }

        public void ShowMainForm(User User)
        {
            var MainForm = WindowFormsFactory.CreateMainView(this);
            var form = (Form)MainForm;
            form.Show();
        }

        public void ShowLoginForm(IStartView StartView)
        {
            AccountController AccountController = new AccountController();
            var LoginView = WindowFormsFactory.CreateLoginView(this);
            var form = (Form)StartView;
            form.Hide();
            form.ShowInTaskbar = false;
            AccountController.ShowLoginForm(LoginView);
            
            // LoginController.Login(UserRepository, LoginView, this);
        }

        public void ShowCreateNannyForm()
        {//ovdje dođem s create forme i trebao bih otići spremiti nanny i vratiti mainnannyform
            NannyController NannyController = new NannyController();
            var CreateNannyForm = WindowFormsFactory.CreateNannyView(this);
            NannyController.ShowCreateNannyForm(CreateNannyForm);

            //nanycon umjesto
        }
        public void CreateNanny(INannyView CreateNannyForm)
        {
            NannyController NannyController = new NannyController();
            NannyController.CreateNanny(CreateNannyForm, UserRepository);
        }

        public void CreateParent()
        {

        }

        public void LoginUser(ILoginView LoginView)
        {
            AccountController LoginController = new AccountController();

            AccountController.Login(UserRepository, LoginView, this);
        }
        private void HideForm(Form form)
        {

        }
    }
}
