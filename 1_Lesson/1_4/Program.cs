int N = int.Parse(Console.ReadLine());
if (N<=0)
{
    N = N*(-1);
}
int M = -N;

while (M<N+1)
{
    Console.WriteLine(M);
    M++;
}