using ProjektP.Modele;
using System;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjektP.Mapy
{
    public class ZamowienieJedzeniaMap : ClassMapping<ZamawienieJedzeniaModel>
    {
        public ZamowienieJedzeniaMap()
        {
            Schema("dbo");

            Table("FoodOrder");

            Id(x => x.idOrder, map => map.Generator(Generators.Identity));

            Property(x => x.totalPrice);

            ManyToOne(x => x.AccModel, m =>
            {
                m.Lazy(LazyRelation.NoLazy);
                m.Column("idAccount");

            });

            Set(x => x.OrderPositionModelList1, m =>
            {
                m.Key(k => k.Column("idOrder"));
                m.Inverse(true);
                m.Cascade(Cascade.All);

            }, r => r.OneToMany(x => x.Class(typeof(PozycjaZamowieniaModel))));

        }
    }
}