using System;
using System.Collections.Generic;
using System.Text;

namespace ProjektP.Modele
{
    public class MenuModel
    {
        public virtual int idMenu { get; set; }
        public virtual string productName { get; set; }
        public virtual string price { get; set; }
        public virtual ISet<PozycjaZamowieniaModel> OrderPositionModelList { get; set; }
    }
}