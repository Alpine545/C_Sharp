﻿void Print(int[,] arr)
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

int[] MinEl (int[,] arr)
{
    int min_num = arr[0,0];
    int[] indexes = new int[2];

    for(int i=0;i<arr.GetLength(0);i++)
    {
        for (int j=0;j<arr.GetLength(1);j++)
            if (min_num > arr[i,j])
            {
                min_num = arr[i,j];
                indexes[0] = i;
                indexes[1] = j;
            }
    }
    Console.WriteLine(arr[indexes[0],indexes[1]]);
    return indexes;
}

void DelRowCol(int[,] arr, int[] m_indexes)
{
    for(int i=0;i<arr.GetLength(0);i++)
    {
        for (int j=0;j<arr.GetLength(1);j++)
            if(m_indexes[0] == i || m_indexes[1] == j) continue; 
            else Console.Write($"{arr[i, j],3}");
        Console.WriteLine();
    }
    Console.WriteLine();    
}

Console.WriteLine("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());
int[,] arr_1 = MassNums(row, column, 1, 10);
Print(arr_1);
Console.WriteLine(MinEl(arr_1));
DelRowCol(arr_1, MinEl(arr_1));