using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static int Menu()
        {
            Console.Clear();
            int resp;
            Console.WriteLine("Entre com o número de acordo com o exercício.\n");
            Console.WriteLine("Exercicio: 01");
            Console.WriteLine("Exercicio: 02");
            Console.WriteLine("Exercicio: 03");
            Console.WriteLine("Exercicio: 04");
            Console.WriteLine("Exercicio: 05");
            Console.WriteLine("Exercicio: 06");
            Console.WriteLine("Exercicio: 0 - Sair");
            resp = int.Parse(Console.ReadLine());
            return resp;
        }
        static void Ex1()
        {
            Random numAleatorio = new Random();

            int maior = 23, menor = 9568, cont = 0, num;
            int soma = 0, media;

            for (int i = 0; i <= 172; i++)
            {
                num = numAleatorio.Next(23, 9568);
                //Console.WriteLine(num+"\n");

                if (num > maior)
                    maior = num;
                if (num < menor)
                    menor = num;

                if (num % 2 == 0 && num < 100)
                {
                    cont++;
                    soma = soma + num;
                    
                }

                if(cont==0)
                    cont= 1;
               media = soma / cont;
            }


            media = soma / cont;

            Console.WriteLine("O maior numero e: " + maior);
            Console.WriteLine("O menor numero e: " + menor);
            Console.WriteLine("A media e: " + media);
            Console.ReadKey();
        }
        static void Ex2()
        {
            // Exercicio resolvido
            double soma = 0, lido, final;
            int quantidade = 0;

            Console.WriteLine("Entre com números para somar. Entre com 0 para parar.");

            do
            {
                lido = double.Parse(Console.ReadLine());
                soma = soma + lido;
                quantidade++;
            }
            while (lido != 0);

            quantidade--;

            final = soma / quantidade;

            Console.WriteLine("A média final é de " + final);
            Console.ReadKey();
        }
        static void Ex3()
        {
            int inicio, fim;

            Console.WriteLine("Defina o intervalo em questão. (Digitar um número, enter, outro número, enter.)");

            inicio = int.Parse(Console.ReadLine());
            fim = int.Parse(Console.ReadLine());

            for (int i = inicio; i <= fim; i++)
            {
                if (i % 7 == 3 || i % 7 == 5)
                    Console.WriteLine(i);
            }

            Console.ReadKey();

        }
        
        static void Ex4()
        {
            int num;

            Console.WriteLine("Entre com um número inteiro.");
            num = int.Parse(Console.ReadLine());

            for (int i = 0; i <= (num * num * num); i++)
            {
               
                if(i % 2 == 0 && i % 4 == 0 && i % 6!= 0)
                    Console.WriteLine(i);

            }

            Console.WriteLine("Fim");
            Console.ReadKey();
        }
        static void Ex5()
        {
            int linhas;
            char simbolo;

            Console.WriteLine("Entre com o número de linhas desejado.");
            linhas = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com um caractere.");
            simbolo = char.Parse(Console.ReadLine());

            for (int i = 1; i <= linhas; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write(simbolo);
                Console.WriteLine(" ");
            }

            Console.ReadKey();
        }
        static void Ex6()
        {
            int linhas;
            char simbolo;

            Console.WriteLine("Entre com o número de linhas desejado.");
            linhas = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com um caractere.");
            simbolo = char.Parse(Console.ReadLine());

            for (int i = 1; i <= linhas; i++)
            {

                for (i = 1; i <= linhas; i++)
                {
                    for (int j = (2 * linhas - i); j >= 1; j--)
                        Console.Write(" ");
                    for (int j = 2; j <= i; j++)
                        Console.Write(simbolo);
                    Console.Write("");
                    for (int j = 1; j <= i; j++)
                        Console.Write(simbolo);
                        Console.Write("  ");

                    for (int j = 0; j <= (linhas - i); j++)
                        Console.Write(simbolo);
                        Console.Write("");
                    for (int j = 1; j <= (linhas - i); j++)
                        Console.Write(simbolo);

                    Console.Write("  ");

                    for (int j = 2 * linhas - 1; j <= i; j++)
                        Console.Write(simbolo);
                        Console.Write("");
                    Console.WriteLine();
                    Console.Write("");

                   
                }

                Console.ReadKey();

            }    }

        static void Main(string[] args)
        {
            int resp;
            do
            {
                resp = Menu();
                switch (resp)
                {
                    case 0:
                        Console.WriteLine("Até a próxima.\n");
                        Console.ReadKey();
                        break;
                    case 1:
                        Console.Clear();
                        Ex1();
                        break;
                    case 2:
                        Console.Clear();
                        Ex2();
                        break;
                    case 3:
                        Console.Clear();
                        Ex3();
                        break;
                    case 4:
                        Console.Clear();
                        Ex4();
                        break;
                    case 5:
                        Console.Clear();
                        Ex5();
                        break;
                    case 6:
                        Console.Clear();
                        Ex6();
                        break;
                    default:
                        Console.WriteLine("Entre com valor válido\n");
                        break;
                }
            }
            while (resp != 0);
        }
    }
}