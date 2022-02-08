using System;

namespace ListaExercicios1.ConsoleApp
{
    internal class Program
    {
        /* A imobiliária Imóbilis vende apenas terrenos retangulares.Faça um
algoritmo para ler as dimensões de um terreno e depois exibir a área do terreno.
         */

      
       
        static void Main(string[] args)
        {

            
            Console.WriteLine("Valor da base:");

            float largura = float.Parse(Console.ReadLine ());

            Console.WriteLine("Valor da altura:");

            float altura = float.Parse(Console.ReadLine());

            float area = largura * altura;

            Console.WriteLine("Area e " + area);


        }
    }
}
