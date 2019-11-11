using System;

namespace Desafio21
{
    class Program
    {
        static void Main(string[] args)
        {
        //Criar um programa que simule o uso de um caixa eletronico, onde o usuário pode entrar um valor, e o programa calcula o número de notas a serem entregues pelo dispositivo. O dispositivo deve minimizar o número de notas entregues para o usuário.
            int valor;
            int ced = 50;
            int totalced =0;

            //50,20,10,5,2
            System.Console.WriteLine( "==========================" );
            System.Console.WriteLine( "Digite o valor do saque" );
            valor =int.Parse(Console.ReadLine());
            System.Console.WriteLine( "==========================" );

            
            while(true){

                if(valor >= ced){   
                    valor -=ced;
                    totalced +=1;
                    }
                else if (valor <= ced){
                        ced =20;
                }
                else if(valor == 0){
                    break;
                }
                
            }
            
        }
    }
}
