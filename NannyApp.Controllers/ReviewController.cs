using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NannyApp.Model;
using NannyApp.BaseLib;
using System.Windows.Forms;
using NannyApp.Model.Repositories;
namespace NannyApp.Controllers
{
    public class ReviewController
    {
        public void ShowReviews(BaseLib.IReviewsView ReviewsView, int NannyId, Model.Repositories.IUserRepository UserRepository)
        {
            Nanny Nanny = UserRepository.GetNanny(NannyId);
            IList<Cooperation> Cooperations = Nanny.Cooperations;
            List<Review> Reviews = new List<Review>();

            foreach (var c in Cooperations){
                if(c != null)
                Reviews.Add(c.Review);
            }
            ReviewsView.Reviews = Reviews;
            var frm = (Form)ReviewsView;
            frm.Show();
        }
        public void SaveReview(IReviewView ReviewView, User User, IUserRepository UserRepository)
        {
            Cooperation Cooperation = GetCooperation(User, ReviewView.CooperationId);
            Review Review  = new Review(ReviewView.ReviewScore, ReviewView.Comment);
            Cooperation.Review = Review;
            UserRepository.UpdateUser(User);

            var frm = (Form)ReviewView;
            frm.Close();

        }

        public void ShowReview(IReviewView ReviewView, int CooperationId, User User )
        {
            ReviewView.CooperationId = CooperationId;
            Cooperation Cooperation = GetCooperation(User, CooperationId);
            Review Review = Cooperation.Review;
            if (Review != null)
            {
                ReviewView.ReviewScore = Review.Grade;
                ReviewView.Comment = Review.ReviewText;
                
            }
            var frm = (Form)ReviewView;
            frm.Show();
        }

        private Cooperation GetCooperation(User User, int CooperationId)
        {
            if (User.UserType == UserType.NANNY)
            {
                Nanny n = (Nanny)User;
                foreach (var c in n.Cooperations)
                {
                    if (c.Id == CooperationId)
                    {
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
    }
}
