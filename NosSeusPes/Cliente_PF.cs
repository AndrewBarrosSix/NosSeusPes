using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NosSeusPes
{
    public class Cliente_PF : Cliente
    {
        public int CPF { get; set; }

        public DateTime Data_nascimento { get; set; }

        public String Endereco { get; set; }

    }
}
