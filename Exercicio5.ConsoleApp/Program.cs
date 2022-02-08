using System;

namespace Exercicio5.ConsoleApp
{ /* Faça um algoritmo para ler o salário de um funcionário e aumentá-lo em 15%.
Após o aumento,desconte 8% de impostos. Imprima o salário inicial, o salário
com o aumento e o salário final. 
   */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Salário inicial:");

            float salario = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Salário com aumento:");

            float salario2 = salario * 0.15f + salario;

           Console.WriteLine(salario2);

            float salario3 = salario2 * 0.8f - salario2;

            Console.WriteLine(salario3);    

        }
    }
}
