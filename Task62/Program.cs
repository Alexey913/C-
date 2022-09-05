// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void FillRandom (int [,] arr)
{
    int fillCount = 1;
    int i = 0;
    int j = 0;

    while (j < 3)
    {
        arr[i,j] = fillCount;
        j++;
        fillCount++;
    }
    while (i < 3)
    {
        arr[i,j] = fillCount;
        i++;
        fillCount++;
    }
    while (j > 0)
    {
        arr[i,j] = fillCount;
        j=j-1;
        fillCount++;
    }
    while (i > 1)
    {
        arr[i,j] = fillCount;
        i=i-1;
        fillCount++;
    }
    while (j < 2)
    {
        arr[i,j] = fillCount;
        j++;
        fillCount++;
    }
    while (i < 2)
    {
        arr[i,j] = fillCount;
        i++;
        fillCount++;
    }
    while (j > 0)
    {
        arr[i,j] = fillCount;
        j=j-1;
        fillCount++;
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
            if (print[i,j]/10 == 0)
            {
                Console.Write ("0"+print[i,j]+" ");
            }
            else
            {
                Console.Write (print[i,j]+" ");
            }
        } 
        Console.WriteLine();
    }
}

int [,] array = new int [4,4];

FillRandom  (array);
Console.WriteLine ("Спиральный массив");
Console.WriteLine (); 
PrintArray (array);
Console.WriteLine();