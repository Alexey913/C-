// **Задача 51: **Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

Console.WriteLine("Введите количество строк и столбцов массива, и я заполню его элементами, равными сумме своих индексов");
Console.WriteLine("Сколько будет строк?");
int m = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Сколько будет столбцов?");
int n = Convert.ToInt32 (Console.ReadLine());

int sum = 0;
int [,] array = new int [m,n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array [i,j] = new Random().Next (-10, 11);
        Console.Write(array[i,j]+" ");
        if (i==j)
        {
            sum = sum + array [i,j];
        }
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine($"Сумма элементов главной диагонали равна: {sum}");
