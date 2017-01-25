using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NannyApp.Model;
using FluentNHibernate.Mapping;

namespace NannyApp.DAL.Mappings
{
    class ReviewMap : ClassMap<Review>
    {
        public ReviewMap()
        {
            Table("Review");

            Map(b => b.Review).Column("Review").CustomType("String").Not.Nullable().Length(500);
            Map(b => b.Grade).Column("Grade").CustomType("Int32").Not.Nullable();
        }
    }
}
