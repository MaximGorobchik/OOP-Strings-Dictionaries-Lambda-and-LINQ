Dictionary<string,string> persons = new Dictionary<string,string>();
string? text = Console.ReadLine();
while(!text.Equals("END"))
{
    string[] split = text.Split(' ');
    if (split[0].Equals("A"))
    {
        if (persons.ContainsKey(split[1])) //У разі спроби додати ім’я, яке вже є в телефонній книзі, змінюємо наявний номер телефону на новий.
        {
            persons[split[1]] = split[2]; 
        }
        else
        {
            persons.Add(split[1], split[2]); //додаємо нову людину
        }
    }
    if (split[0].Equals("S"))
    {
        if (persons.ContainsKey(split[1])) //якщо є таке ім'я
        {
            Console.WriteLine($"{split[1]} -> {persons[split[1]]}");
        }
        else //якщо немає
        {
            Console.WriteLine($"Contact {split[1]} does not exist.");
        }
    }
    text= Console.ReadLine();
}