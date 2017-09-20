using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fix03A
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mat;
            string[] mainOptions;
            int m1, m2, codPesquisa, esquerda, direita, acima, abaixo;

            Console.Write("Entre com o modelo de posicoes do array multi-dimensionais: ");
            mainOptions = Console.ReadLine().Split(' ');
            m1 = int.Parse(mainOptions[0]);
            m2 = int.Parse(mainOptions[1]);

            mat = new int[m1, m2];

            for (int i = 0; i < m1; i++)
            {
                string[] linha = Console.ReadLine().Split(' ');
                for (int j = 0; j < m2; j++)
                {
                    mat[i, j] = int.Parse(linha[j]);
                }
            }

            Console.WriteLine("Entre com o código de pesquisa: ");
            codPesquisa = int.Parse(Console.ReadLine());

            for (int i = 0; i < m1; i++)
            {
                for (int j = 0; j < m2; j++)
                {
                    if (mat[i, j] == codPesquisa)
                    {
                        // Get left item
                        try
                        {
                            esquerda = mat[i, j - 1];
                            Console.WriteLine("Esquerda: " + esquerda);
                        }
                        catch
                        {
                            Console.WriteLine("Esquerda: posição não encontrada");
                        }
                        // Get right item
                        try
                        {
                            direita = mat[i, j + 1];
                            Console.WriteLine("Direita: " + direita);
                        }
                        catch
                        {
                            Console.WriteLine("Direita: posição não encontrada");
                        }
                        // Get up item
                        try
                        {
                            acima = mat[i - 1, j];
                            Console.WriteLine("Acima: " + acima);
                        }
                        catch
                        {
                            Console.WriteLine("Acima: posição não encontrada");
                        }
                        // Get down item
                        try
                        {
                            abaixo = mat[i + 1, j];
                            Console.WriteLine("Abaixo: " + abaixo);
                        }
                        catch
                        {
                            Console.WriteLine("Abaixo: posição não encontrada");
                        }
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
