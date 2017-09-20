using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Fix04a
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> listaFunc = new List<Funcionario>();
            int cpfAumento, posAumento;
            double valAumento;

            Console.Write("Quantos funcionários serão cadastrados? ");
            int qtoFunc = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtoFunc; i++)
            {
                int cpf;
                string nome;
                double salario;

                Console.WriteLine("Dados do " + (i + 1) + "º funcionário");
                Console.Write("CPF: ");
                cpf = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                nome = Console.ReadLine();
                Console.Write("Salário: ");
                salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                listaFunc.Add(new Funcionario(cpf, nome, salario));
                Console.WriteLine();
            }

            Console.Write("Digite o CPF do funcionário que terá aumento: ");
            cpfAumento = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            try
            {
                posAumento = listaFunc.FindIndex(c => c.cpf == cpfAumento);
                if (posAumento > -1)
                {
                    Console.Write("Digite a porcentagem do aumento: ");
                    valAumento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    listaFunc[posAumento].aumentaSalario(valAumento);
                }
                else
                {
                    Console.WriteLine("CPF INEXISTENTE");
                    Console.WriteLine();
                }
                
            }
            catch (Exception)
            {
                
            }
            Console.WriteLine("Listagem atualizada de funcionários: ");
            for (int i = 0; i < listaFunc.Count; i++)
            {
                Console.WriteLine(listaFunc[i]);
            }
            Console.ReadLine();
        }
    }
}
