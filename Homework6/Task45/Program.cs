﻿// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
   

void FillArray (int [,] fill)
{
    for (int i = 0; i < fill.GetLength(0); i++)
    {
        for (int j = 0; j < fill.GetLength(1); j++)
        {
            fill [i,j] = new Random().Next(-99,100);
        }
    }
}

void PrintArray (int[,] print)
{
    for (int i = 0; i < print.GetLength(0); i++)
    {
        for (int j = 0; j < print.GetLength(1); j++)
        {
            Console.Write($"{print[i,j]} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine ("Зададим случайный двумерный массив в диапазоне [-99; 99] и я сделю его копию");
Console.WriteLine ("Введите количество строк массива");
int row = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Введите количество столбцов массива");
int column = Convert.ToInt32 (Console.ReadLine());

int [,] randArray = new int [row, column];
FillArray (randArray);

Console.WriteLine ("Исходный массив:");
PrintArray (randArray);
Console.WriteLine ();

int [,] copyArray = new int [row, column];
for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            copyArray [i,j] = randArray [i,j];
        }
    }
    
Console.WriteLine ("Скопированный массив:");

PrintArray (copyArray);