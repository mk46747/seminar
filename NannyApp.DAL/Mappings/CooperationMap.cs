using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NannyApp.Model;
using FluentNHibernate.Mapping;

namespace NannyApp.DAL.Mappings
{
    class CooperationMap: ClassMap<Cooperation>
    {
        public CooperationMap()
        {
            Table("Cooperation");

            Map(b => b.CooperationInitiator).Column("CooperationInitiator").CustomType<User>().Not.Nullable(); //treba provjeriti je li ovo ide tako
            Map(b => b.CooperationAcceptee).Column("CooperationAcceptee").CustomType<User>().Not.Nullable();
            Map(b => b.Offer).Column("Offer").CustomType<Offer>().Not.Nullable();
            Map(b => b.Status).Column("Status").CustomType<CooperationStatus>().Not.Nullable();
            Map(b => b.Review).Column("Review").CustomType<Review>().Not.Nullable();
        }
    }
}
