namespace Desafio1
{
    class Progam
    {
        static void Main(string[] args)
        {
            // Calculando soma dos números de 1 a 10
            int Conta = 0;

            for (int i = 0; i <= 10; i++)
            {
                Conta = Conta + i;
            }
            Console.WriteLine("A soma de 1 a 10 é : " + Conta);
        }
    }
}