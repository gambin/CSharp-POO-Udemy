using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace aula42
{
    class Util
    {
        public static Conta CadastroConta()
        {
            Console.Write("Número da Conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Nome do Titular: ");
            string titular = Console.ReadLine();
            Console.Write("Limite de Saque: ");
            double limite = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            return new Conta(numero, titular, 0.0, limite);
        }

    }
}
