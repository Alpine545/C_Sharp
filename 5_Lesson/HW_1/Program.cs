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
        arr[i] = new Random().Next(100, 1000);
    }
    return arr;
}

void EvenNum(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++) 
    if (arr[i]%2==0) count++;
    Console.WriteLine(count);
}

int[] arr_1 = MassNums(8);
Print(arr_1);
EvenNum(arr_1);