using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número para ver a sua tabuada em ordem decrescente: ");
        int numero = int.Parse(Console.ReadLine());

        for (int i = 10; i >= 1; i--)
        {
            Console.WriteLine($"{numero} x {i} = {numero * i}");
        }
    }
}