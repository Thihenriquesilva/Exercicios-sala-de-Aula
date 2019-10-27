using System;

namespace Desafio5
{
    class Program
    {   
        static void Main(string[] args)
        {       //Criar uma aplicação que leia dois valores para as variáveis A e B, efetuar a troca dos valores de forma que a variável A passe a ter o valor da variável B e a variável B passe a ter o valor da variável A. Apresentar os valores trocados.
            bool sair = false;
            do {

                Console.WriteLine("HEHEHEH");
                System.Console.WriteLine("Digite um valor qualquer para A");
                double a = double.Parse(Console.ReadLine());
                System.Console.WriteLine("Digite um outro valor qualquer para B");
                double b = double.Parse(Console.ReadLine());

                System.Console.WriteLine("O valor de A é: " + b);
                System.Console.WriteLine("O valor de B é: " + a);

                System.Console.WriteLine("Deseja fazer novamente S/N");
                string opcao = Console.ReadLine();
                
                
                if(opcao == "n"){
                    sair = true;
                }
            
            }while(!sair);
        }
    }
}
