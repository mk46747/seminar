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

            References(b => b.CooperationInitiator).Column("CooperationInitiatorId").Cascade.All();
            References(b => b.CooperationAcceptee).Column("CooperationAccepteeId").Cascade.All();
            References(b => b.Offer).Column("OfferId").Cascade.All();
            Map(b => b.Status).Column("StatusId").CustomType<CooperationStatus>().Not.Nullable();
            References(b => b.Review).Column("ReviewId").Cascade.All();
        }
    }
}
