using System;

namespace Desafio2

{
    class Program
    {

        //Criar um programa que leia uma temperatura em graus centígrados e apresentá-la convertida em graus Fahrenheit.
        static void Main(string[] args)
        {
            Console.WriteLine("Conversão de Celsius (°C)");
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine("Digite a temperatura para conversã:");
            double c = double.Parse(Console.ReadLine());

            double f;

            f = (c * 9)/5 + 32;
            Console.Clear();
            System.Console.WriteLine();
            System.Console.WriteLine("Conversão para Fahrenheit é " + f);
            System.Console.WriteLine();

        }
    }
}
