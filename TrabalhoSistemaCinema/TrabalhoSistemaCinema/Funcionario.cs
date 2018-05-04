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
        bool validacaoIdadeFuncionario = true;
        int atual = 0;

        public void CadastroFuncionario()
        {
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
            Console.WriteLine("Informe o salário: ");
            salarioFuncionario[atual] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe a função: ");
            funcaoFuncionario[atual] = Console.ReadLine();

        }
    }
}
