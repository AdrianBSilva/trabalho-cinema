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
        int idade = 0;
        
        
        
        
        double precoIngresso = 12;

        double desconto = 6;

        double valorTotalIngresso = 0;
        int atual = 0;

        //utilizado para que você consiga utiliar "Menu();" para conseguir fazer isso, você vai ter que acrescentar nas duas classes que você criar para filme e alimentação.
        Sistema _sistema = null;
        public Cliente(Sistema sistema)
        {
            _sistema = sistema;
        }



        //Faz o cadastro
        public void CadastroClientes()
        {
            Console.Clear();

            string sairTexto = " (ou \"sair\" para sair): ";
            string idade = "";

            while (nomeClientes[atual] != "sair")
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
                nomeClientes[atual] = nome.ToLower().Trim();
                idadeClientes[atual] = idadeNumero;

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
                if (nomeClientes[i].Length == maiorNome.Length)
                {
                    nomes[indiceNomes++] = nomeClientes[i];

                } // Adiciona o maior.
                else if (nomeClientes[i].Length > maiorNome.Length)
                {
                    // Seleciona o maior nome.
                    maiorNome = nomeClientes[i];

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

        //Faz a busca dos clientes
        public void BuscarCliente()
         {
            Console.Clear();
            
            
                
                Console.WriteLine("Digite o nome para a busca(ou \"Sair\" para sair): ");
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
                        Console.Write("Digite o nome para a busca(ou \"Sair\" para sair): ");
                        nomeBuscado = Console.ReadLine().ToLower().Trim();
                        Console.Clear();
                    }


                
                      

                }                
            
         }
        //Locazia o nome apartir de nomeClientes
        public string LocalizarMaiorNome()
        {
            string maiorNome = "";

            for (int i = 0; i < atual; i++)
            {
                if (nomeClientes[i].Length > maiorNome.Length)
                {
                    maiorNome = nomeClientes[i];
                }


            }
            return maiorNome;
        }

        //Faz a listagem dos clientes
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
                        nomeClientes[i], 
                        idadeClientes[i])
                        );
                
                }

                Console.WriteLine("------------------------");
                ExibirMaioresNomes();
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            }                                            
        }

        //Compra dos Ingressos
        public void ComprarIngresso()
        {
            validacaoIdadeCliente = true;
            while (validacaoIdadeCliente == true)
            {
                try
                {
                    Console.WriteLine("Informe a idade: ");
                    readLineValue = Console.ReadLine();
                    idade = Convert.ToInt32(readLineValue);
                    Console.Clear();
                    validacaoIdadeCliente = false;
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("O valor \"" + readLineValue + "\" não é numérico\nInforme Novamente");


                }
            }


            if (idade < 18)
            {
                Console.WriteLine("Desconto por ser menor de 18(Descartado o desconto de Estudante)");
                Console.WriteLine("\n\n");
                precoIngresso = precoIngresso - desconto;
            }

            if (idade > 60)
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
                    readLineValue = Console.ReadLine();
                    carteiraEstudante[atual] = Convert.ToInt32(readLineValue);
                    Console.Clear();
                    
                    validacaoIngresso = false;

                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("O valor \"" + readLineValue + "\" não é numérico\nInforme Novamente");

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
            if ((carteiraEstudante[atual] == 1) && (idadeClientes[atual] > 60))
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
                readLineValue = Console.ReadLine();
                Console.Clear();
                compraIngresso[atual] = Convert.ToDouble(readLineValue);                
                validacaoIngresso = false;
                valorTotalIngresso = compraIngresso[atual] - precoIngresso;
            }
            catch(Exception)
            {
                    Console.Clear();
                    Console.WriteLine("O valor \"" + readLineValue + "\" não é numérico\nInforme Novamente");
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
                        readLineValue = Console.ReadLine();
                        Console.Clear();
                        compraIngresso[atual] = Convert.ToDouble(readLineValue);
                        Console.WriteLine("\n");
                        validacaoIngresso = false;
                        valorTotalIngresso = compraIngresso[atual] - precoIngresso;
                    }
                    catch (Exception)
                    {
                        Console.Clear();
                        Console.WriteLine("O valor \"" + readLineValue + "\" não é numérico\nInforme Novamente");
                        Console.WriteLine("\n");
                    }
                    valorTotalIngresso = compraIngresso[atual] - precoIngresso;
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
