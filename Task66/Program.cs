// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int SumNumbers (int M, int N)
{
    if (N == M)
    {
        return M;
    }
    return N + SumNumbers(M, N-1);
}



Console.WriteLine ("Введите числа M и N, и я выведу сумму всех натуральные числа от M до N");
        markRepeat:
Console.Write ("Число M равно: ");
int M = Convert.ToInt32 (Console.ReadLine());

Console.Write ("Число N равно: ");
int N = Convert.ToInt32 (Console.ReadLine());

if (M<1 || N<1)
{
    Console.WriteLine ($"Введены ненатуральные числа! Попробуйте снова:");
    goto markRepeat;
}
else
{
    if (M < N)
    {
        Console.WriteLine ($"Сумма натуральных чисел от {M} до {N} равна: {SumNumbers(M, N)}");
    }
    else
    {   
        Console.WriteLine ($"Сумма натуральных чисел от {N} до {M} равна: {SumNumbers(N, M)}");
    }
}