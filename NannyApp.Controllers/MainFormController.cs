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
            if (User == null)
            {
                return;
            }
            var mainForm = WindowFormsFactory.CreateMainView(this);
            mainForm.HideLoginButton();
            mainForm.SetWelcomeLabel("Welcome " + User.Name);
            mainForm.EnableMenu();
            var form = (Form)mainForm;
            form.Show();
        }

        public void ShowLoginForm(IMainView MainView)
        {
            var frm = (Form)MainView;
            frm.Hide();
            frm.ShowInTaskbar = false;
            AccountController AccountController = new AccountController();
            var LoginView = WindowFormsFactory.CreateLoginView(this);
           
             AccountController.ShowLoginForm(LoginView);
            
            // LoginController.Login(UserRepository, LoginView, this);
        }

        public void ShowNannyForm(Form LoginView)
        {//ovdje dođem s create forme i trebao bih otići spremiti nanny i vratiti mainnannyform
            NannyController NannyController = new NannyController();
            var CreateNannyForm = WindowFormsFactory.CreateNannyView(this);
            NannyController.ShowCreateNannyForm(CreateNannyForm);
            LoginView.Close();
            //nanycon umjesto
        }
        public void CreateNanny(INannyView CreateNannyForm)
        {
            NannyController NannyController = new NannyController();
            NannyController.CreateNanny(CreateNannyForm, UserRepository);
        }

        public void ShowParentForm(Form LoginView)
        {
            ParentController ParentController = new ParentController();
            ParentForm ParentForm = (ParentForm)WindowFormsFactory.CreateParentView(this);
            ParentController.ShowParentForm(ParentForm);
            LoginView.Close();

        }

        public void LoginUser(ILoginView LoginView)
        {
            AccountController AccountController = new AccountController();

            User User = AccountController.Login(UserRepository, LoginView, this);

            ShowMainForm(User);
        }
        private void HideForm(Form form)
        {

        }
    }
}
