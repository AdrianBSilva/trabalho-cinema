using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoSistemaCinema
{
    class Funcionario
    {
        string readLineValue = "";
        string[] nomeFuncionario = new string[100];
        int[] idadeFuncionario = new int[100];
        double[] salarioFuncionario = new double[100];
        string[] funcaoFuncionario = new string[100];
        bool validacaoIdadeFuncionario = true, validacaoSalarioFuncionario = true;
        int senha = 951753;
        int atual = 0;

        public void CadastroFuncionario()
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
                Console.Clear();



            }
            Console.WriteLine("Informe o nome: ");
            nomeFuncionario[atual] = Console.ReadLine();
            Console.Clear();
            while (validacaoIdadeFuncionario == true)
            {
                try
                {
                    Console.WriteLine("Informe a idade: ");
                    readLineValue = Console.ReadLine();
                    idadeFuncionario[atual] = Convert.ToInt32(readLineValue);
                    Console.Clear();
                    validacaoIdadeFuncionario = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("O valor \"" + readLineValue + "\" não é numérico");

                }
            }
            

            while (validacaoSalarioFuncionario == true)
            {
                try
                {
                    Console.WriteLine("Informe o salário: ");
                    readLineValue = Console.ReadLine();
                    salarioFuncionario[atual] = Convert.ToDouble(readLineValue);
                    Console.Clear();
                    validacaoSalarioFuncionario = false;
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("O valor \"" + readLineValue + "\" não é numérico");
                    Console.WriteLine("\n");

                }
            }
            Console.WriteLine("Informe o salário: ");
            salarioFuncionario[atual] = Convert.ToDouble(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Informe a função: ");
            funcaoFuncionario[atual] = Console.ReadLine();
            atual++;
        }
    }
}
