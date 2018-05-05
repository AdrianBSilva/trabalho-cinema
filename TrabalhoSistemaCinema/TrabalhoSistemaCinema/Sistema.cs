using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoSistemaCinema
{
    class Sistema
    {
        public EscolhaCliente cinema = null;
        public Filme filme = null;
        public Alimentacao alimentacao = null;
        public EscolhaFuncionario funcionario = null;
        int menuEscolha = 0;
        bool validacaoMenu = true;
        string readLineValue = "";

        public Sistema()
        {
            cinema = new EscolhaCliente(this);
            funcionario = new EscolhaFuncionario(this);
            filme = new Filme();
            alimentacao = new Alimentacao();

            GerirMenu();
        }


        public void Menu()
        {
            Console.WriteLine(
                @"
1 - Cliente
2 - Filmes
3 - Alimentação
4 - Funcionário
9 - Sair");
        }


        public void GerirMenu()
        {
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
                        Console.Clear();
                        cinema.MenuCliente();
                        break;
                    case 2:
                        Console.Clear();
                        filme.CadastroFilme();
                        break;
                    case 3:
                        Console.Clear();
                        alimentacao.CadastrarAlimentacao();
                        break;
                    case 4:
                        Console.Clear();
                        funcionario.MenuFuncionario(); 
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
