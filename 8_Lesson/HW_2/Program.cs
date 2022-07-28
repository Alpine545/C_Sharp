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

int FindMinSum(int[,] arr)
{
    int result = 0;
    int min = 999;
    int sum = 0;
    for(int i=0;i<arr.GetLength(0);i++)
    {
        for (int j=0;j<arr.GetLength(1);j++)
        {
            sum+=arr[i,j];
        }
        if (sum<min)
        {    
        min = sum;
        result = i;
        }
        sum = 0;
    }
    return result+1;    
}

Console.WriteLine("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());
int[,] arr_1 = MassNums(row, column, 1, 10);
Print(arr_1);
Console.WriteLine($"Number MinSum string is - {FindMinSum(arr_1)}");