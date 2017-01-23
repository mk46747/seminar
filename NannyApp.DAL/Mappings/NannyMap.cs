using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NannyApp.DAL.Mappings
{
    class NannyMap
    {
    }
}
/*
 using FinAssist.Model;
using FluentNHibernate.Mapping;

namespace FinAssist.DAL.Mappings
{
    // Mapiranje Table per class hierarchy
    public class AccountMap : ClassMap<Account>
    {
        public AccountMap()
        {
            Id(b => b.Id).GeneratedBy.Native();
            Map(b => b.Name);
            References(b => b.AccountOwner);

            DiscriminateSubClassesOnColumn("type");
        }
    }
    public class AccountWithBalanceMap : SubclassMap<AccountWithBalance>
    {
        public AccountWithBalanceMap()
        {
            DiscriminatorValue("AWB");
            Map(b => b.InitialBalance);
        }
    }
    public class CashAccountMap : SubclassMap<CashAccount>
    {
        public CashAccountMap()
        {
            DiscriminatorValue("CSH");
        }
    }
    public class CurrentAccountMap : SubclassMap<CurrentAccount>
    {
        public CurrentAccountMap()
        {
            DiscriminatorValue("CUR");
        }
    }

    public class CreditCardAccountMap : SubclassMap<CreditCardAccount>
    {
        public CreditCardAccountMap()
        {
            DiscriminatorValue("CRD");
        }
    }

    public class DebitCardAccountMap : SubclassMap<DebitCardAccount>
    {
        public DebitCardAccountMap()
        {
            DiscriminatorValue("DBT");
        }
    }

    public class ExpenditureSinkAccountMap : SubclassMap<ExpenditureSinkAccount>
    {
        public ExpenditureSinkAccountMap()
        {
            DiscriminatorValue("EXP");
        }
    }

    public class IncomeSourceAccountMap : SubclassMap<IncomeSourceAccount>
    {
        public IncomeSourceAccountMap()
        {
            DiscriminatorValue("INC");
        }
    }

/*
    // mapiranje Table per concrete class
    public class AccountMap : ClassMap<Account>
    {
        public AccountMap()
        {
            Id(b => b.Id).GeneratedBy.HiLo("1000");
            Map(b => b.Name);
            References(b => b.AccountOwner);
            UseUnionSubclassForInheritanceMapping();
        }
    }

    public class AccountWithBalanceMap : SubclassMap<AccountWithBalance>
    {
        public AccountWithBalanceMap()
        {
            Map(b => b.InitialBalance);
        }
    }

    public class CashAccountMap : SubclassMap<CashAccount>
    {
    }

    public class CurrentAccountMap : SubclassMap<CurrentAccount>
    {
    }

    public class CreditCardAccountMap : SubclassMap<CreditCardAccount>
    {
    }

    public class DebitCardAccountMap : SubclassMap<DebitCardAccount>
    {
    }

    public class ExpenditureSinkAccountMap : SubclassMap<ExpenditureSinkAccount>
    {
    }

    public class IncomeSourceAccountMap : SubclassMap<IncomeSourceAccount>
    {
    }
*/
    /*
    // mapiranje Table per subclass
    public class AccountMap : ClassMap<Account>
    {
        public AccountMap()
        {
            Id(b => b.Id).GeneratedBy.Native();
            Map(b => b.Name);
            References(b => b.AccountOwner);
        }
    }
    public class AccountWithBalanceMap : SubclassMap<AccountWithBalance>
    {
        public AccountWithBalanceMap()
        {
            Map(b => b.InitialBalance);
        }
    }
    public class CashAccountMap : SubclassMap<CashAccount>
    {
    }
    public class CurrentAccountMap : SubclassMap<CurrentAccount>
    {
    }
    public class CreditCardAccountMap : SubclassMap<CreditCardAccount>
    {
    }
    public class DebitCardAccountMap : SubclassMap<DebitCardAccount>
    {
    }
    public class ExpenditureSinkAccountMap : SubclassMap<ExpenditureSinkAccount>
    {
    }
    public class IncomeSourceAccountMap : SubclassMap<IncomeSourceAccount>
    {
    }
    */
}

 */