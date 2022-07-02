int N = int.Parse(Console.ReadLine());
int M = 1;

if (N < 0)
{
    N = N * (-1);
}

while (M <= N)
{
    Console.WriteLine(M);
    M++;
}
