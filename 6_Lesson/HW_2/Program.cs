void Inter(double b1, double k1, double b2, double k2)
{
    double x = (b2-b1) / (k1-k2);
    double y = k1*x+b1;
    Console.WriteLine($"Int point: ({x}; {y})");
}
Inter (2, 5, 4, 9);