using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektP.Modele
{
    public class AccModel
    {
        public virtual int idAccount { get; set; }
        public virtual string accountLogin { get; set; }
        public virtual string accountPassword { get; set; }
        public virtual string firstName { get; set; }
        public virtual string lastName { get; set; }
        public virtual bool admin { get; set; }
        public virtual ISet<ZamawienieJedzeniaModel> ZamawianieJedzeniaModelList { get; set; }
    }

}
