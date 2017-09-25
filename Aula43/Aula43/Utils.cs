using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula43
{
    class Utils
    {
        public static void MenuPrincipal()
        {
            Console.WriteLine("1 - Listar produtos ordenadamente (nome e valor)");
            Console.WriteLine("2 - Cadastrar produto");
            Console.WriteLine("3 - Cadastrar pedido");
            Console.WriteLine("4 - Mostrar dados de um pedido");
            Console.WriteLine("5 - Sair");
            Console.Write("Digite uma opção: ");
        }

        public static void ListaProduto()
        {
            Console.WriteLine("LISTAGEM DE PRODUTOS:");
            Program.listaProdutos.Sort();
            for (int i = 0; i < Program.listaProdutos.Count(); i++)
            {
                Console.WriteLine(Program.listaProdutos[i]);
            }
        }

        public static Produto CadastroProduto()
        {
            Console.WriteLine("Digite os dados do produto:");
            Console.Write("Código: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Descrição: ");
            string descricao = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            return new Produto(codigo, descricao, preco);
        }

        public static void CadastroPedido()
        {
            Console.WriteLine("Digite os dados do pedido:");

            Console.Write("Código: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Dia: ");
            int dia = int.Parse(Console.ReadLine());
            Console.Write("Mês: ");
            int mes = int.Parse(Console.ReadLine());
            Console.Write("Ano: ");
            int ano = int.Parse(Console.ReadLine());
            DateTime data = new DateTime(ano, mes, dia);
            Pedido P = new Pedido(codigo, data);


            Console.Write("Quantos itens tem o pedido? ");
            int qtdPedido = int.Parse(Console.ReadLine());
            List <ItemPedido> listaItemPedido = new List<ItemPedido>();

            for (int i = 0; i < qtdPedido; i++)
            {
                Console.WriteLine("Digite os dados do " + (i + 1) + "º item");
                Console.Write("Produto (código): ");
                int codProduto = int.Parse(Console.ReadLine());
                int pos = Program.listaProdutos.FindIndex(x => x.codigo == codProduto);
                if (pos == -1)
                {
                    throw new ModelException("Código de produto não encontrado: " + codProduto);
                }

                Console.Write("Quantidade: ");
                int qtdProduto = int.Parse(Console.ReadLine());
                Console.Write("Porcentagem de desconto: ");
                double descProduto = double.Parse(Console.ReadLine());
                ItemPedido ip = new ItemPedido(qtdPedido, descProduto, Program.listaProdutos[pos], P);
                P.itens.Add(ip);
            }
            Program.listaPedido.Add(P);
        }


        public static void listaPedidos()
        {
            Console.Write("Digite o código do Pedido: ");
            int codPedido = int.Parse(Console.ReadLine());
            int pos = Program.listaPedido.FindIndex(x => x.codigo == codPedido);
            if(pos == -1)
            {
                throw new ModelException("Código de pedido não encontrado: " + codPedido);
            }
            Console.WriteLine(Program.listaPedido[pos]);
            Console.WriteLine();
        }
    }
}

