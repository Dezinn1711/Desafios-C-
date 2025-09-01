//Criar um programa que Calcule o índice IMC

class CalculoDoIMC
{
    static void Main()
    {
        Console.Write("Digite um peso em Quilogramas: ");

        double peso = double.Parse(Console.ReadLine());

        Console.Write("Digite um altura em Metros: ");

        double altura = double.Parse(Console.ReadLine());

        var calculoIMC = peso / (altura * altura);


        if (calculoIMC < 18.5)
        {
            Console.Write("O IMC é: " + calculoIMC + ", e é classificado como Magro");
        }
        else if (calculoIMC >= 18.5 && calculoIMC <= 24.9)
        {
            Console.Write("O IMC é: " + calculoIMC + ", e é classificado como peso Adequado");
        }
        else if (calculoIMC >= 25 && calculoIMC <= 29.9)
        {
            Console.Write("O IMC é: " + calculoIMC + ", e é classificado como Sobrepeso");
        }
        else if (calculoIMC >= 30 && calculoIMC <= 34.9)
        {
            Console.Write("O IMC é: " + calculoIMC + ", e é classificado como Obesidade Grau 1");
        }
        else if (calculoIMC >= 35 && calculoIMC <= 39.9)
        {
            Console.Write("O IMC é: " + calculoIMC + ", e é classificado como Obesidade Grau 2");
        }
        else if (calculoIMC >= 40)
        {
            Console.Write("O IMC é: " + calculoIMC + ", e é classificado como Obesidade Grau 3 (Mórbida)");
        }

        Console.ReadLine();
    }
}