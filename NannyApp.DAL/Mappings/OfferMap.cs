using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NannyApp.Model;
using FluentNHibernate.Mapping;

namespace NannyApp.DAL.Mappings
{
    class OfferMap : ClassMap<Offer>
    {
        public OfferMap()
        {
            Table("Offer");
            UseUnionSubclassForInheritanceMapping();

            Id(b => b.Id).Column("Id").CustomType("Int32").GeneratedBy.HiLo("1000");
            Map(b => b.Price).Column("Price").CustomType("Double").Not.Nullable().Length(50);
            Map(b => b.Experience).Column("Experience").CustomType("String").Not.Nullable().Length(500);
            Map(b => b.BabySittingPlace).Column("BabySittingPlace").CustomType<BabySittingPlace>().Not.Nullable().Length(50);
            Map(b => b.Notice).Column("Notice").CustomType("String").Length(500);
            Map(b => b.StartTime).Column("StartTime").CustomType("datetime").Not.Nullable();
            Map(b => b.EndTime).Column("EndTime").CustomType("datetime").Not.Nullable();
            Map(b => b.City).Column("City").CustomType("String").Not.Nullable().Length(50);
            Map(b => b.Address).Column("Address").CustomType("String").Not.Nullable().Length(100);
            Map(b => b.ChildrenNumber).Column("ChildrenNumber").CustomType("Int32").Not.Nullable();
            Map(b => b.MinChildrenAge).Column("MinChildrenAge").CustomType("Int32").Not.Nullable();
            Map(b => b.MaxChildrenAge).Column("MaxChildrenAge").CustomType("Int32").Not.Nullable();
            Map(b => b.Deadline).Column("Deadline").CustomType("datetime").Not.Nullable();
            //Map(b => b.Opened).Column("Opened").CustomType("Bool").Not.Nullable();
            Map(b => b.Opened).Column("Opened").Not.Nullable();
        }
    }

    class NannyOfferMap : SubclassMap<NannyOffer>
    {
        public NannyOfferMap()
        {
            Table("NannyOffer");
            Abstract();
            References(b => b.Nanny, "NannyId").Cascade.None(); 

        }
    }

    class ParentOfferMap : SubclassMap<ParentOffer>
    {
        public ParentOfferMap()
        {
            Table("ParentOffer");
            Abstract();

            References(b => b.Parent, "ParentId").Cascade.None();
        }
    }
}
