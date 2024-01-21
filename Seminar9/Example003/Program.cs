// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9
int sum = 0;
int SumOfDigits (int N)
{   
    if (N == 0)
    {
        return sum;
    }

    else
    {
        SumOfDigits (N / 10);
        sum = sum + N%10;
        return sum;
        
    }
}

Console.WriteLine("Введите любое целое число, и я покажу сумму его цифр");
int num = Convert.ToInt32 (Console.ReadLine());

sum = SumOfDigits(num);
Console.WriteLine (sum);













