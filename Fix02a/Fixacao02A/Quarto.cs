using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fixacao02A
{
    class Quarto
    {
        public string nome { get; private set; }
        public string email { get; private set; }
        public int numero { get; private set; }

        public Quarto(string nome, string email, int numero)
        {
            this.nome = nome;
            this.email = email;
            this.numero = numero;
        }
        public override string ToString()
        {
            //return base.ToString();
            return numero + ": " + nome + ", " + email;
        }

    }
}
