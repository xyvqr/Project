using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjektP.Modele;

namespace ProjektP.Serwis
{
    public class MenuSerwis
    {
        public List<MenuModel> GetAll()
        {
            using (ISession session = NHSerwis.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    var menuProd = session.Query<MenuModel>().ToList();
                    return menuProd;
                }
            }
        }
    }
}
