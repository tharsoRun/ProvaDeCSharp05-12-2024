using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite uma frase: ");
        string frase = Console.ReadLine();

        string[] palavras = frase.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int numeroDePalavras = palavras.Length;

        Console.WriteLine("Número de palavras: " + numeroDePalavras);
    }
}
