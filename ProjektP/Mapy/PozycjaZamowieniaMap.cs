
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using ProjektP.Modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektP.Mapy
{
    public class PozycjaZamowieniaMap : ClassMapping<PozycjaZamowieniaModel>
    {
        public PozycjaZamowieniaMap()
        {
            Schema("dbo");

            Table("OrderPostion");

            Id(x => x.idPosition, map => map.Generator(Generators.Identity));

            Property(x => x.quantity);

            Property(x => x.price);

            ManyToOne(x => x.MenuModel, m =>
            {
                m.Lazy(LazyRelation.NoLazy);
                m.Column("idMenu");

            });

            ManyToOne(x => x.FoodOrderModel, m =>
            {
                m.Lazy(LazyRelation.NoLazy);
                m.Column("idOrder");

            });
        }
    }
}
