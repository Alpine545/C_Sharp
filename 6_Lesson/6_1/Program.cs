void Three(int a, int b, int c)
{
    if (a < b+c && b<a+c && c<a+b) Console.WriteLine("Yes");
    else Console.WriteLine("No");
}
Three (1, 2, 3);