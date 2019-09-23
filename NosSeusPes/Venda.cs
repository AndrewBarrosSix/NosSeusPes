using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NosSeusPes
{
    public class Venda
    {
        public DateTime Data_Venda { get; set; }

        public IList<Modelo> Modelos { get; set; }

        public Cliente Cliente { get; set; }

    }
}
