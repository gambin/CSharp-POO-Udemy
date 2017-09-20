using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Fixacao01
{
    class Program
    {
        static void Main(string[] args)
        {
            int conta;
            string nome;
            string depSN;
            double valor;




            Conta c;
            
            Console.Write("Digite o número da conta: ");
            conta = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome do titular da conta: ");
            nome = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)?");
            depSN = Console.ReadLine();

            if(depSN.Equals("S", StringComparison.InvariantCultureIgnoreCase)){
                Console.Write("Digite o valor do depósito inicial: ");
                valor = double.Parse(Console.ReadLine(),CultureInfo.InstalledUICulture);
                c = new Conta(nome, conta, valor);
            } else {
                c = new Conta(nome, conta);
            }
            Console.WriteLine("");
            Console.WriteLine("Conta criada:");
            Console.WriteLine(c);

            Console.WriteLine("");
            Console.Write("Digite um valor para depósito: ");
            c.realizaDeposito(double.Parse(Console.ReadLine()));
            Console.WriteLine(c);

            Console.WriteLine("");
            Console.Write("Digite um valor para saque: ");
            c.realizaSaque(double.Parse(Console.ReadLine()));
            Console.WriteLine(c);

            Console.ReadKey();
        }
    }
}
