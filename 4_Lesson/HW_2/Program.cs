int Two (int x)
{
    int z = 0;
 while (x>0)
 {
    z+=x%10;
    x/=10;
 }
    return z;
}

Console.WriteLine (Two (int.Parse(Console.ReadLine())));