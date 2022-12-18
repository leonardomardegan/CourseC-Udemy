using System;
using System.Globalization;

namespace Exercicios2
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercicio8();
        }
        static void Exercicio1()
        {
            Console.WriteLine("Digite um número para saber se é Negativo ou Não:");

            int Number = int.Parse(Console.ReadLine());

            if (Number < 0)
            {
                Console.WriteLine("NEGATIVO");
            }
            else
            {
                Console.WriteLine("NÃO NEGATIVO");
            }
        }

        static void Exercicio2()
        {
            Console.WriteLine("Digite um número para saber se é Par ou Impar:");

            int Number = int.Parse(Console.ReadLine());

            if (Number % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }
        }
        static void Exercicio3()
        {
            string[] valores = Console.ReadLine().Split(' ');
            int A = int.Parse(valores[0]);
            int B = int.Parse(valores[1]);

            if (A % B == 0 || B % A == 0)
            {
                Console.WriteLine("São Multiplos");
            }
            else
            {
                Console.WriteLine("Não são Multiplos");
            }
        }
        static void Exercicio4()
        {
            string[] valores = Console.ReadLine().Split(' ');
            int horaInicial = int.Parse(valores[0]);
            int horaFinal = int.Parse(valores[1]);

            int duracao;
            if (horaInicial < horaFinal)
            {
                duracao = horaFinal - horaInicial;
            }
            else
            {
                duracao = 24 - horaInicial + horaFinal;
            }

            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
        }
        static void Exercicio5()
        {
            string[] valores = Console.ReadLine().Split(' ');
            int codigo = int.Parse(valores[0]);
            int quantidade = int.Parse(valores[1]);

            double total;
            if (codigo == 1)
            {
                total = quantidade * 4.00;
            } else if (codigo == 2)
            {
                total = quantidade * 4.50;
            } else if (codigo == 3)
            {
                total = quantidade * 5.00;
            } else if (codigo == 4)
            {
                total = quantidade * 2.00;
            } else
            {
                total = quantidade * 1.50;
            }

            Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
        static void Exercicio6()
        {
            double numero = double.Parse(Console.ReadLine());

            if (numero < 0.0 || numero > 100.0)
            {
                Console.WriteLine("Fora de intervalo");
            }
            else if (numero <= 25.0)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (numero <= 50.0)
            {
                Console.WriteLine("Intervalo [25,50]");
            }
            else if (numero <= 75.0)
            {
                Console.WriteLine("Intervalo [50,75]");
            }
            else
            {
                Console.WriteLine("Intervalo [75,100]");
            }
        }
        static void Exercicio7()
        {
            string[] valores = Console.ReadLine().Split(' ');
            double x = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double y = double.Parse(valores[1], CultureInfo.InvariantCulture);

            if (x == 0 && y == 0)
            {
                Console.WriteLine("Origem");
            }
            else if (x == 0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (y == 0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (x > 0.0 && y > 0.0)
            {
                Console.WriteLine("Q1");
            }
            else if (x < 0.0 && y > 0.0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0.0 && y < 0.0)
            {
                Console.WriteLine("Q3");
            }
            else
            {
                Console.WriteLine("Q4");
            }
        }
        static void Exercicio8()
        {
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double imposto;

            if (salario <= 2000.0)
            {
                Console.WriteLine("Isento");
            } else if (salario <= 3000.0)
            {
                imposto = (salario - 2000.0) * 0.08;
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            } else if (salario <= 4500.0)
            {
                imposto = (salario - 3000.0) * 0.18 + 1000.0 * 0.08;
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            } else if (salario > 4500.0)
            {
                imposto = (salario - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}