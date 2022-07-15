void Print(int[] arr)
{
    int size = arr.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] MassNums(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(1, 10);
    }
    return arr;
}

void Product(int[] arr)
{
    for (int i = 0; i < arr.Length/2; i++) 
    {
       int z = arr[i]*arr[arr.Length-(1+i)];
       Console.Write($"{z} ");
    }
    if (arr.Length % 2 != 0) Console.Write (arr[arr.Length/2]);
}

int[] arr_1 = MassNums(8);
Print(arr_1);
Product(arr_1);