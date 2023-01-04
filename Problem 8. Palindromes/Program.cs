 string? text = Console.ReadLine();
if(text != null)
{
    string[] words = text.Split(' ', ',','.','!','?'); // розбиваємо на підстроки
    List<string> palindrom = new List<string>(); //для паліндромів
    foreach(string word in words) //перебір колекції
    {
        string reverser = ReverseString(word); //зареверсене слово
        if(Equals(reverser,word)) //якщо слово == зареверсеному слові
        {
            palindrom.Add(word); //додаємо у колекцію
        }
    }
    palindrom.Sort(); //сортування колекції паліндромів
    Console.WriteLine($"{string.Join(" ", palindrom)}"); //вивід через пробіл
}
string ReverseString(string str)
{
    char[] a = str.ToCharArray();
    Array.Reverse(a);
    return new string(a);
}