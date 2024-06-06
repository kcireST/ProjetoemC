using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testesaula
{
    internal class Program
    {
        static void Main(string[] args)
        {/*

            {
                {
                    Console.Write("Digite um número para ver a sua tabuada em ordem decrescente: ");
                    int numero = int.Parse(Console.ReadLine());

                    for (int i = 10; i >= 1; i--)
                    {
                        Console.WriteLine($"{numero} x {i} = {numero * i}");
                    }
                }
            }
            --------------------------------------------------------------------------------------------------------------------------
        
            int[] numeros = new int[20];

            for (int i = 0; i < 20; i++)
            {
                Console.Write($"Digite o {i + 1}º número: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            int maior = numeros.Max();
            int menor = numeros.Min();

            Console.WriteLine($"O maior número digitado é: {maior}");
            Console.WriteLine($"O menor número digitado é: {menor}");
            
            ------------------------------------------------------------------------------------------------------------

            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"({i}, ");
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine(")");
            }
        
            --------------------------------------------------------------------------------------------------------------------------
            */
            Console.Write("Quantidade de números a digitar: ");
            int quantidade = int.Parse(Console.ReadLine());

            int paresNegativos = 0;
            int zeros = 0;

            for (int i = 0; i < quantidade; i++)
            {
                Console.Write($"Digite o {i + 1}º número: ");
                int num = int.Parse(Console.ReadLine());

                if (num == 0)
                {
                    zeros++;
                }
                else if (num < 0 && num % 2 == 0)
                {
                    paresNegativos++;
                }
            }

            Console.WriteLine($"Quantidade de números pares negativos: {paresNegativos}");
            Console.WriteLine($"Quantidade de vezes que o número zero foi digitado: {zeros}");
        }
    }
}
