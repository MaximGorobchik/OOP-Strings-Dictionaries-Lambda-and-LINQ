var email = Console.ReadLine();
var str = Console.ReadLine();
if (email != null && str != null)
{
    var CensoredEmail = ""; //рядок для зацензурених емайлів
    int index = 0; //пошук @
    for(int i=0;i<email.Length;i++)
    {
        if (email[i] != '@') //якщо емайл не містить @
        {
            CensoredEmail += index == 0 ? '*' : email[i]; //до CensoredEmail додаємо *, якщо index == 0, інакше хост
        }
        else
        {
            index++;
            CensoredEmail += email[i];
        }
    }
    str = str.Replace(email, CensoredEmail); //заміна емайла на зацензурений у рядку
    Console.WriteLine(str);
}