using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoSistemaCinema
{
    class Cliente
    {
        // Todos os itens
        string _readLineValue = "";
        bool _validacaoIdadeCliente = true, validacaoIngresso = true;
        int _idade = 0;                                
        int atual = 0;
        double precoIngresso = 12;
        double desconto = 6;
        double valorTotalIngresso = 0;
        double[] _compraIngresso = new double[100];
        int[] _carteiraEstudante = new int[100];
        int[] _idadeClientes = new int[100];
        string[] _nomeClientes = new string[100];
        bool pararRepeticao = true;
        bool repeticaoTexto = false;
                      
        /// <summary>
        /// Cadastro de Clientes
        /// </summary>
        public void CadastroClientes()
        {
            Console.Clear();

            string sairTexto = " (ou \"sair\" para sair): ";
            string idade = "";

            while (_nomeClientes[atual] != "sair")
            {
                Console.Clear();

                // Recebe o nome 
                Console.WriteLine("Informe seu nome" + sairTexto);
                string nome = Console.ReadLine();

                // Sai do programa se for "sair"
                if (nome.Trim().ToLower() == "sair")
                {
                    break;
                }

                int idadeNumero = 0;

                while (idadeNumero == 0)
                {
                    try
                    {
                        // Recebe a idade                
                        Console.Write("Informe sua idade: ");
                        idade = Console.ReadLine();
                                              
                        idadeNumero = Convert.ToInt32(idade);

                        if (idadeNumero == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("\nInforme uma idade válida! Você informou: \"{0}\"", idade);
                        }

                    }

                    catch (Exception)
                    {
                        Console.Clear();
                        Console.WriteLine("\nInforme uma idade válida! Você informou: \"{0}\"", idade);
                    }
                }
                
                // Guarda o "nome" e a "idade" se estiver ok.
                _nomeClientes[atual] = nome.ToLower().Trim();
                _idadeClientes[atual] = idadeNumero;

                if(idadeNumero > 0)
                {
                atual++;

                }
                // atualiza o "atual" para um novo cadastro
            }
        }

        public void ExibirMaioresNomes()
        {
            string maiorNome = "";
            int indiceNomes = 0;
            string[] nomes = new string[atual];

            
            for (int i = 0; i < atual; i++)
            {
                
                // adiciona repitidos
                if (_nomeClientes[i].Length == maiorNome.Length)
                {
                    nomes[indiceNomes++] = _nomeClientes[i];

                } // Adiciona o maior.
                else if (_nomeClientes[i].Length > maiorNome.Length)
                {
                    // Seleciona o maior nome.
                    maiorNome = _nomeClientes[i];

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
        /// Busca de Clientes
        /// </summary>
        public void BuscarCliente()
         {
            Console.Clear();
            string nomeBuscado = "";
            if (pararRepeticao == true)
            {
                Console.WriteLine("Digite o nome para a busca(ou \"Sair\" para sair): ");
                nomeBuscado = Console.ReadLine().ToLower().Trim();
                pararRepeticao = false;

            }                        
                

                while (nomeBuscado != "sair")
                {
                    
                     bool achou = false;

                    for (int i = 0; i < atual; i++)
                    {

                        if (nomeBuscado == _nomeClientes[i])
                        {
                            achou = true;
                            
                            Console.WriteLine("Nome: " + _nomeClientes[i]);
                            Console.WriteLine("Idade: " + _idadeClientes[i]);
                            Console.WriteLine("\n");                                                                                    
                        }
                    }
                    if (repeticaoTexto == true)
                    {
                        Console.WriteLine("Digite o nome para a busca(ou \"Sair\" para sair): ");
                        nomeBuscado = Console.ReadLine().ToLower().Trim();
                    }
                    repeticaoTexto = true;
                    Console.Clear();

                if (!achou)
                    {
                        Console.Clear();
                                                                        
                    }
                                      
                } 
                
            
         }
        /// <summary>
        /// Localiza o Maior Nome
        /// </summary>
        /// <returns></returns>
        public string LocalizarMaiorNome()
        {
            string maiorNome = "";

            for (int i = 0; i < atual; i++)
            {
                if (_nomeClientes[i].Length > maiorNome.Length)
                {
                    maiorNome = _nomeClientes[i];
                }


            }
            return maiorNome;
        }

        /// <summary>
        /// Lista de Clientes
        /// </summary>
        public void ListarCliente()
        {
            if (atual == 0)
            {
                Console.WriteLine("Nenhum cliente cadastrado! Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                
                
            }
            else
            {
                Console.WriteLine("Lista de Clientes: ");

                Console.WriteLine("-------------------------");

                for (int i = 0; i < atual; i++)
                {
                    Console.WriteLine(String.Format("Código: {0}\nNome: {1}\nIdade: {2}\n",
                        i + 1, 
                        _nomeClientes[i], 
                        _idadeClientes[i])
                        );
                
                }

                Console.WriteLine("------------------------");
                ExibirMaioresNomes();
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            }                                            
        }

        /// <summary>
        /// Compra de Ingressos
        /// </summary>
        public void ComprarIngresso()
        {
            _validacaoIdadeCliente = true;
            while (_validacaoIdadeCliente == true)
            {
                try
                {
                    Console.WriteLine("Informe a idade: ");
                    _readLineValue = Console.ReadLine();
                    _idade = Convert.ToInt32(_readLineValue);
                    Console.Clear();
                    _validacaoIdadeCliente = false;
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("O valor \"" + _readLineValue + "\" não é numérico\nInforme Novamente");


                }
            }


            if (_idade < 18)
            {
                Console.WriteLine("Desconto por ser menor de 18(Descartado o desconto de Estudante)");
                Console.WriteLine("\n\n");
                precoIngresso = precoIngresso - desconto;
            }

            if (_idade > 60)
            {
                Console.WriteLine("Desconto por ser Idoso(Descartado o desconto de Estudante)");
                Console.WriteLine("\n\n");
                precoIngresso = precoIngresso - desconto;
            }
            validacaoIngresso = true;
            while (validacaoIngresso == true)
            {


                try
                {
                    Console.WriteLine("Carteira de Estudante \n 1 - Sim \n 2 - Não");
                    _readLineValue = Console.ReadLine();
                    _carteiraEstudante[atual] = Convert.ToInt32(_readLineValue);
                    Console.Clear();
                    
                    validacaoIngresso = false;

                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("O valor \"" + _readLineValue + "\" não é numérico\nInforme Novamente");

                }
            }
            

            if ((_carteiraEstudante[atual] == 1) && (_idadeClientes[atual] > 18))
            {
                precoIngresso = precoIngresso - desconto;
            }

            else if (_carteiraEstudante[atual] == 2)
            {
                Console.WriteLine("Sem desconto da carteira de estudante");
                Console.WriteLine("\n");

            }
            if ((_carteiraEstudante[atual] == 1) && (_idadeClientes[atual] > 60))
            {
                precoIngresso = 6;
            }


            validacaoIngresso = true;
            while(validacaoIngresso == true)
            try
            {
                Console.WriteLine("O valor total a ser pago é: R$" + precoIngresso);
                Console.WriteLine("\n");
                Console.WriteLine("Valor para depositar o pagamento: ");
                _readLineValue = Console.ReadLine();
                Console.Clear();
                _compraIngresso[atual] = Convert.ToDouble(_readLineValue);                
                validacaoIngresso = false;
                valorTotalIngresso = _compraIngresso[atual] - precoIngresso;
            }
            catch(Exception)
            {
                    Console.Clear();
                    Console.WriteLine("O valor \"" + _readLineValue + "\" não é numérico\nInforme Novamente");
                    Console.WriteLine("\n");
                    

            }

            while (valorTotalIngresso < 0)
            {
                Console.WriteLine("\n\n");                                                
                validacaoIngresso = true;

                while (validacaoIngresso == true)
                {
                    try
                    {
                        Console.WriteLine("O valor total a ser pago é: R$" + precoIngresso);
                        Console.WriteLine("\n");
                        Console.WriteLine("Valor para Depositar o pagando: ");
                        _readLineValue = Console.ReadLine();
                        Console.Clear();
                        _compraIngresso[atual] = Convert.ToDouble(_readLineValue);
                        Console.WriteLine("\n");
                        validacaoIngresso = false;
                        valorTotalIngresso = _compraIngresso[atual] - precoIngresso;
                    }
                    catch (Exception)
                    {
                        Console.Clear();
                        Console.WriteLine("O valor \"" + _readLineValue + "\" não é numérico\nInforme Novamente");
                        Console.WriteLine("\n");
                    }
                    valorTotalIngresso = _compraIngresso[atual] - precoIngresso;
                }
                

            }

            Console.WriteLine("\n");            
            Console.WriteLine("O valor total de troco é: R$" + valorTotalIngresso);
            Console.WriteLine("\n");
            Console.Write("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            precoIngresso = 12;
            
        }




        
    }
}
