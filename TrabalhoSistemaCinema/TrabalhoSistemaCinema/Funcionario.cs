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
        int atual = 0, acesso = 0;
        int senha = 951753;
        bool validacaoIdadeFuncionario = true;
        bool validacaoSalarioFuncionario = true;
        bool validacaoSenha = true;
        string nome = "";
        string[] funcaoFuncionario = new string[100];
        double[] salarioFuncionario = new double[100];
        string[] _nomeFuncionario = new string[100];
        int[] idadeFuncionario = new int[100];
        int codigoFuncionario = 0;
        int[] _codigoFuncionario = new int[100];

        /// <summary>
        /// Cadastro do funcionário
        /// </summary>
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

                try
                {
                    Console.WriteLine("Senha incorreta digite novamente");
                    acesso = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                }
                catch (Exception)
                {
                    Console.WriteLine("Valor incorreto, informe a senha novamente");
                }
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
                _nomeFuncionario[atual] = nome;
                codigoFuncionario++;
                for (int i = 0; i < atual; i++)
                {
                    _codigoFuncionario[atual] = codigoFuncionario;
                }
                atual++;
                Console.Clear();
            }

        }

        /// <summary>
        /// Busca do funcionário
        /// </summary>
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

                    if (nomeBuscado == _nomeFuncionario[i])
                    {
                        achou = true;
                        
                        Console.WriteLine("Nome: " + _nomeFuncionario[i]);
                        Console.WriteLine("Idade: " + idadeFuncionario[i]);
                        Console.WriteLine("Salário: " + salarioFuncionario[i]);
                        Console.WriteLine("\n");                                                
                    }
                }
                Console.Write("Digite o nome para a busca(ou \"Sair\" para sair): ");
                nomeBuscado = Console.ReadLine().ToLower().Trim();
                Console.Clear();

                if (!achou)
                {
                    Console.Clear();
                }

                
            }
        }

        /// <summary>
        /// Exibe o maior nome
        /// </summary>
        public void ExibirMaioresNomes()
        {
            string maiorNome = "";
            int indiceNomes = 0;
            string[] nomes = new string[atual];

            for (int i = 0; i < atual; i++)
            {
                // adiciona repitidos
                if (_nomeFuncionario[i].Length == maiorNome.Length)
                {
                    nomes[indiceNomes++] = _nomeFuncionario[i];

                } // Adiciona o maior.
                else if (_nomeFuncionario[i].Length > maiorNome.Length)
                {
                    // Seleciona o maior nome.
                    maiorNome = _nomeFuncionario[i];

                    // Começa a lista novamente...
                    indiceNomes = 0;
                    nomes = new string[atual];
                    nomes[indiceNomes++] = maiorNome;

                }
            }

            string nomesX = "";
            for (int i = 0; i < indiceNomes; i++)
            {
                nomesX += (nomes[i] + ", ");
            }


            if (indiceNomes > 1)
            {
                Console.WriteLine("Os maiores nomes são: {0}", nomesX);
            }
            else
            {
                Console.WriteLine("O maior nome é: {0}", nomesX);
            }
        }

        /// <summary>
        /// Lista dos funcionários
        /// </summary>
        public void ListarFuncionario()
        {
            Console.Clear();
            Console.WriteLine("Lista de Funcionários: ");

            Console.WriteLine("-------------------------");

            for (int i = 0; i < atual; i++)
            {
                Console.WriteLine(String.Format("Código: {0}\nNome: {1}\nIdade: {2}\nFunção: {3}\nSalário: {4}",
                    i + 1,
                    _nomeFuncionario[i],
                    idadeFuncionario[i],
                    funcaoFuncionario[i],
                    salarioFuncionario[i])
                    );
                Console.WriteLine("\n");

            }

            Console.WriteLine("------------------------");
            // Console.WriteLine("O maior nome é: " + LocalizarMaiorNome());
            ExibirMaioresNomes();
            Console.WriteLine("\nPressione qualquer tecla para sair: ");
            Console.ReadKey();
        }

        /// <summary>
        /// Atualização de funcionário
        /// </summary>
        public void AltualizarFuncionario()
        {
            Console.Clear();
            Console.Write("Digite o codigo do funcionário: ");
            codigoFuncionario = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            int posicao = -1;

            for (int i = 0; i < atual; i++)
            {
                if (codigoFuncionario != null)
                {
                    posicao = i;
                }
            }
            if (posicao != -1)
            {
                Console.Write("Alterar Nome do Funcionário: ");
                _nomeFuncionario[posicao] = Console.ReadLine().ToLower().Trim();
                validacaoIdadeFuncionario = true;
                Console.Clear();

                while (validacaoIdadeFuncionario == true)
                {
                    try
                    {
                        Console.Write("Alterar Idade do Funcionário: ");
                        idadeFuncionario[posicao] = Convert.ToInt32(Console.ReadLine());
                        validacaoIdadeFuncionario = false;
                        Console.Clear();
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
                        Console.Write("Alterar Salário do funcionário: ");
                        salarioFuncionario[posicao] = Convert.ToDouble(Console.ReadLine());
                        validacaoSalarioFuncionario = false;
                        Console.Clear();
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
            Console.Write("Alterar função do funcionário: ");
            funcaoFuncionario[posicao] = Console.ReadLine().ToLower().Trim();

            for (int i = 0; i < atual; i++)
            {
                Console.WriteLine("Funcionário: {0}\nIdade: {1}\nSalário: {2}\nFunção: {3}",
                    _nomeFuncionario,
                    idadeFuncionario,
                    salarioFuncionario,
                    funcaoFuncionario);
            }
        }
    }
}
