//int x = new Random().Next(100,1000);
//Console.WriteLine(x);
//Console.WriteLine((x / 100)*10 + (x % 10));

int Maxnumber (int x)
{
    return (x / 100)*10 + (x % 10);
}
int SecondNum = new Random().Next(100,1000);
Console.WriteLine (SecondNum);
Console.WriteLine (Maxnumber (SecondNum));