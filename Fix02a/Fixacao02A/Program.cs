using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fixacao02A
{
    class Program
    {
        static void Main(string[] args)
        {
            Quarto[] vet;
            vet = new Quarto[9];

            for (int i = 0; i < 9; i++)
            {
                vet[i] = new Quarto(null, null, i);
            }

            Console.Write("Quantos aluguéis serão registrados? ");
            int alTot = int.Parse(Console.ReadLine());          

            Console.WriteLine();

            for (int i = 0; i < alTot; i++)
            {
                string nome, email;
                int numero;
                Console.WriteLine("Dados do " + (i + 1) + "º aluguel: ");
                Console.Write("Nome: ");
                nome = Console.ReadLine();
                Console.Write("Email: ");
                email = Console.ReadLine();
                Console.Write("Quarto: ");
                numero = int.Parse(Console.ReadLine());
                vet[numero] = new Quarto(nome, email, numero);
                Console.WriteLine();
            }
            Console.WriteLine("Quartos ocupados: ");

            // vet = (from i in vet orderby i.numero ascending select i).ToArray();
            // vet = vet.OrderBy(c => c.numero).ToArray();

            for (int i = 0; i < vet.Length; i++)
            {
                if (vet[i].nome != null)
                {
                    Console.WriteLine(vet[i]);
                }
                
            }
            Console.ReadKey();
        }
    }
}
