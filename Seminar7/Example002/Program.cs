// **Задача 49:** Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4


Console.WriteLine("Введите количество строк и столбцов массива, и я заполню его элементами, равными сумме своих индексов");
Console.WriteLine("Сколько будет строк?");
int m = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Сколько будет столбцов?");
int n = Convert.ToInt32 (Console.ReadLine());

int [,] array = new int [m,n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array [i,j] = new Random().Next (-10, 11);
        Console.Write(array[i,j]+" ");
    }
    Console.WriteLine();
}
Console.WriteLine();

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if ((i%2==0)&&(j%2==0))
        {
            array [i,j] = array [i,j] * array[i,j];
        }
        Console.Write(array[i,j]+" ");
    }
    Console.WriteLine();
}