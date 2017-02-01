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

        public void CreateOffer(IOfferView OfferView, IUserRepository UserRepository, User CurrentUser)
        {
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
            else
            {
                Offer Offer = OfferFactory.CreateParentOffer(Price, Experience, BabySittingPlace, Notice,
                    StartTime, EndTime, City, Address, ChildrenNumber, MinChildrenAge, MaxChildrenAge,
                    DeadLine, true, (Parent)CurrentUser);
                Parent parent = (Parent)CurrentUser;
                parent.AddOffer((ParentOffer)Offer);
                UserRepository.UpdateUser(parent);
            }
        }
    }
}
