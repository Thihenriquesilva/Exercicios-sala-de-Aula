using System;

namespace Desafio18
{
    class Program
    {
        static void Main(string[] args)
        {   //Criar uma aplicação que leia um número que será o limite superior de um intervalo e imprimir todos os números ímpares menores do que esse número.s
            int i =0;
            int impar;
            bool sair=false;
            string opcao; 

            do{

            System.Console.WriteLine("Digite um numero");
            i = int.Parse(Console.ReadLine());
            System.Console.WriteLine();
            

            for(int a = 0; a<= i; a++){
                impar = a%2;
                if(impar !=0){

                System.Console.Write(a + " ");
                }
            }

            System.Console.WriteLine();
            System.Console.WriteLine("Deseja fazer novamente S/N");
            opcao = Console.ReadLine();
            
            if(opcao == "n"){
                sair = true;
            }
            }while(!sair);
        }
    }
}
