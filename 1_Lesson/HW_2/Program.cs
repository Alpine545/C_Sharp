int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());
int z = int.Parse(Console.ReadLine());
int index = 0;
int max = 0;

if (x>y)
{
    max = x;
}
else
{
    max = y;
}

if (max > z)
{
    Console.WriteLine(max);
}
else
{
    Console.WriteLine(z);
}