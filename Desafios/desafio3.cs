//Desenvolva uma calculora simples, que faça operaçôes de soma, subtração, divisão e multiplicação.

class Calculadora
{
    static void Main()
    {
        Console.Write("Digite o Primeiro número: ");
        double primeiroNum = double.Parse(Console.ReadLine());

        Console.Write("Digite o Segundo número: ");
        double segundoNum = double.Parse(Console.ReadLine());

        Console.Write("Digite a operação que deseja realizar: \n\n");
        Console.Write("Digite +, para realizar uma Soma\n");
        Console.Write("Digite -, para realizar uma Subtração\n");
        Console.Write("Digite /, para realizar uma Divisão\n");
        Console.Write("Digite *, para realizar uma Multiplicação\n");

        string operacao = Console.ReadLine();

        if (operacao == "+")
        {
            Console.Write($"A soma dos números é: {primeiroNum + segundoNum}");
        }
        else if (operacao == "-")
        {
            Console.Write($"A subtração dos números é: {primeiroNum - segundoNum}");
        }
        else if (operacao == "/")
        {
            if (segundoNum != 0)
                Console.Write($"A divisão dos números é: {primeiroNum / segundoNum}");

            else
                Console.Write("Erro: Não é possivel fazer divisão por zero");
        }
        else if (operacao == "*")
        {
            Console.Write($"A divisão dos números é: {primeiroNum * segundoNum}");
        }
        else
        {
            Console.WriteLine("Operação inválida");
        }


        Console.ReadLine();

    }
}