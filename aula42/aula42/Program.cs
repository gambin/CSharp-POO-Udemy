using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace aula42
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criacao de conta através de tela em metodo estatico
            Conta c = Util.CadastroConta();

            Console.WriteLine();
            Console.Write("Informe um valor para depósito: ");
            double valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Depositar(valorDeposito);
            Console.WriteLine("Novo saldo = R$" + c.saldo.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine();
            Console.Write("Informe um valor para saque: ");
            double valorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            try
            {
                c.Sacar(valorSaque);
                Console.WriteLine("Novo saldo = R$" + c.saldo.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }




            Console.ReadLine();

        }
    }
}
