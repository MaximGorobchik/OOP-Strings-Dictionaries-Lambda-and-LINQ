string? sentence = Console.ReadLine();

if (sentence != null)
{
    string[] split = sentence.Split('.', ',', ':', ';', '=', '(', ')', '&', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ');
    List<string> words = new(); // для слів
    List<string> characters = new(); // для символів між словами


    foreach (string item in split) // записуються слова
        if (item.Length > 0) words.Add(item);

    for (int i = 0; i < words.Count - 1; i++) // записуються символи віж словами
        characters.Add
            (
                sentence.Substring
                (
                    sentence.IndexOf(words[i]) + words[i].Length, // між першим входженням слова
                    sentence.IndexOf(words[i + 1]) - (sentence.IndexOf(words[i]) + words[i].Length) // до початку наступного слова
                )
            );

    string reversed = "";
    int index = 0; //проходження по characters
    for (int i = words.Count - 1; i >= 0; i--)
    {
        reversed += words[i];

        if (index < characters.Count)
            reversed += characters[index++]; //додається символ між словами
    }
    reversed += sentence.Substring(reversed.Length); //додаються символи після останнього слова

    Console.WriteLine(reversed);
}

