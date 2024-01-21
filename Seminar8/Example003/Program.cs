// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

void FillRandom (int [,] arr)
{
    int quantityRow = arr.GetLength(0);
    int quantityColumn = arr.GetLength(1);
    for (int i = 0; i < quantityRow; i++)
    {
        for (int j = 0; j < quantityColumn; j++)
        {
            arr [i,j] = new Random().Next(1, 100);
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

Console.WriteLine("Я могу посчитать, сколько раз встречается каждый элемент в массиве");

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

int max = 0;
int size = 0;
int count = 0;
for (int i = 0; i < row; i++)
{
    for (int j = 0; j < column; j++)
    {
        if (arrayRandom [i,j] > max)
        {
            max = arrayRandom [i,j];
        }
    }
}
while (size <= max)
{
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            if (arrayRandom [i,j] == size)
            {
                count++;
            }
        }
    }
    if (count!=0)
    {
        Console.WriteLine ($"Элемент {size} повторяется в массиве {count} раз(а)");
    }
    count = 0;
    size++;
}
