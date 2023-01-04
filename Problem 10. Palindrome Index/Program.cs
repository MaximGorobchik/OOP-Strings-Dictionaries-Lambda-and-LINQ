using System.Diagnostics.Tracing;
using System.Globalization;

string? text = Console.ReadLine();
if (text != null)
{
    int index = 0;
    for (int i = 0; i < text.Length / 2; i++) //чи є слово паліндромом
        if (text[i] == text[text.Length - i - 1])
            index++;
    if (index == text.Length / 2)
    {
        Console.WriteLine("-1"); //якщо паліндром то -1
    }
    else
    {
        for (int i = 0; i < text.Length; i++) // і - символ який пропускається
        {
            for (int j = 0; j < text.Length; j++) // перевірка на паліндром без і-го символа
                if (text[j] == text[text.Length - j - 1] && i != j)
                    index++;
                if (index == text.Length / 2) //якщо паліндром
                {
                    Console.WriteLine(i); //вивід пропущеного символу
                    break;
                }
                else
                    index = 0;
        }
    }
}
string ReverseString(string str)
{
    char[] a = str.ToCharArray();
    Array.Reverse(a);
    return new string(a);
}