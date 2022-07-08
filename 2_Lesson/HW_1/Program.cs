//int x = int.Parse(Console.ReadLine());
//x = x % 100 / 10;
//Console.WriteLine(x);

int Maxnumber (int x)
{
    return x % 100 / 10;
}
int SecondNum = int.Parse(Console.ReadLine());
Console.WriteLine (Maxnumber (SecondNum));