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

        private User CurrentUser;

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
        public void ShowMyCooperations()
        {
            CooperationController CooperationController = new CooperationController();
            ICooperationsView CooperationsView = WindowFormsFactory.CreateCooperationsView(this);
            CooperationController.ShowMyCooperations(CooperationsView, CurrentUser);
        }

        public void ShowMainForm()
        {
            if (CurrentUser == null)
            {
                return;
            }

            var mainForm = WindowFormsFactory.CreateMainView(this);
            mainForm.HideLoginButton();
            mainForm.SetWelcomeLabel("Welcome " + CurrentUser.Name);
            mainForm.EnableMenu();
            mainForm.NannyOffers = getNannyOffers();
            mainForm.NannyOffers = getNannyOffers();

            var form = (Form)mainForm;
            form.Show();
        }

        public void ShowReviews(int NannyId)
        {
            ReviewController ReviewController = new ReviewController();
            IReviewsView ReviewsView = WindowFormsFactory.CreateReviewsView(this);
            ReviewController.ShowReviews(ReviewsView, NannyId, UserRepository);
        }

        public void ShowOwner(IOfferView OfferView)
        {

            ShowProfile(GetOwner(OfferView.OfferId, OfferRepository));

        }

        private User GetOwner(int Id, IOfferRepository OfferRepository)
        {
            Offer Offer = OfferRepository.GetNannyOffer(Id);
            if (Offer != null)
            {
                NannyOffer o = (NannyOffer)Offer;
                return o.Nanny;
            }
            ParentOffer po = (ParentOffer)OfferRepository.GetParentOffer(Id);
            return po.Parent;


        }
        public void ShowMyProfile()
        {
            ShowProfile(CurrentUser);
        }


        public void ShowProfile(User User)
        {
            if (User.UserType == UserType.NANNY)
            {
                NannyController NannyController = new NannyController();
                INannyView NannyView = WindowFormsFactory.CreateNannyView(this);
                if (User.Id == CurrentUser.Id)
                {
                    NannyView.AdjustEditView();
                }
                else
                {
                    NannyView.AdjustOuterView();

                }
                NannyController.ShowMyProfile(NannyView, (Nanny)User);

            }
            else if (User.UserType == UserType.PARENT)
            {
                ParentController ParentController = new ParentController();
                IParentView ParentView = new ParentForm(this);
                if (User.Id == CurrentUser.Id)
                {
                    ParentView.AdjustEditView();
                }
                else
                {
                    ParentView.AdjustOuterView();

                }
                ParentController.ShowMyProfile(ParentView, (Parent)User);
            }
            else
            {
                MessageBox.Show("Error");
                return;
            }
        }

        public void InitializeLists(IMainView mainForm)
        {
           mainForm.NannyOffers = getNannyOffers();
            mainForm.ParentOffers = getParentOffers();
        }

        private List<ParentOffer> getParentOffers()
        {

            List<ParentOffer> offers = (List<ParentOffer>)OfferRepository.GetAllParentOffers();
            if (offers == null || offers.Count == 0)
            {
                return new List<ParentOffer>();
            }
            int end = offers.Count < 5 ? offers.Count : 5;
            return offers.GetRange(0, end);
        }
        private List<NannyOffer> getNannyOffers()
        {
            List<NannyOffer> offers = (List<NannyOffer>)OfferRepository.GetAllNannyOffers();
            if (offers == null || offers.Count == 0)
            {
                return new List<NannyOffer>();
            }
            int end = offers.Count < 5 ? offers.Count : 5;
            return offers.GetRange(0, end);
        }

        public void ApplyToOffer(int OfferId){
            OfferController OfferController = new OfferController();
            OfferController.ApplyToOffer(CurrentUser, OfferId,  OfferRepository,  UserRepository, CooperationRepository);
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
        {
            NannyController NannyController = new NannyController();
            var CreateNannyForm = WindowFormsFactory.CreateNannyView(this);
            CreateNannyForm.AdjustCreateView();
            NannyController.ShowNannyForm(CreateNannyForm);
            
            LoginView.Close();
            //nanycon umjesto
        }
        public void CreateNanny(INannyView NannyForm)
        {
            NannyController NannyController = new NannyController();
            User User = NannyController.CreateNanny(NannyForm, UserRepository);
            if (User == null)
            {
                return;
            }
            var frm = (Form)NannyForm;
            frm.Close();
            CurrentUser = User;
            ShowMainForm();
        }

        public void CreateOffer(IOfferView OfferForm)
        {
            OfferController OfferController = new OfferController();
            OfferController.CreateOffer(OfferForm, UserRepository, CurrentUser);
        }
        public void ShowCooperation(int Id)
        {
            CooperationController CooperationController = new CooperationController();
            ICooperationView CooperationView = WindowFormsFactory.CreateCooperationView(this);
            CooperationController.ShowCooperation(CooperationView, Id, CooperationRepository, CurrentUser);
        }
        public void UpdateCooperation(ICooperationView CooperationView)
        {
            CooperationController CooperationController = new CooperationController();
            CooperationController.UpdateCooperation(CooperationView, UserRepository, CurrentUser);
        }

        public void ShowReview(int CooperationId)
        {
            IReviewView ReviewView = WindowFormsFactory.CreateReviewView(this);
            ReviewController ReviewController = new ReviewController();
            ReviewController.ShowReview(ReviewView, CooperationId, CurrentUser);
        }

        public void SaveReview(IReviewView ReviewView)
        {
            ReviewController ReviewController = new ReviewController();
            ReviewController.SaveReview(ReviewView, CurrentUser, UserRepository);
        }


        public void ShowOfferForm(int Id, IMainView MainView)
        {
            if (CurrentUser == null)
            {
                MessageBox.Show("Logon or create account to view offer details");
                return;
            }
            OfferForm OfferForm = (OfferForm)WindowFormsFactory.CreateOfferView(this);

            NannyOffer no = OfferRepository.GetNannyOffer(Id);
            if (no != null)
            {
                if (CurrentUser.UserType == UserType.NANNY)
                {
                    OfferForm.AdjustApplyNoView();
                }
                else
                {
                    OfferForm.AdjustApplyYesView();
                }
            }
            ParentOffer po = OfferRepository.GetParentOffer(Id);
            if (po != null)
            {
                if (CurrentUser.UserType == UserType.PARENT)
                {
                    OfferForm.AdjustApplyNoView();
                }
                else
                {
                    OfferForm.AdjustApplyYesView();
                }
            }
            if (CurrentUser == null)
            {
                MessageBox.Show("Logon or create account to view offer details");
                return;
            }
            OfferController OfferController = new OfferController();
            //OfferForm OfferForm = (OfferForm)WindowFormsFactory.CreateOfferView(this);
            OfferController.ShowOfferForm(OfferForm, Id, UserRepository,  OfferRepository, CurrentUser);
        }
        public void ShowOfferForm()
        {
            OfferController OfferController = new OfferController();
            OfferForm OfferForm = (OfferForm)WindowFormsFactory.CreateOfferView(this);
            OfferController.ShowOfferForm(OfferForm);
        }

        public void ShowParentForm(Form LoginView)
        {
            ParentController ParentController = new ParentController();
            ParentForm ParentForm = (ParentForm)WindowFormsFactory.CreateParentView(this);
            ParentForm.AdjustCreateView();
            ParentController.ShowParentForm(ParentForm);
            LoginView.Close();

        }

        public void CreateParent(IParentView ParentForm)
        {
            ParentController ParentController = new ParentController();
            User User = ParentController.CreateParent(ParentForm, UserRepository);
            if (User == null)
            {
                return;
            }
            var frm = (Form)ParentForm;
            frm.Close();
            CurrentUser = User;
            ShowMainForm();
        }

        public void LoginUser(ILoginView LoginView)
        {
            AccountController AccountController = new AccountController();

            User User = AccountController.Login(UserRepository, LoginView, this);

            CurrentUser = User;
            ShowMainForm();
        }

        public void Logout(IMainView MainView)
        {
            CurrentUser = null;
            MainView.DisableMenu();
            MainView.SetWelcomeLabel("");
            MainView.ShowLoginButton();
        }

        public void ShowCreateOfferForm()
        {
            OfferController OfferController = new OfferController();
            
        }
    }
}
