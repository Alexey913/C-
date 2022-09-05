// Задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника



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

void PrintChangeOnSpace (int [,] array)
{
    int quantityRow = array.GetLength(0);
    int quantityColumn = array.GetLength(1);
    for (int i = 0; i < quantityRow; i++)
    {
        for (int j = 0; j < quantityColumn; j++)
        {
            if (array [i,j] == 0)
            {
                Console.Write ("   ");
            }
            else
            {
                Console.Write ($"{array[i,j]} ");
            }
        }
        Console.WriteLine();
    }
}


Console.WriteLine ("Введите число N, и я выведу на экран N первых строк треугольника Паскаля");
int N = Convert.ToInt32(Console.ReadLine());
int [,] treanglePascal = new int [N, 2*N-1];
treanglePascal [0,N-1] = 1;
treanglePascal [1,N] = 1;
treanglePascal [1,N-2] = 1;
treanglePascal [N-1,0] = 1;
treanglePascal [N-1,2*N-2] = 1;
for (int i = 2; i < N; i++)
{
    for (int j = 1; j < 2*N-2; j++)
    {
        treanglePascal [i,j] = treanglePascal [i-1,j-1] + treanglePascal [i-1,j+1];
    }
}
// PrintArray(treanglePascal); // вывод с 0-ми элементами
Console.WriteLine();
PrintChangeOnSpace (treanglePascal); // вывод равнобедренным треугольником