// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.WriteLine("Введите количество строк и столбцов массива, и я заполню его элементами, равными сумме своих индексов");
Console.WriteLine("Сколько будет строк?");
int m = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Сколько будет столбцов?");
int n = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine();
double [,] array = new double [m,n];
double [] srednee = new double [n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array [i,j] = new Random().Next (0, 11);
        Console.Write(array[i,j]+" ");
        srednee[j] = srednee[j] + array [i,j];
    }
    Console.WriteLine();
}

for (int j = 0; j < n; j++)
{
    srednee [j] = Math.Round(srednee [j]/m,1);
}
Console.WriteLine();
Console.WriteLine("Средние арифметические каждого столбца равны:");
Console.WriteLine('['+String.Join(", ", srednee)+']');
