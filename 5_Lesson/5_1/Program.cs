void Print(int[] arr)
{
    int size = arr.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

int[] MassNums(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(-9, 10);
    }
    return arr;
}

void Revers(int[] arr)
{
    for (int i = 0; i < arr.Length; i++) 
    {
        arr[i] = -arr[i];
    }
    Console.WriteLine();
}

int[] arr_1 = MassNums(10);
Print(arr_1);
Revers(arr_1);
Print(arr_1);