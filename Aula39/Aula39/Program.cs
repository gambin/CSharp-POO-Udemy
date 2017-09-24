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
                    Retangulo ret = Util.telaRetangulo();
                    listFiguras.Add(ret);
                } else
                {
                    Triangulo tri = Util.telaTriangulo();
                    listFiguras.Add(tri);
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
