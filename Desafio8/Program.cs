using System;

namespace Desafio8
{
    class Program
    {
        static void Main(string[] args)
        {       //Criar uma aplicação console que peça ao usuário a altura de um triangulo, desenhe na tela o triangulo invertido
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
