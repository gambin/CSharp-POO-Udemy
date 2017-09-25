using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula43
{
    class Program
    {

        public static List<Produto> listaProdutos = new List<Produto>();
        public static List<Pedido> listaPedido = new List<Pedido>();

        static void Main(string[] args)
        {
            // Cadastro iniciar de produtos
            listaProdutos.Add(new Produto(1001, "Cadeira simples", 500.00));
            listaProdutos.Add(new Produto(1002, "Cadeira acolchoada", 900.00));
            listaProdutos.Add(new Produto(1003, "Sofá de três lugares", 2000.00));
            listaProdutos.Add(new Produto(1004, "Mesa retangular", 1500.00));
            listaProdutos.Add(new Produto(1005, "Mesa retangular", 2000.00));
            // listaProdutos.Sort();

            int mOpcao = 0;

            Console.WriteLine();
            while (mOpcao != 5)
            {
                Console.Clear();
                Utils.MenuPrincipal();
                try
                {
                    mOpcao = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erro inesperado: " + e.Message);
                    mOpcao = 0;
                }

                switch (mOpcao)
                {
                    case 1:
                        Utils.ListaProduto();
                        break;
                    case 2:
                        listaProdutos.Add(Utils.CadastroProduto());
                        break;
                    case 3:
                        Utils.CadastroPedido();
                        break;
                    case 4:
                        Utils.listaPedidos();
                        break;
                    case 5:
                        Console.WriteLine("Fim do programa!");
                        break;
                    default:
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}
