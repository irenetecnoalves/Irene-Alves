using System;
using System.Globalization;

namespace exercicioproposto2
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo1, numero1; int codigo2, numero2; double preco1, preco2; double valor;

            double A, B, C, D;
            double areaTriangulo, circulo, trapezio, quadrado, retangulo,formula;

            int numFun, horaTrab;
            double valorHora, salario;
            Console.WriteLine("Exercicío para codigo do produto");

            codigo1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Você digitou o codigo do primeiro produto " + codigo1);

            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Você digitou o número do primeiro produto " + numero1);

            preco1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Você digitou o preço do primeiro produto " + preco1);

            codigo2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Você digitou o codigo do segundo produto " + codigo2);

            numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Você digitou o número do segundo produto " + numero2);

            preco2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Você digitou o preço do segundo produto " + preco2);

            valor = (preco1 * numero1) + (preco2 * numero2);
            Console.WriteLine("O valor a pagar é " + valor);

            Console.WriteLine("Exercício de achar área");
            Console.WriteLine();

            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("você digitou o valor de " + A);
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("você digitou o valor de B " + B);
            C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Você digitou o valor de C " + C);

            areaTriangulo = (A * C) / 2;
            circulo = (C * C) * 3.14159;
            trapezio = (A + B) * C / 2;
            quadrado = B * B;
            retangulo = (A * B);

            Console.WriteLine("A area do triangulo é " + areaTriangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("A area do circulo é  " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("A area do trapézio é " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("A area do quadrado é " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("A area do retangulo é  " + retangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine();

            Console.WriteLine("Exercício para achar valor salário");
            Console.WriteLine();

            numFun = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Este é o numero do funcionário " + numFun);

            horaTrab = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Este é o numero de hora trabalhada " + horaTrab);

            valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Este é o valor da hora trabalhada" + valorHora);
            Console.WriteLine();

            salario = (horaTrab * valorHora);

            Console.WriteLine("Este é o número do funcionário " + numFun);
            Console.WriteLine("Este e o salario " + salario.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Exercicio para ler 4 valores");
            Console.WriteLine();
            A = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Este e o valor de A " + A);

            B = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Este e o valor de B " + B);

            C = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Este e o valor de C " + C);

            D = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Este e o valor de D " + D);

            formula = (A * B) - (C * D);
            Console.WriteLine(" O resultado é "+formula.ToString(CultureInfo.InvariantCulture ));















        }
    }
}
