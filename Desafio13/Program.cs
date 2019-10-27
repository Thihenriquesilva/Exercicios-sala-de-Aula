using System;

namespace Desafio13
{
    class Program
    {
        static void Main(string[] args)
        {   //Criar uma aplicação que peça para o usuário três números e verificar se eles podem ou não ser lados de um triângulo. Imprimir a classificação segundo os lados ou uma mesagem dizendo que os lados não fazem parte de um triângulo. Para ser um triângulo válido, o comprimento de um lado do triângulo é sempre menor do que a soma dos outros dois.
            
            int a,b,c = 0;
            bool sair = false;
            string opcao;
            do{

            Console.WriteLine("Formação de um triângulo");
            System.Console.WriteLine();
            System.Console.WriteLine();

            System.Console.WriteLine("Digite o primeiro numero: ");
            a = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o segundo numero: ");
            b =int.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o terceiro numero: ");
            c = int.Parse(Console.ReadLine());




            if((a<b+c)){
                System.Console.WriteLine("Este triângulo pode ser feito");

            }else{
                System.Console.WriteLine("Este triângulo não pode ser feito");
            }   
            System.Console.WriteLine();
            System.Console.WriteLine("Fazer novamente S/N: ");
            opcao = Console.ReadLine();
            System.Console.WriteLine();
            

            if(opcao == "n"){
                sair = true;
            }
            }while(!sair);
        }
    }
}
