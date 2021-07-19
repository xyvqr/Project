using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using ProjektP.Modele;

namespace ProjektP.Mapy
{
    public class AccMap : ClassMapping<AccModel>
    {
        public AccMap()
        {
            Schema("dbo");

            Table("Account");

            Id(x => x.idAccount, map => map.Generator(Generators.Identity));

            Property(x => x.accountLogin);

            Property(x => x.accountPassword);

            Property(x => x.firstName);

            Property(x => x.lastName);
           
            Property(x => x.admin);



            Set(x => x.ZamawianieJedzeniaModelList, m =>
            {
                m.Key(k => k.Column("idAccount"));
                m.Inverse(true);
                m.Cascade(Cascade.All);

            }, r => r.OneToMany(x => x.Class(typeof(ZamawienieJedzeniaModel))));

        }
    }
}