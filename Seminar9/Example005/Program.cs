// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9
int SumOfDigits (int N)
{   
    if (N == 0)
    {
        return 0;
    }

    return N%10 + SumOfDigits(N/10);
}

Console.WriteLine("Введите любое целое число, и я покажу сумму его цифр");
int num = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine (SumOfDigits(num));












