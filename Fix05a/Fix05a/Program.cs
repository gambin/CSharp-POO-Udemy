using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fix05a
{
    class Program
    {
        static void Main(string[] args)
        {

            // Exercicio sobre a utilização de conjuntos. Neste caso podemos validar todos os alunos (cod)
            // de 3 classes, de forma a contar todos os alunos sem duplicidade usando conjuntos.

            int cA, cB, cC;
            HashSet<int> conjA = new HashSet<int>();
            HashSet<int> conjB = new HashSet<int>();
            HashSet<int> conjC = new HashSet<int>();

            Console.Write("Quantos alunos possui o curso A? ");
            cA = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso A: ");
            for (int i = 0; i < cA; i++)
            {
                int digA = int.Parse(Console.ReadLine());
                conjA.Add(digA);
            }

            Console.Write("Quantos alunos possui o curso B? ");
            cB = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso B: ");
            for (int i = 0; i < cB; i++)
            {
                int digB = int.Parse(Console.ReadLine());
                conjA.Add(digB);
            }

            Console.Write("Quantos alunos possui o curso C? ");
            cC = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso C: ");
            for (int i = 0; i < cC; i++)
            {
                int digC = int.Parse(Console.ReadLine());
                conjC.Add(digC);
            }

            conjA.UnionWith(conjB);
            conjA.UnionWith(conjC);
          
            Console.WriteLine("Total de alunos: " + conjA.Count);
            Console.ReadKey();
        }
    }
}
