using System;

namespace Desafio16
{
    class Program
    {
        static void Main(string[] args)
    {       // Um endocrinologista deseja controlar a saúde de seus pacientes e, para isso, se utiliza do Índice de Massa Corporal (IMC)
            //Criar um programa que apresente o nome do paciente e sua faixa de risco, baseando-se na seguinte tabela
            string nome;
            double kg,alt,result,result2 = 0;

            bool sair = false;
            string opcao;
            do {

                System.Console.WriteLine("CALCULO DO IMC");
                System.Console.WriteLine();
                System.Console.WriteLine("Qual é seu nome: ");
                nome = Console.ReadLine();
                System.Console.WriteLine(nome + " qual o seu peso: ");
                kg = double.Parse(Console.ReadLine());
                System.Console.WriteLine(nome + " qual sua altura em centimetros: ");
                alt = double.Parse(Console.ReadLine());

                result2 = alt/100;
                result = kg/(result2*result2);

                if(result < 18.5){
                    System.Console.WriteLine(nome+ ": Está abaixo do peso");
                
                }else if((result >= 18.5) && (result < 25)){
                    System.Console.WriteLine(nome+ ": Normal ");
                
                }else if((result >= 25)&&(result <= 30)){
                    System.Console.WriteLine(nome+ ": Acima do peso");
                
                }else if((result >=30)&&(result <= 35)){
                    System.Console.WriteLine(nome+ ": Obeso");
            
                }else if (result >35){
                    System.Console.WriteLine(nome+ ": Obesidade morbida");
                    
                }

                System.Console.WriteLine("Deseja fazer novamente S/N");
                opcao = Console.ReadLine();
                

                if(opcao == "n"){
                    sair = true;
                }

            }while(!sair);

        }
    }
}
