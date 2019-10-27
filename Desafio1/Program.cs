using System;

namespace Desafio1
{
    class Program
    {
        static void Main(string[] args)
        {
                 //Criar uma aplicação que permita ao usuário entrar com a base e a altura de um retângulo e imprimir a seguinte saída:
             
                string opcao;
                bool querSair = false;
            do{

                Console.WriteLine("Calculo area do Retângulo");
                System.Console.WriteLine();
                System.Console.WriteLine();
                System.Console.WriteLine("Digite o valor da  altura do retângulo");
                double altura = double.Parse(Console.ReadLine());
                System.Console.WriteLine("Digite o valor da  base do retângulo");
                double Base = double.Parse(Console.ReadLine());
                Console.Clear();
                
                double perimetro = 2*(Base+altura);
                double area = Base* altura;
                double di1 = (Base*Base)+ (altura * altura);
                double diagonal = Math.Sqrt(di1);

                System.Console.WriteLine("O valor do perimetro é " + perimetro);
                System.Console.WriteLine("O valor da area é " +  area);
                System.Console.WriteLine("O valor da diagonal é " + diagonal);
                System.Console.WriteLine();
                System.Console.WriteLine("Deseja fazer novamente S/N");
                opcao = Console.ReadLine();
                
                if (opcao == "n"){
                    querSair = true;

                }

            
            }while(!querSair);
        }
    }
}
