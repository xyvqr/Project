using NHibernate;
using ProjektP.Modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjektP.Serwis
{
    public class ZamowienieSerwis
    {
        public IList<ZamawienieJedzeniaModel> GetAll()
        {
            using (ISession session = NHSerwis.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    var allOrders = session.Query<ZamawienieJedzeniaModel>().ToList();
                    return allOrders;
                }
            }
        }
    }
}
