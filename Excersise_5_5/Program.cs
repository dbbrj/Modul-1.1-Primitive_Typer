﻿Console.WriteLine("Hello, World!");
int i = 1;
long l = 25;
Console.WriteLine("i= " + i);
Console.WriteLine("l= " + l + '\n'); //inlc. new line
i =(int) l;
Console.WriteLine("i= " + i);
Console.WriteLine("l= " + l);
Console.WriteLine();
Console.WriteLine("Its necessary to use explicit cast when going from big datatype til smaller, because we will lose data otherwise");
Console.WriteLine();
float f = 1.5F;
double d = 2.5;
Console.WriteLine("f= " + f);
Console.WriteLine("d= " + d);
Console.WriteLine();
f = (float) d;
Console.WriteLine("f= " + f);
Console.WriteLine("d= " + d);
Console.WriteLine();