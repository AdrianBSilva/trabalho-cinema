using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoSistemaCinema
{
    class Alimentacao
    {
        double valorTotal = 0;
        string pedido = "";
        bool validcaoEscolha = true;
        bool validacaoConfirmacao = true;
        int menuEscolha = 0;


        public void Menu()
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
  |10-Sair                                                                 |
  |________________________________________________________________________|");

            
            validcaoEscolha = true;
            while (validcaoEscolha == true)
            {
                try
                {
                    Console.Write("Pedido do cliente: ");
                    menuEscolha = Convert.ToInt32(Console.ReadLine());
                    validcaoEscolha = false;
                }

                catch (Exception)
                {
                    Console.Clear();
                    Menu();
                   
                    

                }
            }
            while (menuEscolha < 9)
            {
                Console.Clear();
                Menu();
                Console.Write("Pedido do cliente: ");
                menuEscolha = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                validcaoEscolha = false;

                if (menuEscolha == 1)
                {
                    valorTotal = valorTotal + 15.00;
                    pedido = pedido + "," + " Pipoca Grande";

                }
                else if (menuEscolha == 2)
                {
                    valorTotal = valorTotal + 10.00;
                    pedido = pedido + "," + " Pipoca Média";
                }
                else if (menuEscolha == 3)
                {
                    valorTotal = valorTotal + 8.00;
                    pedido = pedido + "," + " Pipoca Pequena";
                }
                else if (menuEscolha == 4)
                {
                    valorTotal = valorTotal + 5.00;
                    pedido = pedido + "," + "Refrigerante lata";
                }
                else if (menuEscolha == 5)
                {
                    valorTotal = valorTotal + 7.00;
                    pedido = pedido + "," + "Refrigerante 600ml";
                }
                else if (menuEscolha == 6)
                {
                    valorTotal = valorTotal + 5.00;
                    pedido = pedido + "," + "Balas fini";
                }
                else if (menuEscolha == 7)
                {
                    valorTotal = valorTotal + 30.00;
                    pedido = pedido + "," + "Combo Família";
                }
                else if (menuEscolha == 8)
                {
                    valorTotal = valorTotal + 23.00;
                    pedido = pedido + "," + "Combo Popular";
                }
                else if (menuEscolha == 9)
                {
                    valorTotal = valorTotal + 15.00;
                    pedido = pedido + "," + "Combo Junior";
                }
                

            }
            

            

            Console.WriteLine("Seu pedido foi : " + pedido);
            Console.WriteLine("Valor total: R$" + valorTotal);
            
        }
 
            


        }
    }

