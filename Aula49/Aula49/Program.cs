using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula49.Dominio;

namespace Aula49
{
    class Program
    {
        public static List<Carro> lCarro;
        public static List<Marca> lMarca;
        public static List<Acessorio> lAcessorio;
        public static int mOption;
        static void Main(string[] args)
        {
            // Inicialização de Acessórios
            lAcessorio = new List<Acessorio>();

            // Pre-cadastro de marcas
            lMarca = new List<Marca>();
            lMarca.Add(new Marca(1001, "Volkswagen", "Alemanha"));
            lMarca.Add(new Marca(1002, "General Motors", "USA"));

            // Pre-cadastro de carros
            lCarro = new List<Carro>();
            Carro c1 = new Carro(101, "Fusca", 1980, 5000.00, lMarca[0]);
            Carro c2 = new Carro(102, "Golf", 2016, 60000.00, lMarca[0]);
            Carro c3 = new Carro(103, "Fox", 2017, 3000.00, lMarca[0]);
            lCarro.Add(c1);
            lCarro.Add(c2);
            lCarro.Add(c3);
            lMarca[0].lCarro.Add(c1);
            lMarca[0].lCarro.Add(c2);
            lMarca[0].lCarro.Add(c3);
            
            Carro c4 = new Carro(104, "Cruze", 2016, 30000.00, lMarca[1]);
            Carro c5 = new Carro(105, "Cobalt", 2015, 25000.00, lMarca[1]);
            Carro c6 = new Carro(106, "Cobalt", 2017, 35000.00, lMarca[1]);
            lCarro.Add(c4);
            lCarro.Add(c5);
            lCarro.Add(c6);
            lMarca[1].lCarro.Add(c4);
            lMarca[1].lCarro.Add(c5);
            lMarca[1].lCarro.Add(c6);

            do
            {
                try
                {
                    Console.Clear();
                    Util.MenuPrincipal();
                    mOption = int.Parse(Console.ReadLine());
                    switch (mOption)
                    {
                        case 1:
                            Util.ListarMarcas(lMarca);
                            break;
                        case 2:
                            Util.ListarCarros(lMarca);
                            break;
                        case 3:
                            Util.CadastrarMarca(lMarca);
                            break;
                        case 4:
                            Util.CadastrarCarro(lCarro);
                            break;
                        case 5:
                            Util.CadastrarAcessorio(lAcessorio, lCarro);
                            break;
                        case 6:
                            Util.ExibirCarro(lCarro);
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ocorreu um erro: " + e.Message);
                }
                Console.ReadLine();
            } while (mOption < 7);
            Console.WriteLine("Fim do programa.");
        }
    }
}
