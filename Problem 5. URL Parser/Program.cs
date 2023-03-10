using System;
using System.Text.RegularExpressions;

string? URL = Console.ReadLine();
string protocol = ""; //протокол
string server = ""; //сервер
string resource = ""; //ресурс
if (URL != null)
{
    if (Regex.IsMatch(URL, @"(\w|\W)+://(\w|\W)+")) //якщо у тексті є ... :// ...
        for (int i = 0; i < URL.Length; i++)
            if (i + 1 < URL.Length && URL[i] != '/' && URL[i + 1] != '/') //доходимо до ://
                protocol += URL[i];
            else break;

    if (Regex.IsMatch(URL, @"[A-Z,a-z,0-9]+/(\w|\W)+")) // якщо є ресурс
    {
        for (int i = protocol.Length + 3; i < URL.Length; i++) // доходимо до /
            if (i + 2 < URL.Length && URL[i] != '/')
                server += URL[i];
            else break;

        for (int i = protocol.Length + 3 + server.Length + 1; i < URL.Length; i++) // записується ресурс
            resource += URL[i];
    }
    else // якщо ресурсу немає
        for (int i = protocol != "" ? protocol.Length + 3 : protocol.Length; i < URL.Length; i++) // записується сервер
            server += URL[i];


    Console.WriteLine("[protocol] = \"" + protocol + "\"");
    Console.WriteLine("[server] = \"" + server + "\"");
    Console.WriteLine("[resource] = \"" + resource + "\"");
}