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

void Exist(int[] arr, int x)
{
    int y = 0;
    for (int i = 0; i < arr.Length; i++) 
    {
        if (arr[i] == x) {Console.WriteLine("Yes"); break;}
    }
    Console.WriteLine("No");
}

int[] arr_1 = MassNums(20);
Print(arr_1);
Exist(arr_1, 4);