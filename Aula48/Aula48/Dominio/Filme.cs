using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula48.Dominio;

namespace Aula48.Dominio
{
    class Filme
    {
        public int codigo { get; internal set; }
        public string titulo { get; internal set; }
        public int ano { get; internal set; }
        public List<Participacao> participacao;

        public Filme(int codigo, string titulo, int ano)
        {
            this.codigo = codigo;
            this.titulo = titulo;
            this.ano = ano;
            this.participacao = new List<Participacao>();
        }

        public double custoTotal()
        {
            double totalizador = 0;
            for (int i = 0; i < participacao.Count; i++)
            {
                totalizador += participacao[i].custo();
            }
            return totalizador;
        }

        public override string ToString()
        {
            // return base.ToString();
            return "Filme " + codigo + ", Título: " + titulo + ", Ano: " + ano;
        }
    }
}
