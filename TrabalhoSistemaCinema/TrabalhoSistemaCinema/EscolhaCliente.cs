using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoSistemaCinema
{
    class EscolhaCliente
    {

        Cliente cliente = new Cliente();
        int atual = 0;
        double precoIngresso = 12;

        double desconto = 6;

        double valorTotalIngresso = 0;


        public void MenuCliente()
        {
            GerirMenuCliente();
        }

        public void Menu()
        {
            Console.WriteLine(
                @"
1 - Cadastro do Cliente
2 - Buscar Cliente
3 - Listar Cliente
4 - Comprar Ingresso 
9 - Sair");
        }

        public void GerirMenuCliente()
        {
            MenuCliente();
            int menuEscolha = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            while (menuEscolha != 9)
            {
                switch (menuEscolha)
                {
                    case 1:
                        cliente.CadastroClientes();
                        break;
                    case 2:
                        
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Lista de clientes: ");
                        for (int i = 0; i < atual; i++)
                        {
                            Console.WriteLine(nomeClientes[i]);
                        }
                        break;
                    case 4:
                        Console.WriteLine("Informe a cliente: ");
                        idadeClientes[atual ] = Convert.ToInt32(Console.ReadLine());
                        if (idadeClientes[atual] < 18)
                        {
                            Console.WriteLine("Desconto por ser menor de 18");
                            Console.WriteLine("\n\n");
                            precoIngresso = precoIngresso - desconto;
                        }
                        if (idadeClientes[atual] > 60)
                        {
                            Console.WriteLine("Desconto por ser Idoso");
                            Console.WriteLine("\n\n");
                            precoIngresso = precoIngresso - desconto;
                        }

                        Console.WriteLine("Carteira de Estudante \n 1 - Sim \n 2 - Não");
                        carteiraEstudante[atual] = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();

                        if ((carteiraEstudante[atual] == 1) && (idadeClientes[atual] > 18))
                        {
                            precoIngresso = precoIngresso - desconto;
                        }
                        else if (carteiraEstudante[atual] == 2)
                        {
                            Console.WriteLine("Sem desconto da carteira de estudante");
                            Console.WriteLine("\n");

                        }

                        Console.WriteLine("Informe o valor depositado: ");
                        compraIngresso[atual] = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("\n");
                        valorTotalIngresso = compraIngresso[atual] - precoIngresso;

                        while (valorTotalIngresso < 0)
                        {
                            Console.WriteLine("\n\n");
                            Console.WriteLine("O valor total a ser pago é: R$" + precoIngresso);
                            Console.WriteLine("\n");
                            Console.WriteLine("Informe o valor novamente: ");
                            compraIngresso[atual] = Convert.ToDouble(Console.ReadLine());
                            valorTotalIngresso = compraIngresso[atual] - precoIngresso;
                            Console.Clear();
                        }
                        Menu();
                        menuEscolha = Convert.ToInt32(Console.ReadLine());
                            break;
                        
                }
            }
        }
    }
}
