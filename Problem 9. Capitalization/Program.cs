string? text = Console.ReadLine();
if(text != null)
{
    string[] split = text.Split('.',',','?','!',';', ' '); //розбиваємо на підстроки
    foreach(string words in split ) //перебір колекції
    {
        string FirstUpCase = "";
        for(int i=0;i<words.Length;i++)
        {
            FirstUpCase += words[i]; //записуємо слово повністю
            if (i == 0)
            {
                FirstUpCase = FirstUpCase.ToUpper(); //перший символ до верхнього регістру
            }
        }
        text = text.Replace(words,FirstUpCase);
    }
    Console.WriteLine(string.Join(" ",text)); //вивід через пробіл
}