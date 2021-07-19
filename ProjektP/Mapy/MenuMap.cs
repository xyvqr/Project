using ProjektP.Modele;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektP.Mapy
{
    public class MenuMap : ClassMapping<MenuModel>
    {
        public MenuMap()
        {
            Schema("dbo");

            Table("Menu");

            Id(x => x.idMenu, map => map.Generator(Generators.Identity));

            Property(x => x.productName);

            Property(x => x.price);

            Set(x => x.OrderPositionModelList, m =>
            {
                m.Key(k => k.Column("idMenu"));
                m.Inverse(true);
                m.Cascade(Cascade.All);

            }, r => r.OneToMany(x => x.Class(typeof(PozycjaZamowieniaModel))));

        }
    }
}