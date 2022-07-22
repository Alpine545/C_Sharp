void Print(int[,] arr)
{
    for (int i=0;i<arr.GetLength(0);i++)
    {
        for (int j=0;j<arr.GetLength(1);j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int [,] MassNums(int row, int col, int from, int to)
{
    int[,] arr = new int[row, col];
    for(int i=0;i<row;i++)
    {
        for (int j=0;j<col;j++)
        arr[i,j] = new Random().Next(from, to);   
    }
    return arr;
}

int[,] Copy(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int col_size = arr.GetLength(1);
    int[,] new_arr = new int [row_size, col_size];

    for (int i=0; i<arr.GetLength(0); i++)
    {
        for (int j=0;j<arr.GetLength(1);j++)
        {
            new_arr[i,j] = arr[i,j];
        }
    }
    return new_arr;
}
int[,] arr_1 = MassNums(2, 5, 1, 11);
Print(arr_1);
int[,] arr_1_new = Copy(arr_1);
Print(arr_1_new);
