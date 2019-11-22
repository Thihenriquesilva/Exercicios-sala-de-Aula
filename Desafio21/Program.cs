using System;

namespace Desafio21
{
    class Program
    {
        static void Main(string[] args)
        {
        //Criar um programa que simule o uso de um caixa eletronico, onde o usuário pode entrar um valor, e o programa calcula o número de notas a serem entregues pelo dispositivo. O dispositivo deve minimizar o número de notas entregues para o usuário.
            int x;
            

            //50,20,10,5,2
            System.Console.WriteLine( "==========================" );
            System.Console.WriteLine( "Digite o valor do saque" );
            x =int.Parse(Console.ReadLine());
            System.Console.WriteLine( "==========================" );

            Console.WriteLine("{0} cédulas de R$ 100,00", x / 100);
            x = x % 100;
            Console.WriteLine("{0} cédulas de R$ 50,00", x / 50);
            x = x % 50;
            Console.WriteLine("{0} cédulas de R$ 20,00", x / 20);
            x = x % 20;
            Console.WriteLine("{0} cédulas de R$ 10,00", x / 10);
            x = x % 10;
            Console.WriteLine("{0} cédulas de R$ 5,00", x / 5);
            x = x % 5;
            Console.WriteLine("{0} cédulas de R$ 2,00", x / 2);
            Console.WriteLine("{0} moedas de R$ 1,00", x % 2);

            Console.ReadKey();

            

            
        }
    }
}
