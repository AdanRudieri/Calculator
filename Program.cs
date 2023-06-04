using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Divisao();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("### MENU ###");
            Console.WriteLine("1- Soma");
            Console.WriteLine("2- Subtração");
            Console.WriteLine("3- Multiplicação");
            Console.WriteLine("4- Multiplicação");

            Console.WriteLine("---  ---  ---  ---");
            Console.WriteLine("Escolha a operação desejada:");
            short res = short.Parse(Console.ReadLine());
        }

        static void Soma()
        {

            Console.Clear();
            Console.WriteLine("Primeiro valor");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 + v2;

            Console.WriteLine();

            // Console.WriteLine("O resultado da soma é: " + resultado);
            Console.WriteLine($"O resultado da soma é: {resultado}");
            // Console.WriteLine($"O resultado da soma é: {v1 + v2}");
            // Console.WriteLine("O resultado da soma é: " + (v1 + v2));
            Console.ReadKey();
        }

        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Primeiro valor");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 + v2;

            Console.WriteLine();

            // Console.WriteLine("O resultado da soma é: " + resultado);
            Console.WriteLine($"O resultado da subtração é: {resultado}");
            Console.ReadKey();
        }

        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Primeiro valor");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 * v2;

            Console.WriteLine();

            // Console.WriteLine("O resultado da soma é: " + resultado);
            Console.WriteLine($"O resultado da subtracao é: {resultado}");
            Console.ReadKey();
        }

        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Primeiro valor");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 / v2;
            Console.WriteLine();

            // Console.WriteLine("O resultado da soma é: " + resultado);
            Console.WriteLine($"O resultado da divisão é: {resultado}");
            Console.ReadKey();
        }
        static void Potencia() { }

        static void Raiz() { }
    }
}

