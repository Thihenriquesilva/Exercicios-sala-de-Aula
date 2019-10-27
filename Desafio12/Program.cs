using System;

namespace Desafio12
{
    class Program
    {
        static void Main(string[] args)
        {       //Criar uma aplicação que entre com três números e imprimi-los em ordem crescente (suponha números diferentes).
            int [] num = new int [3];
            int i;


            for(i = 0; i<3; i++){
                System.Console.WriteLine("Digite o {0}º numero: ", i+1);
                num[i] = int.Parse(Console.ReadLine());

            }
            System.Console.WriteLine();
            Array.Sort(num);

            for(i = 0; i<3; i++){
                Console.WriteLine(num[i]);
            }


        }
    }
}
