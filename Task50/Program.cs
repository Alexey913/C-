// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


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

void FillUser (int [,] arr)
{
    int quantityRow = arr.GetLength(0);
    int quantityColumn = arr.GetLength(1);
    for (int i = 0; i < quantityRow; i++)
    {
        for (int j = 0; j < quantityColumn; j++)
        {
            Console.Write ($"Введите {j+1}-й элемент {i+1}-й строки: ");
            arr [i,j] = Convert.ToInt32(Console.ReadLine());
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


void FindElement (int [,] arr)
{
        markRepeat:
    Console.Write("Введите номер строки элемента: ");
    int findRow = Convert.ToInt16 (Console.ReadLine());
    Console.Write("Введите номер столбца массива: ");
    int findColumn = Convert.ToInt16 (Console.ReadLine());
    Console.WriteLine();
     if ((findRow > arr.GetLength(0)) || (findColumn > arr.GetLength(1)) || (findRow <=0) || (findColumn <= 0))
        {
            Console.WriteLine("Такого элемента в данном массиве нет!");
            goto markRepeat;
        }
    else
    {
        Console.WriteLine($"Вывести {findRow}-й элемент {findColumn}-й строки? Y/N");
        string answer = Console.ReadLine();
        switch (answer.ToLower())
        {
            case "y":
             
            Console.WriteLine($"Номер строки элемента: {findRow}");
            Console.WriteLine($"Номер столбца элемента: {findColumn}");
            Console.WriteLine($"Элемент равен: {arr[findRow-1,findColumn-1]}");
            break;

            case "n":
            Console.WriteLine("Введите новые данные.");
            goto markRepeat;
            break;

            default:
            Console.WriteLine("Ошибка ввода!");
            goto markRepeat;
        }
    }
}

Console.WriteLine("Я могу определить позицию элемента в двумерном массиве");
Console.WriteLine("Для начала определим, какой массив будем использовать");
        repeatEnter:
Console.WriteLine("Введите 1, если хотет использовать мой массив размером 4х4");
Console.WriteLine("Введите 2, если хотите использовать случайный массив");
Console.WriteLine("Введите 3, если хотите ввести массив вручную");
int input = Convert.ToInt16 (Console.ReadLine());

switch (input)
{
    case 1:
    int [,] arrayFix = new int [,]
    {
        {10, 11,-9, 0},
        {65, 14, 8, 32},
        {-32, 11, 5, -104},
        {11, 94, -88, 14},
    };
    Console.WriteLine ();
    Console.WriteLine ("Вот мой массив:");
    Console.WriteLine (); 
    PrintArray (arrayFix);
    Console.WriteLine ();
    FindElement (arrayFix);
    break;

    case 2:
    Console.Write("Введите количество строк массива: ");
    int row2 = Convert.ToInt16 (Console.ReadLine());
    Console.Write("Введите количество столбцов массива: ");
    int column2 = Convert.ToInt16 (Console.ReadLine());
    Console.WriteLine();

    int [,] arrayRandom = new int [row2, column2];
    FillRandom (arrayRandom);
    Console.WriteLine ();
    Console.WriteLine ("Вот случайный массив:");
    Console.WriteLine (); 
    PrintArray (arrayRandom);
    Console.WriteLine();
    FindElement (arrayRandom);
    break;

    case 3:
    Console.Write("Введите количество строк массива: ");
    int row3 = Convert.ToInt16 (Console.ReadLine());
    Console.Write("Введите количество столбцов массива: ");
    int column3 = Convert.ToInt16 (Console.ReadLine());
    Console.WriteLine();
    int [,] arrayUser = new int [row3, column3];
    FillUser (arrayUser);
    Console.WriteLine ();
    Console.WriteLine ("Вот Ваш массив:");
    Console.WriteLine (); 
    PrintArray (arrayUser);
    Console.WriteLine (); 
    FindElement (arrayUser);
    break;

    default:
    Console.WriteLine ("Неверный ввод!");
    goto repeatEnter;
}