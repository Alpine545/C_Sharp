void Print(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MassNums(int row, int col, int from, int to)
{
    int[,] arr = new int[row, col];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            arr[i, j] = new Random().Next(from, to);
    }
    return arr;
}

int[,] MatrixProd(int[,] arr_first, int[,] arr_second)
{
    int[,] pr_matrix = new int[arr_first.GetLength(0), arr_first.GetLength(1)];

    if (arr_first.GetLength(0) != arr_second.GetLength(0) || arr_first.GetLength(1) != arr_second.GetLength(1)) return pr_matrix;

    for (int i = 0; i < arr_first.GetLength(0); i++)
        for (int j = 0; j < arr_first.GetLength(1); j++)
            pr_matrix[i, j] = arr_first[i, j] * arr_second[i, j];
    return pr_matrix;
}

Console.WriteLine("Enter the number of rows_1: ");
int row = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the number of columns_1: ");
int column = int.Parse(Console.ReadLine());
int[,] arr_first = MassNums(row, column, 1, 10);
Console.WriteLine("Enter the number of rows_2: ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the number of columns_2: ");
int columns = int.Parse(Console.ReadLine());
int[,] arr_second = MassNums(rows, columns, 1, 10);
Print(arr_first);
Print(arr_second);
Console.WriteLine(MatrixProd(arr_first, arr_second));