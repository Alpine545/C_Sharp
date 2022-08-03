int SumNumber(int num)
{
    if (num == 0) return 0;
    return SumNumber(num / 10) + num % 10;
}

Console.WriteLine(SumNumber(456));