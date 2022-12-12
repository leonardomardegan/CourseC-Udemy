using System;
using System.Globalization;

namespace Exercicios3
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercicio7();
        }
        static void Exercicio1()
        {
            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void Exercicio2()
        {
            int n = int.Parse(Console.ReadLine());

            int cont_in = 0;
            int cont_out = 0;

            for (int i = 1; i <= n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x >= 10 && x <= 20)
                {
                    cont_in = cont_in + 1;
                }
                else
                {
                    cont_out = cont_out + 1;
                }
            }
            Console.WriteLine(cont_in + " in");
            Console.WriteLine(cont_out + " out");
        }
        static void Exercicio3()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] valor = Console.ReadLine().Split(' ');
                double a = double.Parse(valor[0], CultureInfo.InvariantCulture);
                double b = double.Parse(valor[1], CultureInfo.InvariantCulture);
                double c = double.Parse(valor[2], CultureInfo.InvariantCulture);

                double media = (a * 2.0 + b * 3.0 + c * 5.0) / 10;

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
        static void Exercicio4()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; ++i)
            {
                string[] valor = Console.ReadLine().Split(' ');
                double x = double.Parse(valor[0], CultureInfo.InvariantCulture);
                double y = double.Parse(valor[1], CultureInfo.InvariantCulture);

                double divisao = x / y;

                if (y == 0)
                {
                    Console.WriteLine("divisão impossível");
                }
                else
                {
                    Console.WriteLine(divisao.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
        static void Exercicio5()
        {
            int n = int.Parse(Console.ReadLine());

            int fatorial = 1;
            for (int i = 1; i <= n; ++i)
            {
                fatorial = fatorial * i;
            }

            Console.WriteLine(fatorial);
        }
        static void Exercicio6()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; ++i)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void Exercicio7()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; ++i)
            {
                int primeiro = i;
                int segundo = i * i;
                int terceiro = i * i * i;
                Console.WriteLine($"{primeiro} {segundo} {terceiro}");
            }
        }
    }
}