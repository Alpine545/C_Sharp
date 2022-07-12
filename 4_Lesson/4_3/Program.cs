int ProdNum (int num)
{
    int all_prod = 1;
    for (int i = 1; i <= num; i++)
    {
        all_prod *= i;
    }
    return all_prod;
}

Console.WriteLine (ProdNum (5));
