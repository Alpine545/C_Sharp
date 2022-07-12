double One (double x, double y)
{
    double z = Math.Pow(x, y);
    return z;
}

Console.WriteLine (One (double.Parse(Console.ReadLine()),double.Parse(Console.ReadLine())));