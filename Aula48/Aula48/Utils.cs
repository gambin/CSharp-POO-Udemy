using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula48.Dominio;
using System.Globalization;

namespace Aula48
{
    class Utils
    {
        public static void MenuPrincipal()
        {
            Console.WriteLine("1 - Listar artistas ordenadamente");
            Console.WriteLine("2 - Cadastrar artista");
            Console.WriteLine("3 - Cadastrar filme");
            Console.WriteLine("4 - Mostrar dados de um filme");
            Console.WriteLine("5 - Sair");
        }

        public static void listagemArtistas(List<Artista> lArtista)
        {
            lArtista.Sort();
            for (int i = 0; i < lArtista.Count; i++)
            {
                Console.WriteLine(lArtista[i]);
            }
        }

        public static void cadastrarArtista(List<Artista> lArtista)
        {
            Console.WriteLine("Digite os dados do artista: ");
            Console.Write("Código: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Valor cache: ");
            Double cache = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            lArtista.Add(new Artista(codigo, nome, cache));
        }

        public static void cadastrarFilme(List<Artista> lArtista, List<Filme> lFilme)
        {
            Console.WriteLine("Digite os dados do filme:");
            Console.Write("Código: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Titulo: ");
            string titulo = Console.ReadLine();
            Console.Write("Ano: "); 
            int ano = int.Parse(Console.ReadLine());
            Filme oFilme = new Filme(codigo, titulo, ano);

            Console.WriteLine("Quantas participações tem o filme? ");
            int qtdParticipacoes = int.Parse(Console.ReadLine());
            for (int i = 0; i < qtdParticipacoes; i++)
            {
                Console.WriteLine("Digite os dados da " + (i + 1) + "ª participação:");
                Console.Write("Artista (código): ");
                int codArt = int.Parse(Console.ReadLine());
                int posArt = lArtista.FindIndex(x => x.codigo == codArt);
                if (posArt == -1)
                {
                    throw new Exception("Código do artista não encontrado: " + codArt);
                }
                Console.Write("Desconto: ");
                double desconto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Participacao oParticipacao = new Participacao(desconto, oFilme, lArtista[posArt]);
                oFilme.participacao.Add(oParticipacao);
            }
            lFilme.Add(oFilme);
        }

        public static void listarFilme(List<Artista> lArtista, List<Filme> lFilme)
        {
            Console.WriteLine("Digite o código do filme");
            int codFilme = int.Parse(Console.ReadLine());
            int posCod = lFilme.FindIndex(x => x.codigo == codFilme);
            if (posCod == -1)
            {
                throw new Exception("Código do filme não encontrado: " + codFilme);
            }
            Filme oFilme = lFilme[posCod];
            string participacao = "";

            for (int i = 0; i < oFilme.participacao.Count; i++)
            {
                participacao += oFilme.participacao[i] + "\n";
            }

            Console.WriteLine("Filme: " + oFilme
                + "\nPartipações:"
                + "\n" + participacao
                + "\nCusto total do filme: " + oFilme.custoTotal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
