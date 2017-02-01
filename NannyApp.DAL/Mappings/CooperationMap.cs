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
            Id(b => b.Id).Column("Id").CustomType("Int32").GeneratedBy.Native();

            References(b => b.CooperationInitiator).Column("CooperationInitiatorId").Not.LazyLoad().Cascade.All();
            References(b => b.CooperationAcceptee).Column("CooperationAccepteeId").Not.LazyLoad().Cascade.All();
            References(b => b.Offer).Column("OfferId").Not.LazyLoad().Cascade.All();
            Map(b => b.Status).Column("StatusId").CustomType<CooperationStatus>().Not.Nullable();
            References(b => b.Review).Column("ReviewId").Not.LazyLoad().Cascade.All();
        }
    }
}
