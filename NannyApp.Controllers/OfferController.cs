using NannyApp.BaseLib;
using NannyApp.Model;
using NannyApp.Model.Factories;
using NannyApp.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NannyApp.Controllers
{
    public class OfferController
    {
        public void ShowOfferForm(IOfferView OfferView)
        {
            var form = (Form)OfferView;
            form.Show();
        }
        public void ShowOfferForm(IOfferView OfferView, int Id, IUserRepository UserRepository, IOfferRepository OfferRepository, User User)
        {

            Offer Offer = GetOffer(Id, OfferRepository);
            OfferView.Price = Offer.Price;
            OfferView.Experience = Offer.Experience;
            OfferView.BabySittingPlace = Offer.BabySittingPlace;
            OfferView.Notice = Offer.Notice;
            OfferView.StartTime = Offer.StartTime;
            OfferView.EndTime = Offer.EndTime;
         //   OfferView.CooperationStatus = Offer.Status;
            OfferView.City = Offer.City;
            OfferView.Address = Offer.Address;
            OfferView.MaxChildrenAge = Offer.MaxChildrenAge;
            OfferView.MinChildrenAge = Offer.MinChildrenAge;
            OfferView.ChildrenNumber = Offer.ChildrenNumber;
            OfferView.OfferId = Offer.Id;

            
            
            
            //////////set polja
            var form = (Form)OfferView;
            form.Show();
        }

        private Offer GetOffer(int Id, IOfferRepository OfferRepository)
        {
            Offer Offer = OfferRepository.GetNannyOffer(Id);
            if (Offer != null)
            {
                return Offer;
            }
            return OfferRepository.GetParentOffer(Id);


        }

        public void CreateOffer(IOfferView OfferView, IUserRepository UserRepository, User CurrentUser)
        {
            OfferView.AdjustCreateView();
            double Price = OfferView.Price;
            DateTime StartTime = OfferView.StartTime;
            DateTime EndTime = OfferView.EndTime;
            DateTime DeadLine = OfferView.DeadLine;
            string Address = OfferView.Address;
            string City = OfferView.City;
            BabySittingPlace BabySittingPlace = OfferView.BabySittingPlace;
            int ChildrenNumber = OfferView.ChildrenNumber;
            string Experience = OfferView.Experience;
            int MinChildrenAge = OfferView.MinChildrenAge;
            int MaxChildrenAge = OfferView.MaxChildrenAge;
            string Notice = OfferView.Notice;

            if (Price == 0 || StartTime == null || EndTime == null || DeadLine == null
                || Address == "" || City == "" || ChildrenNumber == 0 || MinChildrenAge == 0
                || MaxChildrenAge == 0)
            {
                MessageBox.Show("Please fill all the fields.");
                return;
            }

            
            if (CurrentUser.UserType == UserType.NANNY)
            {
                Offer Offer = OfferFactory.CreateNannyOffer(Price, Experience, BabySittingPlace, Notice,
                    StartTime, EndTime, City, Address, ChildrenNumber, MinChildrenAge, MaxChildrenAge, 
                    DeadLine, true, (Nanny)CurrentUser);
                Nanny nanny = (Nanny)CurrentUser;
                nanny.AddOffer((NannyOffer)Offer);
                UserRepository.UpdateUser(nanny);
            }
            else if (CurrentUser.UserType == UserType.PARENT)
            {
                Offer Offer = OfferFactory.CreateParentOffer(Price, Experience, BabySittingPlace, Notice,
                    StartTime, EndTime, City, Address, ChildrenNumber, MinChildrenAge, MaxChildrenAge,
                    DeadLine, true, (Parent)CurrentUser);
                Parent parent = (Parent)CurrentUser;
                parent.AddOffer((ParentOffer)Offer);
                UserRepository.UpdateUser(parent);
            }
            else
            {
                //
            }
            var form = (Form)OfferView;
            form.Hide();
        }

        public  void ApplyToOffer(User CurrentUser, int OfferId, IOfferRepository OfferRepository,
            IUserRepository UserRepository, ICooperationRepository CoorporationRepository)
        {
            Offer Offer = GetOffer(OfferId, OfferRepository);
            User Aceptee = null;
            Type o = Offer.GetType();
            if (Offer.GetType() ==  typeof(NannyOffer))
            {
                NannyOffer no = (NannyOffer)Offer;
                Aceptee = no.Nanny;
            }else if(Offer.GetType() == typeof(ParentOffer)){
                ParentOffer po = (ParentOffer) Offer;
                Aceptee = po.Parent;
            }else{
                MessageBox.Show("Error");
                return;
            }

            Cooperation Cooperation = CooperationFactory.CreateCooperation(CurrentUser, Aceptee, Offer);
           // CoorporationRepository.AddCooperation(Cooperation);

            if (Aceptee.UserType == UserType.NANNY)
            {
                Nanny n = (Nanny)Aceptee;
                n.AddCooperation(Cooperation);
                UserRepository.UpdateUser(n);
                MessageBox.Show("You applied successfully");

            }
            else if (Aceptee.UserType == UserType.PARENT)
            {
                Parent p = (Parent)Aceptee;
                p.AddCooperation(Cooperation);
                UserRepository.UpdateUser(p);
                MessageBox.Show("You applied successfully");

            }
            
        }
    }
}
