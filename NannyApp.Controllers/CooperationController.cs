using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NannyApp.BaseLib;
using NannyApp.Model.Repositories;
using NannyApp.Model;
using System.Windows.Forms;
namespace NannyApp.Controllers
{
    public class CooperationController
    {
        public void ShowCooperation(ICooperationView CooperationView, int CooperationId, ICooperationRepository CooperationRepository, User User)
        {
            Cooperation Cooperation = CooperationRepository.GetCooperation(CooperationId);
            if (Cooperation.CooperationInitiator.Id != User.Id)
            {
                CooperationView.HideReviewButton();
            }
            CooperationView.NannyUserName = Cooperation.CooperationInitiator.Username;
            CooperationView.ParentUserName = Cooperation.CooperationAcceptee.Username;
            CooperationView.NannyContact = Cooperation.CooperationInitiator.Contact;
            CooperationView.ParentContact = Cooperation.CooperationAcceptee.Contact;
            CooperationView.StartDate = Cooperation.Offer.StartTime;
            CooperationView.EndDate = Cooperation.Offer.EndTime;
            CooperationView.Price = Cooperation.Offer.Price;
            CooperationView.CooperationId = Cooperation.Id;
            CooperationView.Status = Cooperation.Status;



            var frm = (Form)CooperationView;
            frm.Show();
        }

        public void UpdateCooperation(ICooperationView CooperationView,
            IUserRepository UserRepository,User User)
        {
            
            Cooperation Cooperation = GetCooperation(User, CooperationView.CooperationId);
            if (Cooperation == null)
            {
                MessageBox.Show("Error");
            }
            Cooperation.Status = CooperationView.Status;
            UserRepository.UpdateUser(User);


            var frm = (Form)CooperationView;
            frm.Close();
        }

        private Cooperation GetCooperation(User User, int CooperationId)
        {
             if (User.UserType == UserType.NANNY)
            {
                 Nanny n = (Nanny)User;
                 foreach(var c in n.Cooperations){
                     if(c.Id == CooperationId){
                         return c;
                     }
                 }
                
            }
             else if (User.UserType == UserType.PARENT)
             {
                 Parent p = (Parent)User;
                 foreach (var c in p.Cooperations)
                 {
                     if (c.Id == CooperationId)
                     {
                         return c;
                     }
                 }
             }
             return null;
        }

        public void ShowMyCooperations(ICooperationsView CooperationsView, User CurrentUser){
            IList<Cooperation> Cooperations = new List<Cooperation>();
             if (CurrentUser.UserType == UserType.NANNY)
            {
                 Nanny n = (Nanny)CurrentUser;
                 if (n.Cooperations.Count != 0)
                 {
                     Cooperations = n.Cooperations;
                 }
            }
            else if (CurrentUser.UserType == UserType.PARENT)
            {
                Parent n = (Parent)CurrentUser;
                if (n.Cooperations.Count != 0)
                {
                    Cooperations = n.Cooperations;
                }
            }
            else
            {
                MessageBox.Show("Error");
                return;
            }

             CooperationsView.Cooperations = Cooperations;
             var frm = (Form)CooperationsView;
             frm.Show();
        }
    }
}
