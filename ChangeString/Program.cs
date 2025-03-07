using System;

class Program
{
    static void Main()
    {
        // Solicita a string ao usuário
        Console.Write("Digite uma string: ");
        string str = Console.ReadLine();

        // Solicita o caractere ao usuário
        Console.Write("Digite um caractere a substituir: ");
        char och = Console.ReadKey().KeyChar;
        Console.WriteLine(); // Pular linha após entrada do caractere

        // Substitui todas as ocorrências do caractere por 'x'
        string res = str.Replace(och, 'x');

        // Exibe o resultado
        Console.WriteLine("String transformada: " + res);
    }
}

