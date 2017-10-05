using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula48.Dominio;
using System.Globalization;

namespace Aula48.Dominio
{
    class Participacao
    {
        public double desconto { get; internal set; }
        public Filme filme;
        public Artista artista;

        public Participacao(double desconto, Filme filme, Artista artista)
        {
            this.desconto = desconto;
            this.filme = filme;
            this.artista = artista;
        }

        public double custo()
        {
            return (artista.cache - artista.cache * (desconto / 100));
        }

        public override string ToString()
        {
            // return base.ToString();
            return artista.nome + ", " + artista.cache + ", Desconto: " + desconto + ", Custo: " + custo().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
