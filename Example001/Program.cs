// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

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

Console.WriteLine("Я могу поменять местами первую и последнюю строуку в двумерном массиве");

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
int temp = 0;
for (int j = 0; j < column; j++)
{
    temp = arrayRandom[0,j];
    arrayRandom[0,j] = arrayRandom [row-1, j];
    arrayRandom [row-1, j] = temp;
}
PrintArray (arrayRandom);
