void NumberOne(int x, int y)
{
   if (x % y == 0)
   {
   Console.WriteLine("Кратно");
   }
   else 
   {
   Console.WriteLine(x % y);
   }
}

int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());

Console.WriteLine(NumberOne);