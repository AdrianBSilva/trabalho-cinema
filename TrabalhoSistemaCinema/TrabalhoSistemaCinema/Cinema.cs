﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoSistemaCinema
{
    class Cinema
    {
        // Todos os itens
        string[] nomeClientes = new string[100];
        int[] idadeClientes = new int[100];
        int[] carteiraEstudante = new int[100];
        double[] compraIngresso = new double[100];
        bool validacaoDesconto = false;
        string[] nomeFilme = new string[100];
        double[] duracaoFilme = new double[100];
        int[] classificaoFilme = new int[100];
        string[] generoFilme = new string[100];
        double precoIngresso = 12;
        double desconto = 5.50;
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

            if (idadeClientes[atual] < 17)
            {
                Console.WriteLine("Desconto de idade por ser menor de 18");
                Console.WriteLine("\n\n");
                validacaoDesconto = true;
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

            while(valorTotalIngresso < 0)
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
            Console.WriteLine("O valor total de troco é: R$" + valorTotalIngresso );
            Console.WriteLine("\n");
            precoIngresso = 12;
        }
        public void CadastroFilmes()
        {

        }
        public void Alimentacao()
        {

        }
        public void Funcionario()
        {

        }

       
    }
}