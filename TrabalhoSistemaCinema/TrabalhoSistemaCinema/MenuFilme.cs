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
        Sistema sistema = new Sistema();

        public void menuFilme()
        {
            Console.WriteLine(
    @"
1 - Cadastrar de Filmes
2 - Listar Filmes
3 - Buscar Filme
4 - Voltar para o menu principal
5 - Editar filme
6 - Voltar para o menu principal
7 - sair"
);
            menuFilme();
            int menuFilmeEscolha = Convert.ToInt32(Console.ReadLine());
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
                        sistema.Menu();
                        break;
                    case 5:
                        filme.EditarFilme();
                        break;
                    case 6:
                        sistema.Menu();
                        break;
                }
                menuFilme();
                menuFilmeEscolha = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
