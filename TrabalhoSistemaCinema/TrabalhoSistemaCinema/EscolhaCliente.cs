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
                        cliente.BuscarCliente();
                        break;
                    case 3:
                        cliente.ListarCliente();
                        break;
                    case 4:
                        cliente.ComprarIngresso();
                        
                            break;
                        
                }
            }
        }
    }
}
