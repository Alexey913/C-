// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

uint FunctionAckerman (uint m, uint n)
{
    if (m == 0)
    return n+1;
    else
    if (m > 0 && n == 0)
    return (FunctionAckerman(m-1, 1));
    return FunctionAckerman (m-1, FunctionAckerman(m, n-1));
}

Console.WriteLine ("Введите числа m и n, и я вычислю функцию Аккермана");
        markRepeat:
Console.WriteLine ("Введите число m:");
uint m = Convert.ToUInt32(Console.ReadLine());
Console.WriteLine ("Введите число n:");
uint n = Convert.ToUInt32(Console.ReadLine());

if (m<0 || n<0)
{
    Console.WriteLine ("Значения m и n должны быть положительными! Попробуйте еще раз.");
    goto markRepeat;

}

Console.WriteLine ($"При заданных значениях m = {m} и n = {n} функция Аккермана равна {FunctionAckerman(m, n)}");
