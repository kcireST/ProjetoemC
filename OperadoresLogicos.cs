using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*double nota1, nota2, nota3, nota4, media;
            Console.WriteLine("Digite a primeira nota");
            nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota");
            nota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a sua terceira nota");
            nota3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a sua quarta nota");
            nota4 = Convert.ToDouble(Console.ReadLine());

            media = (nota1 + nota2 + nota3 + nota4) /4 ;
            if(media >= 5)
            {
                Console.WriteLine("APROVADO!!!");
            }else if(media <= 5 )
            {
                Console.WriteLine("RECUPERAÇÃO");
            }else if(media < 3)
            {
                Console.WriteLine("REPROVADO");
            }
            Console.ReadKey();

            ------------------------------------------------------------------------------------------------------

            int qtd;
            string nome_prod;
            double preco, total, total_desc;
            Console.WriteLine("Qual o nome do produto? ");
            nome_prod = (Console.ReadLine());
            Console.WriteLine("Qual quantidade do produto? ");
            qtd = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qual o preço do produto? ");
            preco = Convert.ToDouble(Console.ReadLine());
            total = qtd * preco;
            Console.WriteLine("O preço total do seu produto é: " + total);
            if (qtd <= 5)
            {
                total_desc = total - ((2 * total) / 100);
                Console.WriteLine("Seu produto tem 2% de desconto: " + total_desc);
            }
            else if ((qtd > 5) && (qtd <= 10))
            {
                total_desc = total - ((3 * total) / 100);
                Console.WriteLine("Seu pedido tem 3% de desconto: " + total_desc);
            }

            else
            {
                total_desc = total - ((5 * total) / 100);
                Console.WriteLine("Seu pedido tem 5% de desconto: " + total_desc);
            }

            Console.ReadKey();
            
            ---------------------------------------------------------------------------------------------------------
                */
            Console.Title = "Notas"; //titulo
            Console.SetWindowSize(50, 10); //tamanho da tela

            //notas abaixo
            double tr1, tr2, p1, p2, md, sub;
            Console.WriteLine("Digite a nota do TR1: ");
            tr1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a nota do TR2: ");
            tr2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a nota da P1: ");
            p1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a nota da P2: ");
            p2 = Convert.ToDouble(Console.ReadLine());
            md = (((tr1 + tr2) / 2) + p1 + p2) / 3;
            if (md >= 6)
            {
                Console.WriteLine("Media: " + md);
                Console.WriteLine("Aprovado!");
                if (md >= 9)
                {
                    Console.WriteLine("Seu Conceito é A");
                }
                else if ((md >= 7.5) && (md < 9))
                {
                    Console.WriteLine("Seu Conceito é B");
                }
                else if ((md >= 6) && (md < 7.5))
                {
                    Console.WriteLine("Seu Conceito é C");
                }
            }

            else
            {
                Console.WriteLine("Faça a substitutiva");
                Console.WriteLine("Qual foi a nota da sua prova substitutiva: ");
                sub = Convert.ToDouble(Console.ReadLine());

                if (p2 > p1)
                {
                    if (sub > p1)
                    {
                        md = (((tr1 + tr2) / 2) + sub + p2) / 3;
                        Console.WriteLine("Media: " + md);
                        if (md >= 9)
                        {
                            Console.WriteLine("Seu Conceito é A");
                        }
                        else if ((md >= 7.5) && (md < 9))
                        {
                            Console.WriteLine("Seu Conceito é B");
                        }
                        else if ((md >= 6) && (md < 7.5))
                        {
                            Console.WriteLine("Seu Conceito é C");
                        }
                        else if (md < 6)
                        {
                            Console.WriteLine("Seu Conceito é D");
                        }
                    }
                }

                else
                {
                    if (sub > p2)
                    {
                        md = (((tr1 + tr2) / 2) + p1 + sub) / 3;
                        Console.WriteLine("Media: " + md);
                        if (md >= 9)
                        {
                            Console.WriteLine("Seu Conceito é A");
                        }
                        else if ((md >= 7.5) && (md < 9))
                        {
                            Console.WriteLine("Seu Conceito é B");
                        }
                        else if ((md >= 6) && (md < 7.5))
                        {
                            Console.WriteLine("Seu Conceito é C");
                        }
                        else if (md < 6)
                        {
                            Console.WriteLine("Seu Conceito é D");
                        }
                    }

                }

            }
            Console.ReadKey();
        }//fim
    }
}
