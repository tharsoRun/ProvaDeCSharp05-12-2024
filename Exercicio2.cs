using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite a primeira data: ");
        string entrada1 = Console.ReadLine();

        Console.Write("Digite a segunda data: ");
        string entrada2 = Console.ReadLine();

        if (DateTime.TryParse(entrada1, out DateTime data1) && DateTime.TryParse(entrada2, out DateTime data2))
        {
            int diasEntreDatas = (data2 - data1).Days;
            Console.WriteLine("A quantidade de dias entre as datas é: " + Math.Abs(diasEntreDatas));
        }
        else
        {
            Console.WriteLine("Uma ou ambas as datas são inválidas.");
        }
    }
}
