using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula49.Dominio;
using System.Globalization;

namespace Aula49
{
    class Util
    {
        public static void MenuPrincipal()
        {
            Console.WriteLine("1 - Listar marcas");
            Console.WriteLine("2 - Listar carros de uma marca ordenadamente");
            Console.WriteLine("3 - Cadastrar marca");
            Console.WriteLine("4 - Cadastrar carro");
            Console.WriteLine("5 - Cadastrar acessório");
            Console.WriteLine("6 - Mostrar detalhes de um carro");
            Console.WriteLine("7 - Sair");
        }

        public static void ListarMarcas(List<Marca> lMarca)
        {
            for (int i = 0; i < lMarca.Count; i++)
            {
                Console.WriteLine(lMarca[i]);
            }
        }

        public static void ListarCarros(List<Marca> lMarca) 
        {
            Console.WriteLine("Digite o código da marca: ");
            int codMarca = int.Parse(Console.ReadLine());
            int posMarca = lMarca.FindIndex(x => x.codigo == codMarca);
            if (posMarca != -1)
            {
                Console.WriteLine("Carros da marca " + lMarca[posMarca].nome + ":");
                for (int i = 0; i < lMarca[posMarca].lCarro.Count; i++)
                {
                    Console.WriteLine(lMarca[posMarca].lCarro[i]);
                }
            } else
            {
                // Console.WriteLine("Marca não encontrada!");
                throw new Exception("Código de carro não encontrado: " + codMarca);
            }
        }

        public static void CadastrarMarca(List<Marca> lMarca)
        {
            Console.WriteLine("Digite os dados da marca: ");
            Console.Write("Código: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Páis de origem: ");
            string pais = Console.ReadLine();

            Marca marca = new Marca(codigo, nome, pais);
            lMarca.Add(marca);
        }

        public static void CadastrarCarro(List<Carro> lCarro)
        {
            Console.WriteLine("Digite os dados do carro: ");
            Console.Write("Marca (código: ");
            int codMarca = int.Parse(Console.ReadLine());
            Console.Write("Código do Carro: ");
            int codCarro = int.Parse(Console.ReadLine());
            Console.Write("Modelo: ");
            string modelo = Console.ReadLine();
            Console.Write("Ano: ");
            int ano = int.Parse(Console.ReadLine());
            Console.Write("Preço básico: ");
            double precoBasico = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }

        public static void CadastrarAcessorio(List<Acessorio> lAcessorio, List<Carro> lCarro)
        {
            Console.WriteLine("Digite os dados do acessório");
            Console.Write("Acessório (código): ");
            int codAcessorio = int.Parse(Console.ReadLine());
            Console.Write("Carro (código): ");
            int codCarro = int.Parse(Console.ReadLine());
            Console.Write("Descrição: ");
            string descricao = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            int posCarro = lCarro.FindIndex(x => x.codigo == codCarro);
            if(posCarro != -1)
            {
                Carro carro = lCarro[posCarro];
                Acessorio acessorio = new Acessorio(codAcessorio, descricao, preco, carro);
                lAcessorio.Add(acessorio);
                carro.lAcessorios.Add(acessorio);
            } else
            {
                throw new Exception("Código de carro não encontrado: " + codCarro);
            }
        }

        public static void ExibirCarro(List<Carro> lCarro)
        {
            Console.Write("Digite o código do carro: ");
            int codCarro = int.Parse(Console.ReadLine());
            int posCarro = lCarro.FindIndex(x => x.codigo == codCarro);
            if (posCarro != -1)
            {
                Console.WriteLine(lCarro[posCarro]);
            }
            else
            {
                throw new Exception("Código de carro não encontrado: " + codCarro);
            }
        }

    }
}
