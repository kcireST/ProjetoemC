using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPgilmar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             EX 1
            string nome;
            Console.WriteLine("Digite seu nome");
            nome = Console.ReadLine();
            Console.WriteLine("Seu nome é: " +  nome);
            Console.ReadKey();*/




            /*
            EX 2 
            double op, n1, n2, sum, sub, mult, div;
            Console.WriteLine("Entre com o primeiro número");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Entre com o segundo número");
            n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escolha sua operacao: ");
            Console.WriteLine("(1) + Somar");
            Console.WriteLine("(2) - Subtração");
            Console.WriteLine("(3) * Multiplicação");
            Console.WriteLine("(4) / Divisão");
            op = Convert.ToDouble(Console.ReadLine());

            switch (op)
            {
                case 1:
                    sum = n1 + n2;
                    Console.WriteLine("o resultado da soma é: " + sum);
                    break;
                case 2:
                    sub = n1 - n2;
                    Console.WriteLine("o resultado da subtracao é: " + sub);
                    break;
                case 3:
                    mult = n1 * n2;
                    Console.WriteLine("o resultado da soma é: " + mult);
                    break;
                case 4:
                    div = n1 / n2;
                    Console.WriteLine("o resultado da soma é: " + div);
                    break;*/




            /*
             EX 3
            double anoAtual, anoNascimento, idadeAtual;
            
            Console.WriteLine("Entre com o seu ano de nascimento: ");
            anoNascimento = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Entre com o ano atual: ");
            anoAtual = Convert.ToDouble(Console.ReadLine());
            idadeAtual = anoAtual - anoNascimento;
            Console.WriteLine("Sua idade atual e: " + idadeAtual);
            */




            /*
            EX 4
            double n1, n2, n3, sum, med;

            Console.WriteLine("Entre com o primeiro número: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Entre com o segundo número: ");
            n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Entre com o terceiro número: ");
            n3 = Convert.ToDouble(Console.ReadLine());

            sum = n1 + n2 + n3;
            med = sum / 3;

            Console.WriteLine("a media aritmética dos numeros é: " + med);
            */





            /*
            EX 5
            double valor;
            Console.Write("Entre com o valor: ");
            valor = Convert.ToDouble(Console.ReadLine());
            valor = valor - 1;
            Console.Write("Resultado: " + valor);
            Console.ReadKey();
            */





            /*
            EX 6
            double b, a, result;
            Console.Write("Entre com a base do retangulo: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Entre com a altura do retangulo: ");
            a = Convert.ToDouble(Console.ReadLine());

            result = b * a;

            Console.Write("a área do retangulo e: " + result);
            Console.ReadKey();
            */




            /*
             EX 7
            int anos, meses, dias, multAno, multMes, result;
            Console.Write("Quantos anos vc tem?: ");
            anos = Convert.ToInt32(Console.ReadLine());
            Console.Write("Quantos meses vc tem?: ");
            meses = Convert.ToInt32(Console.ReadLine());
            Console.Write("Quantos dias vc tem?: ");
            dias = Convert.ToInt32(Console.ReadLine());


            multAno = anos * 365;
            multMes = meses * 30;
            result = (multAno + multMes + dias);


            Console.Write("A sua idade expressa em dias e: " + result);
            Console.ReadKey();
            */




            /*
             EX 8
            double v1, v2, v3, delta;

            Console.Write("Entre com o primeiro valor: ");
            v1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Entre com o segundo valor: ");
            v2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Entre com o terceiro valor: ");
            v3 = Convert.ToDouble(Console.ReadLine());

            delta = (v2 * v2) - 4 * v1 * v3;

            Console.Write("O delta é: " + delta);
            Console.ReadKey();
            */




            /*
             EX 9
            int n1, n2, n3, p1, p2, p3, mediaP, resultSumMult, sumP;

            Console.Write("Entre com a primeiro nota do aluno: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Entre com a segundo nota do aluno: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Entre com a terceira nota do aluno: ");
            n3 = Convert.ToInt32(Console.ReadLine());

            p1 = 2;
            p2 = 3;
            p3 = 5;

            n1 = n1 * p1;
            n2 = n2 * p2;
            n3 = n3 * p3;

            resultSumMult = n1 + n2 + n3;
            sumP = p1 + p2 + p3;
            mediaP = resultSumMult / sumP;

            Console.Write("A média ponderada das notas do aluno e: " + mediaP);
            Console.ReadKey();
            */


        }
    }
}