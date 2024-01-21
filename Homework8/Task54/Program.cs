// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void FillRandom (int [,] arr)
{
    int quantityRow = arr.GetLength(0);
    int quantityColumn = arr.GetLength(1);
    for (int i = 0; i < quantityRow; i++)
    {
        for (int j = 0; j < quantityColumn; j++)
        {
            arr [i,j] = new Random().Next(10, 100);
        }
    }
}

void PrintArray (int [,] print)
{
    int quantityRow = print.GetLength(0);
    int quantityColumn = print.GetLength(1);
    for (int i = 0; i < quantityRow; i++)
    {
        for (int j = 0; j < quantityColumn; j++)
        {
            Console.Write (print[i,j]+" ");
        } 
        Console.WriteLine();
    }
}

void MaxToMin (int [,] arrayRandom)
{
int row = arrayRandom.GetLength(0);
int column = arrayRandom.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        int variosElement = 0;
        while (variosElement < column)
        {
            int tempMax = 0;
            int maxPosition = 0;
            for (int j = variosElement; j < column; j++)
            {
                if (arrayRandom[i,j] > tempMax)
                {
                    tempMax = arrayRandom [i,j];
                    maxPosition = j;
                }
            }
            arrayRandom[i,maxPosition] = arrayRandom[i, variosElement];
            arrayRandom[i, variosElement] = tempMax;
            variosElement++;
        }
    }
}

Console.Write("Введите количество строк массива: ");
int row = Convert.ToInt16 (Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int column = Convert.ToInt16 (Console.ReadLine());
Console.WriteLine();

int [,] arrayRandom = new int [row, column];
FillRandom (arrayRandom);
Console.WriteLine ();
Console.WriteLine ("Вот случайный массив:");
Console.WriteLine (); 
PrintArray (arrayRandom);
Console.WriteLine();
Console.WriteLine ("Это упорядоченный массив:");
Console.WriteLine ();
MaxToMin (arrayRandom);
PrintArray (arrayRandom);