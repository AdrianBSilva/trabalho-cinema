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
        string readLineValue = "";
        bool validacaoMenu = true;
        
        Cliente cliente = null;
        //Com o "Sistema _sistema = null"
        //E "cliente = new Cliente(sistema)"
        //Eu consigo utilizar a aba Menu(); para voltar ao menu principal
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
            validacaoMenu = true;
            while (validacaoMenu == true)
            {
                try
                {

                    Menu();
                    readLineValue = Console.ReadLine();
                    menuEscolha = Convert.ToInt32(readLineValue);                    
                    validacaoMenu = false;
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("O valor \"" + readLineValue + "\" não é numérico");
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
                        readLineValue = Console.ReadLine();
                        menuEscolha = Convert.ToInt32(readLineValue);
                        validacaoMenu = false;
                    }
                    catch (Exception)
                    {
                        Console.Clear();
                        Console.WriteLine("O valor \"" + readLineValue + "\" não é numérico");
                    }
                }
                Console.Clear();
            }
        }
    }
}
