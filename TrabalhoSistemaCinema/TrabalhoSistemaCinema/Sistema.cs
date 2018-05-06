using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoSistemaCinema
{
    class Sistema
    {
        public EscolhaCliente cliente = null;
        public Filme filme = null;
        public Alimentacao alimentacao = null;
        public EscolhaFuncionario funcionario = null;
        int menuEscolha = 0;
        bool validacaoMenu = true;
        string readLineValue = "";

        //Public Sistema faz com que "Menu" possa ser usado em outras classes como por exemplo "EscolhaFuncionario"
        // assim você consegue voltar para o menu principal
        //Repete o Sistema nas suas classes, se tiver dúvida copia como eu fiz
        //Quando você for fazer bota o "This" ali entre parenteses
        //Qualquer coisa da um debug e olha passo a passo como ta funcionando, se as  dúvidas persistirem ai me chama que eu te ajudo
        //Tenta seguir meu padrão de como eu fiz, detalhe, fiquei até as 4 da manhã fazendo isso kkkkkkkkkkkkkkk lul 
        public Sistema()
        {
            cliente = new EscolhaCliente(this);
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
                        cliente.MenuCliente();
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
