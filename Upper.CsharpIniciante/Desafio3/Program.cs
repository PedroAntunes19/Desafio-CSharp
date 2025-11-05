namespace Desafio3
{
    class Program
    {
        static void Main(string[] args)
        {
         
            // Calculaedora

            Console.Write("Digite um Número : ");
            var N1 = Convert.ToDouble(Console.ReadLine());

                      Console.Write("Digite um Operador Matemático(+, -, *, /) : ");
            var Operador = Console.ReadLine();

                      Console.Write("Digite um Número : ");
            var N2 = Convert.ToDouble(Console.ReadLine());

            double resultado = 0;

            switch (Operador)
            {
                case "+":
                    resultado = N1 + N2;
                    break;

                case "-":
                    resultado = N1 - N2;
                    break;


                case "*":
                    resultado = N1 * N2;
                    break;

                case "/":
                    if (N2 != 0)
                        resultado = N1 / N2;
                    else
                        Console.Write("Erro: divisão por zero!");
                    break;
                default:
                    Console.Write("Operador inválido!");
                    break;
            }     
              Console.Write($"Resultado: {resultado}");
        }
    }
}

