using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoSistemaCinema
{
    class EscolhaCliente
    {

        Cliente cliente = null;
        
        Sistema _sistema = null;
        public EscolhaCliente(Sistema sistema)
        {
            _sistema = sistema;
            cliente = new Cliente(sistema);          
        }
        




        public void MenuCliente()
        {
            GerirMenuCliente();
        }

        public void Menu()
        {
            Console.Clear();
            Console.WriteLine(
                @"
1 - Cadastro do Cliente
2 - Buscar Cliente
3 - Listar Cliente
4 - Comprar Ingresso 
9 - Voltar");
        }

        public void GerirMenuCliente()
        {
            Menu();
            int menuEscolha = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            while (menuEscolha != 9)
            {                
                switch (menuEscolha)
                {
                    case 1:
                        Console.Clear();
                        cliente.CadastroClientes();                        
                        break;
                    case 2:
                        Console.Clear();
                        cliente.BuscarCliente();
                        break;
                    case 3:
                        Console.Clear();
                        cliente.ListarCliente();
                        break;
                    case 4:
                        Console.Clear();
                        cliente.ComprarIngresso();                        
                        break;
                }

                Menu();
                menuEscolha = Convert.ToInt32(Console.ReadLine());
                
            }
        }
    }
}
