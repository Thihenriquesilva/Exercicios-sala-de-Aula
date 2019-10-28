using System;

namespace Desafio19
{
    class Program
    {
        static void Main(string[] args)
        {   //Criar um programa que dado um vetor de inteiros com N posições, determinadas pelo usuário, permita que usuário digite esses N números através de um prompt na console, listando os valores digitados.

            int n,i =0;
            bool sair = false;
            string opcao;

            do{

            System.Console.WriteLine("Quantos numeros voce deseja adicionar");
            n = int.Parse(Console.ReadLine());
            int [] vetor = new int[n];

            for(i = 0; i <n;i++){
                System.Console.WriteLine($"Digite o {i+1}º numero: ");
                vetor[i]= int.Parse(Console.ReadLine());
                
            }

            System.Console.WriteLine();
            foreach(int l in vetor){
                System.Console.Write(l + " ");
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
