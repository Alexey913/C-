﻿Console.WriteLine("Введите координату x первой точки:");
double xa = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату y первой точки:");
double ya = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату x второй точки:");
double xb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату y второй точки:");
double yb = Convert.ToDouble(Console.ReadLine());
double dist = 0;
dist = Math.Sqrt (Math.Pow(xa-xb,2)+Math.Pow(ya-yb,2));
Console.WriteLine ($"Расстояние между точками равно {dist}");