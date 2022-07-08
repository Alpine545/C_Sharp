//int x = int.Parse(Console.ReadLine());
//if (x % 7 == 0 && x % 23 == 0) Console.WriteLine ("Кратно");
//else Console.WriteLine ("Некратно");

void Maxnumber (int num)
{
    if (num % 7 == 0 && num % 23 == 0)
    {
        Console.WriteLine ("Кратно");
    }
    else
        Console.WriteLine ("Некратно");
}
Maxnumber (16);
Maxnumber (23);