//int x = int.Parse(Console.ReadLine());
//if (x < 100) Console.WriteLine("Does not exist");
//while (x>999) x = x/10;
//Console.WriteLine(x % 10);

void Numbers (int x)
{
    if (x < 100) 
    {
        Console.WriteLine("Does not exist");
        return;
    }
    
    while (x>999) x = x/10;
    Console.WriteLine (x % 10);
    
}
Numbers (int.Parse(Console.ReadLine()));