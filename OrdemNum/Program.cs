using System;

namespace OrdemNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] num = new int [3];
            int aux =0;

            Console.WriteLine("Ordem numerica");
            System.Console.WriteLine();
            for (int a = 0; a < num.Length; a ++){
            System.Console.WriteLine("Digite um numero: ");
            num[a] = int.Parse(Console.ReadLine());
            }

            for (int a = 0; a <= num.Length; a++){
                for(int b = 0; b <= num.Length; b++){
                    aux = num[a];
                    num[a] = num[b];
                    num[b] = aux;
                }
                Console.Clear();
                
            }

            for (int k = 0; k < num.Length; k++)
            {
                Console.WriteLine(num[k]);                
            }



        }
    }
}
