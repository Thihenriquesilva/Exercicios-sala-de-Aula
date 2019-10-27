using System;

namespace Desafio10
{
    class Program
    {
        static void Main(string[] args)
        {       //Crie um programa que peça para o usuário entrar com um número e imprimir uma das mensagens: é multiplo de 3 ou não é multiplo de 3
            int mt;
            bool sair = false;
            do {

            System.Console.WriteLine("Digite um numero ");
            mt = int.Parse(Console.ReadLine());

            double  resultado= (mt%3);

            if (resultado == 0 ){
                System.Console.WriteLine("É multiplo de 3");
            }else {
                System.Console.WriteLine("Não é  multiplo de 3");
            }

            System.Console.WriteLine();
            System.Console.WriteLine("Tentar novamente S/N");
            string opcao = Console.ReadLine();
            
            if(opcao == "n"){
                    sair = true;
            }

            
            }while(!sair);
        }
    }
}
