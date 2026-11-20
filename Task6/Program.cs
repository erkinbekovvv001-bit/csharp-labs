
using System;

class Program
{
    static string ConvertUpperToLower(string text, out int count)
    {
        string result = "";
        count = 0;

        for (int i = 0; i < text.Length; i++)
        {
            char ch = text[i];

            if (char.IsUpper(ch))
            {
                ch = char.ToLower(ch);
                count++;
            }

            result += ch;
        }

        return result;
    }

    static void Main()
    {
        string text;

        do
        {
            Console.Write("Жолды енгізіңіз: ");
            text = Console.ReadLine() ?? "";
        }
        while (text.Length == 0);

        int count;
        string result = ConvertUpperToLower(text, out count);

        Console.WriteLine("Бастапқы жол: " + text);
        Console.WriteLine("Нәтиже: " + result);
        Console.WriteLine("Бас әріптер саны: " + count);
    }
}
