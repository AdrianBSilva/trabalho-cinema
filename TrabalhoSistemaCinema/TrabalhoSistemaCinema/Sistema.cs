using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoSistemaCinema
{
    class Sistema
    {
        public EscolhaCliente _cliente = new EscolhaCliente();
        public Filme _filme = new Filme();
        public Alimentacao _alimentacao = new Alimentacao();
        public EscolhaFuncionario _funcionario = new EscolhaFuncionario();
        int menuEscolha = 0;
        bool validacaoMenu = true;
        string readLineValue = "";

        //Qualquer coisa da um debug e olha passo a passo como ta funcionando, se as  dúvidas persistirem ai me chama que eu te ajudo
        //Tenta seguir meu padrão de como eu fiz, detalhe, fiquei até as 4 da manhã fazendo isso kkkkkkkkkkkkkkk lul 
        public Sistema()
        {
            GerirMenu();
        }

        public void Menu()
        {
            Console.WriteLine("======================================================");
            Console.WriteLine("=================== MENU PRINCIPAL ===================");
            Console.WriteLine("======================================================");                        
            Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}",
                    "1 - Cliente",
                    "2 - Filmes",
                    "3 - Alimentação",
                    "4 - Funcionário",
                    "9 - Voltar"
                );
        }

        public void GerirMenu()
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
                        Console.Clear();
                        _cliente.MenuCliente();
                        break;
                    case 2:
                        Console.Clear();
                        _filme.CadastroFilme();
                        break;
                    case 3:
                        Console.Clear();
                        _alimentacao.CadastrarAlimentacao();
                        break;
                    case 4:
                        Console.Clear();
                        _funcionario.MenuFuncionario();
                        break;
                }

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
                        Console.WriteLine("O valor \"" + readLineValue + "\" não é numérico\nInforme Novamente");
                    }
                }
                Console.Clear();
            }
        }
    }
}
