﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            double valor = 0;
            double saldo = 0;
            double totalsaldo = 0;
            ope saque = new ope();
            saque.saq;

            ope dep2 = new ope();
            dep2.dep;

            
            string op = "S"

            while (op == "S")
            {

                saldo = totalsaldo;
                Console.WriteLine("Escolha entre as opções:");
                Console.WriteLine("1-) Efetuar depósito");
                Console.WriteLine("2-) Efetuar saque");
                Console.WriteLine("3-) Efetuar pagamento");
                Console.WriteLine("4-) Consultar saldo");
                Console.Write("Escolha:");
                int es = int.Parse(Console.ReadLine());

                switch (es)
                {
                    case 1:
                        Console.Write("Quanto deseja depositar? R$");
                        valor = double.Parse(Console.ReadLine());
                        saldo = ope.dep(valor,saldo);
                        break;
                    case 2:
                        Console.Write("Quanto deseja sacar? R$");
                        valor = double.Parse(Console.ReadLine());
                        if (valor > totalsaldo)
                        {
                            Console.WriteLine("saldo insuficiente");
                        }
                        else if (valor < totalsaldo)
                        {

                            saldo = ope.saq(valor, totalsaldo);
                        }
                    case 3:
                        Console.Write("Quanto deseja pagar? R$");
                        valor = double.Parse(Console.ReadLine());
                        if (valor > totalsaldo)
                        {
                            Console.WriteLine("saldo insuficiente");
                        }
                        else if (valor < totalsaldo)
                        {

                            saldo = ope.saq(valor, totalsaldo);
                        }
                    case 4:
                        saldo = totalsaldo;

                }
                Console.WriteLine("O saldo é: R$" + saldo.ToString("C");

                Console.WriteLine("deseja fazer mais alguma coisa(S/N)?");
                string op = Console.ReadLine();



                totalsaldo = saldo;
            }

        }
    }
}
