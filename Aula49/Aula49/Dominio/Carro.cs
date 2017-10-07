using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula49.Dominio
{
    class Carro : IComparable<Carro>
    {
        public int codigo { get; private set; }
        public string modelo { get; private set; }
        public int ano { get; private set; }
        public double precoBasico { get; private set; }
        public Marca marca { get; private set; }
        public List<Acessorio> lAcessorios { get; private set; }

        public double precoTotal()
        {
            double totalAcessorio = 0;
            for (int i = 0; i < lAcessorios.Count; i++)
            {
                totalAcessorio += lAcessorios[i].preco;
            }
            return (totalAcessorio + precoBasico);
        }

        public int CompareTo(Carro other)
        {
            //throw new NotImplementedException();
            return this.marca.codigo.CompareTo(other.marca.codigo);
        }

        public Carro(int codigo, string modelo, int ano, double precoBasico, Marca marca)
        {
            this.codigo = codigo;
            this.modelo = modelo;
            this.ano = ano;
            this.precoBasico = precoBasico;
            this.marca = marca;
            this.lAcessorios = new List<Acessorio>();
        }

        public override string ToString()
        {
            // return base.ToString();
            string acessoriosSaida = "";
            string resultado = "";
            for (int i = 0; i < lAcessorios.Count; i++)
            {
                acessoriosSaida += lAcessorios[i] + "\n";
            }
            resultado = codigo + ", " + modelo
                + ", Ano: " + ano
                + ", Preço básico: " + precoBasico.ToString("F2", CultureInfo.InvariantCulture)
                + ", Preço Total: " + precoTotal().ToString("F2", CultureInfo.InvariantCulture);
                        
            if (acessoriosSaida != "")
            {
                return resultado + "\nAcessórios: \n" + acessoriosSaida;
            }
            else
            {
                return resultado;
            }            
        }
    }
}
