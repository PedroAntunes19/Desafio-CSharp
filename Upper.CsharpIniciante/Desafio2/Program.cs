using System;
using System.Globalization;

namespace Desafio2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calculando o IMC
            Console.Write("Insira seu peso (kg): ");
            double peso = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Insira sua altura (m): ");
            double altura = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            double IMC = peso / (altura * altura);

            if (IMC <= 16)
            {
                Console.WriteLine("Classificação: Magreza grave");
            }
            else if (IMC <= 17)
            {
                Console.WriteLine("Classificação: Magreza moderada");
            }
            else if (IMC <= 18.5)
            {
                Console.WriteLine("Classificação: Magreza leve");
            }
            else if (IMC <= 25)
            {
                Console.WriteLine("Classificação: Saudável");
            }
            else if (IMC <= 30)
            {
                Console.WriteLine("Classificação: Sobrepeso");
            }
            else if (IMC <= 35)
            {
                Console.WriteLine("Classificação: Obesidade grau I");
            }
            else if (IMC <= 40)
            {
                Console.WriteLine("Classificação: Obesidade grau II (severa)");
            }
            else
            {
                Console.WriteLine("Classificação: Obesidade grau III (mórbida)");
            }
        }
    }
}
