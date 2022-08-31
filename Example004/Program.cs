// Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

void FillRandom (int [,] arr)
{
    int quantityRow = arr.GetLength(0);
    int quantityColumn = arr.GetLength(1);
    for (int i = 0; i < quantityRow; i++)
    {
        for (int j = 0; j < quantityColumn; j++)
        {
            arr [i,j] = new Random().Next(-99, 100);
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

// Console.WriteLine("Я могу поменять местами строеи и столбцы в двумерном массиве");

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
int countMinRow = 0;
int countMinColumn = 0;
int rowMin = 0;
int columnMin = 0;
for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            if (arrayRandom[i,j] < min)
            {
                min = arrayRandom[i,j];
                rowMin = i;
                columnMin = j;
            }    
                
            //     if (i != rowMin)
            //     {
            //         countMinRow++;
            //     }
            //     if (j != columnMin)
            //     {
            //         countMinColumn++;
            //     }
            //     rowMin++;
            //     columnMin++;
            // }
        }
    }

// int [,] arrayNew = new int [row-countMinRow, column-countMinColumn];
for (int i = rowMin; i < row; i++)
    {
        for (int j = columnMin; j < column; j++)
        {
            if (i<row-1 || j< column-1)
            {
            arrayRandom[i,j] = arrayRandom[i+1,j+1];
            }
            else
            {
                arrayRandom [i,j] = 0;
            }
        }
    }

Console.WriteLine (); 
PrintArray (arrayRandom);