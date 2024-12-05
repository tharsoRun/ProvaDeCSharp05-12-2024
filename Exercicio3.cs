using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um DDD: ");
        int ddd = int.Parse(Console.ReadLine());

        string cidade;
        
            //NÃO SEI SE ERA PARA USAR IF E ELSE IF, MAS TA AI :D
            
        switch (ddd)
        {
            case 61:
                cidade = "Brasília";
                break;
            case 71:
                cidade = "Salvador";
                break;
            case 11:
                cidade = "São Paulo";
                break;
            case 21:
                cidade = "Rio de Janeiro";
                break;
            case 32:
                cidade = "Juiz de Fora";
                break;
            case 19:
                cidade = "Campinas";
                break;
            case 27:
                cidade = "Vitória";
                break;
            case 31:
                cidade = "Belo Horizonte";
                break;
            default:
                cidade = "DDD não cadastrado";
                break;
        }

        Console.WriteLine(cidade);
    }
}
