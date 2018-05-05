using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoSistemaCinema
{
    class Funcionario
    {
        Sistema _sistema = null;
        public Funcionario(Sistema sistema)
        {
            _sistema = sistema;
        }
        string readLineValue = "";
        string[] nomeFuncionario = new string[100];
        int[] idadeFuncionario = new int[100];
        double[] salarioFuncionario = new double[100];
        string[] funcaoFuncionario = new string[100];
        bool validacaoIdadeFuncionario = true, validacaoSalarioFuncionario = true, validacaoSenha = true;
        int senha = 951753;
        int atual = 0, acesso = 0;
        string nome = "";
        

        
        

        public void CadastroFuncionario()
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
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("Senha Numérica! Informe novamente");
                }
            }

                Console.Clear();
                while (acesso != senha)
                {

                    Console.Clear();
                    Console.WriteLine("Senha incorreta digite novamente");
                    Console.Write("Senha: ");
                    acesso = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();



                }

                while (nome != "sair")
                {
                    Console.WriteLine("Informe o nome(ou \"Sair\" para sair): ");
                    string nome = Console.ReadLine().ToLower().Trim();
                    if (nome == "sair")
                    {
                        break;
                    }
                    Console.Clear();

                    validacaoIdadeFuncionario = true;
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


                    validacaoSalarioFuncionario = true;
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

                    Console.WriteLine("Informe a função: ");
                    funcaoFuncionario[atual] = Console.ReadLine();
                    nomeFuncionario[atual] = nome;

                    atual++;




                }
            
        }

        public void BuscarFuncionario()
        {
            Console.Clear();



            Console.Write("Digite o nome para a busca(ou \"Sair\" para sair): ");
            string nomeBuscado = Console.ReadLine().ToLower().Trim();
            while (nomeBuscado != "sair")
            {


                bool achou = false;


                for (int i = 0; i < atual; i++)
                {

                    if (nomeBuscado == nomeFuncionario[i])
                    {
                        achou = true;
                        Console.Clear();
                        Console.WriteLine("Nome: " + nomeFuncionario[i]);
                        Console.WriteLine("Idade: " + idadeFuncionario[i]);
                        Console.WriteLine("\n");

                        Console.Write("Digite \"Sair\" para sair ");
                        Console.Write("Digite o nome para a busca: ");
                        nomeBuscado = Console.ReadLine().ToLower().Trim();

                    }
                }

                if (!achou)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Nome não encontrado!");
                }


                Console.Write("Digite o nome para a busca(ou \"Sair\" para sair): ");
                nomeBuscado = Console.ReadLine().ToLower().Trim();


            }
        }

        public void ListarFuncionario()
        {
            Console.Clear();
            Console.WriteLine("Lista de Funcionários: ");

            Console.WriteLine("-------------------------");

            for (int i = 0; i < atual; i++)
            {
                Console.WriteLine(String.Format("Código: {0}\nNome: {1}\nIdade: {2}\nFunção: {3}\nSalário: {4}",
                    i + 1,
                    nomeFuncionario[i],
                    idadeFuncionario[i],
                    funcaoFuncionario[i],
                    salarioFuncionario[i])
                    );
                Console.WriteLine("\n");

            }

            Console.WriteLine("------------------------");
            Console.WriteLine("\nDigite qualquer tecla para sair: ");
            string retornar = Console.ReadLine().Trim().ToLower();
        }

        public void SalarioFuncionario()
        {
            Console.Clear();
            Console.WriteLine("Digite o nome do funcionário para a pesquisa: ");
            string nomePesquisado = Console.ReadLine().ToLower().Trim();
            Console.Clear();
            int posicao = -1;
            for (int i = 0; i < atual; i++)
            {
                if (nomePesquisado == nomeFuncionario[i].ToLower())
                {
                    posicao = i;
                }
            }
            if (posicao != -1)
            {
                Console.Write("Nome do Funcionário: ");
                nomeFuncionario[posicao] = Console.ReadLine().ToLower().Trim();
                validacaoIdadeFuncionario = true;
                while (validacaoIdadeFuncionario == true)
                {
                    try
                    {
                        Console.WriteLine("Idade do Funcionário: ");
                        idadeFuncionario[posicao] = Convert.ToInt32(Console.ReadLine());
                        validacaoIdadeFuncionario = false;
                    }
                    catch (Exception)
                    {
                        Console.Clear();
                        Console.WriteLine("Informe a idade novamente!");
                    }
                    
                }
                validacaoSalarioFuncionario = true;
                while (validacaoSalarioFuncionario == true)
                {
                    try
                    {
                        Console.Write("Salário do funcionário: ");
                        salarioFuncionario[posicao] = Convert.ToDouble(Console.ReadLine());
                        validacaoSalarioFuncionario = false;
                    }
                    catch (Exception)
                    {
                        Console.Clear();
                        Console.WriteLine("Informe o salário novamente!");
                    }

                }
                
                
            }
            else
            {
                Console.WriteLine("Registro não encontrado");

            }
            for (int i = 0; i < atual; i++)
            {
                Console.WriteLine("Funcionário: {0}\nIdade: {1}\nSalário: {2}",
                    nomeFuncionario,
                    idadeFuncionario,
                    salarioFuncionario);
            }
        }
    }
}
