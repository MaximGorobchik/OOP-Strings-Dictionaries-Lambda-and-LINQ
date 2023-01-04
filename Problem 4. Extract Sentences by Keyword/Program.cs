var word = Console.ReadLine();
string[] text = Console.ReadLine().Split('.', '!', '?'); //розділяємо на підстроки
if(word != null && text != null)
{
    List<string> textList = new List<string>();
    for(int i=0;i<text.Length;i++)
    {
        if (text[i].Contains(word)) //якщо у рядку є слово
        {
            string[] tempString = text[i].Split(' ','-','-',',','(',')'); //розділяємо на підстроки
            if(tempString.Contains(word)) //якщо у рядку є слово
            {
                textList.Add(text[i]); //додаємо у колекцію
            }
        }
    }
    foreach (var item in textList) //перебір колекції
    {
        Console.WriteLine($"{Environment.NewLine}{item}");
    }
}