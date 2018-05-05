using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoSistemaCinema
{
    class EscolhaFuncionario
    {
        int menuEscolha = 0;
        string readLineValue = "";
        bool validacaoMenu = true;
        Funcionario funcionario = null;

        Sistema _sistema = null;
        
        public EscolhaFuncionario(Sistema sistema)
        {
            _sistema = sistema;
            funcionario = new Funcionario(sistema); 
        }

        public void MenuFuncionario()
        {
            GerarMenuFuncionarios();
        }

        public void Menu()
        {
            Console.Clear();
            Console.WriteLine(
                @"
1 - Cadastro do Funcionário
2 - Busca do Funcionário
3 - Lista de Funcionários
4 - Salário do Funcionário 
9 - Voltar");
        }

        public void GerarMenuFuncionarios()
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
                Console.Clear();

                while (menuEscolha != 9)
                {
                    switch (menuEscolha)
                    {
                        case 1:

                            funcionario.CadastroFuncionario();

                            break;
                        case 2:

                            funcionario.BuscarFuncionario();
                            break;
                        case 3:

                            funcionario.ListarFuncionario();
                            break;
                        case 4:

                            funcionario.SalarioFuncionario();
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
                        Console.Clear();
                    }
                }
            }
        }
    }
}
