﻿using System;

namespace Desafio3
{
    class Program
    {       //Criar um programa que efetue o cálculo da quantidade de litros de combustível gastos em uma viagem, sabendo-se que o carro faz 12 km com um litro. Deverão ser fornecidos o tempo em horas gasto na viagem e a velocidade média em kilometros por hora.
        static void Main(string[] args)
        {
            Console.WriteLine("Velocidade média");
            System.Console.WriteLine("Qual o tempo em horas  de viagem");
            double tempo = double.Parse(Console.ReadLine());
            System.Console.WriteLine();
            System.Console.WriteLine("Digite a distância em Km.");
            double distancia = double.Parse(Console.ReadLine());
            
            double VeloMedia = distancia * tempo;
            double tempogasto = tempo * 60;
            double distancia1 = distancia * 1000;
            double litrosGastos = distancia / 12;

            

            System.Console.WriteLine("O tempo da  viagem foi " + tempogasto);
            System.Console.WriteLine("A velocidade média foi " + VeloMedia);
            System.Console.WriteLine("Qual a distância percorrida " + distancia1);
            System.Console.WriteLine("Quantos litros foi gasto " + litrosGastos);
        }
    }
}
