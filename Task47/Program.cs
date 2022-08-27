// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


// Зададим диапазон вещественных чисел  (-10; 10)

void FillRandom (double [,] arr)
{
    int quantityRow = arr.GetLength(0);
    int quantityColumn = arr.GetLength(1);
    for (int i = 0; i < quantityRow; i++)
    {
        for (int j = 0; j < quantityColumn; j++)
        {
            arr [i,j] = Math.Round((new Random().NextDouble())*(new Random().Next(-10,10)),2);
        }
    }
}

void PrintArray (double [,] print)
{
    int quantityRow = print.GetLength(0);
    int quantityColumn = print.GetLength(1);
    for (int i = 0; i < quantityRow; i++)
    {
        for (int j = 0; j < quantityColumn; j++)
        {
            Console.Write (print[i,j]+"  ");
        } 
        Console.WriteLine();
        Console.WriteLine();

    }
}

 Console.Write("Введите количество строк массива: ");
    int m = Convert.ToInt16 (Console.ReadLine());
    Console.Write("Введите количество столбцов массива: ");
    int n = Convert.ToInt16 (Console.ReadLine());
    Console.WriteLine();

double [,] array = new double [m, n];

FillRandom (array);
Console.WriteLine ("Вот случайный массив:");
Console.WriteLine (); 
PrintArray (array);