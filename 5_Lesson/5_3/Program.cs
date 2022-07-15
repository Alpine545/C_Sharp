void Print(int[] arr)
{
    int size = arr.Length;
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"{arr[i]} ");
    }
}

int[] MassNums(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(1, 500);
    }
    return arr;
}

void Find(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++) 
    {
        if (9 < arr[i] && arr[i] < 100 ) count++;
    }
    Console.WriteLine(count);
}

int[] arr_1 = MassNums(123);
Find(arr_1);