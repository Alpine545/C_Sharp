Console.Write("Введите число М: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int Sequence(int M, int N)
{
    if (N < M) return 0;
    return Sequence(M, N-1)+N;
}

Console.WriteLine(Sequence(M, N));