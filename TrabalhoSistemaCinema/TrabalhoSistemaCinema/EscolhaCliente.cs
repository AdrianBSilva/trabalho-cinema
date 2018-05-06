using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoSistemaCinema
{
    class EscolhaCliente
    {
        int menuEscolha = 0;        
        bool validacaoMenu = true;
        
        Cliente cliente = new Cliente();        
        
        public void MenuCliente()
        {
            GerirMenuCliente();
        }

        /// <summary>
        /// Exibe o menu do cliente
        /// </summary>
        public void Menu()
        {
            Console.Clear();             
            Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}",
                "1 - Cadastro do Cliente",
                "2 - Buscar Cliente",
                "3 - Listar Cliente",
                "4 - Comprar Ingresso",
                "9 - Voltar"
            );
        }

        /// <summary>
        /// Gera o menu do cliente
        /// </summary>
        public void GerirMenuCliente()
        {            
            validacaoMenu = true;
            while (validacaoMenu == true)
            {
                try
                {
                    Menu();
                    menuEscolha = Convert.ToInt32(Console.ReadLine());                    
                    validacaoMenu = false;
                }
                catch (Exception)
                {
                    Console.Clear();                    
                }
            }
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

                Menu();
                validacaoMenu = true;

                while (validacaoMenu == true)
                {
                    try
                    {

                        Menu();

                        menuEscolha = Convert.ToInt32(Console.ReadLine());
                        validacaoMenu = false;
                    }
                    catch (Exception)
                    {
                        Console.Clear();
                        
                    }
                }
                Console.Clear();
            }
        }
    }
}
