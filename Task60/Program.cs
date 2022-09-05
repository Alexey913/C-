// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


void FillRandom (int [,,] arr)
{
    int quantityRow = arr.GetLength(0);
    int quantityColumn = arr.GetLength(1);
    int quantityLayot = arr.GetLength(2);
    int count = 0;
    for (int k = 0; k < quantityLayot; k++)
    {
        for (int i = 0; i < quantityRow; i++)
        {
            for (int j = 0; j < quantityColumn; j++)
            {
                arr [i,j,k] = 10+count;
                count++;
            }
        }
    }
}


void PrintArray (int [,,] print)
{
    int quantityRow = print.GetLength(0);
    int quantityColumn = print.GetLength(1);
    int quantityLayot = print.GetLength(2);

    for (int k = 0; k < quantityLayot; k++)
    {
        for (int i = 0; i < quantityRow; i++)
        {
            for (int j = 0; j < quantityColumn; j++)
            {
                Console.Write ($"{print[i,j,k]} ({i},{j},{k})  ");
            }
            Console.WriteLine();
        } 
        Console.WriteLine();
    }
}

Console.WriteLine("Я построчно выведу трехмерный массив из неповторяющихся двухзначных элементов с обозначением их индексов");

markRepeat:
Console.Write("Введите количество строк массива: ");
int row = Convert.ToInt16 (Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int column = Convert.ToInt16 (Console.ReadLine());
Console.Write("Введите количество слоев массива: ");
int layot = Convert.ToInt16 (Console.ReadLine());
Console.WriteLine();

if (row*column*layot>90)
{
    Console.WriteLine ("Невозможно построить массив с такими параметрами из неповторяющихся чисел!");
    Console.WriteLine ("Ппорбуйте снова.");
    goto markRepeat;
}
else
{
    int [,,] array = new int [row, column, layot];
    FillRandom (array);
    Console.WriteLine ();
    Console.WriteLine ("Вот такой массив получился:");
    Console.WriteLine ();
    PrintArray (array);
}
