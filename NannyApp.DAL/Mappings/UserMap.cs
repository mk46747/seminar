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
            Id(b => b.Id).GeneratedBy.Native();
            Map(b => b.Username).Not.Nullable().Length(50);
            Map(b => b.Password).Not.Nullable().Length(50);
            Map(b => b.Name).Not.Nullable().Length(50);
            Map(b => b.Surname).Not.Nullable().Length(50);
            Map(b => b.Gender).Not.Nullable().Length(10);
            Map(b => b.Contact).Not.Nullable().Length(50);
        }
    }
}
