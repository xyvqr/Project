using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using ProjektP.Modele;

namespace ProjektP.Serwis
{
    public class AccSerwis
    {
        public AccModel GetLogin(string login, string pass)
        {
            AccModel acc;
            using (ISession session = NHSerwis.OpenSession())
            {
                acc = session.Query<AccModel>()
                    .Where(x => x.accountLogin == login && x.accountPassword == pass)
                    .FirstOrDefault();
            }
            return acc;
        }
        public List<AccModel> GetAll()
        {
            using (ISession session = NHSerwis.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    var menuProd = session.Query<AccModel>().ToList();
                    return menuProd;
                }
            }
        }
        public void Add(AccModel pusty)
        {
            using(ISession session  = NHSerwis.OpenSession())
            {
                using(ITransaction transaction = session.BeginTransaction())
                {
                    session.SaveOrUpdate(pusty);
                    transaction.Commit();
                }
            }
        }
        public void DodajPracownika(AccModel entity)
        {

            using (ISession session = NHSerwis.OpenSession())
            {
                using (ITransaction tran = session.BeginTransaction())
                {
                    session.SaveOrUpdate(entity);
                    tran.Commit();
                }
            }
        }
        public void UsunPracownika(AccModel mod)
        {
            using (ISession session = NHSerwis.OpenSession())
            {
                using (ITransaction tran = session.BeginTransaction())

                {
                    session.Delete(mod);
                    tran.Commit();
                }
            }
        }

    }
}
