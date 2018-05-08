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
        int acesso = 0;
        bool validarDuracao = true;
        bool validarClassificacao = true;
        double[] duracaoFilme = new double[100];
        int[] classificaoFilme = new int[100];
        string[] generoFilme = new string[100];
        bool validacaoSenha = true;
        int atual = 0;
        int senha = 951753;
        string nome = "";

        public void CadastroFilme()
        {
            Console.WriteLine("Acesso Restrito");


            validacaoSenha = true;
            while (validacaoSenha == true)
            {
                try
                {
                    Console.Write("Senha: ");
                    acesso = Convert.ToInt32(Console.ReadLine());
                    validacaoSenha = false;
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("Senha incorreta tente novamente");
                }
            }
            Console.Clear();
            while (acesso != senha)
            {

                try
                {
                    Console.Clear();
                    Console.WriteLine("Senha incorreta tente novamente");
                    Console.Write("Senha: ");
                    acesso = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("Senha incorreta tente novamente");
                }
            
            }

            Console.Clear();
            Console.Write("Informe o nome do filme: ");
            nome = Console.ReadLine();

            validarDuracao = true;

            while (validarDuracao == true)
            {
                try
                {
                    Console.Write("Informe a duração do filme: ");
                    duracaoFilme[atual] = Convert.ToDouble(Console.ReadLine());
                    validarDuracao = false;
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("Duração de filme inválida");
                }
            }

            validarClassificacao = true;

            while (validarClassificacao == true)
            {
                try
                {
                    Console.Write("Informe a classificação do filme: ");
                    classificaoFilme[atual] = Convert.ToInt32(Console.ReadLine());
                    validarClassificacao = false;
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("A classificação do filme é inválida");
                }
            }
            
                Console.Write("Informe o gênero do filme: ");
                generoFilme[atual] = Console.ReadLine();
                nomeFilme[atual] = nome;
                atual++;
            
        }
        public void ListarFilmes()
        {
            Console.Clear();
            Console.WriteLine("Lista de Filmes");

            if (atual == 0)
            {
                Console.WriteLine("Nenhum Filme cadastrado!\nPressione qualquer tecla para continuar...");
                Console.ReadKey();

            }
            else
            {
                for (int i = 0; i < atual; i++)
                {
                    Console.WriteLine("Nome do filme: {0}\nDuração do Filme: {1}\nClassificação do filme: {2}\nGênero do filme: {3}",
                        nomeFilme[i], duracaoFilme[i], classificaoFilme[i], generoFilme[i]);
                    Console.WriteLine("\n");
                                        
                }
                Console.WriteLine("Pressione alguma tecla para continuar...");
                Console.ReadKey();
            }            
        }

        public void BuscarFilme()
        {
            Console.Write("Buscar filme por Nome ou Gênero: ");
            string nomeBuscado = Console.ReadLine().ToLower().Trim();
            Console.Clear();
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
                    Console.WriteLine("Pressione alguma tecla para continuar...");
                    Console.ReadKey();
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

        public void EditarFilme()
        {
            Console.WriteLine("Acesso Restrito");
            validacaoSenha = true;

            while (validacaoSenha == true)
            {
                try
                {
                    Console.Write("Senha: ");
                    acesso = Convert.ToInt32(Console.ReadLine());
                    validacaoSenha = false;
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("Senha incorreta tente novamente");
                }
            }
            Console.Clear();

            while (acesso != senha)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("Senha incorreta tente novamente");
                    Console.Write("Senha: ");
                    acesso = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("Senha incorreta tente novamente");
                }

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



