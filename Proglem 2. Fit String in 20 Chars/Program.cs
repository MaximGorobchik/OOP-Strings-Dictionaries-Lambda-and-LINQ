string? s = Console.ReadLine();
if (s != null)
{
    if (s.Length < 20) //якщо розмір рядка менше 20
    {
        while (s.Length != 20) //поки розмір не буде 20
        {
            s += "*"; //додаємо зірочки
        }
        Console.WriteLine(s); //вивід
    }
    else
    {
        Console.WriteLine(s.Substring(0, 20)); // якщо більше 20, вирізаємо рядок від 0 до 20
    }
}