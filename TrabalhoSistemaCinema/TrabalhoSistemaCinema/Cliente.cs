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
        string[] nomeClientes = new string[100];
        int[] idadeClientes = new int[100];
        int[] carteiraEstudante = new int[100];
        double[] compraIngresso = new double[100];
        bool validacaoIdadeCliente = true, validacaoIngresso = true;
        string readLineValue = "";
        
        
        
        
        double precoIngresso = 12;

        double desconto = 6;

        double valorTotalIngresso = 0;
        int atual = 0;

        Sistema _sistema = null;
        public Cliente(Sistema sistema)
        {
            _sistema = sistema;
        }




        public void CadastroClientes()
        {
            Console.Clear();

            string sairTexto = " (ou \"sair\" para sair): ";
            string idade = "";

            while (nomeClientes[atual] != "sair")
            {
                Console.Clear();

                // Recebe o nome
                Console.Write("Informe seu nome" + sairTexto);
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
                nomeClientes[atual] = nome.ToLower().Trim();
                idadeClientes[atual] = idadeNumero;

                if(idadeNumero > 0)
                {
                atual++;

                }
                // atualiza o "atual" para um novo cadastro
            }
        }
        
         public void BuscarCliente()
         {
            Console.Clear();
            
            
                
                Console.Write("Digite o nome para a busca(ou \"Sair\" para sair): ");
                string nomeBuscado = Console.ReadLine().ToLower().Trim();
                while (nomeBuscado != "sair")
                {


                    bool achou = false;


                    for (int i = 0; i < atual; i++)
                    {

                        if (nomeBuscado == nomeClientes[i])
                        {
                            achou = true;
                            Console.Clear();
                            Console.WriteLine("Nome: " + nomeClientes[i]);
                            Console.WriteLine("Idade: " + idadeClientes[i]);
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

        public void ListarCliente()
        {
            
            Console.WriteLine("Lista de Clientes: ");

            Console.WriteLine("-------------------------");

            for (int i = 0; i < atual; i++)
            {
                Console.WriteLine(String.Format("Código: {0}\nNome: {1}\nIdade: {2}\n",
                    i, 
                    nomeClientes[i], 
                    idadeClientes[i])
                    );
                
            }

            Console.WriteLine("------------------------");
                Console.WriteLine("\nDigite qualquer tecla para sair: ");
                string retornar = Console.ReadLine().Trim().ToLower();
                
                


            
        }

        public void ComprarIngresso()
        {
            validacaoIdadeCliente = true;
            while (validacaoIdadeCliente == true)
            {
                try
                {
                    Console.WriteLine("Informe a idade: ");
                    readLineValue = Console.ReadLine();
                    idadeClientes[atual] = Convert.ToInt32(readLineValue);
                    Console.Clear();
                    validacaoIdadeCliente = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("O valor \"" + readLineValue + "\" não é numérico");

                }
            }


            if (idadeClientes[atual] < 18)
            {
                Console.WriteLine("Desconto por ser menor de 18(Descartado o desconto de Estudante)");
                Console.WriteLine("\n\n");
                precoIngresso = precoIngresso - desconto;
            }

            if (idadeClientes[atual] > 60)
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
                    carteiraEstudante[atual] = Convert.ToInt32(Console.ReadLine());
                    
                    validacaoIngresso = false;

                }
                catch (Exception)
                {
                    Console.Clear();
                    
                }
            }
            

            if ((carteiraEstudante[atual] == 1) && (idadeClientes[atual] > 18))
            {
                precoIngresso = precoIngresso - desconto;
            }

            else if (carteiraEstudante[atual] == 2)
            {
                Console.WriteLine("Sem desconto da carteira de estudante");
                Console.WriteLine("\n");

            }
            validacaoIngresso = true;
            while(validacaoIngresso == true)
            try
            {
                Console.WriteLine("Informe o valor depositado: ");
                compraIngresso[atual] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("\n");
                    validacaoIngresso = false;
                valorTotalIngresso = compraIngresso[atual] - precoIngresso;
            }
            catch(Exception)
            {
                    Console.Clear();
                Console.WriteLine("Informe novamente!");

            }

            while (valorTotalIngresso < 0)
            {
                Console.WriteLine("\n\n");
                
                Console.WriteLine("\n");
                Console.WriteLine("O valor total a ser pago é: R$" + precoIngresso);
                validacaoIngresso = true;
                while (validacaoIngresso == true)
                    try
                    {
                        Console.WriteLine("Informe o valor depositado: ");
                        compraIngresso[atual] = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("\n");
                        validacaoIngresso = false;
                        valorTotalIngresso = compraIngresso[atual] - precoIngresso;
                    }
                    catch (Exception)
                    {
                        Console.Clear();
                        Console.WriteLine("Informe novamente!");

                    }
                valorTotalIngresso = compraIngresso[atual] - precoIngresso;
                

            }

            Console.WriteLine("\n");
            Console.WriteLine("O valor total a ser pago é: R$" + precoIngresso);
            Console.WriteLine("O valor total de troco é: R$" + valorTotalIngresso);
            Console.WriteLine("\n");
            Console.Write("Digite algo para continuar: ");
            string retornar = Console.ReadLine();
            precoIngresso = 12;
            atual++;
        }




        
    }
}
