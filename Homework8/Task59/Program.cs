// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

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



int min = arrayRandom [0,0];
for (int i = 0; i < row; i++)
{
    for (int j = 0; j < column; j++)
    {
        if (arrayRandom[i,j] < min)
        {
            min = arrayRandom[i,j];
        }    
    }
}

int [] minRow = new int [row];
int [] minColumn = new int [column];
int quantityMin = 0;
for (int i = 0; i < row; i++)
{
    for (int j = 0; j < column; j++)
    {
        if (arrayRandom[i,j] == min)
        {
            quantityMin = quantityMin+1;
            minRow [i] = 1;
            minColumn [j] = 1;
        }
    }
}

int rowMin = 0;
int columnMin = 0;
int [,] newArray = arrayRandom;
for (int i = 0; i < row; i++)
{
    for (int j = 0; j < column; j++)
    {
        if (minRow[i] == 1)
        {
            rowMin = i;
            newArray[rowMin,j] = 0;
        }
        if (minColumn[j] == 1)
        {
            columnMin = j;
            newArray[i,columnMin] = 0;
        }

    }
}

int [,] finalArray = new int [row - quantityMin, column - quantityMin];
for (int i = 0; i < row-quantityMin; i++)
{
    for (int j = 0; j < column-quantityMin; j++)
    {
        if (newArray[i,j]!=0)
        {
            finalArray [i,j] = newArray[i,j];
        }
    }
}


Console.WriteLine (); 
PrintArray (newArray);


Console.WriteLine (); 
PrintArray (finalArray);