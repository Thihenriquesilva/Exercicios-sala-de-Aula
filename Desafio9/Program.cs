using System;

namespace Desafio9
{
    class Program
    {
        static void Main(string[] args)
        {       //Escrever uma aplicação que leia um peso na Terra e o número de um planeta e imprima o valor do seu peso neste planeta. A relação de planetas é dada a seguir juntamente com o valor das gravidades relativas à Terra
            string decisao;
            bool sair = false;
            double Pplaneta;
            do{

            Console.WriteLine("Gravidade relativa");
            System.Console.WriteLine();
            System.Console.WriteLine("Digite seu peso");
            double pesoP = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("1 - Mercúrio");
            Console.WriteLine("2 - Vênus");
            Console.WriteLine("3 - Marte");
            Console.WriteLine("4 - Júpiter");
            Console.WriteLine("5 - Saturno");
            Console.WriteLine("6 - Urano");
            Console.WriteLine();
            int opcao = int.Parse(Console.ReadLine());
            Console.Clear();
            



            switch(opcao){

                case 1:
                Pplaneta = (pesoP/10) * 0.37;
                System.Console.WriteLine(Pplaneta);
                break;
                case 2:
                Pplaneta = (pesoP/10) * 0.88;
                System.Console.WriteLine(Pplaneta);
                break;
                case 3:
                Pplaneta = (pesoP/10) * 0.38;
                System.Console.WriteLine(Pplaneta);
                break;
                case 4:
                Pplaneta = (pesoP/10) * 2.64;
                System.Console.WriteLine(Pplaneta);
                break;
                case 5:
                Pplaneta = (pesoP/10) * 1.15;
                System.Console.WriteLine(Pplaneta);
                break;
                case 6:
                Pplaneta = (pesoP/10) * 1.17;
                System.Console.WriteLine(Pplaneta);
                break;
            }
                

                System.Console.WriteLine();
                System.Console.WriteLine("Calcular novamente S/N");
                decisao = Console.ReadLine();

                if(decisao == "n"){
                    sair = true;
                }
            }while(!sair);
                

        }
    }
}
