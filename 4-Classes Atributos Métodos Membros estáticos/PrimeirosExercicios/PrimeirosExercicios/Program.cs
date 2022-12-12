using Exercicio2;
using System;
using System.Globalization;

namespace PrimeirosExercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercicio2();
        }
        static void Exercicio1()
        {
            Pessoas primeira, segunda;

            primeira = new Pessoas();
            segunda = new Pessoas();

            Console.WriteLine("Dados da primeira pessoa:");
            primeira.Nome = Console.ReadLine();
            primeira.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");
            segunda.Nome = Console.ReadLine();
            segunda.Idade = int.Parse(Console.ReadLine());

            if (primeira.Idade > segunda.Idade)
            {
                Console.WriteLine("Pessoa mais velha: " + primeira.Nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + segunda.Nome);
            }
        }
        static void Exercicio2()
        {
            Funcionarios funcionario1, funcionario2;

            funcionario1 = new Funcionarios();
            funcionario2 = new Funcionarios();

            Console.WriteLine("Dados do primeiro funcionário:");
            funcionario1.Nome = Console.ReadLine();
            funcionario1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário:");
            funcionario2.Nome = Console.ReadLine();
            funcionario2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (funcionario1.Salario + funcionario2.Salario) / 2;

            Console.WriteLine("Salário médio: " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}