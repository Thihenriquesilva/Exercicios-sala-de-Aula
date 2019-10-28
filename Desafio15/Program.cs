using System;
using System.Collections.Generic;

namespace Desafio15
{
    class Program
    {
        private const int Key = 1;

        static void Main(string[] args)
        {   
            //Crie um programa que peça para o usuário um número inteiro entre 1 e 12 e escrever o mês correspondente. Caso o usuário digite um número fora desse intervalo, deverá aparecer uma mensagem informando que não existe mês com este número.
            Dictionary <int,string> calendario = new Dictionary <int,string>();

            int i =0;
            bool sair = false;
            string opcao;

            calendario.Add(1,"Janeiro");
            calendario.Add(2,"Fevereiro");
            calendario.Add(3,"Março");
            calendario.Add(4,"Abril");
            calendario.Add(5,"Maio");
            calendario.Add(6,"Junho");
            calendario.Add(7,"Julho");
            calendario.Add(8,"Agosto");
            calendario.Add(9,"Setembro");
            calendario.Add(10,"Outubro");
            calendario.Add(11,"Novembro");
            calendario.Add(12,"Dezembro");

            do{

            System.Console.WriteLine("Digite um numero de 1 a 12");
            i = int.Parse(Console.ReadLine());

            if((i<=12)&&(i>=1)){
                System.Console.WriteLine();
                System.Console.WriteLine(calendario[i]);
            }else{
                System.Console.WriteLine("Invalido");
            }

            System.Console.WriteLine();

            System.Console.WriteLine("Deseja tentar novamente S/N");
            opcao = Console.ReadLine();
            
            if(opcao == "n"){
                sair = true;
            }
            
            }while(!sair);
        }
    }
}
