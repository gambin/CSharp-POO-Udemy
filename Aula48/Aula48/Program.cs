using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula48.Dominio;

namespace Aula48
{
    class Program
    {
        public static List<Artista> lArtista = new List<Artista>();
        public static List<Filme> lFilme = new List<Filme>();
        public static int mOption = 0;
        static void Main(string[] args)
        {
            // Inicializacao de artistas cadastrados
            lArtista.Add(new Artista(101, "Scarlett Johansson", 4000000.00));
            lArtista.Add(new Artista(102, "Chris Evans", 2500000.00));
            lArtista.Add(new Artista(103, "Robert Downey Jr.", 3000000.00));
            lArtista.Add(new Artista(104, "Morgan Freeman", 4000000.00));

            do
            {
                Console.Clear();
                Utils.MenuPrincipal();
                try
                {
                    mOption = int.Parse(Console.ReadLine());
                    switch (mOption)
                    {
                        case 1:
                            Utils.listagemArtistas(lArtista);
                            break;
                        case 2:
                            Utils.cadastrarArtista(lArtista);
                            break;
                        case 3:
                            Utils.cadastrarFilme(lArtista, lFilme);
                            break;
                        case 4:
                            Utils.listarFilme(lArtista, lFilme);
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erro inesperado: " + e.Message);
                    //throw;
                }
                
                Console.ReadKey();
            } while (mOption < 5);
        }
    }
}
