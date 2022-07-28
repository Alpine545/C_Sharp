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

void Revers(int[,] arr)
{
   if (arr.GetLength(0) != arr.GetLength(1))
   {
    Console.WriteLine("Error");
    return;
   }
   for(int i=0;i<arr.GetLength(0);i++)
   {
        for(int j=0;j<i;j++)
        (arr[i,j], arr[j,i]) = (arr[j,i], arr[i,j]);
   }
}

Console.WriteLine("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());
int[,] arr_1 = MassNums(row, column, 1, 10);
Print(arr_1);
Revers(arr_1);
Print(arr_1);