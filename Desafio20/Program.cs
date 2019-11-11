using System;
using System.Collections.Generic;

namespace Desafio20
{
    class Program
    {
        static void Main(string[] args)
        {   //Criar um programa que inicialize uma vetor de 10 inteiros com números aleatórios gerados com o método random e imprima duas listas, uma com os números pares outra com numeros impares.
            
            int result;
            int [] vetor = new int [10];
            List <int> par = new List<int>();
            List <int> impar = new List<int>();

            Random numeros = new Random();
            

            for(int i = 0; i< 10; i++){
                vetor[i] = numeros.Next(0,1000);
                result = vetor[i] %2;
                if(result == 0){

                    par.Add(vetor[i]);
                }else{
                    impar.Add(vetor[i]);
                }
            }
            System.Console.WriteLine();
            System.Console.WriteLine();

            foreach(var l in vetor){
                System.Console.Write(l + "  ");
            }
            System.Console.WriteLine();
            System.Console.WriteLine();

            foreach(var p in par){
                System.Console.Write(p + "  ");
            }
            System.Console.WriteLine();
            System.Console.WriteLine();

            foreach(var im in impar){
                System.Console.Write(im + "  ");
            }
        }
    }
}
