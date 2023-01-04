using System.Text.RegularExpressions;

string? text = Console.ReadLine();
if (text != null)
{
    List<string> between_upcases = new List<string>();
    for(int i=0;i<text.Length;i++)
    {
        if(i + 7 < text.Length) //щоб не вийти за межі
        {
            if (text[i].Equals('<') && text[i+1].Equals('u') && text[i+2].Equals('p') && text[i+3].Equals('c') && text[i+4].Equals('a') && text[i+5].Equals('s') &&
                text[i+6].Equals('e') && text[i+7].Equals('>')) // знаходимо <upcase>
            {
                string after_upcase = ""; //до </upcase>
                for(int j=i+8;j<text.Length;j++)
                {
                    after_upcase+= text[j];
                    if(i+9 < text.Length) //щоб не вийти за межі
                    {
                        if(text[j+1].Equals('<') && text[j + 2].Equals('/') && text[j + 3].Equals('u') && text[j + 4].Equals('p') && text[j + 5].Equals('c') && text[j + 6].Equals('a') &&
                text[j + 7].Equals('s') && text[j + 8].Equals('e') && text[j+9].Equals('>')) //знаходимо </upcase>
                        {
                            i = j;
                            break;
                        }
                    }
                }
                between_upcases.Add(after_upcase); //додаємо підстроку в список
            }
        }
    }
    foreach(string words in between_upcases)
    {
        if(text.Contains(words)) //якщо у тексті є підстрока <upcase>...</upcase>
        {
            text = text.Replace(words, words.ToUpper()); //заміна слів на верхній регістр
            text = text.Replace("<upcase>", ""); //заміна <upcase> на пустий рядок, тобто видалення
            text = text.Replace("</upcase>", ""); //заміна </upcase> на пустий рядок, тобто видалення
        }
        Console.WriteLine(text);
    }
}