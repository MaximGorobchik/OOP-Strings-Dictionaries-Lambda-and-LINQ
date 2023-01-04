string? A = Console.ReadLine();
string? B = Console.ReadLine();
if(A != null && B != null)
{
    int counter = 0;
    for(int i=0;i<A.Length;i++) //проходимо рядок A
    {
        for(int j=0; j< B.Length;j++) //проходимо рядок A
        {
            if (A[i] == B[i]) //якщо символ рядка А == символу рядка В
            {
                counter++; //рахуємо
            }
        }
    }
    if(counter > 1) //якщо однакових символів > 1
    {
        Console.WriteLine("yes");
    }
    else //якщо немає
        Console.WriteLine("no");
}