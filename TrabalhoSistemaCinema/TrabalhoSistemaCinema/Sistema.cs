using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoSistemaCinema
{
    class Sistema
    {
        Cinema cinema = new Cinema();
        CadastroFilme filme = new CadastroFilme();
        Alimentacao alimentacao = new Alimentacao();
        Funcionario funcionario = new Funcionario();
        
        
        public Sistema()
        {
            GerirMenu();
        }
        public void Menu()
        {
            Console.WriteLine(
                @"
1 - Cadastro do Cliente
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
                        cinema.CadastroClientes();
                        break;
                    case 2:
                        filme.CadastroFilme();
                        break;
                    case 3:
                        alimentacao.CadastrarAlimentacao();
                        break;
                    case 4:
                        funcionario.CadastroFuncionario();
                        break;
                }
                Menu();
                menuEscolha = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
