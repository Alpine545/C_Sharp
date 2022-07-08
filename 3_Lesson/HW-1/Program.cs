void One (int x)
{
if (x % 10 == x/10000 & x/1000 % 10 == x/10 % 10) Console.WriteLine("Yes");
else Console.WriteLine("No");
}
One (int.Parse(Console.ReadLine()));