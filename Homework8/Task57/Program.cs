// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза

const int startCount = -10;
const int finishCount = 11;

void FillRandom (int [,] arr)
{
    int quantityRow = arr.GetLength(0);
    int quantityColumn = arr.GetLength(1);
    for (int i = 0; i < quantityRow; i++)
    {
        for (int j = 0; j < quantityColumn; j++)
        {
            arr [i,j] = new Random().Next(startCount, finishCount);
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
            Console.Write (print[i,j]+"  ");
        } 
        Console.WriteLine();
    }
}

void FrecuancyDictionary (int [,] arrayRandom)
{
    int row = arrayRandom.GetLength(0);
    int column = arrayRandom.GetLength (1);
    int max = 0;
    int size = startCount;
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
}

Console.WriteLine("Я могу посчитать, сколько раз встречается каждый элемент в массиве");

Console.Write("Введите количество строк массива: ");
int row = Convert.ToInt16 (Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int column = Convert.ToInt16 (Console.ReadLine());
Console.WriteLine();

int [,] arrayRandom = new int [row, column];
FillRandom (arrayRandom);
Console.WriteLine ("Вот случайный массив:");
Console.WriteLine (); 
PrintArray (arrayRandom);
Console.WriteLine();

FrecuancyDictionary (arrayRandom);