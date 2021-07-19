using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjektP.Modele
{
    public class ZamawienieJedzeniaModel
    {
        public virtual int idOrder { get; set; }

        //public virtual int idAccount { get; set; }
        //public virtual AccountModel AccountModel { get; set; }
        //public virtual ISet<OrderPositionModel> OrderPositionModelList { get; set; }
        public virtual int totalPrice { get; set; }
        public virtual AccModel AccModel { get; set; }

        public virtual ISet<PozycjaZamowieniaModel> OrderPositionModelList1 { get; set; }
    }
}
