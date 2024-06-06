using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarefa2405
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Console.Write("Digite o número inicial da sequência: ");
            int inicio = int.Parse(Console.ReadLine());
            Console.Write("Digite o número final da sequência: ");
            int fim = int.Parse(Console.ReadLine());
            if (fim <= inicio)
            {
                Console.WriteLine("O número final deve ser maior que o número inicial.");
            }
            else
            {
                for (int i = inicio; i <= fim; i++)
                {
                    Console.Write($"{i} ");
                }
                Console.ReadKey();
                

            }

            -----------------------------------------------------------------------------------------

            int count = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Digite a idade da pessoa {i + 1}: ");
                int idade = int.Parse(Console.ReadLine());
                if (idade > 18)
                {
                    count++;
                }
            }
            Console.WriteLine($"Número de pessoas com mais de 18 anos: {count}");
            

            -------------------------------------------------------------------------------------------

            int count = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Digite um número: ");
                int numero = int.Parse(Console.ReadLine());
                if (numero < 0)
                {
                    count++;
                }
            }
            Console.WriteLine($"Número de valores negativos digitados: {count}");
            ----------------------------------------------------------------------------------
            int i = 1;
            do
            {
                Console.Write($"({i}, ");
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine(")");
                i++;
            } while (i <= 10);

            ------------------------------------------------------------------
            int numero;
            do
            {
                Console.Write("Digite um número par: ");
                numero = int.Parse(Console.ReadLine());
                if (numero % 2 != 0)
                {
                    Console.WriteLine("O número digitado não é par. Tente novamente.");
                }
            } while (numero % 2 != 0);
            Console.WriteLine($"Número par digitado: {numero}");

            ------------------------------------------------------------------------------------------

            char continuar;
            do
            {
                double nota1, nota2, nota3, nota4;

                do
                {
                    Console.Write("Digite a primeira nota (de 0 a 10): ");
                    nota1 = double.Parse(Console.ReadLine());
                } while (nota1 < 0 || nota1 > 10);
                do
                {
                    Console.Write("Digite a segunda nota (de 0 a 10): ");
                    nota2 = double.Parse(Console.ReadLine());
                } while (nota2 < 0 || nota2 > 10);
                do
                {
                    Console.Write("Digite a terceira nota (de 0 a 10): ");
                    nota3 = double.Parse(Console.ReadLine());
                } while (nota3 < 0 || nota3 > 10);
                do
                {
                    Console.Write("Digite a quarta nota (de 0 a 10): ");
                    nota4 = double.Parse(Console.ReadLine());
                } while (nota4 < 0 || nota4 > 10);
                double media = (nota1 + nota2 + nota3 + nota4) / 4;
                Console.WriteLine($"A média aritmética das notas é: {media}");
                Console.Write("Deseja continuar? (S/N): ");
                continuar = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();
            } while (continuar == 'S');
            
            ------------------------------------------------------------------------------------
            int num;
            do
            {
                Console.Write("Digite um número: ");
                num = int.Parse(Console.ReadLine());
            } while (num > 1);
            Console.WriteLine("Número digitado menor ou igual a 1 encontrado.");
            */
            int num;
            int sum = 0;
            do
            {
                Console.Write("Digite um número: ");
                num = int.Parse(Console.ReadLine());
                sum += num;
            } while (num != 0);
            Console.WriteLine($"A soma dos números digitados é: {sum}");
        }
    }
}
