using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NannyApp.Model
{
    public class Review
    {
        public virtual int Id { get; set; }
        public virtual string ReviewText { get; set; }
        public virtual int Grade { get; set; }

        public Review()
        {

        }
        public Review(int Grade, string ReviewText)
        {
            this.Grade = Grade;
            this.ReviewText = ReviewText;
        }
    }
}
