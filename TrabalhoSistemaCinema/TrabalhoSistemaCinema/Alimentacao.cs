using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoSistemaCinema
{
    class Alimentacao
    {
        bool validarDinheiro = true;
        double valorTotal = 0;
        string pedido = "";
        bool validcaoEscolha = true;
        bool validacaoConfirmacao = true;
        int menuEscolha = 0;
        double dinheiro = 0;

        public void Menu()
        {
            validcaoEscolha = true;
            while (validcaoEscolha == true)
            {
                try
                {
                    while (menuEscolha < 9)
                    {
                        Console.WriteLine(@"                   ====================MENU====================     
  ________________________________________
  |1-Pipoca Grande                 R$15,00|
  |2-Pipoca Média                  R$10,00|
  |3-Pipoca Pequena                R$ 8,00|
  |4-Refigerante lata              R$ 5,00|
  |5-Refrigerante 600ml            R$ 7,00|
  |6-Balas fini                    R$ 5,00|
  |_______________________________________|________________________________
  |                                   COMBOS                               |
  |7-Família: Pipoca Grande + Pequena + Refrigerante 600ml + lata   R$30,00| 
  |                                                                        |
  |8-Popular: Pipoca Média + Refrigerante 600ml + Balas fini        R$23,00|
  |                                                                        |
  |9-Junior: Pipoca Pequena + Refrigerante lata + Balas fini        R$15,00|
  |________________________________________________________________________|
  |Digite qualque outro numero para SAIR                                   |
  |________________________________________________________________________|");


                        Console.Write("Pedido do cliente: ");
                        menuEscolha = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        validcaoEscolha = false;

                        Console.Clear();

                        switch (menuEscolha)
                        {
                            case 1:
                                valorTotal = valorTotal + 15.00;
                                pedido = pedido + "," + " Pipoca Grande";
                                break;

                            case 2:
                                valorTotal = valorTotal + 10.00;
                                pedido = pedido + "," + " Pipoca Média";
                                break;


                            case 3:
                                valorTotal = valorTotal + 8.00;
                                pedido = pedido + "," + " Pipoca Pequena";
                                break;

                            case 4:
                                valorTotal = valorTotal + 5.00;
                                pedido = pedido + "," + "Refrigerante lata";
                                break;

                            case 5:
                                valorTotal = valorTotal + 7.00;
                                pedido = pedido + "," + "Refrigerante 600ml";
                                break;

                            case 6:
                                valorTotal = valorTotal + 5.00;
                                pedido = pedido + "," + "Balas fini";
                                break;

                            case 7:
                                valorTotal = valorTotal + 30.00;
                                pedido = pedido + "," + "Combo Família";
                                break;

                            case 8:
                                valorTotal = valorTotal + 23.00;
                                pedido = pedido + "," + "Combo Popular";
                                break;

                            case 9:
                                valorTotal = valorTotal + 15.00;
                                pedido = pedido + "," + "Combo Junior";
                                break;

                        }


                    }
                }

                catch (Exception)
                {
                    Console.Clear();
                    Menu();



                }
            }
            
        

            Console.WriteLine("Seu pedido foi : " + pedido);
            Console.WriteLine("Valor total: R$" + valorTotal);
            
            
             validarDinheiro = true;
            while (validarDinheiro == true)
            {
                try
                {
                    Console.Write("Informe o valor depositado:");
                    dinheiro = Convert.ToDouble(Console.ReadLine());
                    validarDinheiro = false;
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("Erro! Informe  valor novamente");
                }
            }
            if (dinheiro > valorTotal)
            {
                Console.WriteLine("Troco: " + (dinheiro - valorTotal));
            }
            else if (dinheiro < valorTotal)
            {
                Console.WriteLine("Dinheiro insuficiente\n");
                while ((validarDinheiro == true) || (dinheiro < 0))
                {
                    try
                    {
                        Console.Write("Informe o valor novamnete:");
                        dinheiro = Convert.ToDouble(Console.ReadLine());
                        validarDinheiro = false;
                    }
                    catch
                    {
                        Console.Clear();
                        Console.WriteLine("Erro! Informe  valor novamente");
                    }
                }
            }
            else
            {
                Console.WriteLine("Obrigado :)");
            }
        Console.Clear();
        }
           

       
           




    }




}



