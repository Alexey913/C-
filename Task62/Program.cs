// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void FillRandom (int [,] arr)
{
    int length = arr.GetLength(1);
    int width = arr.GetLength(0);
    int fillCount = 1;
    int i = 0;
    int j = 0;
    int iStart = 0, iFinal = 0, jStart = 0, jFinal = 0;

    while (fillCount <= length*width)
    {
        arr [i,j] = fillCount;
        if (i == iStart && j < length - jFinal - 1)
        {
            j++;
        }
        else if (j == length - jFinal -1 && i < width - iFinal - 1)
        {
            i++;
        }
        else if (i == width - iFinal -1 && j > jStart)
        {
            j = j-1;
        }
        else 
        {
            i = i-1;
        }
        if ((i == iStart+1)&&(j==jFinal)&&(jStart !=length - jFinal-1))
        {
            iFinal++;
            jFinal++;
            iStart++;
            jStart++;
        }
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
