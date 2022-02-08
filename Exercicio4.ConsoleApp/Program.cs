using System;

namespace Exercicio4.ConsoleApp
{
    internal class Program
    { /* Alguns países medem temperaturas em graus Celsius, e outros em graus
Fahrenheit.Faça umalgoritmo para ler uma temperatura Celsius e imprimi-Ia em
Fahrenheit(pesquise como fazer estetipo de conversão).
       */
       

        static void Main(string[] args)
        {
            Console.WriteLine("Temperatura em Celsius:");

            int temperatura = Convert.ToInt32(Console.ReadLine());

            int f = (temperatura * 9 / 5) + 32;

            Console.WriteLine("Temperatura em f:" + f);
        }
    }
}
