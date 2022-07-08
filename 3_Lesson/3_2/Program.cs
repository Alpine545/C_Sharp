void Quarters (int x)
{
    if (x==1) Console.WriteLine($"Quarter {x} -> x>0, y>0");
    else if (x==2) Console.WriteLine($"Quarter {x} -> x<0, y>0");
    else if (x==3) Console.WriteLine($"Quarter {x} -> x<0, y<0");
    else if (x==4) Console.WriteLine($"Quarter {x} -> x>0, y<0");
    else Console.WriteLine("Error");
}
Quarters (1);
Quarters (2);
Quarters (3);
Quarters (4);
Quarters (5);