//Código Principal
using System;
using System.Globalization;
using System.Collections.Generic;

namespace Primeiro_Projeto
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Expressão Condicional If/Else
            /*
            double desconto;
            if (preco < 20.0)
            {
                desconto = preco * 0.1;
            }
            else
            {
                desconto = preco * 0.05;
            }
            */

            // Expressão Condicional ternária, seria no caso If/Else simplificado
            double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;

            Console.WriteLine(desconto);
            Console.WriteLine("Hello World!");
        }
    }
}