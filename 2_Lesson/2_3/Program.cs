﻿int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());

if (x % y == 0) Console.WriteLine ("Кратно");
else Console.WriteLine ($"Остаток от деления {x % y}");