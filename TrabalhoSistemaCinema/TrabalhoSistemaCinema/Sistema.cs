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
        public Funcionario funcionario = null;

        public Sistema()
        {
            cinema = new EscolhaCliente(this);
            funcionario = new Funcionario();
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
            Menu();
            int menuEscolha = Convert.ToInt32(Console.ReadLine());
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
                        funcionario.CadastroFuncionario();
                        break;
                }

                Menu();
                menuEscolha = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
