int Numbers(int A, int B)
{
    if (B == 0) return 1;
    return Numbers(A, B-1) * A;
}

Console.WriteLine(Numbers(3, 5));