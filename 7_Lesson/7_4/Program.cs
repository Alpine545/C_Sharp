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

void FindNum(int[,] arr, int a)
{
    string b = "Does not exist";
    for (int i=0;i<arr.GetLength(0);i++)
    {
        for (int j=0;j<arr.GetLength(1);j++)
        {
            if (arr[i,j] == a) 
            {
                b = $"[{i+1}, {j+1}]";
                break;
            }
        }
    }
    Console.WriteLine(b);
}

Console.WriteLine("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the number: ");
int a = int.Parse(Console.ReadLine());
int[,] arr_1 = MassNums(row, column, 1, 10);
Print(arr_1);
FindNum(arr_1, a);