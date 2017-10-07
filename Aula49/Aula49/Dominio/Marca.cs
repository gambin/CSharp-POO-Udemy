using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula49.Dominio
{
    class Marca
    {
        public int codigo { get; private set; }
        public string nome { get; private set; }
        public string pais { get; private set; }
        public List<Carro> lCarro { get; private set; }

        public Marca(int codigo, string nome, string pais)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.pais = pais;
            this.lCarro = new List<Carro>();
        }

        public override string ToString()
        {
            // return base.ToString();
            return codigo + ", " + nome + ", País: " + pais + ", Número de carros: " + lCarro.Count;
        }
    }
}
