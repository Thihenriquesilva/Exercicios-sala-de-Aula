using System;

namespace Piramide
{
    class Program
    {
        static void Main(string[] args)
        {
            int tm;
            string teste = "#";
            
            Console.WriteLine("Piramide");
            System.Console.WriteLine();
            System.Console.WriteLine("Digite a altura do triângulo");
            tm = int.Parse(Console.ReadLine());


            for(int h = 0; h <= tm; h ++ ){
                for(int g = h; g < tm; g ++){
                    System.Console.Write(teste);
                }
                System.Console.WriteLine();
            }
            
            
        }
    }
}
