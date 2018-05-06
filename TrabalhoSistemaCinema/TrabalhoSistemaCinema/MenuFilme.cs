using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoSistemaCinema
{
    class MenuFilme
    {

        Filme filme = new Filme();
        bool validacaoMenu = true;
        int menuFilmeEscolha = 0;
        public void menuFilme()
        {
            GerarMenuFilme();
        }

        public void Menu()
        {
            Console.Clear();
            Console.WriteLine(
@"
1 - Cadastrar de Filmes
2 - Listar Filmes
3 - Buscar Filme
4 - Editar filme
5 - voltar"
);
        }

        public void GerarMenuFilme()
        {
            Menu();
            validacaoMenu = true;
            while (validacaoMenu == true)
            {
                try
                {
                    Menu();
                    menuFilmeEscolha = Convert.ToInt32(Console.ReadLine());
                    validacaoMenu = false;
                }
                catch (Exception)
                {
                    Console.Clear();
                }

            }
            Console.Clear();
            while (menuFilmeEscolha != 5)
            {
                switch (menuFilmeEscolha)
                {
                    case 1:
                        filme.CadastroFilme();
                        break;
                    case 2:
                        filme.ListarFilmes();
                        break;
                    case 3:
                        filme.BuscarFilme();
                        break;                    
                    case 4:
                        filme.EditarFilme();
                        break;
                   
                }
            }
        }

        
    }
}
