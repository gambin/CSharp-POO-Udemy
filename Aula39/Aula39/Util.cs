using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula39
{
    class Util
    {
        public static Retangulo telaRetangulo()
        {
            Console.Write("Largura: ");
            double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Altura: ");
            double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Cor: ");
            string cor = Console.ReadLine();
            return new Retangulo(largura, altura, cor);

        }

        public static Triangulo telaTriangulo()
        {
            Console.Write("Lado A: ");
            double ladoA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Lado B: ");
            double ladoB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Lado C: ");
            double ladoC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Cor: ");
            string cor = Console.ReadLine();
            return new Triangulo(ladoA, ladoB, ladoC, cor);
        }
    }
}
