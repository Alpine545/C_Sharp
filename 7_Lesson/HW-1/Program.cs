void Print(double[,] arr)
{
    for (int i=0;i<arr.GetLength(0);i++)
    {
        for (int j=0;j<arr.GetLength(1);j++)
        {
            Console.Write($" {arr[i, j], 6} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

double [,] MassNums(int row, int col, int from, int to)
{
    double[,] arr = new double[row, col];
    Random n_new = new Random();
    
    for(int i=0;i<row;i++)
    {
        for (int j=0;j<col;j++)
        arr[i,j] = Math.Round(n_new.NextDouble() * -10, 2);   
    }
    return arr;
}

Console.WriteLine("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());
double[,] arr_1 = MassNums(row, column, -9, 10);
Print(arr_1);