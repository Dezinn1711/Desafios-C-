//Desenvolver um programa que utilize "for" para calcular a soma dos números 1 a 10.

class Program
{
    static void Main()
    {
        int tamanho = 10;
        var somaNumeros = 0;

        for (int i = 1; i <= tamanho; i++)
        {
            somaNumeros += i;
        }

        Console.Write("A soma dos números é: " + somaNumeros);
        Console.ReadLine();
    }
}

