public class Reverse : IReserve
{
    public void Variant1(string text)
    {
        string newText = string.Join("",text.ToCharArray().Reverse()); //рядок до масиву типу char та перевертаємо
        Console.WriteLine(newText); //виводимо перевернутий текст
    }
    public void Variant2(string text)
    {
        for (int i = text.Length - 1; i >= 0; i--) //цикл від кінця до початку рядка
        {
            Console.Write(text[i]); //виводимо перевернутий текст
        }
    }
}