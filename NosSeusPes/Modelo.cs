using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NosSeusPes
{
    public class Modelo
    {
        public String Nome { get; set; }

        public Boolean Cadarco { get; set; }

        public String Material { get; set; }

        public String Cor { get; set; }

        public double Preco { get; set; }

        public int Tamanho { get; set; }

        public IList<Modelo> Modelos { get; set; }
    }
}
