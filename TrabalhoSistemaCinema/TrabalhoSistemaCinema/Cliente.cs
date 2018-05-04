using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoSistemaCinema
{
    class Cliente
    {
        // Todos os itens
        string[] nomeClientes = new string[100];
        int[] idadeClientes = new int[100];
        int[] carteiraEstudante = new int[100];
        double[] compraIngresso = new double[100];
        
        double precoIngresso = 12;

        double desconto = 6;

        double valorTotalIngresso = 0;
        int atual = 0;


        public void CadastroClientes()
        {

            Console.Clear();
            Console.WriteLine("Informe o nome: ");
            nomeClientes[atual] = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Informe a idade: ");
            idadeClientes[atual] = Convert.ToInt32(Console.ReadLine());
            Console.Clear();


            if (idadeClientes[atual] < 18)
            {
                Console.WriteLine("Desconto por ser menor de 18");
                Console.WriteLine("\n\n");
                precoIngresso = precoIngresso - desconto;
            }
            if (idadeClientes[atual] > 60)
            {
                Console.WriteLine("Desconto por ser Idoso");
                Console.WriteLine("\n\n");
                precoIngresso = precoIngresso - desconto;
            }

            Console.WriteLine("Carteira de Estudante \n 1 - Sim \n 2 - Não");
            carteiraEstudante[atual] = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            if ((carteiraEstudante[atual] == 1) && (idadeClientes[atual] > 18))
            {
                precoIngresso = precoIngresso - desconto;
            }
            else if (carteiraEstudante[atual] == 2)
            {
                Console.WriteLine("Sem desconto da carteira de estudante");
                Console.WriteLine("\n");

            }

            Console.WriteLine("Informe o valor depositado: ");
            compraIngresso[atual] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\n");
            valorTotalIngresso = compraIngresso[atual] - precoIngresso;

            while (valorTotalIngresso < 0)
            {
                Console.WriteLine("\n\n");
                Console.WriteLine("O valor total a ser pago é: R$" + precoIngresso);
                Console.WriteLine("\n");
                Console.WriteLine("Informe o valor novamente: ");
                compraIngresso[atual] = Convert.ToDouble(Console.ReadLine());
                valorTotalIngresso = compraIngresso[atual] - precoIngresso;
                Console.Clear();

            }

            Console.WriteLine("\n");
            Console.WriteLine("O valor total de troco é: R$" + valorTotalIngresso);
            Console.WriteLine("\n");
            precoIngresso = 12;
            atual++;

        }




        
    }
}
