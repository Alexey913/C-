﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


void PrintNumbers (int N)
{
    if (N==0)
    {
        return;
    }
    else 
    {
        Console.Write ($"{N} ");
        PrintNumbers(N-1);
    }
}
Console.WriteLine ("Введите число N, и я выведу все натуральные числа от 1 до N");
int N = Convert.ToInt32 (Console.ReadLine());

PrintNumbers(N);