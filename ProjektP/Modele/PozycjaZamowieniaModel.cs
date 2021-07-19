using System;
using System.Collections.Generic;
using System.Text;

namespace ProjektP.Modele
{
    public class PozycjaZamowieniaModel
    {
        public virtual int idPosition { get; set; }
        public virtual MenuModel MenuModel { get; set; }
        public virtual ZamawienieJedzeniaModel FoodOrderModel { get; set; }
        public virtual int quantity { get; set; }

        public virtual int price { get; set; }
    }
}
