// Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

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



arrayRandom [1,4] = -6;
arrayRandom [2,3] = -6;
arrayRandom [6,5] = -6;


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
int quantityMinRow = 0;
int quantityMinColumn = 0;


for (int i = 0; i < row-1; i++)
{
    for (int j = 0; j < column; j++)
    {
        if (arrayRandom[i,j] == min)
        {
            quantityMinRow = quantityMinRow+1;
        }
        if (minRow [i+1] == minRow[i] +1)
        {
            quantityMinRow = quantityMinRow+1;
        }
        minRow [i] = quantityMinRow;
    }
}

for (int j = 0; j < column; j++)
{
    for (int i = 0; i < row; i++)
    {
        if (arrayRandom[i,j] == min)
        {
            quantityMinColumn = quantityMinColumn+1;
        }
        minColumn [j] = quantityMinColumn;
    }
}

Console.WriteLine ($"{min}");

Console.WriteLine ('['+String.Join (" ", minRow)+']');

Console.WriteLine ('['+String.Join (" ", minColumn)+']');


int [,] newArray = new int [row-quantityMinRow, column-quantityMinColumn];
for (int i = 0; i < row-quantityMinRow; i++)
{
    for (int j = 0; j < column-quantityMinColumn; j++)
    {
        newArray [i,j] = arrayRandom [i+minRow[i], j+minColumn[j]];
    }
}
Console.WriteLine (); 
PrintArray (newArray);