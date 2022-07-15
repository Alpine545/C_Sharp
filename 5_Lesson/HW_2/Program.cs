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

void EvenNum(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i+=2) sum+=arr[i];   
    Console.WriteLine(sum);
}

int[] arr_1 = MassNums(6);
Print(arr_1);
EvenNum(arr_1);