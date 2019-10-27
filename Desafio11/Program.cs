using System;

namespace Desafio11
{
    class Program
    {
        static void Main(string[] args)
        {       //Criar uma aplicação que entre com dois nomes e imprimi-los em ordem alfabética

            string [] nome  = new string [10];

            Console.WriteLine("Lista de nomes");
            System.Console.WriteLine();
            for (int i = 0; i < nome.Length; i ++){
            System.Console.WriteLine($"Digite {i+1}º nome: ");
            nome[i] = Console.ReadLine();
            }

            
            StringComparer ordenar = StringComparer.OrdinalIgnoreCase;
            
            for (int i = 0; i < nome.Length; i++){
                Array.Sort(nome,ordenar);
                Console.Write(nome[i]);
                System.Console.WriteLine();
            }
        }
    }
}
