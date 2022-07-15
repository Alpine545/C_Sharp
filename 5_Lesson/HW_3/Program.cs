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
        arr[i] = new Random().Next(1, 100);
    }
    return arr;
}

void Diff(int[] arr)
{
    int min = arr[0];
    int max = 0;
    for (int i = 0; i < arr.Length; i++) 
    {
        if (arr[i] < min) min = arr[i];
        if (arr[i] > max) max = arr[i];
    }
    Console.WriteLine(max-min);
}

int[] arr_1 = MassNums(6);
Print(arr_1);
Diff(arr_1);