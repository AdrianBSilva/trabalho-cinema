    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace TrabalhoSistemaCinema
    {
        class Alimentacao
        {
            bool _validarDinheiro = true;
            double _valorTotal = 0;
            string _pedido = "";
            bool _validcaoEscolha = true;        
            int _menuEscolha = 0;
            double _dinheiro = 0;
            int quantidade = 0;

            public void Menu()
            {
                _validcaoEscolha = true;

                while (_validcaoEscolha == true)
                {
                    try
                    {
                        _menuEscolha = 0;
                        while (_menuEscolha < 9)
                        {
                            Console.WriteLine(@"                   ====================MENU ALIMENTAÇÃO====================     
      ________________________________________
      |1-Pipoca Grande                 R$15,00|
      |2-Pipoca Média                  R$10,00|
      |3-Pipoca Pequena                R$ 8,00|
      |4-Refigerante lata              R$ 5,00|
      |5-Refrigerante 600ml            R$ 7,00|
      |6-Balas fini                    R$ 5,00|
      |_______________________________________|________________________________
      |                                   COMBOS                               |
      |7-Família: Pipoca Grande + Pequena + Refrigerante 600ml + lata   R$30,00| 
      |                                                                        |
      |8-Popular: Pipoca Média + Refrigerante 600ml + Balas fini        R$23,00|
      |                                                                        |
      |9-Junior: Pipoca Pequena + Refrigerante lata + Balas fini        R$15,00|
      |________________________________________________________________________|
      |15-Para exibir o total                                                  |
      |20-Para voltar para o menu principal                                    |
      |________________________________________________________________________|");

                            Console.Write("Pedido do cliente: ");
                            _menuEscolha = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            _validcaoEscolha = false;

                            while (_menuEscolha != 20)
                            {
                                if ((_menuEscolha > 20) || (_menuEscolha < 1))
                                {
                                    Menu();
                                }

                                switch (_menuEscolha)
                                {
                                    case 1:
                                        _valorTotal = _valorTotal + 15.00;
                                        _pedido = _pedido + "," + " Pipoca Grande";
                                        quantidade++;
                                        Menu();
                                        break;

                                    case 2:
                                        _valorTotal = _valorTotal + 10.00;
                                        _pedido = _pedido + "," + " Pipoca Média";
                                        quantidade++;
                                        Menu();
                                        break;

                                    case 3:
                                        _valorTotal = _valorTotal + 8.00;
                                        _pedido = _pedido + "," + " Pipoca Pequena";
                                        quantidade++;
                                        Menu();
                                        break;

                                    case 4:
                                        _valorTotal = _valorTotal + 5.00;
                                        _pedido = _pedido + "," + "Refrigerante lata";
                                        quantidade++;
                                        Menu();
                                        break;

                                    case 5:
                                        _valorTotal = _valorTotal + 7.00;
                                        _pedido = _pedido + "," + "Refrigerante 600ml";
                                        quantidade++;
                                        Menu();
                                        break;

                                    case 6:
                                        _valorTotal = _valorTotal + 5.00;
                                        _pedido = _pedido + "," + "Balas fini";
                                        quantidade++;
                                        Menu();
                                        break;

                                    case 7:
                                        _valorTotal = _valorTotal + 30.00;
                                        _pedido = _pedido + "," + "Combo Família";
                                        quantidade++;
                                        Menu();
                                        break;

                                    case 8:
                                        _valorTotal = _valorTotal + 23.00;
                                        _pedido = _pedido + "," + "Combo Popular";
                                        quantidade++;
                                        Menu();
                                        break;

                                    case 9:
                                        _valorTotal = _valorTotal + 15.00;
                                        _pedido = _pedido + "," + "Combo Junior";
                                        quantidade++;
                                        Menu();
                                        break;
                                    case 15:
                                        Pedido();
                                        break;
                                    

                                
                                }
                            }

                        }
                    }

                    catch (Exception)
                    {
                        Console.Clear();
                        Menu();
                    }
                }
            }
        
                public void Pedido()
                {
                    double media = _valorTotal / quantidade;
                    Console.WriteLine("Seu pedido foi : " + _pedido);
                    Console.WriteLine("\n");
                    Console.WriteLine("Valor total a ser pago: R$" + _valorTotal);
                    Console.WriteLine("Media dos pedidos: " + media);
                    _validarDinheiro = true;

                    while (_validarDinheiro == true)
                    {
                        try
                        {
                            Console.Write("Informe o valor depositado:");
                            _dinheiro = Convert.ToDouble(Console.ReadLine());
                            Console.Clear();
                            _validarDinheiro = false;
                        }
                        catch
                        {
                            Console.Clear();
                            Console.WriteLine("Erro! Informe valor novamente");
                        }
                    }

                    if (_dinheiro >= _valorTotal)
                    {
                        Console.WriteLine("Troco: R$" + (_dinheiro - _valorTotal));
                    }
                    else if (_dinheiro < _valorTotal)
                    {                    
                            try
                            {
                                Console.WriteLine("Valor total a ser pago: R$" + _valorTotal);
                                Console.Write("Informe o valor novamente, valor insuficiente: ");
                                _dinheiro = Convert.ToDouble(Console.ReadLine());
                                Console.Clear();
                                _validarDinheiro = false;
                            }
                            catch
                            {
                                Console.Clear();
                                Console.WriteLine("Erro! Informe  valor novamente");
                            }

                    if (_dinheiro > _valorTotal)
                    {
                        Console.Clear();
                        Console.WriteLine("Troco: R$" + (_dinheiro - _valorTotal));                    
                        Console.WriteLine("Pressione uma tecla para continuar");
                        Console.ReadKey();
                        Console.Clear();
                        _pedido = "";
                        _valorTotal = 0;
                        Menu();
                    }
                }   
                Console.WriteLine("Pressione uma tecla para continuar");
                Console.ReadKey();
                _pedido = "";
                _valorTotal = 0;
                Console.Clear();
                Menu();                            
                }
        }
    }
           

       
           












