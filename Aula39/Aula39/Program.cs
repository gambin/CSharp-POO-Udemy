using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula39
{
    class Program
    {
        static void Main(string[] args)
        {

            // Exercicio de herança co uso de classes abstratas (ou interfaces, como preferir), sobreposição e polimorfismo

            List<Figura> listFiguras = new List<Figura>();

            Console.Write("Quantas figuras voce vai digitar? ");
            int nFig = int.Parse(Console.ReadLine());

            for (int i = 0; i < nFig; i++)
            {
                Console.Write("Figura " + (i + 1) + " - triangulo ou retangulo (t/r)? ");
                char ch = char.Parse(Console.ReadLine());
                if (ch == 'r')
                {
                    Console.Write("Largura: ");
                    double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Altura: ");
                    double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Cor: ");
                    string cor = Console.ReadLine();
                    Retangulo ret = new Retangulo(largura, altura, cor);
                    listFiguras.Add(ret);
                } else
                {
                    Console.Write("Lado A: ");
                    double ladoA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Lado B: ");
                    double ladoB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Lado C: ");
                    double ladoC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Cor: ");
                    string cor = Console.ReadLine();
                    Triangulo ret = new Triangulo(ladoA, ladoB, ladoC, cor);
                    listFiguras.Add(ret);
                }
                Console.WriteLine();
            }
            
            Console.WriteLine("Área das figuras: ");

            for (int i = 0; i < listFiguras.Count; i++)
            {
                Console.WriteLine("Figura " + (i + 1) + "(" + listFiguras[i].cor + "): " + listFiguras[i]);
            }
            
            Console.ReadLine();
        }
    }
}
