// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void FillRandom (int [,] arr)
{
    int quantityRow = arr.GetLength(0);
    int quantityColumn = arr.GetLength(1);
    for (int i = 0; i < quantityRow; i++)
    {
        for (int j = 0; j < quantityColumn; j++)
        {
            arr [i,j] = new Random().Next(-9, 10);
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

int [,] MultiplicateMatrix (int [,] matrix1, int [,] matrix2)
{
    int row1 = matrix1.GetLength(0);
    int column1 = matrix1.GetLength (1);
    int row2 = matrix2.GetLength(0);
    int column2 = matrix2.GetLength (1);

    int [,] multiplicate = new int [row1, column2];
    int size = 0;
    while (size < row2)
    {
        for (int i = 0; i < row1; i++)
        {
            for (int j = 0; j < column2; j++)
            {
                multiplicate[i,j] = multiplicate [i, j] + matrix1 [i,size] * matrix2 [size,j];
            }
        }
        size++;
    }
    return (multiplicate);
}

Console.WriteLine("Я могу посчитать произведение двух мартиц");
        markRepeat:
Console.Write("Введите количество строк первой матрицы: ");
int row1 = Convert.ToInt16 (Console.ReadLine());
Console.Write("Введите количество столбцов первой матрицы: ");
int column1 = Convert.ToInt16 (Console.ReadLine());
Console.WriteLine();

Console.Write("Введите количество строк второй матрицы: ");
int row2 = Convert.ToInt16 (Console.ReadLine());
Console.Write("Введите количество столбцов второй матрицы: ");
int column2 = Convert.ToInt16 (Console.ReadLine());
Console.WriteLine();

int [,] matrix1 = new int [row1, column1];
int [,] matrix2 = new int [row2, column2];

if (column1!=row2)
    {
        Console.WriteLine ("К сожалению, матрицу 1 нельзя умножить на матрицу 2. Попробуйте ввести другие данные!");
        goto markRepeat;
    }
else
{
    FillRandom (matrix1);
    FillRandom (matrix2);
    Console.WriteLine ("Матрица 1:");
    Console.WriteLine (); 
    PrintArray (matrix1);
    Console.WriteLine ("Матрица 2:");
    Console.WriteLine (); 
    PrintArray (matrix2);
    Console.WriteLine();
    MultiplicateMatrix (matrix1, matrix2);
    Console.WriteLine ("Результирующая матрица:");
    Console.WriteLine (); 
    int [,] multiplicate = MultiplicateMatrix (matrix1, matrix2);
    PrintArray (multiplicate);
}