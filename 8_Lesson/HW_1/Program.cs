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
    for(int i=0;i<arr.GetLength(0);i++)
    {
        for (int j=0;j<arr.GetLength(1);j++)
        arr[i,j] = new Random().Next(from, to);   
    }
    return arr;
}

void Sorting(int[,] arr)
{
    for(int i=0;i<arr.GetLength(0);i++)
    {
        for (int j=0;j<arr.GetLength(1);j++)
        {
            for (int k=0;k<arr.GetLength(1)-j-1;k++)
                if (arr[i,k]<arr[i,k+1]) 
                    (arr[i,k], arr[i,k+1]) = (arr[i,k+1], arr[i,k]);
        }
    }
}

Console.WriteLine("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());
int[,] arr_1 = MassNums(row, column, 1, 10);
Print(arr_1);
Sorting(arr_1);
Print(arr_1);