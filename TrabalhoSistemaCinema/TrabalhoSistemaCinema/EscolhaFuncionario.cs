using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoSistemaCinema
{
    class EscolhaFuncionario
    {
        int _menuEscolha = 0;
        string _readLineValue = "";
        bool _validacaoMenu = true;
        Funcionario _funcionario = new Funcionario();
                      
        public void MenuFuncionario()
        {
            GerarMenuFuncionarios();
        }

        /// <summary>
        /// 
        /// </summary>
        public void Menu()
        {
            Console.Clear();
            Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n{5}",
                "===================== FUNCIONÁRIO ===================",
                "1 - Cadastrar",
                "2 - Buscar",
                "3 - Listar",
                "4 - Alteração do Funcionário ",
                "9 - Voltar"
            );
        }

        /// <summary>
        /// Gera o menu do Funcionario
        /// </summary>
        public void GerarMenuFuncionarios()
        {
            Menu();
            _validacaoMenu = true;
            while (_validacaoMenu == true)
            {
                try
                {
                    Menu();
                    Console.Write("Informe sua opção: ");
                    _readLineValue = Console.ReadLine();
                    _menuEscolha = Convert.ToInt32(_readLineValue);

                    _validacaoMenu = false;
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("O valor \"" + _readLineValue + "\" não é válido");
                }
                Console.Clear();

                while (_menuEscolha != 9)
                {
                    switch (_menuEscolha)
                    {
                        case 1:

                            _funcionario.CadastroFuncionario();

                            break;
                        case 2:

                            _funcionario.BuscarFuncionario();
                            break;
                        case 3:

                            _funcionario.ListarFuncionario();
                            break;
                        case 4:

                            _funcionario.AltualizarFuncionario();
                            break;
                    }
                    Menu();
                    _validacaoMenu = true;

                    while (_validacaoMenu == true)
                    {
                        try
                        {

                            Menu();
                            Console.Write("Informe sua opção: ");
                            _readLineValue = Console.ReadLine();
                            _menuEscolha = Convert.ToInt32(_readLineValue);
                            _validacaoMenu = false;
                        }
                        catch (Exception)
                        {
                            Console.Clear();
                            Console.WriteLine("O valor \"" + _readLineValue + "\" não é válido");

                        }
                        Console.Clear();
                    }
                }
            }
        }
    }
}
