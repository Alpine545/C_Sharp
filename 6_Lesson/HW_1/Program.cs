﻿int Check(int num)
{
    int count = 0;
    for (int i = 1; i <= num; i++)
    {
        Console.Write($"Number {i}: ");
        int a = int.Parse(Console.ReadLine());
        if (a > 0) count++;
    }
    return count;
}
int a = int.Parse(Console.ReadLine());
Console.WriteLine(Check(a));