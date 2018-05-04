using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoSistemaCinema
{
    class Filme
    {
        string[] nomeFilme = new string[100];
        double[] duracaoFilme = new double[100];
        int[] classificaoFilme = new int[100];
        string[] generoFilme = new string[100];
        int atual = 0;
        int senha = 951753;

        public void CadastroFilme()
        {
            Console.WriteLine("Acesso Restrito");
            Console.Write("Senha: ");
            int acesso = Convert.ToInt32(Console.ReadLine());
            while (acesso != senha)
            {

                Console.Clear();
                Console.WriteLine("Senha incorreta digite novamente");
                Console.Write("Senha: ");
                acesso = Convert.ToInt32(Console.ReadLine());
            }

            Console.Clear();
            Console.Write("Informe o nome do filme: ");
            nomeFilme[atual] = Console.ReadLine();
            Console.Write("Informe a duração do filme: ");
            duracaoFilme[atual] = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe a classificação do filme: ");
            classificaoFilme[atual] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe o gênero do filme: ");
            generoFilme[atual] = Console.ReadLine();

        }
        public void ListarFilmes()
        {
            Console.Clear();
            Console.WriteLine("Lista de barcos: ");
            for (int i = 0; i < atual; i++)
            {
                Console.WriteLine(
                    String.Format(
                    @"\nNome do filme: {0} 
                        \nDuração do filme: {1} 
                        \nClassificação do filme: {2} 
                        \nGênero do filme: ",
                    nomeFilme[i], duracaoFilme[i], classificaoFilme[i], generoFilme[i]
                    )
                    );

            }
        }

        public void BuscarFilme()
        {
            Console.Write("Buscar filme por Nome ou Gênero: ");
            string nomeBuscado = Console.ReadLine().ToLower().Trim();
            bool achou = false;
            for (int i = 0; i < atual; i++)
            {
                if (nomeBuscado == nomeFilme[i])
                {
                    Console.WriteLine(
                    String.Format(
                    @"\nNome do filme: {0} 
                        \nDuração do filme: {1} 
                        \nClassificação do filme: {2} 
                        \nGênero do filme: ",
                    nomeFilme[i], duracaoFilme[i], classificaoFilme[i], generoFilme[i]
                    )
                    );
                    achou = true;
                    break;

                }
                if (!achou)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Filme não encontrado!");
                }
                if (nomeBuscado == generoFilme[i])
                {
                    Console.WriteLine(
                    String.Format(
                    @"\nNome do filme: {0} 
                        \nDuração do filme: {1} 
                        \nClassificação do filme: {2} 
                        \nGênero do filme: ",
                    nomeFilme[i], duracaoFilme[i], classificaoFilme[i], generoFilme[i]
                    )
                    );
                    achou = true;
                    break;

                }
                if (!achou)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Filme não encontrado!");
                }

            }
        }

        public  void EditarFilme()
        {
            Console.WriteLine("Acesso Restrito");
            Console.Write("Senha: ");
            int acesso = Convert.ToInt32(Console.ReadLine());
            while (acesso != senha)
            {

                Console.Clear();
                Console.WriteLine("Senha incorreta digite novamente");
                Console.Write("Senha: ");
                acesso = Convert.ToInt32(Console.ReadLine());
            }
            Console.Clear();
            Console.WriteLine("Digite um nome do filme para pesquisa: ");
            string nomePesquisado = Console.ReadLine().ToLower().Trim();
            Console.Clear();
            int posicao = -1;
            for (int i = 0; i < atual; i++)
            {
                if (nomePesquisado == nomeFilme[i])
                {
                    posicao = i;
                }
            }
            if (posicao != -1)
            {
                Console.Write("Informe o nome do filme: ");
                nomeFilme[posicao] = Console.ReadLine();
                Console.Write("Informe a duração do filme: ");
                duracaoFilme[posicao] = Convert.ToDouble(Console.ReadLine());
                Console.Write("Informe a classificação do filme: ");
                classificaoFilme[posicao] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Informe o gênero do filme: ");
                generoFilme[posicao] = Console.ReadLine();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Filme não encontrado");

            }
        }
    }
}



