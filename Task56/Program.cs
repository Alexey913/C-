// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int RowMinSum (int [,] arrayRandom)
{
    int row = arrayRandom.GetLength(0);
    int column = arrayRandom.GetLength(1);
    int [] sum = new int [row];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            sum[i]=sum[i]+arrayRandom[i,j];
        }
    }
    int minSum = sum [0];
    int rowMin = 0;
    for (int i = 0; i < row; i++)
    {
        if (sum [i] < minSum)
        {
            minSum = sum [i];
            rowMin = i;
        }
    }
    Console.WriteLine ('['+String.Join (" ", sum)+']');
    return (rowMin);
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

int rowMin = RowMinSum (arrayRandom);

int sum = 0;
for (int j = 0; j < column; j++)
{
    sum = sum + arrayRandom[rowMin, j];
}

Console.WriteLine ($"Номер строки с минимальной суммой элементов массива - {rowMin+1}. Сумма элементов равна {sum}");