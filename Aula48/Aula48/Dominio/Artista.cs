using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula48.Dominio
{
    class Artista : IComparable<Artista>
    {
        public int codigo { get; internal set; }
        public string nome { get; internal set; }
        public double cache { get; internal set; }

        public Artista(int codigo, string nome, double cache)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.cache = cache;
        }

        public int CompareTo(Artista other)
        {
            //throw new NotImplementedException();
            return this.nome.CompareTo(other.nome);
        }

        public override string ToString()
        {
            // return base.ToString();
            return codigo + ", " + nome + ", " + cache.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
