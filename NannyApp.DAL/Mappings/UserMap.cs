using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NannyApp.Model;
using FluentNHibernate.Mapping;

namespace NannyApp.DAL.Mappings
{
    class UserMap : ClassMap<User>
    {
        public UserMap()
        {
            Table("User");
            UseUnionSubclassForInheritanceMapping();
            Id(b => b.Id).Column("Id").CustomType("Int32").GeneratedBy.HiLo("1000");
            // Map(b => b.Username).Column("Username").CustomType("String").Not.Nullable().Length(50);
            //  Map(b => b.Password).Column("Password").CustomType("String").Not.Nullable().Length(50);

             Map(b => b.Username).Column("Username").Not.Nullable().Length(50);
             Map(b => b.Password).Column("Password").Not.Nullable().Length(50);

            Map(b => b.Name).Column("Name").CustomType("String").Not.Nullable().Length(50);
            Map(b => b.Surname).Column("Surname").CustomType("String").Not.Nullable().Length(50);
            //Map(o => o.AccountType).CustomType<AccountType>();
            Map(b => b.Gender).Column("Gender").CustomType<Gender>().Not.Nullable().Length(10);
            Map(b => b.Contact).Column("Contact").CustomType("String").Not.Nullable().Length(50);
            Map(b => b.UserType).Column("UserType").CustomType<UserType>().Not.Nullable().Length(25);
        }
    }

    class ParentMap : SubclassMap<Parent>
    {
        public ParentMap()
        {
            Table("Parent");
            Abstract();

            HasMany(b => b.Offers).KeyColumn("OfferId").Cascade.All();
            HasMany(b => b.Cooperations).KeyColumn("CooperationId").Cascade.All();
        }
    }

    class NannyMap : SubclassMap<Nanny>
    {
        public NannyMap()
        {
            Table("Nanny");
            Abstract();

            HasMany(b => b.Offers).KeyColumn("OfferId").Cascade.All();
            HasMany(b => b.Cooperations).KeyColumn("CooperationId").Cascade.All();

            Map(b => b.Education).Column("Education").CustomType("String").Not.Nullable().Length(500);
            Map(b => b.Smoking).Column("Smoking").Not.Nullable();
            Map(b => b.Pets).Column("Pets").Not.Nullable();
            Map(b => b.SickChildern).Column("SickChildern").Not.Nullable();
            Map(b => b.Car).Column("Car").Not.Nullable();
            Map(b => b.ExtraServices).Column("ExtraServices").CustomType("String").Length(500);
            Map(b => b.ExtraQualification).Column("ExtraQualification").CustomType("String").Length(500);

        }
    }

    class AdminMap : SubclassMap<Admin>
    {
        public AdminMap()
        {
            Table("Admin");
            Abstract();
        }
    }
}
