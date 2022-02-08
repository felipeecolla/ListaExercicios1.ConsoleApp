using System;

namespace Exercicio3.ConsoleApp
{
    internal class Program
    { /* Escreva um algoritmo para ler o nome e a idade de uma pessoa, e exibir
quantos dias de vidaela possui.Considere sempre anos completos, e que um
ano possui 365 dias.Ex: uma pessoa com 19 anos possui 6935 dias de vida; veja
um exemplo de saída: MARIA, VOCÊ JÁ VIVEU 6935 DIAS.
       */
       
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome:");

            string nome = Console.ReadLine();

            Console.WriteLine("Digite sua idade:");

            int idade = Convert.ToInt32(Console.ReadLine());

            int dias = 365 * idade;

            Console.WriteLine( nome + " você já viveu " + dias + " dias");
        }
    }
}
