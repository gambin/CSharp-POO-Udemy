using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula49.Dominio
{
    class Acessorio
    {
        public int codigo { get; private set; }
        public string nome { get; private set; }
        public double preco { get; private set; }
        public Carro carro { get; private set; }

        public Acessorio(int codigo, string nome, double preco, Carro carro)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.preco = preco;
            this.carro = carro;
        }

        public override string ToString()
        {
            //return base.ToString();
            return nome + ", Preço: " + preco.ToString("F2", CultureInfo.InvariantCulture);
        }
    }


}
