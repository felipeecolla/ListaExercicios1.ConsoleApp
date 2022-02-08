using System;

namespace Exercicio2.ConsoleApp
{
    internal class Program
    { /*  A padaria Hotpão vende uma certa quantidade de pães franceses e uma
quantidade de broas acada dia.Cada pãozinho custa R$ 0,12 e a broa custa R$
1,50. Ao final do dia, o dono quer saber quanto arrecadou com a venda dos pães
e broas(juntos), e quanto deve guardar numa conta depoupança(10% do total
arrecadado). Você foi contratado para fazer os cálculos para o dono.Combase
nestes fatos, faça um algoritmo para ler as quantidades de pães e de broas, e
depois calcularos dados solicitados.
       */
      
        static void Main(string[] args)
        {
            Console.WriteLine("Quantidade de pães:");

            int paes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Quantidade de broas:");

            int broas = Convert.ToInt32(Console.ReadLine());

            float total = paes * 0.12f + broas * 1.50f;

            float poupanca = total * 0.1f;

            Console.WriteLine("Valor arrecadado:" + Math.Round(total,2));

            Console.WriteLine("Valor a ser guardado:" + Math.Round(poupanca,2));









        }
    }
}
