using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoSistemaCinema
{
    class CadastrarFilme
    {
        string[] nomeFilme = new string[100];
        double[] duracaoFilme = new double[100];
        int[] classificaoFilme = new int[100];
        string[] generoFilme = new string[100];
        int atual = 0;
        int senha = 951753;
        bool validarSenha = true;
        public void CadastrarFilme()
        {
            while (validarSenha == true)
            {
                try
                {

                    Console.WriteLine("Acesso Restrito");
                    Console.Write("Senha: ");
                    validarSenha = false;
                    Console.Clear();
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("Senha incorreta digite novamente");
                }

            }
            int acesso = Convert.ToInt32(Console.ReadLine());


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
    }
}
